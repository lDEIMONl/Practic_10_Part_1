using System;

namespace Practic_10
{
    class Program
    {

        public static int ConvertRomanNumber(string romanNumber)
        {
            //Перевод из риских цифр в арабские
            int[] normalNumber = new int[romanNumber.Length];
            for (int i = 0; i < romanNumber.Length; i++)
            {
                switch (romanNumber[i].ToString())
                {
                    case ("I"):
                        normalNumber[i] = 1;
                        break;
                    case ("V"):
                        normalNumber[i] = 5;
                        break;
                    case "X":
                        normalNumber[i] = 10;
                        break;
                    case ("L"):
                        normalNumber[i] = 50;
                        break;
                    case ("C"):
                        normalNumber[i] = 100;
                        break;
                    case ("D"):
                        normalNumber[i] = 500;
                        break;
                    case ("M"):
                        normalNumber[i] = 1000;
                        break;
                }
            }

            //Подсчёт каждой цифры
            int oldNumber = normalNumber[0];
            for (int i = 1; i < normalNumber.Length; i++)
            {
                if (oldNumber < normalNumber[i])
                {
                    normalNumber[i] -= oldNumber;
                    normalNumber[i - 1] -= oldNumber;
                }
                else
                {
                    oldNumber = normalNumber[i];
                }
            }

            //Посчёт результата
            int result = 0;
            for (int i = 0; i < normalNumber.Length; i++)
            {
                result += normalNumber[i];
            }

            return result;
        }//Метод для конвертации из римских цифр в десятичные
        public static bool isPalindrome(int number)
        {
            string numberString = number.ToString();
            string reverseNumberString = "";
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                reverseNumberString += numberString[i].ToString();
            }

            if (numberString.Equals(reverseNumberString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Метод для определения, является ли число палидромам
        static void Main(string[] args)
        {

        }
    }
}
