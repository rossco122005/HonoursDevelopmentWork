using System;
using System.Collections.Generic;
using IntegratedV1.Shared;

namespace MVCApp.Models
{
    public class HomeIndexViewModel
    {
        public string Heading;
        public IList<Game> Games {get; set;}
    }
}