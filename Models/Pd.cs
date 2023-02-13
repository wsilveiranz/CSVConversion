using System;

namespace Theta.BC.Utilities.Models
{
    public class Pd
    {
        public string REFNO {get; set; } 
        public string SEX {get; set; } 
        public string DOB {get; set; } 
        public string AGE {get; set; } 
        public string AGEUNIT {get; set; } 
        public string AGEDAYS {get; set; } 
        public string HEIGHT {get; set; } 
        public string WEIGHT {get; set; } 
        public string BSA {get; set; } 
        public string PREHB {get; set; }

        public Pd()
        {}

        public Pd(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            SEX = fields[2];
            DOB = fields[3];
            AGE = fields[4];
            AGEUNIT = fields[5];
            AGEDAYS = fields[6];
            HEIGHT = fields[7];
            WEIGHT = fields[8];
            BSA = fields[9];
            PREHB = fields[10];
        }         
    }
}