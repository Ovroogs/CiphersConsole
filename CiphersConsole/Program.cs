using static System.Console;

using CiphersLibrary;

Cipher cipher = null;
byte on = 0;
while (on != 9)
{
    if (on == 0)
    {
        Write("Введите строку: ");
        cipher = new(ReadLine());
    }
    while (true)
    {
        Write("0. Другая строка для шифровки\n1. Шифр Виженера(шифровка)\n2. Шифр Виженера(дешифровка)\n3. Шифр Цезаря(шифровка)\n4. Шифр Цезаря(дешифровка)\n" +
              "5. Транспозиция(шифровка\\дешифровка)\n6. Xor(шифровка\\дешифровка).\n7. Шифр Плейфера(шифровка)\n8. Шифр Плейфера(дешифровка)\n9. Выход\n");
        Write("Введите пункт: ");
        if (byte.TryParse(ReadLine(), out on) && on >= 0 && on < 10)
            break;
        Clear();
    }

    cipher.ChoiceCipher(on);
}