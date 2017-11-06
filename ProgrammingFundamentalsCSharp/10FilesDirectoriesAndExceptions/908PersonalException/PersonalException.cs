namespace PersonalException
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());

                    if (input < 0)
                    {
                        throw new NegativeNumberException();
                    }

                    Console.WriteLine(input);
                }
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    internal class NegativeNumberException : Exception
    {
        public NegativeNumberException()
    : base(String.Format("My first exception is awesome!!!"))
        {
        }
    }
}