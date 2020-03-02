using System;
using System.Collections.Generic;
using System.Text;

namespace ContractAutomation.Services
{
    class PayPal : IContractedPaymentService
    {
        public double MonthlySimple(double value, int month)
        {
            return value + value * (0.01 * month);
        }
        public double PaymentFee(double value)
        {
            return value + value * 0.02;
        }
    }
}
