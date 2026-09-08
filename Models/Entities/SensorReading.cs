using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace IceCity.EFCore.Entities
    {

        public class SensorReading
        {
        public Guid SensorReadingId { get; set; }

        public Guid HeaterId { get; set; }

        public Guid HouseId { get; set; }

            public DateTime UsageDate { get; set; }

            public decimal HoursWorked { get; set; }

            public decimal HeaterValue { get; set; }

            // Navigation Properties
            public Heater Heater { get; set; } = null!;

            public House House { get; set; } = null!;
        }
    }

