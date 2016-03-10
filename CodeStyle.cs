/* Правила написания кода
 * 1. Стараемся избегать расположения нескольких классов в одном файле.
 * 2. Один файл должен взаимодействовать с одним пространством имен.
 * 3. Избегаем файлов с более чем 500 строками (за исключением машинно сгенерированных).
 * 4. Избегаем методов с более чем 200 строками.
 * 5. Избегаем методов содержащих более 5 аргументов. Используем структуры для передачи большого количества аргументов.
 * 6. Строка должна быть ограничена 80 символами.
 * 7. Вместо таба используем 4 пробела.
 * 8. Не редактируем руками авто сгенерированный код.
 * 9. Избегаем комментирования очевидных вещей. Код должен сам себя пояснять. 
 * 10. Используем const только для естественных констант, таких как количество дней в неделе.
 * 11. Каждая строка кода должна читаться как "white box"
 * 12. Никогда не хардкодить строки, которые могут быть использованы пользователем, используем ресурсы. 
 * 13. Используем логгирование и трассировку
 */
//Группируем все пространства имен фреймворка 
//и располагаем все сторонние и свои под ними

using System;
using System.Collections.Generic;
using System.ComponentModel;
using ItWebNet;
using ItWebNet.SomeTech.SomeFeuture;

//CompanyName.Technology[.Feuture][.Design]
namespace ItWebNet.SomeTech.SomeFeuture
{
    //Pascal case для имен классов
    class SomeClassName
    {
        /* ИМЕНА ПЕРЕМЕННЫХ
         * 
         * Стараемся избегать однобуквенных обозначений, таких как t и i.
         * Лучше использовать index или temp
         * 
         * Избегаем венгерской нотации в public и protected именах
         * 
         * Не сокращаем слова (например num вместо numbers)
         * 
         */

        //Префикс _ для приватных переменных
        private int _number;
        
        public enum Color 
        {
            NoSet = 0,
            Red,
            Green,
            Blue,
        }

        //Pascal case для имен методов, делегатов и событий
        //Camel case для локальных переменных и аргументов методов
        public void SomeMethod(int someNumber = 0)
        {
            string longString =
                @"Очень Очень Очень Очень Очень Очень 
                Очень Очень Очень Очень Очень Очень Очень Очень
                Очень Длинная Строка";

            //Используем var только когда правая часть присваивания точно описывает тип переменной
            //Избегаем
            var myVariable = DoSomething();
            //Верно
            var name = EmployeeName;

            //String.Empty вместо ""
            string yetName = String.Empty;

            //Образец сложного улсловия
            if (
                    condition
                    || secondCondition
                    || (
                        one + more * another / condition
                    )
                    && oneMoreCondition
            )
            {
                throw new SomeException("Example of exception");
            }
            else
            {
                //Вызов метода с кучей параметров
                LongNameMethod(
                    firstParametr,
                    secondParametr,
                    AnotherLongMethod(
                        foo,
                        bah
                    ),
                    thirdParametr
                );

                //Каскадный вызов методов
                var cascadeMethodCall = 
                        FirstMethod()
                        .SecondMethod()
                        .ThirdMethod();
            }

            //Тернарный оператор
            int yetNumber = 
                (parameter)
                    ? first
                    : second;

            //Всегда описываем default в switch
            switch (number) 
            {
                case 1:
                    Trace.WriteLine("Case 1:");
                    break;
                case 2:
                    Trace.WriteLine("Case 2:");
                    break;
                default:
                    Debug.Assert(false);
                    break;
            }
        }

        private bool IsEverythingOK()
        {
            //some code
            return true;
        }
    }

    //Интерфейсы начинаем c I
    interface IMyInterface
    {
        //some code
    }

    //Используем окончание Attribute для классов описывающих атрибуты
    public class SomeAttribute : Attribute
    {

    }

    //Используем окончание Exception для классов описывающих исключения
    public class SomeException : Exception
    {
        public SomeException(string exceptionText)
        {}
    }

    //Лучше перегружать методы имеющие значение по умлочанию
    //Избегаем  
    class MyClassAvoid
    {
        void MyMethod(int number = 123)
        {
            //some code
        }
    }
    //Верно
    class MyClassCorrect
    {
        void MyMethod()
        {
            MyMethod(123);
        }
        
        //При использовании атрибутов по умолчанию, всегда присваиваем им неизменные константы,
        //такие как null,false или 0
        void MyMethod(int number = 0)
        {
            //some code
        }
    }
}