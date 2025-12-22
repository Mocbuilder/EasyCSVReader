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
	var reader = new EasyCSVReader();

	reader.IgnoreHeaderRows = true; // Ignore the first row as header
    reader.Delimiter = ';'; // Set custom delimiter
	```

3. Read Rows from a CSV file:
   ```csharp
	//Read all rows from a CSV file and parse into a list of Row objects
	List<Row> rows = reader.ReadAllRows("path/to/your/file.csv");

	//Access the content with Row.Text property
	foreach(Row row in rows)
	{
		Console.WriteLine(row.Text);
    }
	```

4. Read Collumns from a CSV file:
   ```csharp
	//Read all collumns from a CSV file and parse into a list of Collumn objects
	List<Collumn> collumns = reader.ReadAllCollumns("path/to/your/file.csv");

	//Collumns contain a list of Row objects as Collumn.Rows property
	foreach(Collumn collumn in collumns)
	{
		Row newRow = collumn.Rows[0];
		Console.WriteLine(newRow.Text);
    }
	```

5. There is also a Convert function with multiple input overloads:
   ```csharp
	string testString = "value1";
	Row newRow = reader.ConvertStringToRow(test)

	List<string> testList = new List<string>() { "value1", "value2", "value3" };
	List<Row> newRowsFromList = reader.ConvertStringToRow(testList);

	string[] testArray = new string[] { "value1", "value2", "value3" };
	List<Row> newRowsFromArray = reader.ConvertStringToRow(testArray);
	```

I hope someone finds this library useful. Also, no license, so do whatever you want with it. Although Credit is always welcome.

Credit:
</br>
Idea and Programming - Mocbuilder
