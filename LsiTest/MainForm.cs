using LsiTest.Model;
using LsiTest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LsiTest
{
    public partial class MainForm : Form
    {
        IExportDataProvider exportDataProvider;
        List<ExportData> visibleExportData;
        List<Local> locals;
        ILocalProvider localProvider;
        Local selectedLocal;
        public MainForm()
        {
            InitializeComponent();
            setupForm();

            exportDataProvider = new ExportDataProvider();
            localProvider = new LocalProvider();
            fetchLocals();
        }
        void setupForm()
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            exportDataGrid.AutoGenerateColumns = false;
            exportDataGrid.Columns["ExportDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
            exportDataGrid.Columns["ExportHour"].DefaultCellStyle.Format = "hh:mm";
        }
        ReportFilterModel fetchFilter()
        {
            return new ReportFilterModel()
            {
                From = dateFromPicker.Value,
                To = dateToPicker.Value,
                LocalId = selectedLocal.Id
            };
        }
        void fetchLocals()
        {
            locals = localProvider.GetLocals();
            localsComboBox.DataSource = locals;
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                var filter = fetchFilter();
                visibleExportData = exportDataProvider.GetExportData(filter);
                exportDataGrid.DataSource = visibleExportData;
            }
            else
            {
                MessageBox.Show("Something wrong with provided data");
            }
        }

        private void localsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLocal = localsComboBox.SelectedItem as Local;
        }
        private bool validateForm()
        {
            return selectedLocal != null && (dateFromPicker.Value <= dateToPicker.Value);
        }

       
    }
}
