namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
              int startYear, endYear;
       {
           Console.Write("Enter the start year");
           startYear = Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter the end year");
           endYear = Convert.ToInt32(Console.ReadLine());
       } while (startYear >= 2000 || startYear >= endYear);
       Console.WriteLine("Year difference" + (endYear - startYear));
   }


        }
    }
}
