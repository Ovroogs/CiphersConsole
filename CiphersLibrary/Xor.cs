using System.Text.RegularExpressions;

using static System.Console;

namespace CiphersLibrary
{
    public class Xor : Cipher<string?>
    {
        public Xor(string str) => StringToEncrypt = str;

        public override void decrypt() => StringToEncrypt = cipher();

        public override void encrypt() => StringToEncrypt = cipher();

        private string cipher()
        {
            var cipher = string.Empty;
            var count = 0;

            CreateKey(out string? key);
            for (var i = 0; i < StringToEncrypt.Length; i++)
            {
                var j = i;
                if (j >= key.Length)
                {
                    if (count > 0)
                    {
                        j -= key.Length * count;
                        if (j >= key.Length - 1)
                            count++;
                    }
                    else
                    {
                        j -= key.Length;
                        count++;
                    }
                }

                cipher += (char)(key[j] ^ StringToEncrypt[i]);
            }
            return cipher;
        }

        protected override void CreateKey(out string? key)
        {
            do
            {
                Write("Введите ключ(только буквы английского алфавита): ");
                key = ReadLine();
            } while (!(!key.Contains(' ') && Regex.IsMatch(key, @"[A-Za-z]", RegexOptions.IgnoreCase)));
            Clear();
        }
    }
}