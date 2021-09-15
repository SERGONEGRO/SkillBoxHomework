using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

                                  /*   РЕШЕНИЕ    */

            string firstname;                         //имя
            string lastname;                          //фамилия
            int height;                               //рост
            byte history; byte math; byte rus;        //оценки
            float sredbal;                            //средний балл
          
            string text = "Введите имя: ";                                 //строка, в которую записывается текст для последующей печати
            int centerX = (Console.WindowWidth / 2) - (text.Length / 2);   //вычисление центра строки на основе длины текста, установка курсора в центр по оси Х
            int y = Console.CursorTop;                                     // позиция по оси Y = текущей строке

            /// <summary>
            /// Функция для печати по центру
            /// </summary>
            void CenterPrint(string sometext)
            {
                y = Console.CursorTop + 1;
                centerX = (Console.WindowWidth / 2) - (sometext.Length / 2);
                Console.SetCursorPosition(centerX, y);
                Console.WriteLine(sometext);
                

            }

            /// <summary>
            /// Функция для ввода по центру
            /// </summary>
            string CenterRead()
            {
                y = Console.CursorTop + 1;
                centerX = (Console.WindowWidth / 2) -2 ;
                Console.SetCursorPosition(centerX, y);
                string somestring = Console.ReadLine();
                return somestring;
                
            }

            /// <summary>
            /// вычисление среднего балла
            /// </summary>
            float Sredbal(byte a, byte b, byte c)
            {
                return sredbal = (float)(a + b + c) / 3;
            }

            
            CenterPrint("Имя:");                               
            firstname = CenterRead();                        //ввод имени
            
            CenterPrint("Фамилия:");                             
            lastname = CenterRead();                         //ввод фамилии

            CenterPrint("Возраст: ");                          
            height = Convert.ToInt32(CenterRead());          //Ввод возраста и преобразование строки в Int
            
            CenterPrint("Балл за историю:");                 //балл по истории
            history = Convert.ToByte(CenterRead());

            CenterPrint("Балл за математику:");              //балл по математике
            math = Convert.ToByte(CenterRead());

            CenterPrint("Балл за русский язык:");             //балл по рус. язу
            rus = Convert.ToByte(CenterRead());

            //печать всей информации:
            CenterPrint($"Студент: {firstname} {lastname}, Средний балл: {Sredbal(rus,math,history):0.0}");

            Console.ReadKey();


        }
    }
}
