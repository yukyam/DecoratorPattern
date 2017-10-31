using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StringDisplay : Display
    {
        private readonly string _string;

        public StringDisplay(string _string)
        {
            this._string = _string;
        }

        public override int GetColums()
        {
            Encoding sjisEnc = Encoding.GetEncoding("shift_jis");
            return sjisEnc.GetByteCount(_string);
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int row)
        {
            return (row == 0) ? _string : null;
        }
    }
}
