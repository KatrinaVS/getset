using System;
namespace свойства
{
    class Exam
    {
        public string Name; // фамилия студента, открытое поле
        private int rating; // оценка от 0 до 10, закрытое поле
        public int Rating //объявление свойства
        {
            get // аксессор чтения поля с преобразованием
            {
                if (rating < 5)
                    return 2;
                else
                    return (rating + 1) / 2;
            }
            set // аксессор записи в поле
            {
                if (value < 0)
                    rating = 0;
                else if (value > 10)
                    rating = 10;
                else
                    rating = value;
            }
        }
        public Exam(string name)  // конструктор
        {
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Exam examen = new Exam("Иванов");    // создание нового студента
            Console.Write("Студент - {0}: Введите оценку за экзамен от 0 до 10: ", examen.Name);
           
            // записываем в поле, используя аксессор set
            examen.Rating = Convert.ToInt32(Console.ReadLine());
           
            // читаем поле, используя аксессор get
            Console.WriteLine("В зачетку: {0}", examen.Rating);
            Console.ReadKey();
        }
    }
}