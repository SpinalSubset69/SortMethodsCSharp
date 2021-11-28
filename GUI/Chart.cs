using GUI.Dtos;
using Infrastructure.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Chart : Form
    {
        private ArrayLogic _repo;
  
        public Chart(ArrayLogic repo)
        {
            _repo = repo;
            InitializeComponent();
            LoadData();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public async void LoadData()
        {
            var _reports = await _repo.GetReportsAsync();

            if (_reports.Count != 0)
            {
                foreach (var report in _reports)
                {
                    if (report.Method.Contains("Burble"))
                    {
                        this.chart1.Series["Burble"].Points.AddXY(report.TimeElapsed, report.NumberElements.ToString());
                    }

                    if (report.Method.Contains("Insertion"))
                    {
                        this.chart1.Series["Insertion"].Points.AddXY(report.TimeElapsed, report.NumberElements.ToString());
                    }

                    if (report.Method.Contains("Selection"))
                    {
                        this.chart1.Series["Selection"].Points.AddXY(report.TimeElapsed, report.NumberElements.ToString());
                    }

                    if (report.Method.Contains("QuickSort"))
                    {
                        this.chart1.Series["QuickSort"].Points.AddXY(report.TimeElapsed, report.NumberElements.ToString());
                    }

                    if (report.Method.Contains("Merge"))
                    {
                        this.chart1.Series["Merge"].Points.AddXY(report.TimeElapsed, report.NumberElements.ToString());
                    }

                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
