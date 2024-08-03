﻿namespace AuctionService.Domain.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal StartingPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
