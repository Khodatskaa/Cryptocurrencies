using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Series;
using Cryptocurrencies.Models;

namespace Cryptocurrencies.Services
{
    public static class ChartService
    {
        public static PlotModel GeneratePriceChart(List<Cryptocurrency> priceHistory)
        {
            var plotModel = new PlotModel { Title = "Price Chart" };

            var lineSeries = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White
            };

            foreach (var data in priceHistory)
            {
                lineSeries.Points.Add(new DataPoint(data.Timestamp, (double)data.PriceUsd));
            }

            plotModel.Series.Add(lineSeries);
            return plotModel;
        }
    }
}
