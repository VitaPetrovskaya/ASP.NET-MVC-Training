namespace No4.Solution.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
               RandomFileGenerator.GenerateFiles(new BytesFileService(), 3, 10);
               RandomFileGenerator.GenerateFiles(new CharsFileService(), 3, 10);
               System.Console.ReadLine();
          }
    }
}
