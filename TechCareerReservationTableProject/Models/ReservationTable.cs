using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TechCareerReservationTableProject.Migrations;

namespace TechCareerReservationTableProject.Models
{
    public class ReservationTable : TableBase
         private readonly TechCareerDbContextModel _context;

    public ReservationController()
    {
        _context = new TechCareerDbContextModel();
    }
    [HttpGet]
    public IActionResult GetReservation()
    {
        var reservations = _context.Reservation.ToList();
        return Ok(reservation);

    }
}
