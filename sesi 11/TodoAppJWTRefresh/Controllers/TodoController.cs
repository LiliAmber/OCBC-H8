﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAppJWT.Data;
using TodoAppJWT.Models;

namespace TodoAppJWT.Controllers
{   
    //=define the routing that our controller going to use
    [Route("api/[controller]")]
    //==need to specify the type of the controller to let .Net core know
    [ApiController]
    //==auth process==
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TodoController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TodoController(ApiDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems() 
        {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data) 
        {
            if(ModelState.IsValid) 
            {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.Id}, data);
            }

            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetItem(int id) 
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

            if(item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemData item)
        {
            if(id != item.Id)
                return BadRequest();
            
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return NotFound();

            existItem.Title = item.Title;
            existItem.Description = item.Description;
            existItem.Done = item.Done;
            
            //==Implement the changes on the database level==
            await _context.SaveChangesAsync();

            // return NoContent();
            return Ok("Successfully edit selected Todo");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return NotFound();

            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();

            // return Ok(existItem);//==respon disini==
            return Ok("Successfully delete selected Todo");
        }
    }
}
