namespace ex01;

class Program
{
    static void Main(string[] args)
    {
        int[,] pulses;
        int bedMaxAvg, hourMax, bedMax, maxValue;
        double[] avgPulses;
        double maxAvg, sum;
        Random random;

        pulses = new int[24, 4];
        avgPulses = new double[4];
        random = new Random();
        

        Console.WriteLine("Preenchendo as  pulsacoes de forma randomica  \n");

        for (int i = 0; i < 24; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                pulses[i, j] = random.Next(60, 100);
                Console.WriteLine($"Hora {i} - Cama {j + 1}: {pulses[i, j]}");
            }
        }

        for (int j = 0; j < 4; j++)
        {
            sum = 0;
            for (int i = 0; i < 24; i++)
            {
                sum = sum + pulses[i, j];
            }
            avgPulses[j] = sum / 24;
        }
        Console.WriteLine($"\nMedias das camas");
        for (int j = 0; j < 4; j++)
        {
            Console.WriteLine($"Cama {j + 1}: {avgPulses[j]:F2}");
        }

        maxAvg = avgPulses[0];
        bedMaxAvg = 1;
        for (int j = 1; j < 4; j++)
        {
            if (avgPulses[j] > maxAvg)
            {
                maxAvg = avgPulses[j];
                bedMaxAvg = j + 1;
            }
        }

        Console.WriteLine($"\nPaciente com maior media: Cama {bedMaxAvg} ({maxAvg:F2})");

        maxValue = pulses[0, 0];
        hourMax = 0;
        bedMax = 1;

        for (int i = 0; i < 24; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (pulses[i, j] > maxValue)
                {
                    maxValue = pulses[i, j];
                    hourMax = i;
                    bedMax = j + 1;
                }
            }
        }

        Console.WriteLine($"\nValor mais elevado: {maxValue} - Cama {bedMax} - Hora {hourMax}");
    }
}