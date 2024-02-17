using static System.Console;

using CiphersLibrary;


internal class Program
{
    private static void Main(string[] args)
    {
        var str = string.Empty;
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
                        case 1:
                        case 2:
                            break;
                        case 3:
                        case 4:
                            Caesar caesar = new(str);
                            if (numberCipher == 3) caesar.encrypt();
                            else caesar.decrypt();
                            WriteLine(caesar.StringToEncrypt);
                            break;
                        case 6:
                            Xor xor = new(str);
                            xor.encrypt();
                            WriteLine(xor.StringToEncrypt);
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