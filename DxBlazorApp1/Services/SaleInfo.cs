using System;
using System.Runtime.InteropServices;

namespace DxBlazorApp1.Services
{
    public class SaleInfo
    {
        public required int OrderId { get; set; }
        public required string City { get; set; }
        public required int Amount { get; set; }
        public required DateTime Date { get; set; }
    }
}
