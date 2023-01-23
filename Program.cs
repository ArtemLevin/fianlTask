// method to create an array filled with string elements


void CreateAndPrintStringArray()
{
    Random rnd = new Random();
    int lengthOfArray = rnd.Next(0, 11); // рандомизируем длину массива
    string[] StringArray = new string[lengthOfArray]; // инициализируем новый массив
    for (int i = 0; i < lengthOfArray; i++)
    {
        int StringLength = rnd.Next(0, 11); // рандомизируем длину нового слова
        string str = ""; // инициализируем новое слово
        char letter; // инициализируем новую букву для нового слова
        for (int j = 0; j < StringLength; j++)
        {
            int randValue = rnd.Next(0, 26); // рандомзируем новую букву
            letter = Convert.ToChar(randValue + 65); // переводим ее в тип char
            str +=letter ; // добавляем новую букву к формируемому слову
        }
        StringArray[i] = str;
        
    }
    for (int i = 0; i < lengthOfArray; i++)
    {
        Console.Write(StringArray[i] + " ");
    }

}

CreateAndPrintStringArray();