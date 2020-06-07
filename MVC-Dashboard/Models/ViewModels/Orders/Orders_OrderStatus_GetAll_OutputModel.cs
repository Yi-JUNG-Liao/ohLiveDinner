using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Dashboard.Models.ViewModels.Orders
{
    public class Orders_OrderStatus_GetAll_OutputModel
    {
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public decimal OrderTotalPrice { get; set; }
        public int OrderStatusId { get; set; }
        public int OrderPayMethod { get; set; }
        public double OrderEvaluation { get; set; }
        public DateTime OrderStartTime { get; set; }
        public DateTime OrderEndTime { get; set; }

        public string OrderStatusName { get; set; }
    }
}