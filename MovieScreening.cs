﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class MovieScreening
    {
        private LocalDateTime dateAndTime { get; set; }
        private double pricePerSeat { get; set; }

        private MovieScreening(Movie movie, LocalDateTime dateAndTime, double, pricePerSeat)
        {
            this.dateAndTime = dateAndTime;
            this.pricePerSeat = pricePerSeat;
        }

        public double getPricePerSeat()
        {
            return this.pricePerSeat;
        }

        public string toString()
        {
            return "" ;
        }
    }
}