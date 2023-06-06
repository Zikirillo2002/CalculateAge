namespace CalculateAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter the Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter the T. Yil : ");
            int birthYear = int.Parse(Console.ReadLine());

            Console.Write("Enter the T. Oy : ");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.Write("Enter the T. Kun : ");
            int birthDay = int.Parse(Console.ReadLine());

            var BirthDate = new DateTime(birthYear, birthMonth, birthDay);

            var today = DateTime.Now;

            int years = today.Year - BirthDate.Year;

            if (BirthDate.Date > today.AddYears(-years))
            {
                years--;
            }

            int months = today.Month - BirthDate.Month;

            if (today.Day < BirthDate.Day)
            {
                months--;
            }

            if (months < 0)
            {
                months += 12;
            }

            int days = (today - BirthDate.AddMonths((years * 12) + months)).Days;

            Console.WriteLine($" Age : {years} year /" +
                $" {months} month /" +
                $" {days} days");

            Console.ReadKey();
            Console.Clear();
            Main(args);
        }
    }
}