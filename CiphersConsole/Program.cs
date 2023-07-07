using static System.Console;

using CiphersLibrary;


internal class Program
{
    private static void Main(string[] args)
    {
        string str = string.Empty;
        byte numberCipher = 0;

        while (true)
        {
            if (numberCipher == 0)
            {
                Write("Введите строку: ");
                str = new(ReadLine());
            }

            while (true)
            {
                WriteLine("0. Другая строка для шифровки\n1. Шифр Виженера(шифровка)\n2. Шифр Виженера(дешифровка)\n3. Шифр Цезаря(шифровка)\n4. Шифр Цезаря(дешифровка)\n" +
                      "5. Транспозиция(шифровка\\дешифровка)\n6. Xor(шифровка\\дешифровка).\n7. Шифр Плейфера(шифровка)\n8. Шифр Плейфера(дешифровка)\n9. Выход\n");
                Write("Введите пункт: ");
                if (byte.TryParse(ReadLine(), out numberCipher) && numberCipher >= 0 && numberCipher < 10)
                {
                    Clear();
                    switch (numberCipher)
                    {
                        case 3:
                            WriteLine(new Caesar(str).encrypt());
                            break;
                        case 4:
                            WriteLine(new Caesar(str).decrypt());
                            break;
                        default:
                            break;
                    }
                    //WriteLine(cipher.ChoiceCipher(numberCipher));
                    break;
                }
            }

            if (numberCipher == 9) break;
        }
    }
}