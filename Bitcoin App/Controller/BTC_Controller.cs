using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3._1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace T3._1.Controller
{
    internal class BTC_Controller
    {

        //BTC Price listing:
        internal static async Task<BTC_Model> FetchBTCAsync(long uTimeMax, long uTimeMin)
        {
            string url =
                "https://api.coingecko.com/api/v3/coins/bitcoin/market_chart/range?vs_currency=eur&from=" + uTimeMax.ToString() + "&to=" + uTimeMin.ToString();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                var jsonString = await response.Content.ReadAsStringAsync();
                var BTC = JsonConvert.DeserializeObject<BTC_Model>(jsonString);

                return BTC;
            }

        } //finds bitcoins from date range.

        public static async Task<List<string>> WriteToData(long start, long end) //makes found bitcoin prices into a list.
        {
            var BTC = await BTC_Controller.FetchBTCAsync(start, end);
            List<string> outputList = new List<string>();
            if(BTC.Prices != null ) 
            {
                for (int i = 0; i < BTC.Prices.Count(); i++)
                {
                    string output = "Bitcoinin hinta: " +
                                    BTC.Prices[i][1] + " Ajalta: " +
                                    BTC_Controller.UnixTimeToDate(Convert.ToInt64(BTC.Prices[i][0] / 1000));

                    outputList.Add(output);
                }
                
            }
            return outputList;
        }

        public static async Task<(int, string)> WriteTrend(long start, long end) //Looks for trends in bitcoin list.
        {
            double CurrentPrice = 0;
            int HighestTrend = 0;
            string TrendEnd = "";
            int Trend = 0;

            var BTC = await BTC_Controller.FetchBTCAsync(start, end);

            if (BTC.Prices != null)
            {
                BTC.Prices[0][1] = CurrentPrice;


                for (int i = 0; i < BTC.Prices.Count(); i++)
                {

                    if (BTC.Prices[i][1] < CurrentPrice)
                    {
                        Trend++;
                        CurrentPrice = BTC.Prices[i][1];
                    }//jos BTC.Price on pienempi kuin current price trendi menee ylöspäin!

                    else if (BTC.Prices[i][1] > CurrentPrice)
                    {

                        if (Trend > HighestTrend)
                        {
                            HighestTrend = Trend; //tallennetaan uusi suurin trendi!
                            TrendEnd = "" + BTC_Controller.UnixTimeToDate(Convert.ToInt64(BTC.Prices[i][0] / 1000));
                        }

                        Trend = 0; //resetataan trendi
                        CurrentPrice = BTC.Prices[i][1];
                    }

                }

            }
            return (HighestTrend, TrendEnd);

        }

        

        //BTC Volumes:
        public static async Task<List<string>> WriteToDataVolume(long start, long end) //makes found bitcoin volumes into a list.
        {
            var BTC = await BTC_Controller.FetchBTCAsync(start, end);
            List<string> outputList = new List<string>();
            if (BTC.Prices != null)
            {
                for (int i = 0; i < BTC.Prices.Count(); i++)
                {
                    string output = "Bitcoinin voluumi: " +
                                    BTC.TotalVolumes[i][1] + " Ajalta: " +
                                    BTC_Controller.UnixTimeToDate(Convert.ToInt64(BTC.TotalVolumes[i][0] / 1000));

                    outputList.Add(output);
                }

            }
            return outputList;
        }
        
        public static async Task<(double, double, string)> WriteHighestVolume(long start, long end) //finds highest volume in date range
        {
            string Time = "";
            double High = 0;
            double BTCPrice = 0;
            var BTC = await BTC_Controller.FetchBTCAsync(start, end);
            if( BTC.TotalVolumes != null)
            {
                for (int i = 0; i < BTC.TotalVolumes.Count(); i++)
                {
                    if (BTC.TotalVolumes[i][1] > High)
                    {
                        High = BTC.TotalVolumes[i][1];
                        Time = "" + BTC_Controller.UnixTimeToDate(Convert.ToInt64(BTC.TotalVolumes[i][0] / 1000));
                        BTCPrice = BTC.Prices[i][1];
                    }
                }
            }
            return (High, BTCPrice, Time);
        }



        //Best times to buy/sell:
        public static async Task<(double, long)> FindHighestPrice(long start, long end) //Finds highest price of bitcoin in given time
        {
            double HighestPrice = 0;
            long time = 0;

            var BTC = await BTC_Controller.FetchBTCAsync(start, end);

            if (BTC.Prices != null)
            {
                for (int i = 0; i < BTC.Prices.Count(); i++)
                {
                    if (BTC.Prices[i][1] > HighestPrice)
                    {
                        HighestPrice = BTC.Prices[i][1];
                        time = Convert.ToInt64(BTC.Prices[i][0]);
                    }
                }
            }

            return (HighestPrice, time);
        }
        public static async Task<(double, string, double, string)> FindMostProfit(long start, long end) //Löytää parhaan ajan ostaa bitcoinia
        {
            (double HighestPrice, long time) = await FindHighestPrice(start, end);
            var BTC = await BTC_Controller.FetchBTCAsync(start, end);
            string HighestTime = "";
            string lowestTime = "";
            double lowestPrice = 0;

            long lowestTimeU = 0;


            if (BTC.Prices != null)
            {
                lowestPrice = BTC.Prices[0][1];
                for (int i = 0; i < BTC.Prices.Count(); i++)
                {
                    if (BTC.Prices[i][1] < lowestPrice && BTC.Prices[i][0] < time)
                    {
                        lowestPrice = BTC.Prices[i][1];
                        lowestTimeU = (long)BTC.Prices[i][0];
                    }

                }
            }
            HighestTime = "" + BTC_Controller.UnixTimeToDate(Convert.ToInt64(time / 1000));
            lowestTime = "" + BTC_Controller.UnixTimeToDate(Convert.ToInt64(lowestTimeU / 1000));


            return (lowestPrice, lowestTime, HighestPrice, HighestTime);
        }



        //ChartForm:
        public static async Task<(List<DateTime>,List<double>)> ListPriceDate(long start, long end) //Makes list of prices and dates (ChartForm)
        {
            var BTC = await BTC_Controller.FetchBTCAsync(start, end);
            List<DateTime> outputListDate = new List<DateTime>();
            List<double> outputListPrice = new List<double>();

            for (int i = 0; i < BTC.Prices.Count(); i++)
            {
                DateTime outputDate = BTC_Controller.UnixTimeToDate(Convert.ToInt64(BTC.Prices[i][0] / 1000));
                double outputPrice = BTC.Prices[i][1];

                outputListPrice.Add(outputPrice);
                outputListDate.Add(outputDate);
            }
            return (outputListDate, outputListPrice);
        }




        //Date & Unix Conversions:
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
       
        public static long DateToUnixTime(DateTimePicker dateTimePicker)
        {
            DateTime selectedDate = dateTimePicker.Value;
            TimeSpan timeDifference = selectedDate.ToUniversalTime() - UnixEpoch;
            long unixTime = (long)timeDifference.TotalSeconds;
            return unixTime;
        } //turns given date to UNIX time

        public static DateTime UnixTimeToDate(long unixTimeSeconds)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimeSeconds);
            return dateTimeOffset.DateTime;
        }  //turns UNIX time into a date

        public long WriteCurrentTime()
        {
            DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            DateTime currentTime = DateTime.UtcNow;
            long unixTime = ((DateTimeOffset)currentTime).ToUnixTimeSeconds();

            return unixTime;
        } //gives current time

    }
}
