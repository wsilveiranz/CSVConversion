using System;

namespace Theta.BC.Utilities.Models
{
    public class MeTotal
    {
        public string REFNO {get; set; } 
        public string SEQNO {get; set; } 
        public string AUTOTIME {get; set; } 
        public string MEDIC {get; set; } 
        public string TOTAL {get; set; } 
        public string COMMENT {get; set; } 

        public MeTotal()
        {}

        public MeTotal(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            SEQNO = fields[2];
            AUTOTIME = fields[3];
            MEDIC = fields[4];
            TOTAL = fields[5];
            COMMENT = fields[6];
        }
    }
}