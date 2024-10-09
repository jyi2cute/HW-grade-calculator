namespace grade_calculator
{ 
    /* 
     * Name: Jin Yi
     * Class: IGME.201.01 - Interac Des & Alg Prob Sol III
     * Date: 10/13/24
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Variable
            string studentName = "Jin";

            //Array of ints that hold 10 numbers
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };

            //Print out a custom greeting that says welcome and the name of the student
            Console.WriteLine("Welcome " + studentName);

            //Print to the console: "Here are your grades:"
            Console.WriteLine("Here are your grades: ");

            //Loop through the grades array and print each grade
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);

                if (grades[i] >= 90 && grades[i] <= 100)
                {
                    Console.WriteLine("This grade is an A!");

                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if (grades[i] >= 80 && grades[i] <= 89)
                {
                    Console.WriteLine("This grade is a B.");

                }
                else if (grades[i] >= 70 && grades[i] <= 79)
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if (grades[i] >= 65 && grades[i] <= 69)
                {
                    Console.WriteLine("This grade is a D.");
                }
                else if (grades[i] >= 0 && grades[i] <= 64)
                {
                    Console.WriteLine("This grade is an F.");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
                
            }

            //Calculate an average for the grades and store in a new variable called "average".
            var average = new int[] { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            double avg = Queryable.Average(average.AsQueryable());

            //Display the final calculated average in the console.
            Console.WriteLine("Your final calculated average = " + avg);

            //End the program with a print that says we have displayed all grades for that user
            Console.WriteLine("We have displayed all grades for " + studentName + ".");
        }
    }
}
