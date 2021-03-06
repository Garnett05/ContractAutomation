﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContractAutomation.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
    
}
