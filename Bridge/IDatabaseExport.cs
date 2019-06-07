namespace Bridge
{
    public interface IDatabaseExport
    {
        void setNewFormatter(IFormatter formatter);
        void exportDatabase();
    }
}