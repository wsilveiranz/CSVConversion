using System;

namespace Theta.BC.Utilities.Models
{
    public class Cav
    {
        public string REFNO {get; set; } 
        public string SEQNO {get; set; } 
        public string AUTOTIME {get; set; } 
        public string CATHETER {get; set; } 
        public string REFEQ {get; set; } 
        public string LOTVN {get; set; } 
        public string COMMENT {get; set; } 
        public Cav()
        {}

        public Cav(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            SEQNO = fields[2];
            AUTOTIME = fields[3];
            CATHETER = fields[4];
            REFEQ = fields[5];
            LOTVN = fields[6];
            COMMENT = fields[7];
        }        
    }
}