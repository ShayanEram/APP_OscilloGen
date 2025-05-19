using System.IO.Ports;

namespace OscilloGen.Src;

internal class SerialProtocol
{
    private const int SEND_DATA_SIZE = 13;
    private const int RECEIVE_DATA_SIZE = 1024;

    public static float[] signalBuffer = new float[RECEIVE_DATA_SIZE];
    public static int bufferIndex = 0;

    public static void EncodeSendData(int signalType, float frequency, float amplitude, float offset)
    {
        byte[] dataToSend = new byte[SEND_DATA_SIZE];

        byte typeByte = Convert.ToByte(signalType);
        byte[] freqBytes = BitConverter.GetBytes(frequency);
        byte[] ampBytes = BitConverter.GetBytes(amplitude);
        byte[] offsetBytes = BitConverter.GetBytes(offset);

        dataToSend[0] = typeByte;
        Buffer.BlockCopy(freqBytes, 0, dataToSend, 1, freqBytes.Length);
        Buffer.BlockCopy(ampBytes, 0, dataToSend, 5, ampBytes.Length);
        Buffer.BlockCopy(offsetBytes, 0, dataToSend, 9, offsetBytes.Length);

        SerialConnection.SendData(dataToSend, out string error);
    }

    public static void StopOscilloscope()
    {
        byte[] stopBuffer = new byte[SEND_DATA_SIZE];
        SerialConnection.SendData(stopBuffer, out string error);
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
