using System.IO;
using LibUsbDotNet;
using DeviceProgramming.Dfu;
using DeviceProgramming.FileFormat;
using LibUsbDfu;

namespace OscilloGen.Src;

internal class UpdateFw
{
    private static readonly string password = "admin";
    private static readonly int vendorId = About.VENDOR_ID;
    private static readonly int productId = About.PRODUCT_ID;

    public static bool CheckPassword(string enteredPassword)
    {
        if (enteredPassword == password)
        {
            return true;
        }
        return false;
    }

    public static bool ReadBinaryFile(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File does not exist");
                return false;
            }

            LibUsbDfu.Device device = LibUsbDfu.Device.OpenFirst(UsbDevice.AllDevices, vendorId, productId);
            if (device == null)
            {
                Console.WriteLine("Error: Device not found");
                return false;
            }

            Console.WriteLine("Device found: " + device);

            if (device.InAppMode())
            {
                Console.WriteLine("Device is in application mode");
                device.Reconfigure();
            }

            var memory = IntelHex.ParseFile(filePath);

            device.DownloadProgressChanged += (obj, e) => Console.WriteLine("Download progress %: " + e.ProgressPercentage);

            device.DeviceError += (obj, e) => Console.WriteLine("Error: " + e.GetException().Message);

            device.DownloadFirmware(memory);

            device.Manifest();

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        return false;
    }
}
