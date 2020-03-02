using System;
using System.Collections.Generic;
using System.Text;

namespace ContractAutomation.Services
{
    interface IContractedPaymentService
    {
        double MonthlySimple(double value, int month);
        double PaymentFee(double value);
    }
}
