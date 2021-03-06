﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    /// <summary>
    /// This class represents a single course, and contains various
    /// details about the course
    /// </summary>
    public class CourseDetailsDTO
    {
        /// <summary>
        /// The ID of the course
        /// Example: 1
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The name of the course
        /// Example: "Vefþjónustur
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// List of students in the course
        /// </summary>
        public List<StudentDTO>  Students { get; set; }

        /// <summary>
        /// Description of the course
        /// </summary>
        public String Description { get; set; }
    }
}
