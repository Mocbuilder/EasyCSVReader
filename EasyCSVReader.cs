using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCSVReader
{
    public class EasyCSVReader
    {
        private List<Row> _rows = new List<Row>();
        public bool IgnoreHeaderRows { get; set; } = false;

        public EasyCSVReader() { }

        public EasyCSVReader(bool ignoreHeaderRows)
        {
            IgnoreHeaderRows = ignoreHeaderRows;
        }

        public List<Row> ReadAllRows(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file was not found.", filePath);
            }

            _rows = ConvertStringToRow(File.ReadAllLines(filePath));
            if (IgnoreHeaderRows && _rows.Count > 0)
            {
                _rows.RemoveAt(0);
            }
            return _rows;
        }

        public List<Collumn> ReadAllCollumns(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file was not found.", filePath);
            }

            _rows = ConvertStringToRow(File.ReadAllLines(filePath));
            
            if (IgnoreHeaderRows && _rows.Count > 0)
            {
                _rows.RemoveAt(0);
            }

            bool isFirstRow = true;
            List<Collumn> collumnsList = new List<Collumn>();

            foreach (var currentRow in _rows)
            {
                var columns = currentRow.Text.Split(',');

                if (isFirstRow)
                {
                    for (int i = 0; i < columns.Count(); i++)
                    {
                        Collumn newCollumn = new Collumn(new List<Row>());
                        collumnsList.Add(newCollumn);
                    }
                }

                for (int i = 0; i < columns.Count(); i++)
                {
                    if (string.IsNullOrEmpty(columns[i]))
                    {
                        continue;
                    }

                    Row newRow = new Row(columns[i]);
                    collumnsList[i].Text.Add(newRow);
                }

                isFirstRow = false;
            }

            return collumnsList;
        }

        public Row ConvertStringToRow(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            return new Row(text);
        }

        public List<Row> ConvertStringToRow(List<string> texts)
        {
            List<Row> rows = new List<Row>();
            foreach (var text in texts)
            {
                if (string.IsNullOrEmpty(text))
                {
                    continue;
                }
                Row newRow = new Row(text);
                rows.Add(newRow);
            }
            return rows;
        }

        public List<Row> ConvertStringToRow(string[] texts)
        {
            List<Row> rows = new List<Row>();
            foreach (var text in texts)
            {
                if (string.IsNullOrEmpty(text))
                {
                    continue;
                }
                Row newRow = new Row(text);
                rows.Add(newRow);
            }
            return rows;
        }
    }
}
