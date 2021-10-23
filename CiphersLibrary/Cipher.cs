using static System.Console;

namespace CiphersLibrary
{
    public class Cipher
    {
        private string _stringToEncrypt;

        public Cipher(string str)
        {
            _stringToEncrypt = str;
        }

        public void ChoiceCipher(byte number)
        {
            switch (number)
            {
                case 1: VigenereСipher(_stringToEncrypt.ToUpper()); break;
                case 2: VigenereСipher(_stringToEncrypt.ToUpper()); break;
                case 3: CaesarСipher(_stringToEncrypt.ToUpper()); break;
                case 4: CaesarСipher(_stringToEncrypt.ToUpper()); break;
                case 5: TranspositionСipher(_stringToEncrypt); break;
                case 6: XorСipher(_stringToEncrypt); break;
                case 7: PlayfairСipher(_stringToEncrypt.Replace(" ", string.Empty).ToUpper().Replace("J", "I")); break;
                case 8: PlayfairСipher(_stringToEncrypt.Replace(" ", string.Empty).ToUpper().Replace("J", "I")); break;
            }
        }

        public void CaesarСipher(string str)
        {

        }

        public void VigenereСipher(string str)
        {

        }

        public void TranspositionСipher(string str)
        {

        }

        public void XorСipher(string str)
        {

        }

        public void PlayfairСipher(string str)
        {

        }
    }
}