using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Display display1 = new StringDisplay("Hello,world!");
            Display display2 = new SideBorder(display1,'#');
            Display display3 = new FullBorder(display2);

            display1.Show();
            display2.Show();
            display3.Show();

            Display display4 = 
            new SideBorder(
                    new FullBorder(
                        new SideBorder(
                            new FullBorder(
                                new StringDisplay("こんにちは。")
                                ),
                                '*')
                            ),
                            '/'
                        );
            
            display4.Show();

            Console.ReadLine();
         }
    }
}
