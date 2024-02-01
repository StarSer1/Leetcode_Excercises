using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodex
{
    public class Solutions
    {
        public static bool IsPalindrome(int x)
        {
            bool isPalindrome = true;
            string numbers = x.ToString();
            char[] arraynumbers = new char[numbers.Length];
            char[] arraynumbersCheck = new char[numbers.Length];

            for (int i = 0, p = numbers.Length - 1; i < numbers.Length; i++, p--)
            {
                arraynumbers[i] = Convert.ToChar(numbers[i].ToString());
                arraynumbersCheck[p] = Convert.ToChar(numbers[i].ToString());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (arraynumbersCheck[i] != arraynumbers[i])
                    isPalindrome = false;
            }
            return isPalindrome;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int summation, temp1 = 0, temp2 = 0;
            for (int i = 0, a = 1; i < nums.Length; a++)
            {
                summation = nums[i] + nums[a];
                if (summation == target)
                {
                    temp1 = i; temp2 = a;
                    break;
                }
                if (a == nums.Length - 1)
                {
                    i++;
                    a = i;
                }
            }
            return new int[] { temp1, temp2 };
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int UnicNums = 1, cont = 0;
            List<int> list = new List<int>();
            for (int i = 0, a = 1; a < nums.Length; i++, a++)
            {
                if (nums[i] != nums[a])
                {
                    UnicNums++;
                    list.Add(nums[i]);
                    cont++;
                }
                if (a == nums.Length - 1)
                {
                    list.Add(nums[a]);
                }
            }
            return UnicNums;
        }

        public static bool IsHappy(int n)
        {
            bool Happy = false;
            for (int contator = 0; Happy != true && contator < 20; contator++)
            {
                double newnum = 0;
                string num = n.ToString();
                int[] numArray = new int[num.Length];
                int i = 0;
                for (int a = 0; a < num.Length; a++)
                {
                    numArray[a] = int.Parse(num[a].ToString());
                }
                while (i < numArray.Length)
                {
                    newnum = newnum + Math.Pow(numArray[i], 2);
                    i++;
                }
                if (newnum == 1)
                    Happy = true;
                n = int.Parse(newnum.ToString());
            }
            return Happy;
        }
        public static int SingleNumber(int[] nums)
        {
            int Exit = 0, actual = 0;
            if (nums.Length == 1)
                return nums[0];
            else
            {
                while (actual < nums.Length)
                {
                    int cont = 0;
                    Exit = nums[actual];
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] == Exit)
                            cont++;
                    }
                    actual++;
                    if (cont == 1)
                        break;
                }
                return Exit;
            }

        }
        //MEJORABLE 
        public static bool UniqueOccurrences(int[] arr)
        {
            int Acumulator_A = 0, Acumilator_B = 0, Num_A = 0, Num_B = 1;

            Array.Sort(arr);

            while (Num_A < arr.Length)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    Num_B = i;
                    if (arr[Num_A] != arr[i])
                    {
                        Acumulator_A = numsOfRepet(arr, arr[Num_A]);
                        Acumilator_B = numsOfRepet(arr, arr[Num_B]);
                        if (Acumulator_A == Acumilator_B)
                            return false;
                    }
                }
                Num_A++;
            }
            return true;
        }
        public static int numsOfRepet(int[] arr, int num)
        {
            int Repet_Times = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    Repet_Times++;
            }
            return Repet_Times;
        }

        public static int sumasxd(int numero, int numero2)
        {
            return numero + numero2;
        }

        public static bool numerodelusuariopendejo1(int numero, int[] pendejada)
        {
            return false;
        }

        public static bool numerodelusuariopendejo2(int numero, int[] pendejada)
        {
            bool flag = false;
            for (int index = 0; index < pendejada.Length; index++)
            {
                if (pendejada[index] == numero)
                {
                    flag = true;
                }

            }
            return flag;

        }
    }
}
