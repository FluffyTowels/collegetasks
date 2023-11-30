public static bool IsTextIncludesChar(string text)
{    

    //Пишите тело вашего метода здесь 
    foreach(char e in text)
        if (e == 'e')
            return true;
    return false;
}