using System;

namespace Theta.BC.Utilities.Models
{
    public class Study
    {
        public string PATNO {get; set; } 
        public string SEQNO {get; set; } 
        public string REFNO {get; set; } 
        public string OPENED {get; set; } 
        public string ACQU {get; set; } 
        public string TIMEOUT {get; set; } 
        public string SIGNED {get; set; } 
        public string STUDATE {get; set; } 
        public string NCSTUID {get; set; } 
        public string UNIQID {get; set; } 
        public string REFPHYS {get; set; } 
        public string REQPHYS {get; set; } 
        public string DIAGNOSE {get; set; } 
        public string PATLOC {get; set; } 
        public string ADMISSID {get; set; } 
        public string INSTRES {get; set; } 
        public string STUDYID {get; set; } 
        public string ACCESSNO {get; set; } 
        public string REQPRID {get; set; } 
        public string REQPRDES {get; set; } 
        public string STUDESC {get; set; } 
        public string STUCOM {get; set; } 
        public string PATPOS {get; set; } 
        public string INSTNAME {get; set; } 
        public string PERPHYS1 {get; set; } 
        public string PERPHYS2 {get; set; } 
        public string OPNAME1 {get; set; } 
        public string OPNAME2 {get; set; } 
        public string PREMED {get; set; } 
        public string CONTRAST {get; set; } 
        public string MEDALERT {get; set; } 
        public string ALLERGY {get; set; } 
        public string SPECNEED {get; set; } 
        public string PATSTATE {get; set; } 
        public string SMOKING {get; set; } 
        public string PREGSTAT {get; set; } 
        public string MENSDATE {get; set; } 
        public string STATEID {get; set; } 
        public string PCATHTIM {get; set; } 
        public string ORDNUM {get; set; }

        public Study()
        {}

        public Study(string fieldLine)
        {
            string[] fields = fieldLine.Split('|');
            
            PATNO = fields[1];
            SEQNO = fields[2];
            REFNO = fields[3];
            OPENED = fields[4];
            ACQU = fields[5];
            TIMEOUT = fields[6];
            SIGNED = fields[7];
            STUDATE = fields[8];
            NCSTUID = fields[9];
            UNIQID = fields[10];
            REFPHYS = fields[11];
            REQPHYS = fields[12];
            DIAGNOSE = fields[13];
            PATLOC = fields[14];
            ADMISSID = fields[15];
            INSTRES = fields[16];
            STUDYID = fields[17];
            ACCESSNO = fields[18];
            REQPRID = fields[19];
            REQPRDES = fields[20];
            STUDESC = fields[21];
            STUCOM = fields[22];
            PATPOS = fields[23];
            INSTNAME = fields[24];
            PERPHYS1 = fields[25];
            PERPHYS2 = fields[26];
            OPNAME1 = fields[27];
            OPNAME2 = fields[28];
            PREMED = fields[29];
            CONTRAST = fields[30];
            MEDALERT = fields[31];
            ALLERGY = fields[32];
            SPECNEED = fields[33];
            PATSTATE = fields[34];
            SMOKING = fields[35];
            PREGSTAT = fields[36];
            MENSDATE = fields[37];
            STATEID = fields[38];
            PCATHTIM = fields[39];
            ORDNUM = fields[40];
        }         
    }
}