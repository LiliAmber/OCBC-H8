using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Payment.Models;
using Payment.Data;
using Payment.Services;

namespace Payment.Services
{
    public class PaymentService : IPaymentService
    {
        #region Property
        private readonly ApiDbContext _apiDbContext;
        #endregion

        #region Constructor
        public PaymentService(ApiDbContext apiDbContext) 
        {
            _apiDbContext = apiDbContext;
        }
        #endregion

        public async Task<string> GetPaymentById(int PayID)
        {
            var name = await _apiDbContext.Payments.Where(c => c.paymentDetailId == PayID).Select(d => d.cardOwnerName).FirstOrDefaultAsync();
            return name;
        }

        public async Task<ItemData> GetPaymentDetails(int PayID)
        {
            
            var pay = await _apiDbContext.Payments.FirstOrDefaultAsync(c => c.paymentDetailId == PayID);
            return pay;
        }
    }
}