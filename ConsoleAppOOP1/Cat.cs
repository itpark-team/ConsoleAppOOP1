using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP1
{
    internal class Cat
    {
        private string _name;
        private int _age;

        public Cat()
        {
            _name = "безымянный кот";
            _age = 0;
        }

        public Cat(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Cat(Cat cat)
        {
            _name = cat._name;
            _age = cat._age;
        }

        public void SetName(string name)
        {
            if (name.Length == 0 || name.Length > 35)
            {
                Console.WriteLine("Ошибка. Длина имени кота, должна быть от 1 до 5 символов");
                return;
            }
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetAge(int age)
        {
            if (age < 0 || age > 25)
            {
                Console.WriteLine("Ошибка. Возраст кота должен быть от 1 до 25 лет");
                return;
            }
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }
    }
}
