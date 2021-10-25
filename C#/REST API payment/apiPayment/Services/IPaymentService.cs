using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payment.Models;

namespace Payment.Services
{
    public interface IPaymentService
    {
        Task<string> GetPaymentById(int PayID);
        Task<ItemData> GetPaymentDetails(int PayID);
    }
}