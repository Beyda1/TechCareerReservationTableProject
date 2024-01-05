using System.ComponentModel.DataAnnotations.Schema;

namespace TechCareerReservationTableProject.Models
{
    public class client
    {
        public nvarchar(50) Name { get; set; }
        public nvarchar(50) Surname { get; set; }
        public date BirthDate { get; set; }
        public nvarchar(100) Address { get; set; }
        public nvarchar(50) Email { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public CompanyModel Company { get; set; }
    }
}
