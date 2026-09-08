using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IceCity.EFCore.Entities
{
   public class House
    {
        public Guid HouseId { get; set; }
        public Guid OwnerId { get; set; }
        public string Address { get; set; } 
        public string CityZone { get; set; }
        public Owner owner { get; set; } = null!;
        public List<Heater> heaters { get; set; } = new List<Heater>();
        public List< SensorReading> dailyUsages { get;  set; }= new List<SensorReading> () ;
        public List <MonthlyReport> monthlyReports { get; set; }= new List<MonthlyReport> () ;

    }



}
