namespace ArithmeticQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic Question\'s\r\n");

            Random random = new Random();
            int numQuestions = random.Next(5, 15);
            int correctAnswers = 0;
            Console.WriteLine("Please answer the given Questions below:\r\n");
            for (int i = 1; i <= numQuestions; i++)
            {
                int operand1 = random.Next(1, 11);
                int operand2 = random.Next(11);
                char[] operators = { '+', '-', '*', '/'};
                char op = operators[random.Next(operators.Length)];


                Console.Write($"Question {i}: What is {operand1} {op} {operand2}?\nYour Answer:");
                int userAns = 0;

                while (!int.TryParse(Console.ReadLine(), out userAns))
                {
                    Console.WriteLine("Invalid input! Your answer must be an interger.\n");
                    Console.Write("Your Answer:");

                }

                // Calculate the correct answer
                int correctAnswer = CalculateAnswer(operand1, operand2, op);

                if(userAns == correctAnswer)
                {
                    Console.WriteLine("Correct!\n");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is {correctAnswer}.\n");
                }
            }
            static int CalculateAnswer(int operand1, int operand2, char op)
            {
                switch (op)
                {
                    case '+':
                        return operand1 + operand2;
                    case '-':
                        return operand1 - operand2;
                    case '*':
                        return operand1 * operand2;
                    case '/':
                        return operand1 / operand2;
                    default:
                        throw new ArgumentException("Invalid operator");
                }
            }
            Console.WriteLine($"Results:\n");
            Console.WriteLine($"Total Correct Answers:{correctAnswers}");
            double percentage = (double)correctAnswers / numQuestions * 100;

            Console.WriteLine($"Percentage of Correct Answers:{percentage}%");
        } 
    }
}
