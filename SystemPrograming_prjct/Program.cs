using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace SystemPrograming_prjct
{
    internal class Program
    {
        enum YesNo
        {
            YES = 6,
            NO = 7,
        }
        static void Main(string[] args)
        {
            //Ex1------------------------------------------------------------------------------------
            int res = Functions.MessageBox(IntPtr.Zero, "Hello World", "Ex1", 0);
            //Ex2------------------------------------------------------------------------------------
            List<int> randomList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                randomList.Add(i);
            }

            randomList.Shuffle();

            for (int i = 0; i < randomList.Count; i++)
            {
                if (Functions.MessageBox(IntPtr.Zero, "Your digit is: " + randomList[i] + "?", "Digits guesser", (uint)Functions.YES_NO) == 6)
                {
                    Functions.MessageBox(IntPtr.Zero, "Congrats!", "Digits guesser", 0);
                    break;
                }
            }
            //Ex3------------------------------------------------------------------------------------

            Console.Write("Enter window name: ");

            var title = Console.ReadLine();
            IntPtr handle = Functions.FindWindowByCaption(IntPtr.Zero, title);
            Functions.SendMessage(handle, Functions.WM_CLOSE, UIntPtr.Zero, new StringBuilder());

            //Ex4------------------------------------------------------------------------------------

            Console.Write("Enter window name: ");

            var title1 = Console.ReadLine();
            IntPtr handle1 = Functions.FindWindowByCaption(IntPtr.Zero, title1);
            Functions.SendMessage(handle1, Functions.WM_SETTEXT, UIntPtr.Zero, new StringBuilder(DateTime.Now.TimeOfDay.ToString()));

            Console.ReadKey();
        }
}
}
