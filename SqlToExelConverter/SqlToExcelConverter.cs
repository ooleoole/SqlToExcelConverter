using System.Data;
using System.Data.SqlClient;
using ClosedXML.Excel;


namespace SqlToExelConverter
{
    public static class SqlToExcelConverter
    {
        public static void Convert(string connectionString, string query, string fileName)
        {


            var connection = new SqlConnection(connectionString);
            connection.Open();
            var command = new SqlCommand(query, connection);
            var data = new DataSet();

            using (var a = new SqlDataAdapter(command))
            {
                a.Fill(data);

                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(data);
                    wb.SaveAs($"{fileName}.xlsx");
                    
                }
            }

        }

    }
}
