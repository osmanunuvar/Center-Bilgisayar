namespace CarControl.Models
{
    public class Result
    {
        public string OrderNumber { get; set; }
        public int WithoutCarTime { get; set; }
        public int BreakdownTime { get; set; }
        public int WithoutGoodsTime { get; set; }
        public int WithoutEnergyTime { get; set; }
        public int Total { get; set; }
    }

}
