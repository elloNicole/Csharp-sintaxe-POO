// See https://aka.ms/new-console-template for more information

string[] line = Console.ReadLine().Split(' ');

int l = int.Parse(line[0]);
int c = int.Parse(line[1]);

int[,] matriz = new int[l, c];

for (int i = 0; i < l; i++)
{
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < c; j++)
    {
        matriz[i, j] = int.Parse(values[j]); //j é quem percorre as posições horizontais da matriz na ordem em que foi escrita
    }
}

int num = int.Parse(Console.ReadLine());

for (int i = 0; i < l; i++)
{

    for (int j = 0; j < c; j++)
    {
        if (matriz[i, j] == num)
        {
            Console.WriteLine($"Position: [{i}][{j}]");

            if (j+1 < c ) 
            {
                Console.WriteLine($"Right: {matriz[i,j+1]}");
            }
            if (j - 1 >= 0)
            {
                Console.WriteLine($"Left: {matriz[i, j-1]}");
            }
            if (i - 1 >= 0)
            {
                Console.WriteLine($"Up: {matriz[i-1, j]}");
            }
            if (i+1 < l ) 
            {
                Console.WriteLine($"Down: {matriz[i+1, j]}");
            }
        }

    }
}
          