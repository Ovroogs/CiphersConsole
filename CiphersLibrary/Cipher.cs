using System.Text.RegularExpressions;

using static System.Console;

namespace CiphersLibrary
{
    public abstract class Cipher<T>
    {
        protected string _stringToEncrypt;
        protected const int symbolMin = 65, symbolMax = 90, AlphabetSize = 26;

        public string StringToEncrypt
        {
            get => _stringToEncrypt; 
            protected set => _stringToEncrypt = value; 
        }

        public abstract string encrypt();
        public abstract string decrypt();
        protected abstract void CreateKey(out T key);

        //public string ChoiceCipher(byte number)
        //{
        //    return number switch
        //    {
        //        1 => VigenereСipher(StringToEncrypt.ToUpper(), EncryptionMode.Encryption),
        //        2 => VigenereСipher(StringToEncrypt.ToUpper(), EncryptionMode.Decryption),
        //        //3 => CaesarСipher(_stringToEncrypt.ToUpper(), EncryptionMode.Encryption),
        //        //4 => CaesarСipher(_stringToEncrypt.ToUpper(), EncryptionMode.Decryption),
        //        5 => TranspositionСipher(StringToEncrypt),
        //        6 => XorСipher(StringToEncrypt),
        //        7 => PlayfairСipher(StringToEncrypt.Replace(" ", string.Empty).ToUpper().Replace("J", "I")),
        //        8 => PlayfairСipher(StringToEncrypt.Replace(" ", string.Empty).ToUpper().Replace("J", "I")),
        //        _ => "",
        //    };
        //}

        //private string VigenereСipher(string originString, EncryptionMode mode)
        //{
        //    return "";
        //}

        //private string TranspositionСipher(string str)
        //{
        //    return "";
        //}

        //private string XorСipher(string str)
        //{
        //    return "";
        //}

        //private string PlayfairСipher(string str)
        //{
        //    return "";
        //}


        //private void Enc(ref char character, int key, int border, int alphabetSize, bool isEncryption)
        //{
        //    character = (char)(character + key);
        //    if (isEncryption)
        //    {
        //        if (character > border) character = (char)(character - alphabetSize); 
        //    }
        //    else
        //    {
        //        if (character < border) character = (char)(character + alphabetSize);
        //    }
        //}


        //private void CreateKey(out string key)
        //{
        //    while (true)
        //    {
        //        Write("Введите ключ(только буквы английского алфавита): ");
        //        key = ReadLine();
        //        if (!key.Contains(' ') && Regex.IsMatch(key, @"[A-Za-z]", RegexOptions.IgnoreCase)) break;
        //    }
        //    Clear();
        //}

        //private void CreateKey(out byte key)
        //{
        //    while (true)
        //    {
        //        Write("Введите ключ(только цифры): ");
        //        if (byte.TryParse(ReadLine(), out key)) break;
        //    }
        //    Clear();
        //}
    }
}