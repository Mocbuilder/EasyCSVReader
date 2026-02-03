using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCSVReader.Models;

namespace EasyCSVReader
{
    public class EasyCSVReader
    {
        public bool _ignoreHeader = false;
        public readonly char _defaultDelimiter = ',';
        public List<CSVFile> _csvFiles = new List<CSVFile>();

        public EasyCSVReader(bool ignoreHeader)
        {
            _ignoreHeader = ignoreHeader;
        }

        public EasyCSVReader(bool ignoreHeader, char defaultDelimiter)
        {
            _ignoreHeader = ignoreHeader;
            _defaultDelimiter = defaultDelimiter;
        }

        public CSVFile GetCSVFile(string filePath, char delimiter)
        {
            CSVFile csvFile = new CSVFile(filePath, delimiter);
            _csvFiles.Add(csvFile);
            return csvFile;
        }

        public CSVFile GetCSVFile(string filePath)
        {
            CSVFile csvFile = new CSVFile(filePath, _defaultDelimiter, _ignoreHeader);
            _csvFiles.Add(csvFile);
            return csvFile;
        }
    }
}
