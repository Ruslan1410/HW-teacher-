using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_teacher_
{
    internal class Program
    {
        //11. Напишите программу, которая запрашивает у пользователя строку и проверяет,
        //является ли она палиндромом(читается одинаково с начала и с конца).
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for(int i = s.Length - 1; i >= 0; i--) 
            {
                if(s[i]string() != " ")
            {

                s += s[i]string();

            }
            }
        }
    }
}
