using System;
using System.ComponentModel.DataAnnotations;

namespace tortuga_api.Models
{
    public class MusicCafeCalendar
    {
        public int ID { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EventDate { get; set; }

        public string BandName { get; set; }

        public string Summary { get; set; }
    }
}
