using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCSVReader
{
    public class Row
    {
        public string Text { get; private set; }

        public Row(string text)
        {
            Text = text;
        }
    }
}
