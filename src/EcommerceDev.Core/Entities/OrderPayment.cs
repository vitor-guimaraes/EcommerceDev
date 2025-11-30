using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceDev.Core.Entities
{
    public class OrderPayment : BaseEntity
    {
        public OrderPayment() { }

        public OrderPayment(int externalPaymentId, int status, DateTime confirmationDate, int orderId)
        {
            ExternalPaymentId = externalPaymentId;
            Status = status;
            ConfirmationDate = confirmationDate;
            OrderId = orderId;
        }

        public int ExternalPaymentId { get; set; }
        public int Status { get; set; }
        public DateTime ConfirmationDate { get; set; }
        public int OrderId { get; set; }
    }
}
