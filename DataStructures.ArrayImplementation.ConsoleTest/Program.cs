namespace DataStructures.ArrayImplementation.ConsoleTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Implementations.ArrayImplementation array = new Implementations.ArrayImplementation();
            
            array.Push("1");
            array.Push("2");
            array.Push("3");
            array.Pop();
            array.Delete(0);
            
            for (int i = 0; i < array._length; i++)
            {
                Console.WriteLine(array.Get(i));
            }
        }
    }
}