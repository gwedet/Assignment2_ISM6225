using System;
using System.Collections.Generic;

namespace Assignment2_ISM6225
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1.

            // Declare and initialize arrays.
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };
            //FindIntersection() FUNCTION and storing the result.
            int[] res = FindIntersection(nums1, nums2);
            // Print.
            Console.Write("[");
            for (int i = 0; i < res.Length - 1; i++)
            {
                Console.Write(res[i]);
                Console.Write(",");
            }
            if (res.Length != 0)
                Console.Write(res[res.Length - 1]);
            Console.WriteLine("]");}
        private static int[] FindIntersection(int[] nums1, int[] nums2)
        {
            throw new NotImplementedException();
        }
    }
}
//Question 2

class Program
{

    //Initiate searchValue function
    static int searchValue(int[] arr, int target)
    {
        int lower, high, mid, contPos = 0;
        lower = 0;
        high = arr.Length - 1;

        while (lower <= high)
        {
            // To find the mid of the array
            mid = (lower + high) / 2;

            //If the array mid index value is = to target
            if (arr[mid] == target)
            {
                return mid;
            }

            // If target value is less than to mid value
            if (target < arr[mid])
            {
                high = mid - 1;
                if ((arr[mid] - 1) == target)
                    contPos = mid;
            }
            else
            {
                // When target value is greater than to mid value
                lower = mid + 1;

                if ((arr[mid] + 1) == target)
                    contPos = (mid + 1);
            }
        }
        return contPos;
    }
}


    //Question 3

namespace LuckInt
{
    class Program
    {
        public static int GetLuckyInteger(int[] arr)
        {
            int res = -1;
            //To create dictionary.
            Dictionary<int, int> dict = new Dictionary<int, int>();
            //Elements in the arr.
            for (int i = 0; i < arr.Length; i++)
            {
                //To store the arr[i],count in the dictionary.
                if (dict.ContainsKey(arr[i]))
                {
                    //WriteLine
                    int val = dict.GetValueOrDefault(arr[i]) + 1;
                    dict.Remove(arr[i]);
                    dict.Add(arr[i], val);
                }
                else
                {
                    dict.Add(arr[i], 1);
                }

            }
            //To find the biggest lucky number.
            foreach (KeyValuePair<int, int> ele in dict)
            {
                if (ele.Key == ele.Value)
                {
                    if (res < ele.Key)
                        res = ele.Key;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 3, 3 };
            Console.WriteLine(GetLuckyInteger(arr));

            //Question 4   

            {
                static int maxNum(int n)
                {
                    if (n <= 0)
                        return -1;
                    if (n == 1 || n == 2)
                        return 1;
                    int[] nums = new int[n + 1];
                    nums[0] = 0;
                    nums[1] = 1;
                    int max = 1;
                    for (int i = 1; i < n; i++)
                    {
                        int j = 2 * i;
                        int k = 2 * i + 1;
                        if (j >= 2 && j <= n)
                        {
                            nums[j] = nums[i];
                            if (nums[j] > max)
                                max = nums[j];
                        }
                        if (k >= 2 && k <= n)
                        {
                            nums[k] = nums[i] + nums[i + 1];
                            if (nums[k] > max)
                                max = nums[k];
                        }
                    }
                    return max;
                }
                {
                    Console.WriteLine("n=1, Max= " + maxNum(1));
                    Console.WriteLine("n=2, Max= " + maxNum(2));
                    Console.WriteLine("n=3, Max= " + maxNum(3));
                    Console.WriteLine("n=4, Max= " + maxNum(4));
                    Console.WriteLine("n=5, Max= " + maxNum(5));
                    Console.WriteLine("n=6, Max= " + maxNum(6));
                    Console.WriteLine("n=7, Max= " + maxNum(7));
                }
            }
        }

        //Question 5
        public class Solution
        {
            public string DestCity(IList<IList<string>> paths)
            {
                Dictionary<string, string> map = new Dictionary<string, string>();
                string destination = paths[0][1];

                foreach (IList<string> path in paths)
                    map.Add(path[0], path[1]);
                //Since paths form a line use while(true)
                while (true)
                {
                    map.TryGetValue(destination, out string value);
                    if (value == null)
                        return destination;
                    else
                        destination = value;
                }
                return null;
            }
        }

        //Question 6
        public class AlreadySort
        {
            public static int[] sumFunc(int[] nums, int target)

            {

                int i = 0;

                int j = nums.Length - 1;

                // nums[i]+nums[j]=17 (2+15)
                while (i < j)
                {
                    if (nums[i] + nums[j] == target)

                        return new int[] { i + 1, j + 1 };

                    // If nums[i]+nums[j]< target, increase i to target

                    else if (nums[i] + nums[j] < target)

                        i++;

                    // If nums[i]+nums[j]> target, decrease j to approach target
                    else
                        j--;
                }
                // If not found
                return new int[] { -1, -1 };
            }
            public static void Main(string[] args)
            {
                int[] arr = { 2, 7, 11, 15 };
                int target = 9;
                int[] res = sumFunc(arr, target);
                for (int i = 0; i < res.Length; i++)
                    Console.WriteLine(res[i]);
            }
        }
    }

    //Question 7

    //Question 8
    class RotateArr
    {
        static void RotateRight(int [] arr, int n, int k)
        {
            //When rotation greater than size of array
            k = k % n;
            for(int i = 0; i < n; i ++)
            {
                if(i < k)
                {
                    Console.Write(arr[n + i - k] + "");
                }
                else
                {
                    Console.Write(arr[i - k] + "");
                }
            }
            Console.WriteLine();
        }
        public static void Main(String []args)
        {
            int[] nums = { -1, -100, 3, 99 };
            int N = nums.Length;
            if (N<1 && N >105)
            {
                return;
            }
            int k = 2;
        }
    }


    //Question 9

    //Question 10

    public class StairsCost
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            int pre = 0, cur = 0;
            for (int i = 2; i <= cost.Length; ++i)
                
                // Cost to iterate stairs
            {
                (pre, cur) = (cur, Math.Min(cur + cost[i - 1], pre + cost[i - 2]));
            }
            return cur;
        }
    }
}

