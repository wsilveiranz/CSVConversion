using System;

namespace Theta.BC.Utilities.Models
{
    public class Cd
    {
        public string REFNO {get; set; } 
        public string SEQNO {get; set; } 
        public string AUTOTIME {get; set; } 
        public string CLINDIAG {get; set; } 
        public string PREVTRT {get; set; } 
        public string COMMENT {get; set; } 

        public Cd()
        {}

        public Cd(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            SEQNO = fields[2];
            AUTOTIME = fields[3];
            CLINDIAG = fields[4];
            PREVTRT = fields[5];
            COMMENT  = fields[6];
        }
    }
}