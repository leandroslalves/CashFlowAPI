﻿using CashFlow.Comunication.Enums;

namespace CashFlow.Comunication.Requests
{
    public class RequestRegisterExepensesJson
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public PaymentType PaymentType { get; set; }

    }
}