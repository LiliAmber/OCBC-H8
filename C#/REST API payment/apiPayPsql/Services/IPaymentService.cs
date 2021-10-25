using Payment.Models;  
using System.Collections.Generic;  
  
namespace Payment.Services  
{  
    public interface IPaymentService  
    {  
        void AddPaymentRecord(ItemData payment);  
        void UpdatePaymentRecord(ItemData payment);  
        void DeletePaymentRecord(string id);  
        ItemData GetPaymentSingleRecord(string id);  
        List<ItemData> GetPaymentRecords();  
    }  
}  