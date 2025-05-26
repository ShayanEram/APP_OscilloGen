using NUnit.Framework;
using Moq;
using System.IO.Ports;
using OscilloGen;

namespace UTests;

[TestFixture]
public class SerialConnectionTests
{
    private Mock<SerialPort> _mockSerialPort;

    [SetUp]
    public void SetUp()
    {
        // Mock the SerialPort to simulate hardware behavior
        _mockSerialPort = new Mock<SerialPort>();
        SerialConnection.serialPort = _mockSerialPort.Object;
    }

    [Test]
    public void ConnectToDevice_ReturnsFalse_WhenDeviceNotFound()
    {
        // Arrange
        Mock.Get(typeof(SerialConnection))
            .Setup(x => SerialConnection.GetComPortByDeviceName(It.IsAny<string>(), It.IsAny<string>()))
            .Returns((string)null);

        // Act
        bool result = SerialConnection.ConnectToDevice();

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void ConnectToDevice_ReturnsTrue_WhenDeviceConnected()
    {
        // Arrange
        string mockComPort = "COM3";
        Mock.Get(typeof(SerialConnection))
            .Setup(x => SerialConnection.GetComPortByDeviceName(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(mockComPort);

        Mock.Get(typeof(SerialConnection))
            .Setup(x => SerialConnection.OpenSerialPort(mockComPort))
            .Returns(true);

        Mock.Get(typeof(SerialConnection))
            .Setup(x => SerialConnection.SendHandShake(It.IsAny<byte[]>()))
            .Returns(true);

        // Act
        bool result = SerialConnection.ConnectToDevice();

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void OpenSerialPort_ReturnsFalse_WhenPortCannotBeOpened()
    {
        // Arrange
        _mockSerialPort.Setup(x => x.Open()).Throws(new IOException());

        // Act
        bool result = SerialConnection.OpenSerialPort("COM3");

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void OpenSerialPort_ReturnsTrue_WhenPortOpenedSuccessfully()
    {
        // Arrange
        _mockSerialPort.Setup(x => x.Open());

        // Act
        bool result = SerialConnection.OpenSerialPort("COM3");

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void CloseSerialPort_ClosesPort_WhenPortIsOpen()
    {
        // Arrange
        _mockSerialPort.Setup(x => x.IsOpen).Returns(true);

        // Act
        SerialConnection.CloseSerialPort();

        // Assert
        _mockSerialPort.Verify(x => x.Close(), Times.Once);
    }
}