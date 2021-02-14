
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace db_projektarbeit.Model
{
    class StatisticsModel
    {

        public DataTable GetAll()
        {

            DataTable dt = new DataTable("Jahresvergleich");
            DataColumn column;

            int currentYear = DateTime.Now.Year;


            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Kategorie";
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "YOY " + currentYear + " zu " + (currentYear-1);
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Q4 " + currentYear;
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Q3 " + currentYear;
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Q2 " + currentYear;
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Q1 " + currentYear;
            column.ReadOnly = true;
            column.Unique = false;
            dt.Columns.Add(column);

            GetOrderCount(dt);
            //GetPositionCount(dt);

            return dt;
        }
        public void GetOrderCount(DataTable dt)
        {
            int[,] vergleichArray = new int[3, 6];
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
                                      "ORDER BY OrderYear ";
                context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    int index = 2;
                    foreach (var item in result)
                    {
                        vergleichArray[index, 0] = result.GetInt32(0);
                        vergleichArray[index, 1] = result.GetInt32(1);
                        vergleichArray[index, 2] = result.GetInt32(2);
                        vergleichArray[index, 3] = result.GetInt32(3);
                        vergleichArray[index, 4] = result.GetInt32(4);
                        vergleichArray[index, 5] = result.GetInt32(5);
                        index--;
                    }
                }
            }

            DataRow row = dt.NewRow();
            row[0] = "Anzahl Aufträge";
            row[1] = Math.Round((double)vergleichArray[0, 1] / (double)vergleichArray[1, 1] * 10000) / 100 + "%";
            row[2] = vergleichArray[0, 2];
            row[3] = vergleichArray[0, 3];
            row[4] = vergleichArray[0, 4];
            row[5] = vergleichArray[0, 5];

            dt.Rows.Add(row);
        }

        public void GetPositionCount(DataTable dt)
        {
            int[,] vergleichArray = new int[3, 6];
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
                                      "ORDER BY OrderYear ";
                context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    int index = 2;
                    foreach (var item in result)
                    {
                        vergleichArray[index, 0] = result.GetInt32(0);
                        vergleichArray[index, 1] = result.GetInt32(1);
                        vergleichArray[index, 2] = result.GetInt32(2);
                        vergleichArray[index, 3] = result.GetInt32(3);
                        vergleichArray[index, 4] = result.GetInt32(4);
                        vergleichArray[index, 5] = result.GetInt32(5);
                        index--;
                    }
                }
            }

            DataRow row = dt.NewRow();
            row[0] = "Anzahl Aufträge";
            row[1] = Math.Round((double)vergleichArray[0, 1] / (double)vergleichArray[1, 1] * 10000) / 100 + "%";
            row[2] = vergleichArray[0, 2];
            row[3] = vergleichArray[0, 3];
            row[4] = vergleichArray[0, 4];
            row[5] = vergleichArray[0, 5];

            dt.Rows.Add(row);
        }
    }
}
