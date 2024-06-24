using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_14.DesafioInjecaoDependencia.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        private double _monthlyInterestFee = 0.01;
        private double _paymentFee = 0.02;
        
        public double Interest(double amount, int months)
        {
            return amount * _monthlyInterestFee * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * _paymentFee;
        }
    }
}
