using IceCity.EFCore.Entities.contrac;
using IceCity2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCity.EFCore.Entities
{
    public class Owner:IsSoftDeletable
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public  string Phone { get; set; }
        public List <House> Houses { get; set; } = new List<House>();
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public ApplicationUser User { get; set; } = null!;
    }
}
