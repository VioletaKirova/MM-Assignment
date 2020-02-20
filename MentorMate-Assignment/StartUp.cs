namespace MentorMate_Assignment
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            const string UserInputPrefix = "Please enter a valid odd number larger than 2:";

            Console.WriteLine(UserInputPrefix);
            string input = Console.ReadLine();
            bool notValid = true;
            int inputNumber = 0;

            if (!int.TryParse(input, out int n) || n % 2 == 0 || n < 2)
            {
                while (notValid)
                {
                    Console.WriteLine(UserInputPrefix);
                    input = Console.ReadLine();

                    if (int.TryParse(input, out int m) && m % 2 != 0 && m > 2)
                    {
                        inputNumber = m;
                        notValid = false;
                    }
                }
            }
            else
            {
                inputNumber = int.Parse(input);
            }

            int height = (inputNumber + 1) / 2;
            int length = inputNumber * 5;
            int topHalfStarsIncrement = 0;

            // Top Half

            for (int i = 0; i < height; i++)
            {
                Top line = new Top(inputNumber, i, length, topHalfStarsIncrement);

                line.SetBorderDashes();
                line.SetStars();
                line.SetMiddleDashes();
                line.SetHalf();

                Console.WriteLine(line.Draw());

                topHalfStarsIncrement += 2;
            }

            // Bottom Half

            int bottomHalfMiddleStarsCount = inputNumber * 2 + 1;
            int bottomHalfMiddleStarsDecrement = 0;

            for (int i = height; i > 0; i--)
            {
                Bottom line = new Bottom(inputNumber, i, length, bottomHalfMiddleStarsCount, bottomHalfMiddleStarsDecrement);

                line.SetBorderDashes();
                line.SetBorderStars();
                line.SetMiddleStars();
                line.SetMiddleDashes();
                line.SetHalf();

                Console.WriteLine(line.Draw());

                bottomHalfMiddleStarsDecrement += 2;
            }
        }
    }
}
