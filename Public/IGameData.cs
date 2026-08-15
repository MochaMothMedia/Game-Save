namespace MochaMoth.GameSave
{
    public interface IGameData
    {
        void LoadData(byte[] data);
        byte[] SaveData();
    }
}