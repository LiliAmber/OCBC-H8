using Microsoft.AspNetCore.Mvc;  
using Payment.Services;  
using Payment.Models;  
using System;  
using System.Collections.Generic;  
  
namespace Payment.Controllers  
{  
    [Route("api/[controller]")]  
    public class PaymentController : ControllerBase  
    {  
        private readonly IPaymentService _paymentService;  
  
        public PaymentController(IPaymentService paymentService)  
        {  
            _paymentService = paymentService;  
            // return _paymentService;
        }  
  
        [HttpGet]  
        public IEnumerable<ItemData> Get()  
        {  
            return _paymentService.GetPaymentRecords();  
        }  
  
        [HttpPost]  
        public IActionResult Create([FromBody]ItemData payment)  
        {  
            if (ModelState.IsValid)  
            {  
                await _context.Items.AddAsync(payment);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {payment.paymentDetailId}, payment);
            }  
            return BadRequest();  
        }  
  
        [HttpGet("{id}")]  
        public ItemData Details(string id)  
        {  
            return _paymentService.GetPaymentSingleRecord(id);  
        }  
  
        [HttpPut]  
        public IActionResult Edit([FromBody]ItemData payment)  
        {  
            if (ModelState.IsValid)  
            {  
                _paymentService.UpdatePaymentRecord(payment);  
                return Ok();  
            }  
            return BadRequest();  
        }  
  
        [HttpDelete("{id}")]  
        public IActionResult DeleteConfirmed(string id)  
        {  
            var data = _paymentService.GetPaymentSingleRecord(id);  
            if (data == null)  
            {  
                return NotFound();  
            }  
            _paymentService.DeletePaymentRecord(id);  
            return Ok();  
        }  
    }  
}  