namespace cmethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            Task(num);

        }

        static void Task(int num)
        {
            if (num % 7 == 0)
            {
                Console.WriteLine("7 ye bolunur");
            }
            else if (num % 7 != 0)
            {
                int num1 = num;
                int num2 = num;
                int result1 = 0;
                int result2 = 0;

                while (num1 % 7 != 0)
                {
                    num1++;
                    result1++;
                }
                while (num2 % 7 != 0)
                {
                    num2--;
                    result2++;
                }

                if (result1 < result2)
                {
                    Console.WriteLine(num1);
                }
                else if (result2 < result1)
                {
                    Console.WriteLine(num2);
                }
            }
           
        }
    }
}