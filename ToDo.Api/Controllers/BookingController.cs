using ToDo.Application.IService;
using ToDo.Domain.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToDo.Api.Controllers
{
    
    [Authorize]
    public class BookingController : BaseController
    {
        

        public BookingController()
        {
            
        }
        //[HttpPost]
        //[Route("AddBooking")]
        //public async Task<IActionResult> AddBooking([FromBody] BookingModel bookingModel)
        //{
        //    if (await _bookingService.IsBookingNoExist(bookingModel.BookingNo))
        //    {
        //        return BadRequest("Booking no exist");
        //    }
        //    await _bookingService.AddBooking(bookingModel);
        //    return Ok();
        //}
        //[HttpGet]
        //[Route("GetBookings")]
        //public async Task<IActionResult> GetBookings()
        //{
        //    var result = await _bookingService.GetBookings();
        //    return Ok(result);
        //}
        //[HttpPost]
        //[Route("GetBookingsByFilter")]
        //public async Task<IActionResult> GetBookingsByFilter([FromBody] BookingFilterModel filter)
        //{
        //    var result = await _bookingService.GetBookingsByFilter(filter);
        //    return Ok(result);
        //}

        //[HttpPatch]
        //[Route("UpdateBooking")]
        //public async Task<IActionResult> UpdateBooking([FromBody] BookingModel bookingModel)
        //{
        //    await _bookingService.UpdateBooking(bookingModel);
        //    return Ok();
        //}
        //[HttpGet]
        //[Route("GetBookingById")]
        //public async Task<IActionResult> GetBookingById([FromQuery] int id)
        //{
        //    var result = await _bookingService.GetBookingsById(id);
        //    return Ok(result);
        //}
        //[HttpGet]
        //[Route("GetBookingsByOperationId")]
        //public async Task<IActionResult> GetBookingsByOperationId([FromQuery] int operationId)
        //{
        //    var result = await _bookingService.GetBookingsByOperationId(operationId);
        //    return Ok(result);
        //}



        //[HttpGet]
        //[Route("GetInitialPageData")]
        //public async Task<IActionResult> GetInitialPageData()
        //{
        //    return Ok(await _bookingService.GetInitialPageData());
        //}
        //[HttpDelete]
        //[Route("DeleteBooking")]
        //public async Task<IActionResult> DeleteBooking([FromQuery] int id)
        //{
        //    await _bookingService.DeleteBooking(id);
        //    return Ok();
        //}
    }
}
