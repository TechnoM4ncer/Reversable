using System;
using System.Windows.Forms;

namespace Reversable
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        { 
            Start:
            String revA = System.String.Empty;
            String revB = System.String.Empty;

            Console.WriteLine("Please enter a string to be reversed");

            revA = Console.ReadLine();

            for (int i = revA.Length - 1; i <= revA.Length && i >= 0; i--)
            {
                revB += revA[i];
            }
            Clipboard.SetText(revB);
            Console.WriteLine(revA + " reversed is " + revB + " and has been copied to your clipboard.");

            goto Start;

        }
    }
}
