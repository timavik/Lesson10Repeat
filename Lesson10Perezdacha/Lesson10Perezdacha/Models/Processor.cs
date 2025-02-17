using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10Perezdacha.NewFolder
{
    public class StringProcessor
    {
        public void ProcessString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new EmptyStringException();
            }

            Console.WriteLine($"Обработана строка: {input}");
        }
    }
}
