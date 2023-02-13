using System;

namespace Theta.BC.Utilities.Models
{
    public class Ca
    {
        public string REFNO {get; set; } 
        public string SEQNO {get; set; } 
        public string AUTOTIME {get; set; } 
        public string CATHETER {get; set; } 
        public string REFEQ {get; set; } 
        public string COMMENT {get; set; }        

        public Ca()
        {}

        public Ca(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            SEQNO = fields[2];
            AUTOTIME = fields[3];
            CATHETER = fields[4];
            REFEQ = fields[5];
            COMMENT  = fields[6];
        }
    }
}