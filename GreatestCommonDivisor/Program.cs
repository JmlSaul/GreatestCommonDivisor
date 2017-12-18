using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("输入分数x/y");
                int[] nums = null;
                while (true)
                {
                    var input = Console.ReadLine();
                    try
                    {
                        nums = input?.Split('/').Select(int.Parse).ToArray();
                        if (input == null || nums.Length != 2)
                            throw new Exception();
                    }
                    catch
                    {
                        Console.WriteLine("输入有误，请重新输入x/y");
                        continue;
                    }

                    break;
                }

                int x = nums[0], y = nums[1];
                var z = y;
                while (x % y != 0)
                {
                    z = x % y;
                    x = y;
                    y = z;
                }
                Console.WriteLine($"{nums[0]}/{nums[1]}的最大公约数为{z}，约分后为{nums[0] / z}/{nums[1] / z}");
                Console.WriteLine("输入Q退出，其他任意继续");
                var key = Console.ReadLine();
                if (key == "Q" || key == "q") break;
            }
        }
    }
}
