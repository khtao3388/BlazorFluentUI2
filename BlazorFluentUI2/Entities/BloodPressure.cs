﻿namespace BlazorFluentUI2.Entities
{
    public class BloodPressure
    {
        public int Id { get; set; }
        public DateTime DateAndTime { get; set; }
        
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public int HeartRate { get; set; }


    }
}
