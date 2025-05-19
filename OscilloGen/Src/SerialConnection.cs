using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Management;

namespace OscilloGen.Src;

internal static class SerialConnection
{
    private const int TIMEOUT = 1000; // ms
    private const int DELAY = 100; // ms
    private const int BAUD_RATE = 115200;
    private const string DEVICE_NAME = "STMicroelectronics";
    private const string VENDOR_ID = "0483";               // Vendor ID for STMicroelectronics
    private const string PRODUCT_ID = "5740";              // Product ID for STM32 device

    static SerialPort serialPort;
    private static int expectedResponseLength;
    private static readonly byte[] handshake = { 0xBB, 0xCC };


    public static bool SendHandShake(byte[] handshake)
    {
        string error = "";
        SendData(handshake, out error);

        if (error != "")
        {
            return false;
        }
        return true;
    }

    public static bool OpenSerialPort(string portName)
    {
        CloseSerialPort();
        serialPort = new SerialPort(portName, BAUD_RATE, Parity.None, 8, StopBits.One)
        {
            ReadTimeout = TIMEOUT
        };

        try
        {
            serialPort.Open();
        }
        catch (Exception ex)
        {
            return false;
        }
        return true;
    }

    public static void CloseSerialPort()
    {
        if (serialPort != null)
        {
            serialPort.Close();
            serialPort.Dispose();
        }
    }

    public static void SendData(byte[] data, out string error)
    {
        error = "";
        try
        {
            serialPort.Write(data, 0, data.Length);
        }
        catch (TimeoutException ex)
        {
            error = ex.Message;
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

    public static int ReceiveData(byte[] buffer, int expectedLength, out string error)
    {
        error = "";
        int bytesRead = 0;

        try
        {
            bytesRead = serialPort.Read(buffer, 0, expectedLength);
        }
        catch (TimeoutException ex)
        {
            error = ex.Message;
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }

        return bytesRead;
    }

    static string GetComPortByDeviceName(string vendorId, string productId)
    {
        try
        {
            // Query USB devices with specified VID and PID
            string query = $"SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE '%VID_{vendorId}&PID_{productId}%'";

            using (var searcher = new ManagementObjectSearcher(query))
            {
                foreach (var device in searcher.Get())
                {
                    string name = device["Name"]?.ToString();

                    if (name != null && name.Contains("COM"))
                    {
                        // Extract the COM port (e.g., "COM3")
                        int startIndex = name.LastIndexOf('(') + 1;
                        int endIndex = name.LastIndexOf(')');
                        return name.Substring(startIndex, endIndex - startIndex);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        return null; // Device not found
    }

}
