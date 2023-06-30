namespace StructExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myKmStruct = new KMConverter(113);
            myKmStruct.CalculateMiles();
            
            Console.WriteLine($"Total km: {myKmStruct.Km}");
            Console.WriteLine($"Total miles: {myKmStruct.Miles}");
        }
    }
}