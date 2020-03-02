using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ContractAutomation.Services;

namespace ContractAutomation.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        private IContractedPaymentService _paymentService;

        public Contract (int number, DateTime date, double totalValue, IContractedPaymentService paymentService)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            _paymentService = paymentService;
        }
        public void InstallmentCalculation(int numberInstallments)
        {
            for (int i = 1; i <= numberInstallments; i++)
            {
                Date.AddMonths(i);
                int month = Date.Month;

                double value = TotalValue;
                value = value / numberInstallments;
                value = _paymentService.MonthlySimple(value, i);
                value = _paymentService.PaymentFee(value);

                Installments.Add(new Installment(Date.AddMonths(i), value));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Installments: ");
            foreach(Installment x in Installments)
            {
                sb.AppendLine(x.DueDate.ToString("dd/MM/yyyy") + " - " + x.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}
