using SMTApp.Models;
using System.Text.Json;

namespace SMTApp.Common;

static class CommonMethods
{
    internal static string mainPath = string.Empty;

    /// <summary>
    /// Get complete details of each room
    /// </summary>
    /// <param name="room">Full room path</param>
    /// <returns>Return null if no room found else return room details</returns>
    internal static Room GetRoomDetails(string room)
    {
        Room roomDetails = new();
        var txtFilesPath = Path.Combine(room, ConstantValues.DetailFiles);
        try
        {
            if (!GetDirectories(room).Contains(txtFilesPath))
            {
                Directory.CreateDirectory(txtFilesPath);
                return null;
            }
            roomDetails.RoomName = Path.GetFileName(room);

            return roomDetails;
        }
        catch
        {
            return null;
        }
    }

    internal static Room GenerateRoomModelFromCSV(string csv)
    {
        var lst = csv.Split(',');
        return new()
        {
            AdvanceAmount = double.Parse(CheckDoubleEmptyValue(lst[(int)RoomDetailsOrder.AdvanceAmount])),
            RentAmount = double.Parse(CheckDoubleEmptyValue(lst[(int)RoomDetailsOrder.RentAmount])),
            LeaseAmount = double.Parse(CheckDoubleEmptyValue(lst[(int)RoomDetailsOrder.LeaseAmount])),
            RentStartDate = string.IsNullOrEmpty(lst[(int)RoomDetailsOrder.RentStartDate]) ? null : DateTime.Parse(lst[(int)RoomDetailsOrder.RentStartDate]),
            ElectricityAccountNumber = lst[(int)RoomDetailsOrder.ElectricityAccountNumber],
            WaterAccountNumber = lst[(int)RoomDetailsOrder.WaterAccountNumber],
            RoomType = lst[(int)RoomDetailsOrder.RoomType],
        };
    }
    internal static Room GenerateRoomModelFromRentCSV(string csv)
    {
        var lst = csv.Split(',');
        return new()
        {
            RentAmount = double.Parse(CheckDoubleEmptyValue(lst[(int)RentDetailsOrder.RentAmount])),
            ElectricityBill = new() { Amount = double.Parse(CheckDoubleEmptyValue(lst[(int)RentDetailsOrder.ElectricityAmount])) },
            WaterBill = new() { Amount = double.Parse(CheckDoubleEmptyValue(lst[(int)RentDetailsOrder.WaterAmount])) },
        };
    }
    private static string CheckDoubleEmptyValue(string value)
    {
        return string.IsNullOrEmpty(value) ? "0" : value;
    }

    internal static string GenerateCSVFromRoomModel(Room roomDetails)
    {
        var lst = new List<string>()
        {
            roomDetails.AdvanceAmount.ToString(),
            roomDetails.RentAmount.ToString(),
            roomDetails.LeaseAmount.ToString(),
            roomDetails.RentStartDate.ToString(),
            roomDetails.ElectricityAccountNumber,
            roomDetails.WaterAccountNumber,
            roomDetails.RoomType
        };
        return string.Join(",", lst);
    }
    internal static string GenerateRentCSVFromRoomModel(Room roomDetails)
    {
        var lst = new List<string>()
        {
            (roomDetails.RentAmount??0).ToString("0.##"),
            (roomDetails.ElectricityBill.Amount??0).ToString("0.##"),
            (roomDetails.WaterBill.Amount??0).ToString("0.##")
        };
        return string.Join(",", lst);
    }

    internal static async Task<string> GetImageFromFile(string targetFile)
    {
        var bytesData = File.ReadAllBytes(targetFile);
        var stream = new MemoryStream(bytesData);
        return await PopulateImageFromStream(stream);
    }
    internal static string GetLatestFile(string path)
    {
        var txtFilesData = GetFiles(Path.Combine(path, ConstantValues.DetailFiles));
        if (txtFilesData == null || !txtFilesData.Any())
            return null;
        Dictionary<string, DateTime> allFiles = new();
        foreach (var fls in txtFilesData)
        {
            allFiles.Add(fls, DateTime.Parse(Path.GetFileNameWithoutExtension(fls)));
        }
        return allFiles.MaxBy(x => x.Value).Key;
    }

    internal static List<string> GetRooms(string building) =>
    GetDirectories(
        Path.Combine(mainPath, building)
    );

    internal static void SaveImageFile(Stream stream, string targetFile)
    {
        var bytesData = ConvertImageStreamToBytes(stream);
        using (FileStream fs = new FileStream(targetFile, FileMode.Create))
        {
            fs.Write(bytesData, 0, bytesData.Length);
        }
    }

    /// <summary>
    /// Get Base64 image string
    /// </summary>
    /// <param name="stream"></param>
    /// <returns></returns>
    internal static async Task<string> PopulateImageFromStream(Stream stream)
    {
        MemoryStream ms = new MemoryStream();
        stream.CopyTo(ms);
        byte[] byteArray = ms.ToArray();
        var b64String = Convert.ToBase64String(byteArray);
        var imageBytes = Convert.FromBase64String(b64String);

        MemoryStream imageDecodeStream = new(imageBytes);
        var a = ImageSource.FromStream(() => imageDecodeStream);
        return "data:image/png;base64," + b64String;
    }

    internal async static Task<string> ReadTextFile(string filePath)
    {
        try
        {
            using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(filePath);
            using StreamReader reader = new StreamReader(fileStream);
            return await reader.ReadToEndAsync();
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public static async Task<Stream> GetImageStream()
    {
        var result = await MediaPicker.PickPhotoAsync();
        return await result.OpenReadAsync();
    }
    public static async Task ShareFilesList(List<ShareFile> files, string title)
    {
        await Share.Default.RequestAsync(new ShareMultipleFilesRequest
        {
            Title = title,
            Files = files
        });
    }
    internal static byte[] ConvertImageStreamToBytes(Stream input)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            input.CopyTo(ms);
            return ms.ToArray();
        }
    }

    internal static double? GetBalance(string paymentDetailsPath)
    {
        RentPaymentDetails details = GetRentPaymentDetails(paymentDetailsPath);
        return details.Balance;
    }

    internal static RentPaymentDetails GetRentPaymentDetails(string paymentDetailsPath)
    {
        var data = File.ReadAllText(paymentDetailsPath);
        var details = JsonSerializer.Deserialize<RentPaymentDetails>(data);
        return details;
    }

    internal static List<string> GetFiles(string path) => Directory.GetFiles(path).ToList();
    internal static List<string> GetDirectories(string directoryPath) => Directory.GetDirectories(directoryPath).ToList();
    internal static List<string> GetBuildings() => GetDirectories(mainPath);
}
