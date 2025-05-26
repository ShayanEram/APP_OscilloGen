using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscilloGen.Src;

public class FuncGen
{
    const float MIN_FREQUENCY = 0.0F;
    const float MAX_FREQUENCY = 1000.0F;

    const float MIN_AMPLITUDE = 0.0F;
    const float MAX_AMPLITUDE_VP = 9.800F;

    const float MIN_OFFSET = 0.0F;
    const float MAX_OFFSET = 360.0F;

    public struct SignalType
    {
        public bool noise;
        public bool sine;
        public bool square;
        public bool triangle;
        public bool saw;

        public SignalType()
        {
            noise = false;
            sine = false;
            square = false;
            triangle = false;
            saw = false;
        }
    }

    public static float CheckFrequency(float frequency)
    {
        if (frequency < MIN_FREQUENCY)
        {
            return MIN_FREQUENCY;
        }
        if (frequency > MAX_FREQUENCY)
        {
            return MAX_FREQUENCY;
        }
        return frequency;
    }

    public static float CheckAmplitude(float amplitude)
    {
        if (amplitude < MIN_AMPLITUDE)
        {
            return MIN_AMPLITUDE;
        }

        if (amplitude > MAX_AMPLITUDE_VP)
        {
            return MAX_AMPLITUDE_VP;
        }

        return amplitude;
    }

    public static float CheckOffset(float offset)
    {
        if (offset < MIN_OFFSET)
        {
            return MIN_OFFSET;
        }
        if (offset > MAX_OFFSET)
        {
            return MAX_OFFSET;
        }
        return offset;
    }

    public static int GetSignalType(SignalType type)
    {
        if (type.noise)
            return 0;
        else if (type.sine)
            return 1;
        else if (type.square)
            return 2;
        else if (type.triangle)
            return 3;
        else
            return 4;
    }
}
