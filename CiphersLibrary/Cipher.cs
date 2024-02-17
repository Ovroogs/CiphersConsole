namespace CiphersLibrary
{
    public abstract class Cipher<T>
    {
        protected string _stringToEncrypt;
        protected const int SYMBOLMIN = 65, SYMBOLMAX = 90, ALPHABETSIZE = 26;

        public string StringToEncrypt
        {
            get => _stringToEncrypt; 
            protected set => _stringToEncrypt = value ?? string.Empty; 
        }

        public abstract void encrypt();
        public abstract void decrypt();
        protected abstract void CreateKey(out T key);
    }
}