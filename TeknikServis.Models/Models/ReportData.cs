﻿using System;

namespace TeknikServis.Models.Models
{
    public class SurveyReport
    {
        public string question { get; set; }
        public double point { get; set; }
    }

    public class TechReport
    {
        public string nameSurname { get; set; }
        public double point { get; set; }
    }

    public class WeeklyReport
    {
        public string date { get; set; }
        public int count { get; set; }
    }
}
