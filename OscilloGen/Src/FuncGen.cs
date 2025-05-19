using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscilloGen.Src;

internal class FuncGen
{
    const float MIN_FREQUENCY = 0.0F;
    const float MAX_FREQUENCY = 1000.0F;

    const float MIN_AMPLITUDE = 0.0F;
    const float MAX_AMPLITUDE_VP = 9.800F;

    const float MIN_OFFSET = 0.0F;
    const float MAX_OFFSET = 360.0F;

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

}
