using System;
using System.Linq;

namespace ExcelGosti
{
    class outdated
    {
        ////ovo sad nikako radi, treba ucinit normalno
        //private void formatDataTable()
        //{
        //    int columnIndexPositionNameSurname = -1;
        //    int columnIndexPositionDateOfArrival = -1;
        //    int columnIndexPositionDateOfDeparture = -1;
        //    int columnIndexPositionNightsStayed = -1;

        //    int columnCounter = 0;

        //    int dtRowCounterArival = 0, dtRowCounterDeparture = 0, dtRowCounterNights = 0;
        //    formatedExcel = new DataTable();

        //    DataRow tempDataRow = null;

        //    for (int column = 0; column < rawExcel.Columns.Count; column++)
        //    {
        //        for (int row = 0; row < rawExcel.Rows.Count; row++)
        //        {
        //            if (rawExcel.Rows[row].Field<string>(column) == ColumnNames.NameSurnameColumnName)
        //            {
        //                formatedExcel.Columns.Add(ColumnNames.NameSurnameColumnName, typeof(string));
        //                columnIndexPositionNameSurname = column;
        //                columnCounter++;
        //                continue;   //da ne pise ime kolone u prvon redu
        //            }
        //            if (columnIndexPositionNameSurname == column)
        //            {
        //                tempDataRow = formatedExcel.NewRow();
        //                tempDataRow[ColumnNames.NameSurnameColumnName] = rawExcel.Rows[row].Field<string>(column);
        //                formatedExcel.Rows.Add(tempDataRow);
        //            }

        //            if (rawExcel.Rows[row].Field<string>(column) == ColumnNames.DateOfArrivalColumnName)
        //            {
        //                formatedExcel.Columns.Add(ColumnNames.DateOfArrivalColumnName, typeof(DateTime));
        //                columnIndexPositionDateOfArrival = column;
        //                columnCounter++;
        //                continue;
        //            }
        //            if (columnIndexPositionDateOfArrival == column)
        //            {
        //                formatedExcel.Rows[dtRowCounterArival][columnCounter - 1] = rawExcel.Rows[row].Field<string>(column);
        //                dtRowCounterArival++;
        //            }

        //            if (rawExcel.Rows[row].Field<string>(column) == ColumnNames.DateOfDepartureColumnName)
        //            {
        //                formatedExcel.Columns.Add(ColumnNames.DateOfDepartureColumnName, typeof(DateTime));
        //                columnIndexPositionDateOfDeparture = column;
        //                columnCounter++;
        //                continue;
        //            }
        //            if (columnIndexPositionDateOfDeparture == column)
        //            {
        //                formatedExcel.Rows[dtRowCounterDeparture][columnCounter - 1] = rawExcel.Rows[row].Field<string>(column);
        //                dtRowCounterDeparture++;
        //            }

        //            if (rawExcel.Rows[row].Field<string>(column) == ColumnNames.NightsStayedColumnName)
        //            {
        //                formatedExcel.Columns.Add(ColumnNames.NightsStayedColumnName, typeof(string));
        //                columnIndexPositionNightsStayed = column;
        //                columnCounter++;
        //                continue;
        //            }
        //            if (columnIndexPositionNightsStayed == column)
        //            {
        //                formatedExcel.Rows[dtRowCounterNights][columnCounter - 1] = rawExcel.Rows[row].Field<string>(column);
        //                dtRowCounterNights++;
        //            }
        //        }
        //    }

        //    formatedExcel.DefaultView.Sort = ColumnNames.DateOfDepartureColumnName + "," + ColumnNames.DateOfArrivalColumnName;

        //    formatedExcel.Columns.Add(ColumnNames.NightPriceSumColumnName, typeof(string));

        //    dgvExcel.DataSource = formatedExcel;

        //    lblGuestSum.Text = formatedExcel.Rows.Count.ToString();
        //}


        ////ovo je za excel koji je vec unaprid pravilno formatiran
        //private void fillformatedExcelData(string fullFilePath, string sheetName)
        //{
        //    using (OleDbConnection dbExcel = new OleDbConnection(prefix + fullFilePath + sufix))
        //    {
        //        dbExcel.Open();

        //        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT [" + ColumnNames.NameSurnameColumnName + "], [" + ColumnNames.DateOfArrivalColumnName + "], [" + ColumnNames.DateOfDepartureColumnName + "], [" + ColumnNames.NightsStayedColumnName + "] FROM [" + sheetName + "$]", dbExcel);

        //        rawExcel = new DataTable();
        //        oleDbDataAdapter.Fill(rawExcel);

        //        rawExcel.DefaultView.Sort = ColumnNames.DateOfDepartureColumnName + "," + ColumnNames.DateOfArrivalColumnName;

        //        rawExcel.Columns.Add(ColumnNames.NightPriceSumColumnName, typeof(string));

        //        dgvExcel.DataSource = rawExcel;

        //        lblGuestSum.Text = rawExcel.Rows.Count.ToString();

        //    }
        //}


    }
}
