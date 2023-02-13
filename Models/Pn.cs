using System;

namespace Theta.BC.Utilities.Models
{
    public class Pn
    {
        public string REFNO {get; set; } 
        public string SEQNO {get; set; } 
        public string AUTOTIME {get; set; } 
        public string PNNAME {get; set; } 
        public string STAFF {get; set; } 
        public string COMMENT {get; set; } 

        public Pn()
        {}

        public Pn(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            SEQNO = fields[2];
            AUTOTIME = fields[3];
            PNNAME = fields[4];
            STAFF = fields[5];
            COMMENT = fields[6];
        }
    }
}