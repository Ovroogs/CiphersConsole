using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace CiphersLibrary
{
    public class Caesar : Cipher<int>
    {
        public Caesar(string str) => StringToEncrypt = str.ToUpper();

        public override string decrypt()
        {
            CreateKey(out int key);
            return $"{StringToEncrypt} {cipher(-key)}";
        }

        public override string encrypt()
        {
            CreateKey(out int key);
            return $"{StringToEncrypt} {cipher(key)}";
        }

        private string cipher(int key)
        {
            var cipherString = string.Empty;

            foreach (var characterFromString in StringToEncrypt)
            {
                int character = characterFromString;
                if (character >= symbolMin && character <= symbolMax)
                {
                    character += key;
                    if (character > symbolMax) character -= AlphabetSize;
                    else if (character < symbolMin) character += AlphabetSize;
                    cipherString += (char)character;
                }
            }

            return cipherString;
        }

        protected override void CreateKey(out int key)
        {
            do
            {
                Write("Введите ключ(только цифры): ");
            } while (!int.TryParse(ReadLine(), out key));
            Clear();
        }
    }
}