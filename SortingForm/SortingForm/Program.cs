using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortingForm.Sorting;

namespace SortingForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Random random = new Random();
            int[] nums = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                nums[i] = random.Next();
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            nums = BubbleSort.PreformBubbleSortAscending(nums);
            s.Stop();
            Debug.WriteLine("Total Time: " + s.ElapsedTicks);
            s.Reset();
           nums = new int[] { 2, 1, 6, 4, 6, 7 };
           s.Start();
           nums = BubbleSort.FasterBubbleSortAscending(nums);
           s.Stop();
           Debug.WriteLine("Total Time: " + s.ElapsedTicks);

//            foreach (var num in nums)
//            {
//                Debug.WriteLine(num);
//                
//            }
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new UtimateSortingDemo());
        }
    }
}
