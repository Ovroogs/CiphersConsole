using System.Text.RegularExpressions;

using static System.Console;

namespace CiphersLibrary
{
    public class Cipher
    {
        private string _stringToEncrypt;
        private const int symbolMin = 65, symbolMax = 90, AlphabetSize = 26;

        public Cipher(string str)
        {
            _stringToEncrypt = str;
        }

        public string ChoiceCipher(byte number)
        {
            return number switch
            {
                1 => VigenereСipher(_stringToEncrypt.ToUpper(), EncryptionMode.Encryption),
                2 => VigenereСipher(_stringToEncrypt.ToUpper(), EncryptionMode.Decryption),
                3 => CaesarСipher(_stringToEncrypt.ToUpper(), EncryptionMode.Encryption),
                4 => CaesarСipher(_stringToEncrypt.ToUpper(), EncryptionMode.Decryption),
                5 => TranspositionСipher(_stringToEncrypt),
                6 => XorСipher(_stringToEncrypt),
                7 => PlayfairСipher(_stringToEncrypt.Replace(" ", string.Empty).ToUpper().Replace("J", "I")),
                8 => PlayfairСipher(_stringToEncrypt.Replace(" ", string.Empty).ToUpper().Replace("J", "I")),
                _ => "",
            };
        }

        private string CaesarСipher(string originString, EncryptionMode mode)
        {
            var cipherString = string.Empty;
            CreateKey(out byte key);

            foreach (var characterFromString in originString)
            {
                var character = characterFromString;
                if (character >= symbolMin && character <= symbolMax)
                {
                    var isEncryption = EncryptionMode.Encryption == mode;
                    var border = isEncryption ? symbolMax : symbolMin;
                    var encKey = isEncryption ? key : -key;

                    Enc(ref character, encKey, border, AlphabetSize, isEncryption);
                }

                cipherString += character;
            }

            return $"{originString} {cipherString}";
        }

        private string VigenereСipher(string originString, EncryptionMode mode)
        {
            return "";
        }

        private string TranspositionСipher(string str)
        {
            return "";
        }

        private string XorСipher(string str)
        {
            return "";
        }

        private string PlayfairСipher(string str)
        {
            return "";
        }


        private void Enc(ref char character, int key, int border, int alphabetSize, bool isEncryption)
        {
            character = (char)(character + key);
            if (isEncryption)
            {
                if (character > border) character = (char)(character - alphabetSize); 
            }
            else
            {
                if (character < border) character = (char)(character + alphabetSize);
            }
        }


        private void CreateKey(out string key)
        {
            while (true)
            {
                Write("Введите ключ(только буквы английского алфавита): ");
                key = ReadLine();
                if (!key.Contains(' ') && Regex.IsMatch(key, @"[A-Za-z]", RegexOptions.IgnoreCase)) break;
            }
            Clear();
        }

        private void CreateKey(out byte key)
        {
            while (true)
            {
                Write("Введите ключ(только цифры): ");
                if (byte.TryParse(ReadLine(), out key)) break;
            }
            Clear();
        }
    }

    public enum EncryptionMode
    {
        Encryption,
        Decryption
    }
}