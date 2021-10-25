using Payment.Models; 
using Payment.Data; 
using System.Collections.Generic; 
using Npgsql.EntityFrameworkCore.PostgreSQL; 
using System.Linq;  
  
namespace Payment.Services   
{  
    public class PaymentService : IPaymentService
    {  
        private readonly PostgreSqlContext _context;  
  
        public DataAccessProvider(PostgreSqlContext context)  
        {  
            _context = context;  
            return _context;
        }  
  
        public void AddPaymentRecord(ItemData payment)  
        {  
            _context.patients.Add(payment);  
            _context.SaveChanges();  
        }  
  
        public void UpdatePaymentRecord(ItemData payment)  
        {  
            _context.patients.Update(payment);  
            _context.SaveChanges();  
        }  
  
        public void DeletePaymentRecord(string id)  
        {  
            var entity = _context.patients.FirstOrDefault(t => t.id == id);  
            _context.payment.Remove(entity);  
            _context.SaveChanges();  
        }  
  
        public ItemData GetPaymentSingleRecord(string id)  
        {  
            return _context.payment.FirstOrDefault(t => t.id == id);  
        }  
  
        public List<ItemData> GetPaymentRecords()  
        {  
            return _context.payment.ToList();  
        }  
    }  
}  
