using System;

namespace Theta.BC.Utilities.Models
{
    public class Cont1
    {
        public string REFNO {get; set; } 
        public string SEQNO {get; set; } 
        public string AUTOTIME {get; set; } 
        public string CONTR {get; set; } 
        public string CONTA {get; set; } 
        public string PCREF {get; set; } 
        public string COMMENT {get; set; } 

        public Cont1()
        {}

        public Cont1(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            SEQNO = fields[2];
            AUTOTIME = fields[3];
            CONTR = fields[4];
            CONTA = fields[5];
            PCREF  = fields[6];
            COMMENT = fields[7];
        }        
    }
}