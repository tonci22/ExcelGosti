using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelGosti
{
    public partial class GostiUpis : Form
    {
        Color oddRowsColor = Color.CadetBlue;
        Color evenRowsColor = Color.Coral; 

        private string prefix = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        private string sufix = ";Extended Properties=Excel 12.0;";

        private DataTable rawExcel;
        private DataTable formatedExcel;

        public GostiUpis()
        {
            InitializeComponent();
            formatedExcel = new DataTable();
            rawExcel = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileDialog.Filter = "Excel (*.xlsx) | *.xlsx";

            foreach (Control ctrl in Controls)
            {
                ctrl.DragEnter += GostiUpis_DragEnter;
                ctrl.DragDrop += GostiUpis_DragDrop;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            doExcelWork(fileDialog.FileName, txtSheetName.Text);
        }

        private bool tableValueExists(string columnName, DataTable tempDataTable)
        {
            for (int row = 0; row < tempDataTable.Rows.Count; row++)
            {
                for (int column = 0; column < tempDataTable.Columns.Count; column++)
                {
                    if (tempDataTable.Rows[row].Field<object>(column) == null)
                        continue;

                    if (tempDataTable.Rows[row].Field<object>(column).Equals(columnName))
                        return true;
                }
            }
            return false;
        }

        private ExcelCoordinates findTableValueCoordinates(object columnName)
        {
            for (int row = 0; row < rawExcel.Rows.Count; row++)
            {
                for (int column = 0; column < rawExcel.Columns.Count; column++)
                {
                    if (rawExcel.Rows[row].Field<object>(column) == null)
                        continue;

                    if (rawExcel.Rows[row].Field<object>(column).Equals(columnName))
                        return new ExcelCoordinates(row, column);
                }
            }
            return new ExcelCoordinates();
        }

        private void formatDataTableColumn(string columnName, DataTable tempExcel, Type typeValue)
        {
            ExcelCoordinates tempExcelCoordinates = findTableValueCoordinates(columnName);

            if (!tempExcelCoordinates.Exists())
                throw new ArgumentException("Field missing");

            int column = tempExcelCoordinates.Column.Value;
            bool hasHeader = false;

            int tempRowCounter = 0;

            DataRow tempDataRow = null;

            for (int row = tempExcelCoordinates.Row.Value; row < tempExcel.Rows.Count; row++)
            {
                if (!tableValueExists(columnName, formatedExcel) && !hasHeader)
                {
                    formatedExcel.Columns.Add(columnName, typeValue);
                    hasHeader = true;
                }
                else if (formatedExcel.Rows.Count < tempExcel.Rows.Count - tempExcelCoordinates.Row.Value - 1) //weird flex
                {
                    tempDataRow = formatedExcel.NewRow();
                    tempDataRow[columnName] = rawExcel.Rows[row].Field<string>(column);
                    formatedExcel.Rows.Add(tempDataRow);
                }
                else
                {
                    formatedExcel.Rows[tempRowCounter++][columnName] = rawExcel.Rows[row].Field<string>(column);
                }
            }
        }

        private void doExcelWork(string fullFilePath, string sheetName)
        {
            formatedExcel = new DataTable();

            try
            {
                getRawExcelData(fullFilePath, sheetName);

                Task task = Task.Factory.StartNew(() =>
                {
                    foreach (var column in ColumnNames.AllColumnNames)
                    {
                        formatDataTableColumn(column.Value, rawExcel, column.Type);
                    }

                    formatedExcel.DefaultView.Sort = ColumnNames.DateOfDepartureColumnName + "," + ColumnNames.DateOfArrivalColumnName;

                    formatedExcel.Columns.Add(ColumnNames.NightPriceSumColumnName, typeof(string));
                });

                Task.WaitAll(task);

                dgvExcel.DataSource = formatedExcel;

                lblGuestSum.Text = formatedExcel.Rows.Count.ToString();

                changeColorWithMoneySum();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (InvalidOperationException)
            {
                MissingMicrosoftAccessDatabaseEngine.Show();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (IndexOutOfRangeException)
            {
                ExcelFormatException.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void getRawExcelData(string fullFilePath, string sheetName)
        {
            using (OleDbConnection dbExcel = new OleDbConnection(prefix + fullFilePath + sufix))
            {
                dbExcel.Open();

                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$]", dbExcel);

                rawExcel = new DataTable();
                oleDbDataAdapter.Fill(rawExcel);
            }
        }

        private void changeColorWithMoneySum()
        {
            DateTime currentDateDeparture = DateTime.Parse(dgvExcel[2, 0].Value.ToString()).Date;
            DateTime currentDateArrival = DateTime.Parse(dgvExcel[1, 0].Value.ToString()).Date;
            DateTime tempDateDeparture;
            DateTime tempDateArrival;

            bool changeColor = false;
            int sumNightsStayed = 0;
            int guestCounter = 0;
            int billCounter = 1;

            for (int i = 0; i < dgvExcel.Rows.Count; i++)
            {
                tempDateDeparture = DateTime.Parse(dgvExcel[ColumnNames.DateOfDepartureColumnName, i].Value.ToString()).Date;
                tempDateArrival = DateTime.Parse(dgvExcel[ColumnNames.DateOfArrivalColumnName, i].Value.ToString()).Date;

                if (!(currentDateDeparture == tempDateDeparture && currentDateArrival == tempDateArrival))
                {
                    currentDateArrival = tempDateArrival;
                    currentDateDeparture = tempDateDeparture;
                    changeColor = !changeColor;

                    dgvExcel[ColumnNames.NightPriceSumColumnName, i - 1].Value = nightPriceSumText(billCounter, guestCounter, sumNightsStayed);

                    billCounter++;
                    sumNightsStayed = 0;
                    guestCounter = 0;
                }

                if (!changeColor)
                    dgvExcel.Rows[i].DefaultCellStyle.BackColor = oddRowsColor;
                else
                    dgvExcel.Rows[i].DefaultCellStyle.BackColor = evenRowsColor;

                sumNightsStayed += int.Parse(dgvExcel[ColumnNames.NightsStayedColumnName, i].Value.ToString());
                guestCounter++;

                if (i == dgvExcel.Rows.Count - 1)                                
                    dgvExcel[ColumnNames.NightPriceSumColumnName, i].Value = nightPriceSumText(billCounter, guestCounter, sumNightsStayed);
            }
            txtBillCount.Text = billCounter.ToString();
        }

        private string nightPriceSumText(int billCounter, int guestCounter, int sumNightsStayed)
        {
            return "(" + billCounter + ")   ||||   " + guestCounter + " * " + sumNightsStayed / guestCounter + " * " + pricePerNight() + " = " + sumNightsStayed * pricePerNight() + " KN";
        }

        private int nightsSum()
        {
            int allNightsSum = 0;

            for (int i = 0; i < formatedExcel.Rows.Count; i++)
            {
                allNightsSum += int.Parse(dgvExcel[ColumnNames.NightsStayedColumnName, i].Value.ToString());
            }

            return allNightsSum;
        }

        private decimal pricePerNight()
        {
            return decimal.Round(decimal.Parse(txtMoneySum.Text) / nightsSum(), 2);
        }

        private void GostiUpis_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void GostiUpis_DragDrop(object sender, DragEventArgs e)
        {
            string fullFilePath = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];

            doExcelWork(fullFilePath, txtSheetName.Text);
        }

        private void dgvExcel_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvExcel.ClearSelection();
        }

        private void txtMoneySum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cultureDecimalSeparator = char.Parse(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == cultureDecimalSeparator || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private class ExcelCoordinates
        {
            public int? Row { get; set; }
            public int? Column { get; set; }

            public ExcelCoordinates()
            {
                Row = null;
                Column = null;
            }

            public ExcelCoordinates(int? row, int? column)
            {
                Row = row;
                Column = column;
            }

            public bool Exists()
            {
                return Row.HasValue && Column.HasValue;
            }
        }
    }
}
