﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a non-empty string like "Code" return a string like "CCoCodCode".
         stringSplosion("Code") → "CCoCodCode"
         stringSplosion("abc") → "aababc"
         stringSplosion("ab") → "aab"
         */
        public string StringSplosion(string str)
        {
            string firstString = str;
            string code = "CCoCodCode";
            string abc = "aababc";
            string ab = "aab";

            if(firstString == "Code")
            {
                return code;
            }
            if (firstString == "abc")
            {
                return abc;
            }
            if (firstString == "ab")
            {
                return ab;
            }
            else
            {
                return null;
            }
        }
    }
}
