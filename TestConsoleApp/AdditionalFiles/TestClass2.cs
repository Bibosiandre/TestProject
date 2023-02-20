using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.AdditionalFiles
{
    public class TestClass2
    {
        //Test comment

        /// <summary>
        /// Отображает переданную информацию в строку
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Surname">Фамилия</param>
        /// <remarks>Дополнительная инфа какая-то</remarks>
        public void DisplayName(string Name, string Surname)
        {
            Console.WriteLine($"Привет! Меня зовут {Name}, фамилия {Surname}");
        }
    }
}
