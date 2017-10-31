using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FullBorder : Border
    {
        public FullBorder(Display display) : base(display)
        {
        }

        public override int GetColums()
        {
            return 1 + display.GetColums() + 1;
        }

        public override int GetRows()
        {
            return 1 + display.GetRows() + 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return "+" + MakeLine('-', display.GetColums()) + "+";
            }
            else if (row == display.GetRows() + 1)
            {
                return "+" + MakeLine('-', display.GetColums()) + "+";
            }
            return "|" + display.GetRowText(row - 1) + "|";
        }

        private string MakeLine(char ch, int count)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(ch);
            }
            return stringBuilder.ToString();
        }
    }
}
