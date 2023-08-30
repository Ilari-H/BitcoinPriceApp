using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T3._1.Controller;
using OxyPlot.Axes;

namespace T3._1.View
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }
        private PlotView plotView;

        private async Task Load()
        {
            var plotModel = new PlotModel { Title = "" };

            var lineSeries = new LineSeries
            {
                Title = "Bitcoin"
            };
            MainForm mf = new();

            long Start = BTC_Controller.DateToUnixTime(dtpFrom);
            long End = BTC_Controller.DateToUnixTime(dtpTo);

            (List<DateTime> outputListDate, List<double> outputListPrice) = await BTC_Controller.ListPriceDate(Start, End);

            List<double> priceList = outputListPrice;
            List<DateTime> dateList = outputListDate;

            for (int i = 0; i < priceList.Count; i++)
            {
                lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dateList[i]), priceList[i]));
            }

            plotModel.Series.Add(lineSeries);

            var dateAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "dd.MM.yyyy",
                Title = "Date"
            };

            var priceAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Price"
            };


            plotModel.Axes.Add(dateAxis);
            plotModel.Axes.Add(priceAxis);

            plotView = new PlotView
            {
                Model = plotModel,
                Dock = DockStyle.Fill
            };

            Controls.Add(plotView);


        }

        private void btnDraw_Click(object sender, EventArgs e)//loads chart
        {
            if (plotView != null)
            {
                Controls.Remove(plotView);
                plotView = null;
            }
            Load();
        }

    }
}
