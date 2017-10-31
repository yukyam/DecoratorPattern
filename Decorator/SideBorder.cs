using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SideBorder : Border
    {
        private char borderChar;

        public SideBorder(Display display, char ch) : base(display)
        {
            borderChar = ch;
        }

        public override int GetColums()
        {
            return 1 + display.GetColums() + 1;
        }

        public override int GetRows()
        {
            return display.GetRows();
        }

        public override string GetRowText(int row)
        {
            return borderChar + display.GetRowText(row) + borderChar;
        }
    }
}
