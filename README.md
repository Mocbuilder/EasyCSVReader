# EasyCSVReader
EasyCSVReader is a simple C# library for reading CSV files with ease. 
It provides a simple API to parse CSV data.

## How to Use
1. Install the EasyCSVReader package via the NuGet Package Manager:
   ```
   Install-Package EasyCSVReader
   ```

2. Create a Reader instance and set some options if needed:
   ```csharp
	var reader = new EasyCSVReader([bool IgnoreHeader] true; [char DefaultDelimiter] ",");

	//bool IgnoreHeader = Ignore the first row as header
    //char DefaultDelimiter = Set custom delimiter that is used if no other is specified
	```

3. Read a CSV file:
   ```csharp
	//Parse a CSV file into a CSVFile object
	CSVFile file = csvReader.GetCSVFile("C:\Path\To\Your\File.csv");
	```

4. Access the data:
   ```csharp
	file._lines[0]._fields[0]; //Access the first field of the first line
	int lineNumber file._lines[0].lineNumber; //Get the line number of the first line
	```

I hope someone finds this library useful. Also, no license, so do whatever you want with it. Although Credit is always welcome.

Credit:
</br>
Idea and Programming - Mocbuilder
