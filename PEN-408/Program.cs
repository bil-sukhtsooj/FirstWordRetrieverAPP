using System;
using System.Text;

namespace GradeBook
{
    class Program
    {
        public static void extractProductUID()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\bil.sukhtsooj\Desktop\test\PEN-408\PEN-408\iss FDX-SP 2930.txt");
            var arr = new List<string>();
            int counter = 0;
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < lines.Length; i++)
            {
                arr.Add(lines[i].Split('\t')[0]);
            }
            for(int i = 1; i < arr.Count; i++)
            {
                counter = i;
                Console.WriteLine(arr[i]);
                if(i == arr.Count - 1)
                {
                    sb.Append($"{arr[i]}");
                }
                else
                {
                    sb.Append($"{arr[i]},");
                }

            }

            System.IO.File.WriteAllText(@"C:\Users\bil.sukhtsooj\Desktop\test\PEN-408\PEN-408\ProductUIDs.txt", sb.ToString());

            Console.WriteLine("total: " + counter);
        }

        public static async Task ExampleAsync(string[] lines)
        {   
            await File.WriteAllLinesAsync("WriteLines.txt", lines);
        }

        public static void doubleCheck()
        {
            int counter = 0;
            var wdProducts = new List<int> { 669, 678, 254, 354, 629, 630, 356, 412, 357, 358, 370, 608, 410, 371, 372, 373, 374, 375, 902, 903, 904, 928, 900, 901, 929, 787, 789, 790, 784, 783, 786, 803, 804, 785, 68, 403, 71, 605, 72, 73, 74, 109, 110, 111, 112, 604, 588, 113, 592, 664, 755, 253, 665, 1012, 254, 668, 669, 670, 671, 672, 1029, 54, 832, 56, 57, 58, 818, 817, 833, 52, 53, 834, 679, 680, 683, 684, 685, 673, 674, 675, 677, 678, 676 };
            for(int x = counter; x < wdProducts.Count; x++)
            {
                counter = x;
            }
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            //extractProductUID();
            doubleCheck();
        }

    }
}
