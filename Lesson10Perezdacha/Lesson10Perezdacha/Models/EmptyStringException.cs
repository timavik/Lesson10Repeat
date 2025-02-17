using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10Perezdacha.NewFolder
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException() : base("Строка не может быть пустой!")
        {
        }

        public EmptyStringException(string message) : base(message)
        {
        }
    }
}
