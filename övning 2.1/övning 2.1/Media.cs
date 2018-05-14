using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_2._1
{
    class Media
    {
        protected string titel = ""; // alla medier har titel så det matas in härifrån istället för att lägga till en titel-del i varje del

        public Media(string titel)
        {
            this.titel = titel;
        }
    }
}