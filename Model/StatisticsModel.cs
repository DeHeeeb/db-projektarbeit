
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

namespace db_projektarbeit.Model
{
    class StatisticsModel
    {

        public DataTable GetAllSelf()
        {

            DataTable dt = new DataTable("Jahresvergleich Geschäft");
            DataColumn column;

            int currentYear = DateTime.Now.Year;


            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Kategorie";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);


            for (int i = 1; i < 4; i++)
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "YOY " + (currentYear - i) + " zu " + (currentYear - (i+1));
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Q4 " + (currentYear - i);
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Q3 " + (currentYear - i);
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Q2 " + (currentYear - i);
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Q1 " + (currentYear - i);
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);
            }


            GetOrderCount(dt);
            GetArtikelCount(dt);
            GetArtikelPerOrder(dt);
            GetTotalSales(dt);

            return dt;
        }

        public DataTable GetAllCustomer()
        {

            DataTable dt = new DataTable("Jahresvergleich Customer");
            DataColumn column;

            int currentYear = DateTime.Now.Year;


            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Kategorie";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);


            for (int i = 1; i < 4; i++)
            {
                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "YOY " + (currentYear - i) + " zu " + (currentYear - (i + 1));
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Q4 " + (currentYear - i);
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Q3 " + (currentYear - i);
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Q2 " + (currentYear - i);
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = Type.GetType("System.String");
                column.ColumnName = "Q1 " + (currentYear - i);
                column.ReadOnly = true;
                column.Unique = false;
                dt.Columns.Add(column);
            }

            GetTotalSalesPerCustomer(dt);

            return dt;
        }
        private void GetOrderCount(DataTable dt)
        {
            int[,] compareArray = new int[4, 6];
            using (var context = new ProjectContext())
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = ";WITH CTE_GET_ALL_GROUP_DATA AS" +
                                      "(SELECT " +
                                      "DATEPART(YEAR, ord.Date) AS OrderYear, " +
                                      "DATEPART(QUARTER, ord.Date) AS OrderQuarter, " +
                                      "COUNT(*) AS OrderPerQuarter " +
                                      "FROM dbo.Orders AS ord " +
                                      "WHERE DATEPART(YEAR, ord.Date) BETWEEN(YEAR(GETDATE()) - 4) AND(YEAR(GETDATE()) - 1) " +
                                      "GROUP BY DATEPART(YEAR, ord.Date), DATEPART(QUARTER, ord.Date) " +
                                      ")," +
                                      "CTE_STEP AS " +
                                      "( SELECT * , SUM(OrderPerQuarter) OVER(PARTITION BY OrderYear ORDER BY OrderYear DESC) AS OrderPerYear " +
                                      "FROM CTE_GET_ALL_GROUP_DATA) " +

                                      "SELECT * " +
                                      "FROM CTE_STEP " +
                                      "PIVOT ( " +
                                      "SUM(OrderPerQuarter) " +
                                      "FOR OrderQuarter IN([1], [2], [3],[4]) " +
                                      ") AS PIVTABLE " +
                                      "ORDER BY OrderYear DESC";
                context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    int index = 0;
                    foreach (var item in result)
                    {
                        compareArray[index, 0] = result.GetInt32(0);
                        compareArray[index, 1] = result.GetInt32(1);
                        compareArray[index, 2] = result.GetInt32(2);
                        compareArray[index, 3] = result.GetInt32(3);
                        compareArray[index, 4] = result.GetInt32(4);
                        compareArray[index, 5] = result.GetInt32(5);
                        index++;
                    }
                }
            }
            CompareArrayToDataRow(dt, compareArray, "Anzahl Aufträge");
        }
        private void GetArtikelCount(DataTable dt)
        {
            int[,] compareArray = new int[4, 6];
            using (var context = new ProjectContext())
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = ";WITH CTE_GET_ALL_DATA AS " +
                                      "( SELECT " +
                                      "DATEPART(YEAR, pro.CreationDate) AS Year, " +
                                      "DATEPART(QUARTER, pro.CreationDate) AS Quart, " +
                                      "COUNT(*) AS ArtPerQuart " +
                                      "FROM dbo.Products AS pro " +
                                      "WHERE DATEPART(YEAR, pro.CreationDate) BETWEEN(YEAR(GETDATE()) - 4) AND(YEAR(GETDATE()) - 1) " +
                                      "GROUP BY DATEPART(YEAR, pro.CreationDate), DATEPART(QUARTER, pro.CreationDate) " +
                                      "), " +
                                      "CTE_AGREGATION AS " +
                                      "( SELECT " +
                                      "Year, " +
                                      "Quart, " +
                                      "ArtPerQuart, " +
                                      "SUM(ArtPerQuart) OVER(ORDER BY Year, Quart) AS ArtSumCounter " +
                                      "FROM CTE_GET_ALL_DATA" +
                                      "), " +
                                      "CTE_WINDOW AS " +
                                      "( " +
                                      "SELECT Year, Quart, ArtSumCounter, SUM(ArtPerQuart) OVER(PARTITION BY Year) AS ArtPerYear " +
                                      "FROM CTE_AGREGATION " +
                                      ") " +
                                      "SELECT Year, ArtPerYear, isnull([1], 0) AS '1' ,isnull([2], 0) AS '2',isnull([3], 0) AS '3',isnull([4], 0) AS '4'   FROM CTE_WINDOW " +
                                      "PIVOT " +
                                      "( " +
                                      "SUM(ArtSumCounter) " +
                                      "FOR Quart IN([1], [2], [3],[4]) " +
                                      ") AS PIVTABLE " +
                                      "ORDER BY Year DESC ";
                context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    int index = 0;
                    foreach (var item in result)
                    {
                        compareArray[index, 0] = result.GetInt32(0);
                        compareArray[index, 1] = result.GetInt32(1);
                        compareArray[index, 2] = result.GetInt32(2);
                        compareArray[index, 3] = result.GetInt32(3);
                        compareArray[index, 4] = result.GetInt32(4);
                        compareArray[index, 5] = result.GetInt32(5);
                        index++;
                    }
                }
            }
            CompareArrayToDataRow(dt, compareArray, "Anzahl Artikel");
        }
        private void GetArtikelPerOrder(DataTable dt)
        {
            int[,] compareArray = new int[4, 6];
            using (var context = new ProjectContext())
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = ";WITH CTE_GET_ALL_DATA AS " +
                                      "( SELECT " +
                                      "ord.Id AS IdOrd, " +
                                      "ord.Date AS DateOrd, " +
                                      "DATEPART(YEAR, ord.Date) AS Year, " +
                                      "DATEPART(QUARTER, ord.Date) AS Quart, " +
                                      "ord.CustomerId AS CustomerIdOrd, " +
                                      "pos.Id AS IdPos, " +
                                      "pos.Count AS CountPos, " +
                                      "pos.OrderId AS OrderIdPos, " +
                                      "pos.ProductId AS ProductIdPos " +
                                      "FROM dbo.Orders AS ord " +
                                      "INNER JOIN dbo.Positions AS pos " +
                                      "ON ord.Id = pos.OrderId " +
                                      "WHERE DATEPART(YEAR, ord.Date) BETWEEN(YEAR(GETDATE()) - 4) AND(YEAR(GETDATE()) - 1) " +
                                      "), " +
                                      "CTE_AGREGATION AS " +
                                      "( " +
                                      "SELECT " +
                                      "Year, " +
                                      "Quart, " +
                                      "AVG(CountPos) OVER(PARTITION BY Year) AS AVGYear, " +
                                      "AVG(CountPos) OVER(PARTITION BY Year, Quart) AS SumQuart " +
                                      "FROM CTE_GET_ALL_DATA " +
                                      ") " +
                                      "SELECT* FROM CTE_AGREGATION " +
                                      "PIVOT " +
                                      "( " +
                                      "AVG(SumQuart) " +
                                      "FOR Quart IN([1], [2], [3],[4]) " +
                                      ") AS PIVTABLE " +
                                      "ORDER BY Year DESC ";
                context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    int index = 0;
                    foreach (var item in result)
                    {
                        compareArray[index, 0] = result.GetInt32(0);
                        compareArray[index, 1] = result.GetInt32(1);
                        compareArray[index, 2] = result.GetInt32(2);
                        compareArray[index, 3] = result.GetInt32(3);
                        compareArray[index, 4] = result.GetInt32(4);
                        compareArray[index, 5] = result.GetInt32(5);
                        index++;
                    }
                }
            }
            CompareArrayToDataRow(dt, compareArray, "Anzahl Artikel pro Bestellung");
        }
        private void GetTotalSales(DataTable dt)
        {
            int[,] compareArray = new int[4, 6];
            using (var context = new ProjectContext())
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = ";WITH CTE_GET_ALL_DATA AS " +
                                      "( SELECT " +
                                      "ord.Id AS IdOrd, " +
                                      "ord.Date AS DateOrd, " +
                                      "DATEPART(YEAR, ord.Date) AS Year, " +
                                      "DATEPART(QUARTER, ord.Date) AS Quart, " +
                                      "ord.CustomerId AS CustomerIdOrd, " +
                                      "pos.Id AS IdPos, " +
                                      "pos.Count AS CountPos, " +
                                      "pos.OrderId AS OrderIdPos, " +
                                      "pos.ProductId AS ProductIdPos, " +
                                      "pro.id AS IdPro, " +
                                      "pro.Price AS PricePro, " +
                                      "pro.CreationDate AS CreationDatePro " +
                                      "FROM dbo.Orders AS ord " +
                                      "INNER JOIN dbo.Positions AS pos " +
                                      "ON ord.Id = pos.OrderId " +
                                      "INNER JOIN dbo.Products AS pro " +
                                      "ON pos.ProductId = pro.Id " +
                                      "WHERE DATEPART(YEAR, ord.Date) BETWEEN(YEAR(GETDATE()) - 4) AND(YEAR(GETDATE()) - 1) " +
                                      "), " +
                                      "CTE_AGREGATION AS " +
                                      "( " +
                                      "SELECT " +
                                      "Year, " +
                                      "Quart, " +
                                      "SUM(CountPos* PricePro) SumQuart " +
                                      "FROM CTE_GET_ALL_DATA " +
                                      "GROUP BY Year, Quart " +
                                      "), " +
                                      "CTE_WINDOW AS " +
                                      "( " +
                                      "SELECT*, SUM(SumQuart) OVER(PARTITION BY Year) AS YearTotal " +
                                      "FROM CTE_AGREGATION " +
                                      ") " +
                                      "SELECT* FROM CTE_WINDOW " +
                                      "PIVOT " +
                                      "( " +
                                      "SUM(SumQuart) " +
                                      "FOR Quart IN([1], [2], [3],[4]) " +
                                      ") AS PIVTABLE " +
                                      "ORDER BY Year DESC ";

                context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    int index = 0;
                    foreach (var item in result)
                    {
                        compareArray[index, 0] = result.GetInt32(0);
                        compareArray[index, 1] = Convert.ToInt32(result.GetDecimal(1));
                        compareArray[index, 2] = Convert.ToInt32(result.GetDecimal(2));
                        compareArray[index, 3] = Convert.ToInt32(result.GetDecimal(3));
                        compareArray[index, 4] = Convert.ToInt32(result.GetDecimal(4));
                        compareArray[index, 5] = Convert.ToInt32(result.GetDecimal(5));
                        index++;
                    }
                }
            }
            CompareArrayToDataRow(dt, compareArray, "Gesamtumsatz");
        }
        private void GetTotalSalesPerCustomer(DataTable dt)
        {
            int[,] compareArray = new int[4, 6];
            using (var context = new ProjectContext())
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = ";WITH CTE_GET_ALL_DATA AS " +
                                      "( SELECT " +
                                      "cus.CompanyName AS CompanyName, " +
                                      "cus.FirstName AS FirstName, " +
                                      "cus.Lastname AS Lastname, " +
                                      "ord.Id AS IdOrd, ord.Date AS DateOrd, " +
                                      "DATEPART(YEAR, ord.Date) AS Year, " +
                                      "DATEPART(QUARTER, ord.Date) AS Quart, " +
                                      "ord.CustomerId AS CustomerIdOrd , " +
                                      "pos.Id AS IdPos, " +
                                      "pos.Count AS CountPos, " +
                                      "pos.OrderId AS OrderIdPos, " +
                                      "pos.ProductId AS ProductIdPos," +
                                      "pro.id AS IdPro, " +
                                      "pro.Price AS PricePro, " +
                                      "pro.CreationDate AS CreationDatePro " +
                                      "FROM dbo.Orders AS ord " +
                                      "INNER JOIN dbo.Positions AS pos " +
                                      "ON ord.Id = pos.OrderId " +
                                      "INNER JOIN dbo.Products AS pro " +
                                      "ON pos.ProductId = pro.Id " +
                                      "INNER JOIN dbo.Customers AS cus " +
                                      "ON ord.CustomerId = cus.Id " +
                                      "WHERE DATEPART(YEAR, ord.Date) BETWEEN(YEAR(GETDATE()) - 4) AND(YEAR(GETDATE()) - 1) " +
                                      "), " +
                                      "CTE_AGREGATION AS " +
                                      "( " +
                                      "SELECT " +
                                      "CompanyName, " +
                                      "FirstName, " +
                                      "Lastname, " +
                                      "Year, " +
                                      "Quart, " +
                                      "SUM(CountPos* PricePro) OVER(PARTITION BY CustomerIdOrd) SumQuart " +
                                      "FROM CTE_GET_ALL_DATA " +
                                      "), " +
                                      "CTE_WINDOW AS " +
                                      "( " +
                                      "SELECT* , SUM(SumQuart) OVER(PARTITION BY Year, CompanyName, FirstName, Lastname) AS YearTotal " +
                                      "FROM CTE_AGREGATION " +
                                      ") " +
                                      "SELECT " +
                                      "isnull([CompanyName], '') AS CompNameNN," +
                                      "isnull([FirstName], '') AS FirstNameNN," +
                                      "isnull([Lastname], '') AS LastnameNN," +
                                      "Year, " +
                                      "YearTotal, " +
                                      "isnull([1], 0) AS '1', " +
                                      "isnull([2], 0) AS '2', " +
                                      "isnull([3], 0) AS '3'," +
                                      "isnull([4], 0) AS '4'" +
                                      "FROM CTE_WINDOW " +
                                      "PIVOT " +
                                      "( " +
                                      "SUM(SumQuart) " +
                                      "FOR Quart IN([1], [2], [3],[4]) " +
                                      ") AS PIVTABLE " +
                                      "ORDER BY CompNameNN,FirstNameNN,LastnameNN,Year";

                context.Database.OpenConnection();

                string customerName = "";
                using (var result = command.ExecuteReader())
                {

                    int counter = 0;
                    foreach (var item in result)
                    {
                        customerName = result.GetString(0);                                         // Suboptimal 
                        if (customerName == "")
                        {
                            customerName = result.GetString(1) + " " + result.GetString(2);
                        }
                        compareArray[counter, 0] = result.GetInt32(3);
                        compareArray[counter, 1] = Convert.ToInt32(result.GetDecimal(4));
                        compareArray[counter, 2] = Convert.ToInt32(result.GetDecimal(5));
                        compareArray[counter, 3] = Convert.ToInt32(result.GetDecimal(6));
                        compareArray[counter, 4] = Convert.ToInt32(result.GetDecimal(7));
                        compareArray[counter, 5] = Convert.ToInt32(result.GetDecimal(8));
                        counter++;
                        if (counter >= 4)
                        {
                            CompareArrayToDataRow(dt, compareArray, "Umsatz " + customerName);  // nicht omptimal weil die Datenverbindung zu DB noch offen ist
                            counter = 0;
                        }
                    }
                }
            }
        }
        private void CompareArrayToDataRow(DataTable dt, int[,] compareArray,string rowName)
        {
            DataRow row = dt.NewRow();
            row[0] = rowName;

            row[1] = Math.Round((double)compareArray[0, 1] / (double)compareArray[1, 1] * 10000) / 100 + "%";
            row[2] = compareArray[0, 2];
            row[3] = compareArray[0, 3];
            row[4] = compareArray[0, 4];
            row[5] = compareArray[0, 5];

            row[6] = Math.Round((double)compareArray[1, 1] / (double)compareArray[2, 1] * 10000) / 100 + "%";
            row[7] = compareArray[1, 2];
            row[8] = compareArray[1, 3];
            row[9] = compareArray[1, 4];
            row[10] = compareArray[1, 5];

            row[11] = Math.Round((double)compareArray[2, 1] / (double)compareArray[3, 1] * 10000) / 100 + "%";
            row[12] = compareArray[2, 2];
            row[13] = compareArray[2, 3];
            row[14] = compareArray[2, 4];
            row[15] = compareArray[2, 5];

            dt.Rows.Add(row);
        }
    }
}
