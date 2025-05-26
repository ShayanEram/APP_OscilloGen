using NUnit.Framework;
using OscilloGen;

namespace UTests;

[TestFixture]
public class FuncGenTests
{
    private const float MIN_FREQUENCY = 20.0f; // Replace with actual value from FuncGen.cs
    private const float MAX_FREQUENCY = 20000.0f; // Replace with actual value from FuncGen.cs
    private const float MIN_AMPLITUDE = 0.0f; // Replace with actual value from FuncGen.cs
    private const float MAX_AMPLITUDE_VP = 5.0f; // Replace with actual value from FuncGen.cs

    [Test]
    public void CheckFrequency_ReturnsMinFrequency_WhenBelowMin()
    {
        float inputFrequency = 10.0f; // Below MIN_FREQUENCY
        float result = FuncGen.CheckFrequency(inputFrequency);
        Assert.AreEqual(MIN_FREQUENCY, result);
    }

    [Test]
    public void CheckFrequency_ReturnsMaxFrequency_WhenAboveMax()
    {
        float inputFrequency = 25000.0f; // Above MAX_FREQUENCY
        float result = FuncGen.CheckFrequency(inputFrequency);
        Assert.AreEqual(MAX_FREQUENCY, result);
    }

    [Test]
    public void CheckFrequency_ReturnsInputFrequency_WhenWithinRange()
    {
        float inputFrequency = 1000.0f; // Within range
        float result = FuncGen.CheckFrequency(inputFrequency);
        Assert.AreEqual(inputFrequency, result);
    }

    [Test]
    public void CheckAmplitude_ReturnsMinAmplitude_WhenBelowMin()
    {
        float inputAmplitude = -1.0f; // Below MIN_AMPLITUDE
        float result = FuncGen.CheckAmplitude(inputAmplitude);
        Assert.AreEqual(MIN_AMPLITUDE, result);
    }

    [Test]
    public void CheckAmplitude_ReturnsMaxAmplitude_WhenAboveMax()
    {
        float inputAmplitude = 10.0f; // Above MAX_AMPLITUDE_VP
        float result = FuncGen.CheckAmplitude(inputAmplitude);
        Assert.AreEqual(MAX_AMPLITUDE_VP, result);
    }

    [Test]
    public void CheckAmplitude_ReturnsInputAmplitude_WhenWithinRange()
    {
        float inputAmplitude = 2.5f; // Within range
        float result = FuncGen.CheckAmplitude(inputAmplitude);
        Assert.AreEqual(inputAmplitude, result);
    }
}