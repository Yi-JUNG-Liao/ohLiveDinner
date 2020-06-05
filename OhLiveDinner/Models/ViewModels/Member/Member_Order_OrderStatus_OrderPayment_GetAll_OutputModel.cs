using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OhLiveDinner.Models.ViewModels.Member
{
    public class Member_Order_OrderStatus_OrderPayment_GetAll_OutputModel
    {
        public int OrderId { get; set; }

        public int MemberId { get; set; }

        public int OrderStatusId { get; set; }

        public string OrderStatusName { get; set; }

        public string OrderpaymentName { get; set; }
        public int OrderPaymentId { get; set; }

        public DateTime OrderStartTime { get; set; }

        public DateTime OrderEndTime { get; set; }

    }
}