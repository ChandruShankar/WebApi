using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.KaniniModel;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        public static stationaryContext db = new stationaryContext();

        [HttpGet]
        public async Task<IActionResult> GetAllBookingTs()
        {
            return Ok(await db.BookingTs.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddBookingT(BookingT e)
        {
            db.BookingTs.Add(e);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBookingT(int id, BookingT e)
        {
            using (var db = new stationaryContext())
            {
                db.Entry(e).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return Ok(e);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBookingT(int id)
        {
            BookingT e = db.BookingTs.Find(id);
            db.BookingTs.Remove(e);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<BookingT>> Getid(int id)
        {
            BookingT e = await db.BookingTs.FindAsync(id);
            return Ok(e);
        }
    }
}
