static string GetTypeInfo(object obj)
{
    string otpt = "";
    if (obj is string) otpt = "Переменная является строкой";
    if (obj is int) otpt = "Переменная целочисленного типа";
    if (obj is double) otpt = "Переменная - число с плавающей точкой";
    if (obj is char) otpt = "Переменная является символом";
    return otpt;
}