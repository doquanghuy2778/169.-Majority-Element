using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169.Majority_Element
{
    internal class Program
    {
        static int MajorityElement(int[] nums)
        {
            int check = nums[0];
            int count = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    check = nums[i];
                    count = 1;
                }
                else if (nums[i] == check)
                    count++;
                else
                    count--;
            }
            return check;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int result = MajorityElement(nums);
            Console.Write("MajorityElement " + result); 
            Console.ReadKey();
        }
    }
}
