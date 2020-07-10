using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tortuga_api.Models;

namespace tortuga_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicCafeController : ControllerBase
    {
         private readonly MyDatabaseContext _context;
        private static readonly string[] Bands = new[]
        {
            "GBF", "Westside", "Boogie Wonderland", "MMC All Stars", "JB and the Routine", "Warm"
        };

        private readonly ILogger<MusicCafeController> _logger;

        public MusicCafeController(ILogger<MusicCafeController> logger, MyDatabaseContext context)
        {
            _context = context;
            _logger = logger;

            System.Diagnostics.Debug.WriteLine("heres the context " + _context);
        }

        [HttpGet]
        public IEnumerable<MusicCafeCalendar> Get()
        {
            var result = _context.MusicCafeCalendar.ToArray();

            var rng = new Random();
            var name = Bands[rng.Next(Bands.Length)];
            var entries = Enumerable.Range(1, 5).Select(index => new MusicCafeCalendar
            {
                EventDate = DateTime.Now.AddDays(index),
                BandName = Bands[rng.Next(Bands.Length)]
            })
            .ToArray();
            
            foreach (var element in entries)
            {
                element.Summary = " a group named " + element.BandName;
            }

            // return entries;
            return result;
        }
    }
}
