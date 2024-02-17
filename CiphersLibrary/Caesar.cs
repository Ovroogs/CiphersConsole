using static System.Console;

namespace CiphersLibrary
{
    public class Caesar : Cipher<int>
    {
        public Caesar(string str) => StringToEncrypt = str.ToUpper();

        public override void decrypt()
        {
            CreateKey(out int key);
            StringToEncrypt = cipher(-key);
        }

        public override void encrypt()
        {
            CreateKey(out int key);
            StringToEncrypt = cipher(key);
        }

        private string cipher(int key)
        {
            var cipherString = string.Empty;

            foreach (var characterFromString in StringToEncrypt)
            {
                int character = characterFromString;
                if (character >= SYMBOLMIN && character <= SYMBOLMAX)
                {
                    character += key;
                    if (character > SYMBOLMAX) character -= ALPHABETSIZE;
                    else if (character < SYMBOLMIN) character += ALPHABETSIZE;
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