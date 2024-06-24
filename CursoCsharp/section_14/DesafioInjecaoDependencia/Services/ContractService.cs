using CursoCsharp.section_14.DesafioInjecaoDependencia.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_14.DesafioInjecaoDependencia.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double contractValuePerMonth = contract.TotalValue / months;

            for (int i = 0; i < months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double newQuota = contractValuePerMonth + _onlinePaymentService.Interest(contractValuePerMonth, i);
                double finalQuota = newQuota + _onlinePaymentService.PaymentFee(newQuota);
                
                contract.AddInstallment(new Installment(date, finalQuota));
            }
        }
    }
}
