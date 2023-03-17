internal class Program
{
    public class HaloGeneric
    {
        public static void SapaUser<T>(T inputUser)
        {
            Console.WriteLine("Halo User " + inputUser);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser("Vikhan");
    }
}