using System.IO.Ports;

namespace OscilloGen.Src;

public class SerialProtocol
{
    private const int SEND_DATA_SIZE = 15;
    private const int RECEIVE_DATA_SIZE = 1024;

    public static float[] signalBuffer = new float[RECEIVE_DATA_SIZE];
    public static int bufferIndex = 0;

    public static void EncodeSendData(int signalType, float frequency, float amplitude, float offset)
    {
        byte[] dataToSend = new byte[SEND_DATA_SIZE];
        
        // Function generator identifier
        dataToSend[0] = 0xAA;
        dataToSend[1] = 0xFF;

        byte typeByte = Convert.ToByte(signalType);
        byte[] freqBytes = BitConverter.GetBytes(frequency);
        byte[] ampBytes = BitConverter.GetBytes(amplitude);
        byte[] offsetBytes = BitConverter.GetBytes(offset);

        dataToSend[2] = typeByte;
        Buffer.BlockCopy(freqBytes, 0, dataToSend, 3, freqBytes.Length);
        Buffer.BlockCopy(ampBytes, 0, dataToSend, 7, ampBytes.Length);
        Buffer.BlockCopy(offsetBytes, 0, dataToSend, 11, offsetBytes.Length);

        SerialConnection.SendData(dataToSend, out string error);
    }

    public static void EncodeSendOscilloscope(bool stop, bool fft, bool filter)
    {
        byte[] dataToSend = new byte[SEND_DATA_SIZE];
        
        // Function oscilloscope identifier
        dataToSend[0] = 0xFF;
        dataToSend[1] = 0xC3;

        if (stop) 
        {
            Array.Clear(dataToSend, 2, dataToSend.Length);
        }
        else
        {
            byte fftByte = Convert.ToByte(fft);
            byte filterByte = Convert.ToByte(filter);

            dataToSend[2] = fftByte;
            dataToSend[3] = filterByte;
        }

        SerialConnection.SendData(dataToSend, out string error);
    }

    public static void SignalDataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        const int FLOAT_SIZE = 4;
        byte[] buffer = new byte[FLOAT_SIZE];
        SerialConnection.ReceiveData(buffer, out string error);

        DecodeReceivedData(buffer);
    }

    private static void DecodeReceivedData(byte[] receivedBytes)
    {
        float value = BitConverter.ToSingle(receivedBytes, 0);

        // Circular buffer
        signalBuffer[bufferIndex] = value;
        bufferIndex = (bufferIndex + 1) % signalBuffer.Length;
    }
}
