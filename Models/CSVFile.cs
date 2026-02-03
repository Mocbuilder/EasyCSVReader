using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCSVReader.Models
{
    public class CSVFile
    {
        public bool _ignoreHeader;
        public string _filePath;
        public List<CSVLine> _lines;
        public char _delimiter;

        public CSVFile(string filePath, char delimiter, bool ignoreHeader)
        {
            _filePath = filePath;
            _delimiter = delimiter;
            _lines = new List<CSVLine>();
            _ignoreHeader = ignoreHeader;

            ReadLines();
        }

        public override string ToString()
        {
            return Path.GetFileName(_filePath);
        }

        public void ReadLines()
        {
            var lines = File.ReadAllLines(_filePath);
            int lineNumber = 0;
            foreach (var line in lines)
            {
                var values = line.Split(_delimiter).ToList();
                CSVLine csvLine = new CSVLine
                {
                    _lineNumber = lineNumber,
                    _fields = values
                };

                if (_ignoreHeader && lineNumber == 0)
                {
                    lineNumber++;
                    continue;
                }
                _lines.Add(csvLine);
                lineNumber++;
            }
        }

        public void WriteLines()
        {
            File.WriteAllLines(_filePath, _lines.Select(l => string.Join(_delimiter, l._fields)));
        }
    }
}
