using System;

namespace Theta.BC.Utilities.Models
{
    public class Id
    {
        public string REFNO {get; set; } 
        public string EXAMDATE {get; set; } 
        public string STATIME {get; set; } 
        public string PROCTIME {get; set; } 
        public string ENDTIME {get; set; }  

        public Id()
        {}

        public Id(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            EXAMDATE = fields[2];
            STATIME = fields[3];
            PROCTIME = fields[4];
            ENDTIME = fields[5];
        }
    }
}