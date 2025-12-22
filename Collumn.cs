using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCSVReader
{
    public class Collumn
    {
        public List<Row> Text { get; set; }

        public Collumn(List<Row> text)
        {
            Text = text;
        }
    }
}
