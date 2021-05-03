using System;

namespace SimpleSearch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 1,3,6,8,9,12,30};
            int tarket = 12;
            Solution solution = new Solution();
            var result =solution.BinarySearch(nums,tarket);

        }
    }
}
