using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Windows.Forms;
using T3._1.Controller;
using T3._1.View;

namespace T3._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            BTC_Controller BTCC = new BTC_Controller();
            InitializeComponent();
            UnixTimeLabel.Text = Convert.ToString(BTCC.WriteCurrentTime()); //gets current UNIX time
            timer1.Start();



        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            long time = Convert.ToInt64(UnixTimeLabel.Text);
            time++;
            UnixTimeLabel.Text = time.ToString();

        }//Updates Unix time

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            if (dtpStart.Text == dtpEnd.Text || Convert.ToDateTime(dtpStart.Text) > Convert.ToDateTime(dtpEnd.Text))
            {
                rtbConsole.Text = "Give different times!";
                return;
            }
            lFrom.Text = dtpStart.Text;
            lTo.Text = dtpEnd.Text;
            lBTCSearch.Text = cbBTC.Text;

            long unixTimeS = BTC_Controller.DateToUnixTime(dtpStart);
            long unixTimeE = BTC_Controller.DateToUnixTime(dtpEnd);

            if (cbBTC.Text == "Price")
            {

                List<string> values = await BTC_Controller.WriteToData(unixTimeS, unixTimeE);

                rtbConsole.Clear(); // Clear the RichTextBox "Console" before adding new content

                try
                {
                    values.RemoveRange(0, 3);
                }
                catch (Exception ex)
                {

                }//this removes the first 3 values since they are not in the date range


                foreach (string value in values) //adds all values to the lsit
                {
                    rtbConsole.AppendText(value + Environment.NewLine);
                }
                (var highestTrend, var trendEnd) = await BTC_Controller.WriteTrend(unixTimeS, unixTimeE);

                (var lowestPrice, var lowestTime, var highestPrice, var highestTime) = await BTC_Controller.FindMostProfit(unixTimeS, unixTimeE);
                rtbConsole.AppendText("-------------------------------------------" + Environment.NewLine);
                rtbConsole.AppendText("Largest trend in bitcoin price decreasing was: " + highestTrend.ToString() + Environment.NewLine);
                rtbConsole.AppendText("Trend ended in: " + trendEnd + Environment.NewLine);

                rtbConsole.AppendText("-------------------------------------------" + Environment.NewLine);
                rtbConsole.AppendText("Buy price: " + lowestPrice + Environment.NewLine);
                rtbConsole.AppendText("Buy time: " + lowestTime + Environment.NewLine);
                rtbConsole.AppendText("sell price: " + highestPrice + Environment.NewLine);
                rtbConsole.AppendText("sell time: " + highestTime + Environment.NewLine);

                if (rtbConsole.Text.StartsWith("-------------------------------------------")) //gives error if no values
                {
                    lError.Text = "ERROR FOUND\n\r please close!";
                }
            }

            else if (cbBTC.Text == "Volume")
            {
                List<string> volumeValues = await BTC_Controller.WriteToDataVolume(unixTimeS, unixTimeE);
                rtbConsole.Clear();

                try
                {
                    volumeValues.RemoveRange(0, 3);
                }
                catch (Exception ex)
                {

                }//removes the first 3 values since they are not in the date range

                foreach (string value in volumeValues) //adds all values to the lsit
                {
                    rtbConsole.AppendText(value + Environment.NewLine);
                }

                (double Highest, double Price, string Time) HighestVol = await BTC_Controller.WriteHighestVolume(unixTimeS, unixTimeE);

                rtbConsole.AppendText("-------------------------------------------" + Environment.NewLine);
                rtbConsole.AppendText("Highest Volume in given time was: " + HighestVol.Highest + Environment.NewLine);
                rtbConsole.AppendText("Bitcoins price at the time was: " + HighestVol.Price + Environment.NewLine);
                rtbConsole.AppendText("Highest Volume was on: " + HighestVol.Time + Environment.NewLine);

                if (rtbConsole.Text.StartsWith("-------------------------------------------")) //gives error if no values
                {
                    lError.Text = "ERROR FOUND\n\r please close!";
                }

            }


        }

        private void llSeeChart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //chart link
        {
            ChartForm chartForm = new ChartForm();
            chartForm.ShowDialog();
        }

    }
}