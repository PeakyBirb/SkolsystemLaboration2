﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolsystemLaboration2
{
    public class Betyg : IBetyg
    {
        private string tilldelatBetyg;
        public string TilldelatBetyg { get; set; }

        public Kurs Kurs { get; set; } 
        public Laborationsuppgift Laborationsuppgift { get; set; }
        public Student Student { get; set; }


        public Betyg(string tilldelatBetyg)
        {
            TilldelatBetyg = tilldelatBetyg;
        }


        public Betyg(Kurs kurs, Laborationsuppgift laborationsuppgift, Student student)
        {
            Kurs = kurs;
            Laborationsuppgift = laborationsuppgift;
            Student = student;
        }
    }
}
