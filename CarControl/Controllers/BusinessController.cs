using CarControl.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarControl.Controllers
{
    public class BusinessController : Controller
    {
        public IActionResult Index()
        {
            var resultList = new List<Result>();
            var stoppingList = StoppingList.StoppingItemsList.ToList();
            var ListAllItems = BusinessOrder.OrderItemList.ToList();

            foreach (var item in ListAllItems)
            {
                var result = new Result
                {
                    OrderNumber = item.OrderNumber
                };
                resultList.Add(result);
            }
            foreach (var stopping in stoppingList)
            {
                var order = ListAllItems.FirstOrDefault(o => o.Starting <= stopping.Starting && o.Ending >= stopping.Starting);
                var resultItem = resultList.FirstOrDefault(r => r.OrderNumber == order.OrderNumber);
                if (order.Ending < stopping.Ending)
                {
                    var nextOrderItem = ListAllItems.FirstOrDefault(o => o.Id == order.Id + 1);
                    var nextOrdersResultItem = resultList.FirstOrDefault(r => r.OrderNumber == nextOrderItem.OrderNumber);
                    switch (stopping.StoppingReason)
                    {
                        case "Araba Yok":
                            resultItem.WithoutCarTime += Convert.ToInt32((order.Ending - stopping.Starting).TotalMinutes);
                            resultItem.Total += resultItem.WithoutCarTime;
                            nextOrdersResultItem.WithoutCarTime += Convert.ToInt32((stopping.Ending - nextOrderItem.Starting).TotalMinutes);
                            nextOrdersResultItem.Total += nextOrdersResultItem.WithoutCarTime;
                            break;
                        case "Arıza":
                            resultItem.BreakdownTime += Convert.ToInt32((order.Ending - stopping.Starting).TotalMinutes);
                            resultItem.Total += resultItem.BreakdownTime;
                            nextOrdersResultItem.BreakdownTime += Convert.ToInt32((stopping.Ending - nextOrderItem.Starting).TotalMinutes);
                            nextOrdersResultItem.Total += nextOrdersResultItem.BreakdownTime;
                            break;
                        case "Mal Yok":
                            resultItem.WithoutGoodsTime += Convert.ToInt32((order.Ending - stopping.Starting).TotalMinutes);
                            resultItem.Total += resultItem.WithoutGoodsTime;
                            nextOrdersResultItem.WithoutGoodsTime += Convert.ToInt32((stopping.Ending - nextOrderItem.Starting).TotalMinutes);
                            nextOrdersResultItem.Total += nextOrdersResultItem.WithoutGoodsTime;
                            break;
                        case "Enerji Kesildi":
                            resultItem.WithoutEnergyTime += Convert.ToInt32((order.Ending - stopping.Starting).TotalMinutes);
                            resultItem.Total += resultItem.WithoutEnergyTime;
                            nextOrdersResultItem.WithoutEnergyTime += Convert.ToInt32((stopping.Ending - nextOrderItem.Starting).TotalMinutes);
                            nextOrdersResultItem.Total += nextOrdersResultItem.WithoutEnergyTime;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    var stoppingMinutes = Convert.ToInt32((stopping.Ending - stopping.Starting).TotalMinutes);
                    switch (stopping.StoppingReason)
                    {
                        case "Araba Yok":
                            resultItem.WithoutCarTime += stoppingMinutes;
                            resultItem.Total += stoppingMinutes;
                            break;
                        case "Arıza":
                            resultItem.BreakdownTime += stoppingMinutes;
                            resultItem.Total += stoppingMinutes;
                            break;
                        case "Mal Yok":
                            resultItem.WithoutGoodsTime += stoppingMinutes;
                            resultItem.Total += stoppingMinutes;
                            break;
                        case "Enerji Kesildi":
                            resultItem.WithoutEnergyTime += stoppingMinutes;
                            resultItem.Total += stoppingMinutes;
                            break;
                        default:
                            break;
                    }
                }
            }
            return View(resultList);
        }
    }
}
