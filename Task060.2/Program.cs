// Частотный анализ текста - символьный.



// Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.
Console.Clear();
string stroka1 = "_Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования._";
char[] stroka = stroka1.ToCharArray();
// void PrintTwoDimensionalArray(int[,] anothertwodimensionalarray)
// {
//     for (int i = 0; i < anothertwodimensionalarray.GetLength(0); i++)
//     {

//         Console.Write($"{Convert.ToChar(anothertwodimensionalarray[i, 0])} {anothertwodimensionalarray[i, 1]} ");

//         Console.WriteLine();
//     }
// }
int[,] SortedFrequencyAnalisMatrix(char[] somestring)
{
    int[,] resultArray = new int[somestring.Length, 2];
    int placeNewArray = 0;
    for (int i = 0; i < somestring.Length; i++)
    {
        resultArray[placeNewArray, 0] = somestring[i];
        int counterSubmission = 0;
        for (int k = 0; k < somestring.Length; k++)
        {
            if (somestring[i] == somestring[k])
            {
                counterSubmission++;
            }
        }
        resultArray[placeNewArray, 1] = counterSubmission;
        placeNewArray++;
    }

    int firstTempDigit = 0;
    int secondTempDigit = 0;
    for (int m = 0; m < resultArray.GetLength(0); m++)
    {
        for (int n = 0; n < resultArray.GetLength(0) - 1; n++) // цикл для сортировки по убыванию повторения
        {
            if (resultArray[n, 1] < resultArray[n + 1, 1])
            {
                firstTempDigit = resultArray[n, 1];
                secondTempDigit = resultArray[n, 0];
                resultArray[n, 1] = resultArray[n + 1, 1];
                resultArray[n, 0] = resultArray[n + 1, 0];
                resultArray[n + 1, 1] = firstTempDigit;
                resultArray[n + 1, 0] = secondTempDigit;
            }
        }
    }
    return resultArray;
}
void PrintAndRemoveRepetition(int[,] resultfreqmatrix)
{
    for (int i = 0; i < resultfreqmatrix.GetLength(0); i++)
    {
        for (int k = i + 1; k < resultfreqmatrix.GetLength(0); k++)
        {
            if (resultfreqmatrix[k, 0] == resultfreqmatrix[i, 0])
            {
                resultfreqmatrix[k, 1] = (Math.Abs(resultfreqmatrix[k, 1])) * (-1);
            }
        }
        // Console.WriteLine($"Проверка {resultfreqmatrix[i,0]} {resultfreqmatrix[i,1]} ");   
    }
    for (int j = 0; j < resultfreqmatrix.GetLength(0); j++)
    {
        if (resultfreqmatrix[j, 1] > 0)
        {
            Console.Write($"Символ '{Convert.ToChar(resultfreqmatrix[j, 0])}' встречается {resultfreqmatrix[j, 1]} раз.");
            double digitResult = Convert.ToDouble(resultfreqmatrix[j,1]);
            double sizeResultMatrix = Convert.ToDouble(resultfreqmatrix.GetLength(0));
            double percentageResult = Math.Round(((digitResult/sizeResultMatrix)*100),2);
            Console.WriteLine($"Частота {percentageResult} %");
        }
    }
}
PrintAndRemoveRepetition(SortedFrequencyAnalisMatrix(stroka));













































/* Console.Clear();
string text = "Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения"
            + "отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе"
            + "шифрования и дешифрования.";

void FrequencyAnalys(string textToAnalys, char charOfText)
{
    int count = 0;
    double persentOfRepeat = 0;
    for (int i = 0; i < textToAnalys.Length; i++)
    {
        if (textToAnalys[i] == charOfText)
        {
            count++;
        }
    }
    persentOfRepeat = (count / textToAnalys.Length) * 100;
    Console.WriteLine($"Символ '{charOfText}' встречается {count} раз ({Math.Round(((double)count / textToAnalys.Length) * 100, 2)} %).");
}

for (int i = 0; i < text.Length; i++)
{
    FrequencyAnalys(text, text[i]);
}

Console.WriteLine();
Console.WriteLine(text); */


