﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceRegQuickExample.Model
{
    class Race
    {
        public String RaceTitle { get; set; }
        public DateTime StartDate_Time { get; set; }
        public String RaceDescription { get; set; }
        public ObservableCollection<Racer> racers { get; set; }
    }
}
