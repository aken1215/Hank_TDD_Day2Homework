using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hank_TDD_Day2Homework.Models
{
    public class PoterBook
    {
        public  PoterVersion Version { get;set; }

        public double Pirce { get { return 100; }  }

    }

    public enum PoterVersion
    {
        I ,
        II,
        III,
        IV,
        V
    }
}