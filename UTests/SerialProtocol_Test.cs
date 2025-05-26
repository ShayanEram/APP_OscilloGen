using NUnit.Framework;
using Moq;
using OscilloGen.Src;
using System;
using OscilloGen;

namespace UTests;

[TestFixture]
public class SerialProtocolTests
{
    private Mock<ISerialConnection> _mockSerialConnection;

    [SetUp]
    public void SetUp()
    {
        // Mock the SerialConnection to simulate hardware behavior
        _mockSerialConnection = new Mock<ISerialConnection>();
        SerialConnection.SendData = _mockSerialConnection.Object.SendData;
    }

    [Test]
    public void EncodeSendData_SendsCorrectData()
    {
        // Arrange
        int signalType = 1;
        float frequency = 1000.0f;
        float amplitude = 2.5f;
        float offset = 0.5f;

        byte[] expectedData = new byte[15];
        expectedData[0] = 0xAA;
        expectedData[1] = 0xFF;
        expectedData[2] = Convert.ToByte(signalType);
        Buffer.BlockCopy(BitConverter.GetBytes(frequency), 0, expectedData, 3, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(amplitude), 0, expectedData, 7, 4);
        Buffer.BlockCopy(BitConverter.GetBytes(offset), 0, expectedData, 11, 4);

        // Act
        SerialProtocol.EncodeSendData(signalType, frequency, amplitude, offset);

        // Assert
        _mockSerialConnection.Verify(
            x => x.SendData(It.Is<byte[]>(data => AreArraysEqual(data, expectedData)), out It.Ref<string>.IsAny),
            Times.Once
        );
    }

    [Test]
    public void EncodeSendOscilloscope_SendsCorrectData()
    {
        // Arrange
        bool stop = true;
        bool fft = false;
        bool filter = true;

        byte[] expectedData = new byte[15];
        expectedData[0] = 0xFF;
        expectedData[1] = 0xC3;
        expectedData[2] = (byte)((stop ? 1 : 0) | ((fft ? 1 : 0) << 1) | ((filter ? 1 : 0) << 2));

        // Act
        SerialProtocol.EncodeSendOscilloscope(stop, fft, filter);

        // Assert
        _mockSerialConnection.Verify(
            x => x.SendData(It.Is<byte[]>(data => AreArraysEqual(data, expectedData)), out It.Ref<string>.IsAny),
            Times.Once
        );
    }

    private bool AreArraysEqual(byte[] array1, byte[] array2)
    {
        if (array1.Length != array2.Length) return false;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i]) return false;
        }
        return true;
    }
}

public interface ISerialConnection
{
    void SendData(byte[] data, out string error);
}