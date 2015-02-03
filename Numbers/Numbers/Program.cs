using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Notes: Run the application, put in any 3 numbers (example 1, 2, 3). 
 * Hit enter each time. The application should have 3 lines of output.
 * For example you put in 1, 2, 3, the output should have 3 lines with 5 numbers, it look like this:
 * 11111
 * 22222
 * 33333
 * But instead the output is:
 * 11111
 * 22222
 * 3333? -->missing a 3 here! There is a bug in line 49. */

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      int a;
      int b;
      int c;

      a = int.Parse(Console.ReadLine());
      b = int.Parse(Console.ReadLine());
      c = int.Parse(Console.ReadLine());
      
      Console.Clear();
      
      for (int i = 0; i <= 5; i++)
      {
        Console.Write(a);
      }
      
      Console.WriteLine();
            
      for (int i = 0; i <= 5; i++)
      {
        Console.Write(b);
        
      }
      Console.WriteLine();

      for (int i = 0; i <= 5; i++) //<--The bug has been fixed!
      {
        Console.Write(c);
      }
      Console.ReadLine();
    }
  
  }
}
