﻿namespace Cryptocurrencies.Models
{
    public class Cryptocurrency
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal PriceUsd { get; set; }
        public decimal MarketCapUsd { get; set; }
        public decimal VolumeUsd24Hr { get; set; }
        public decimal ChangePercent24Hr { get; set; }
        public double Timestamp { get; internal set; }
    }
}
