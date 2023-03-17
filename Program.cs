internal class Program
{
    public class HaloGeneric
    {
        public static void SapaUser<T>(T inputUser)
        {
            Console.WriteLine("Halo User " + inputUser);
        }
    }
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
        HaloGeneric.SapaUser("Vikhan");
        DataGeneric<string> objData = new DataGeneric<string>("1302213089");
        objData.PrintData();
    }
}