

int[] array = { 10, 219, 322, 443, 57, 62, 62, 711, 82, 9 };

int n = array.Length;

int find = 62;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }


    index++;
}