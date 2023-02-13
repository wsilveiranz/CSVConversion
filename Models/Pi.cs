using System;

namespace Theta.BC.Utilities.Models
{
    public class Pi
    {
        public string REFNO {get; set; } 
        public string IDNR {get; set; } 
        public string LASTNAME {get; set; } 
        public string FIRNAME {get; set; } 
        public string UNIQID {get; set; } 
        public string EXAMFILE {get; set; }  

        public Pi()
        {}

        public Pi(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            IDNR = fields[2];
            LASTNAME = fields[3];
            FIRNAME = fields[4];
            UNIQID = fields[5];
            EXAMFILE = fields[6];
        }
    }
}