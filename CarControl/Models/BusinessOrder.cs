namespace CarControl.Models
{
    public static class BusinessOrder
    {
        public static List<BusinessOrderItem> OrderItemList { get; set; } = new List<BusinessOrderItem>()
        {
            new BusinessOrderItem()
            {
                Id = 1,
                OrderNumber = "J000101",
                Starting = DateTime.Parse("1.01.2020 08:00:00"),
                Ending = DateTime.Parse("1.01.2020 16:00:00")
                
            },
            new BusinessOrderItem()
            {
                Id = 2,
                OrderNumber = "J000102",
                Starting = DateTime.Parse("1.01.2020 16:00:00"),
                Ending = DateTime.Parse("2.01.2020 00:00:00")
            },
            new BusinessOrderItem()
            {
                Id = 3,
                OrderNumber = "J000103",
                Starting = DateTime.Parse("2.01.2020 00:00:00"),
                Ending = DateTime.Parse("2.01.2020 08:00:00")
            },
            new BusinessOrderItem()
            {
                Id = 4,
                OrderNumber = "J000104",
                Starting = DateTime.Parse("2.01.2020 08:00:00"),
                Ending = DateTime.Parse("2.01.2020 16:00:00")
            },
            new BusinessOrderItem()
            {
                Id = 5,
                OrderNumber = "J000105",
                Starting = DateTime.Parse("2.01.2020 16:00:00"),
                Ending = DateTime.Parse("3.01.2020 00:00:00")
            },
            new BusinessOrderItem()
            {
                Id = 6,
                OrderNumber = "J000106",
                Starting = DateTime.Parse("3.01.2020 00:00:00"),
                Ending = DateTime.Parse("3.01.2020 08:00:00")
            },
            new BusinessOrderItem()
            {
                Id = 7,
                OrderNumber = "J000107",
                Starting = DateTime.Parse("3.01.2020 08:00:00"),
                Ending = DateTime.Parse("3.01.2020 16:00:00")
            },
            new BusinessOrderItem()
            {
                Id = 8,
                OrderNumber = "J000108",
                Starting = DateTime.Parse("3.01.2020 16:00:00"),
                Ending = DateTime.Parse("4.01.2020 00:00:00")
            },
            new BusinessOrderItem()
            {
                Id = 9,
                OrderNumber = "J000109",
                Starting = DateTime.Parse("4.01.2020 00:00:00"),
                Ending = DateTime.Parse("4.01.2020 08:00:00")
            }

        };
    }
    public class BusinessOrderItem
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }
    }


}
