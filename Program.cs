// method to create an array filled with string elements

Random rnd = new Random();
int lengthOfArray = rnd.Next(5, 11); // рандомизируем длину массива

void PrintArray(string[] array) // метод для  вывода массива с учетом расстановки скобок
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0 & array.Length > 1)
        {
            Console.Write("[" + " " + array[i] + " ");
        }

        if (i == 0 & array.Length <2)
        {
            Console.Write("[" + " " + array[i] + " " + "]");
        }

        if (i != 0 & i != array.Length-1 )
        {
            Console.Write(array[i] + " ");
        }

        if (i == array.Length-1 & array.Length > 1 )
        {
            Console.Write(array[i] + " " + "]");
        }
        if (array.Length == 0)
        {
            Console.WriteLine("[ ]");
        }
    }
}

string[] CreateAndPrintStringArray(int lengthOfArray)
{
    string[] StringArray = new string[lengthOfArray]; // инициализируем новый массив
    for (int i = 0; i < lengthOfArray; i++)
    {
        int StringLength = rnd.Next(1, 11); // рандомизируем длину нового слова
        string str = ""; // инициализируем новое слово
        char letter; // инициализируем новую букву для нового слова
        for (int j = 0; j < StringLength; j++)
        {
            int randValue = rnd.Next(0, 26); // рандомзируем новую букву
            letter = Convert.ToChar(randValue + 65); // переводим ее в тип char
            str +=letter ; // добавляем новую букву к формируемому слову
        }
        StringArray[i] = str; // добавляем новое слово в массив
    }
    PrintArray(StringArray);
    return StringArray;
}

void NotMoreThanThreeSymbolsStringArray () // метод для определения слов заданной длины и записи их в новый массив
{
    string[] stringArray = new string [lengthOfArray];
    stringArray = CreateAndPrintStringArray(lengthOfArray); // создаем массив из слов при помощи метода

    int newStringArrayLength = 0;

    for (int i = 0; i < lengthOfArray; i++) // цикл для определения длины массива с элементами длиной не больше 3 символов
    {
        int length = stringArray[i].Length;
        if (length <= 3)
        {
            newStringArrayLength++;      
        }
    }

    Console.WriteLine();
    string[] newStringArray = new string[newStringArrayLength]; // инициализируем новый массив
    int count = 0; // счетчик для количества индексации слов в номо массиве
    for (int i = 0; i < stringArray.Length; i++) // цикл для определения слов заданной длины и записи их в новый массив
    {
        int length = stringArray[i].Length;
        if (length <= 3)
        {
            newStringArray[count] = stringArray[i];
            Console.Write (newStringArray[count] + " ");
            count++;
        }
    }
    PrintArray(newStringArray);
}

NotMoreThanThreeSymbolsStringArray ();
