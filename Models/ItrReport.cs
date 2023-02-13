using System;
using System.Collections.Generic;

namespace Theta.BC.Utilities.Models
{
    public class ItrReport
    {
        public string FileName { get; set; }
        public string StudyDate { get; set; }
        public string RefNo { get; set; }
        public List<Patient> PATIENT { get; set; } 
        public List<Study> STUDY { get; set; }
        public List<Pi> PI { get; set; }
        public List<Pd> PD { get; set; }
        public List<Id> ID { get; set; }
        public List<Pn> PN { get; set; }
        public List<Cd> CD { get; set; }
        public List<Ca> CA { get; set; }
        public List<Me> ME { get; set; }
        public List<MeTotal> METOTAL { get; set; }
        public List<Cont1> CONT1 { get; set; }
        public List<Cav> CAV { get; set; }

        public ItrReport()
        {
            PATIENT = new List<Patient>();
            STUDY = new List<Study>();
            PI = new List<Pi>();
            PD = new List<Pd>();
            ID = new List<Id>();
            PN = new List<Pn>();
            CD = new List<Cd>();
            CA = new List<Ca>();
            ME = new List<Me>();
            METOTAL = new List<MeTotal>();
            CONT1 = new List<Cont1>();
            CAV = new List<Cav>();
        }
    }
}