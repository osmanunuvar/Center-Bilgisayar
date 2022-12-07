namespace CarControl.Models
{
    public static class StoppingList
    {
        public static List<StoppingListItem> StoppingItemsList { get; set; } = new List<StoppingListItem>()
        {
            new StoppingListItem()
            {
                Id = 1,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("1.01.2020 10:00:00"),
                Ending = DateTime.Parse("1.01.2020 10:10:00")
            },
            new StoppingListItem()
            {
                Id = 2,
                StoppingReason = "Arıza",
                Starting = DateTime.Parse("1.01.2020 10:30:00"),
                Ending = DateTime.Parse("1.01.2020 11:00:00")
            },
            new StoppingListItem()
            {
                Id = 3,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("1.01.2020 12:00:00"),
                Ending = DateTime.Parse("1.01.2020 12:30:00")
            },
            new StoppingListItem()
            {
                Id = 4,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("1.01.2020 14:00:00"),
                Ending = DateTime.Parse("1.01.2020 14:10:00")
            },
            new StoppingListItem()
            {
                Id = 5,
                StoppingReason = "Mal Yok",
                Starting = DateTime.Parse("1.01.2020 15:00:00"),
                Ending = DateTime.Parse("1.01.2020 16:30:00")
            },
            new StoppingListItem()
            {
                Id = 6,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("1.01.2020 18:00:00"),
                Ending = DateTime.Parse("1.01.2020 18:10:00")
            },
            new StoppingListItem()
            {
                Id = 7,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("1.01.2020 20:00:00"),
                Ending = DateTime.Parse("1.01.2020 20:30:00")
            },
            new StoppingListItem()
            {
                Id = 8,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("1.01.2020 22:00:00"),
                Ending = DateTime.Parse("1.01.2020 22:10:00")
            },
            new StoppingListItem()
            {
                Id = 9,
                StoppingReason = "Enerji Kesildi",
                Starting = DateTime.Parse("1.01.2020 23:00:00"),
                Ending = DateTime.Parse("2.01.2020 08:30:00")
            },
            new StoppingListItem()
            {
                Id = 10,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("2.01.2020 10:00:00"),
                Ending = DateTime.Parse("2.01.2020 10:10:00")
            },
            new StoppingListItem()
            {
                Id = 11,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("2.01.2020 12:00:00"),
                Ending = DateTime.Parse("2.01.2020 12:30:00")
            },
            new StoppingListItem()
            {
                Id = 12,
                StoppingReason = "Arıza",
                Starting = DateTime.Parse("2.01.2020 13:00:00"),
                Ending = DateTime.Parse("2.01.2020 13:45:00")
            },
            new StoppingListItem()
            {
                Id = 13,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("2.01.2020 14:00:00"),
                Ending = DateTime.Parse("2.01.2020 14:10:00")
            },
            new StoppingListItem()
            {
                Id = 14,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("2.01.2020 18:00:00"),
                Ending = DateTime.Parse("2.01.2020 18:10:00")
            },
            new StoppingListItem()
            {
                Id = 15,
                StoppingReason = "Enerji Kesildi",
                Starting = DateTime.Parse("2.01.2020 20:00:00"),
                Ending = DateTime.Parse("3.01.2020 02:10:00")
            },
            new StoppingListItem()
            {
                Id = 16,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("3.01.2020 04:00:00"),
                Ending = DateTime.Parse("3.01.2020 04:30:00")
            },
            new StoppingListItem()
            {
                Id = 17,
                StoppingReason = "Mal Yok",
                Starting = DateTime.Parse("3.01.2020 06:00:00"),
                Ending = DateTime.Parse("3.01.2020 09:30:00")
            },
            new StoppingListItem()
            {
                Id = 18,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("3.01.2020 10:00:00"),
                Ending = DateTime.Parse("3.01.2020 10:10:00")
            },
            new StoppingListItem()
            {
                Id = 19,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("3.01.2020 12:00:00"),
                Ending = DateTime.Parse("3.01.2020 12:30:00")
            },
            new StoppingListItem()
            {
                Id = 20,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("3.01.2020 14:00:00"),
                Ending = DateTime.Parse("3.01.2020 14:10:00")
            },
            new StoppingListItem()
            {
                Id = 21,
                StoppingReason = "Arıza",
                Starting = DateTime.Parse("3.01.2020 15:00:00"),
                Ending = DateTime.Parse("3.01.2020 18:45:00")
            },
            new StoppingListItem()
            {
                Id = 22,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("3.01.2020 20:00:00"),
                Ending = DateTime.Parse("3.01.2020 20:30:00")
            },
            new StoppingListItem()
            {
                Id = 23,
                StoppingReason = "Araba Yok",
                Starting = DateTime.Parse("3.01.2020 22:00:00"),
                Ending = DateTime.Parse("3.01.2020 22:10:00")
            }

        };
    }

    public class StoppingListItem
    {
        public int Id { get; set; }
        public string StoppingReason { get; set; }
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }
    }
}
