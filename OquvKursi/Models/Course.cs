﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OquvKursi.Models
{
   public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int TeacherId { get; set; }

        public string Subject { get; set; }

    }
}
