internal class Program
{
    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T input)
        {
            data = input;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah " + data);
        }
    }
    private static void Main(string[] args)
    {
        DataGeneric<string> objData = new DataGeneric<string>("1302213089");
        objData.PrintData();
    }
}