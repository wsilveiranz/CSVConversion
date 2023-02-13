using System;

namespace Theta.BC.Utilities.Models
{
    public class Patient
    {
         public string PATNO {get; set; } 
        public string LASTNAME {get; set; } 
        public string FIRNAME {get; set; } 
        public string MIDNAME {get; set; } 
        public string TITLE {get; set; } 
        public string SUFFIX {get; set; } 
        public string PATID {get; set; } 
        public string PATBIRTH {get; set; } 
        public string PATSEX {get; set; } 
        public string NAME1 {get; set; } 
        public string PATID1 {get; set; } 
        public string OCCUPAT {get; set; } 
        public string HL7LOCK {get; set; } 
        public string PATHIST {get; set; } 
        public string PATCOM {get; set; } 
        public string ADDRESS {get; set; } 
        public string ETHNIC {get; set; } 
        public string MILRANK {get; set; } 
        public string PID {get; set; } 
        public string CONFLICT {get; set; } 
        public string ORIGIN {get; set; } 
        public string SSNUMBER {get; set; } 
        public string SITEID  {get; set; } 

        public Patient()
        {}

        public Patient (string fieldLine)
        {
            string[] fields = fieldLine.Split('|');

            PATNO = fields[1];
            LASTNAME = fields[2];
            FIRNAME = fields[3];
            MIDNAME = fields[4];
            TITLE = fields[5];
            SUFFIX = fields[6];
            PATID = fields[7];
            PATBIRTH = fields[8];
            PATSEX = fields[9];
            NAME1 = fields[10];
            PATID1 = fields[11];
            OCCUPAT = fields[12];
            HL7LOCK = fields[13];
            PATHIST = fields[14];
            PATCOM = fields[15];
            ADDRESS = fields[16];
            ETHNIC = fields[17];
            MILRANK = fields[18];
            PID = fields[19];
            CONFLICT = fields[20];
            ORIGIN = fields[21];
            SSNUMBER = fields[22];
            SITEID = fields[23];
        }
    }
}
