using Lesson10Perezdacha.NewFolder;

namespace Lesson10Perezdacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringProcessor processor = new StringProcessor();

            try
            {
                Console.WriteLine("Введите строку для обработки:");
                string userInput = Console.ReadLine();

                processor.ProcessString(userInput);
            }
            catch (EmptyStringException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine("Программа завершена.");
            Console.ReadKey();
        }
    }
}
