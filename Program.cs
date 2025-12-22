namespace EasyCSVReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EasyCSVReader Demo");

            EasyCSVReader reader = new EasyCSVReader();
            var rows = reader.ReadAllRows("sample2.csv");
            var columns = reader.ReadAllCollumns("sample2.csv");
            foreach (var row in rows)
            {
                Console.WriteLine(row.Text);
            }

            Console.WriteLine("---- Columns ----");

            foreach (var column in columns)
            {
                foreach (var row in column.Text)
                {
                    Console.WriteLine(row.Text);
                }
                Console.WriteLine("----");
            }

            Console.ReadKey();
        }
    }
}
