public static void GetDecryption(string text)
{

    //Тело вашего метода
    foreach (char c in text)
        Console.Write(Convert.ToChar(c/3));
    Console.Write("\n");
}