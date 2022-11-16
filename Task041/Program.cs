// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например:
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;

            nums = readNums();
            int p = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                    p++;

            Console.WriteLine("Больше 0: " + p);
            Console.ReadLine();
        }

        // Ввод чисел
        static int[] readNums()
        {
            string s;

            Console.Write("Введите числа: ");
            s = Console.ReadLine();
            

            string[] ss = s.Split(new char[] { ',' });
            int[] nums = new int[ss.Length];

            for (int i = 0; i < ss.Length; i++)
                nums[i] = Convert.ToInt32(ss[i]);

            return nums;
        }
    }
}
