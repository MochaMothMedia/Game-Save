namespace MochaMoth.GameSave
{
    public interface IEncrypt
    {
        string Encrypt(string humanReadable);
        string Decrypt(string encrypted);
    }
}