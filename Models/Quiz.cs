using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrawApi.Models
{
    public class Quiz
    {
        public int ID { get; set; }

        public string Legend { get; set; }

        public string History { get; set; }

        public string First_Weapon { get; set; }

        public string Second_Weapon { get; set; }

    }
}