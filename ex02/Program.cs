namespace ex02;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix, transposed;
        int[] maxPerRow;
        double[] avgPerColumn;
        int sumRow3, sumColumn, sumDiagonal, sumTotal, countEqual, searchNumber, columnChoice;
        Random random;

        matrix = new int[10, 10];
        transposed = new int[10, 10];
        maxPerRow = new int[10];
        avgPerColumn = new double[10];
        random = new Random();

        Console.WriteLine("Gerando matriz 10x10 com valores aleatorios\n");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = random.Next(1, 101);
            }
        }

        Console.WriteLine("Matriz 10x10");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\na) Maior elemento de cada linha ");
        for (int i = 0; i < 10; i++)
        {
            maxPerRow[i] = matrix[i, 0];
            for (int j = 1; j < 10; j++)
            {
                if (matrix[i, j] > maxPerRow[i])
                {
                    maxPerRow[i] = matrix[i, j];
                }
            }
            Console.WriteLine($"Linha {i} -> {maxPerRow[i]}");
        }

        Console.WriteLine("\nb) Media dos elementos de cada coluna:");
        for (int j = 0; j < 10; j++)
        {
            avgPerColumn[j] = 0;
            for (int i = 0; i < 10; i++)
            {
                avgPerColumn[j] = avgPerColumn[j] + matrix[i, j];
            }
            avgPerColumn[j] = avgPerColumn[j] / 10;
            Console.WriteLine($"Coluna {j} -> {avgPerColumn[j]:F2}");
        }

        sumRow3 = 0;
        for (int j = 0; j < 10; j++)
        {
            sumRow3 = sumRow3 + matrix[3, j];
        }
        Console.WriteLine($"\nc) Soma dos elementos da linha 3: {sumRow3}");

        do
        {
            Console.Write("\nd) Digite o numero da coluna entree 0 e 9: ");
        } while (!int.TryParse(Console.ReadLine(), out columnChoice) || columnChoice < 0 || columnChoice > 9);

        sumColumn = 0;
        for (int i = 0; i < 10; i++)
        {
            sumColumn = sumColumn + matrix[i, columnChoice];
        }
        Console.WriteLine($"Soma dos elementos da coluna; {columnChoice}: {sumColumn}");

        sumDiagonal = 0;
        for (int i = 0; i < 10; i++)
        {
            sumDiagonal = sumDiagonal + matrix[i, i];
        }
        Console.WriteLine($"\ne) Soma dos elementos da diagonal principal: {sumDiagonal}");

        sumTotal = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                sumTotal = sumTotal + matrix[i, j];
            }
        }
        Console.WriteLine($"\nf) Soma de todos os elementos da matriz: {sumTotal}");

        do
        {
            Console.Write("\ng) Digite um numero para contar quantas vezes aparece: ");
        } while (!int.TryParse(Console.ReadLine(), out searchNumber));

        countEqual = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (matrix[i, j] == searchNumber)
                {
                    countEqual++;
                }
            }
        }
        Console.WriteLine($"O numero {searchNumber} aparece {countEqual} vezes na matriz");

        Console.WriteLine("\nh) Matriz transposta ' linhas trocadas por colunas' ");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{transposed[i, j],4} ");
            }
        }
    }
}
