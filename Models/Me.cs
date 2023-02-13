using System;

namespace Theta.BC.Utilities.Models
{
    public class Me
    {
        public string REFNO {get; set; } 
        public string SEQNO {get; set; } 
        public string TIM {get; set; } 
        public string MEDIC {get; set; } 
        public string ADMIN {get; set; } 
        public string AMOUNT {get; set; } 
        public string PCREF {get; set; } 
        public string COMMENT {get; set; } 

        public Me()
        {}

        public Me(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            REFNO = fields[1];
            SEQNO = fields[2];
            TIM = fields[3];
            MEDIC = fields[4];
            ADMIN = fields[5];
            AMOUNT = fields[6];
            PCREF = fields[7];
            COMMENT = fields[8];
        }
    }
}