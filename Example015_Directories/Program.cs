// Примеры работы с директориями, с использованием рекурсивных методов.

// Пример 1. Получение файлов находящихся в папке.
/* Console.Clear();
string path = "C:/Users/Zver/Desktop/GeekBrains/C#/introductionC#/seminar1/HelloCode/Example002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
} */

// Полный обход директории.

void CatalogInfo (string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent} {catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent} {files[i].Name}");
    }
}

string path = @"C:\Users\Zver\Desktop\GeekBrains\C#\introductionC#\seminar1\HelloCode";
CatalogInfo(path);