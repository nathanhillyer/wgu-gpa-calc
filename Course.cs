/*
    Copyright © 2012  Nathan Hillyer
   
    This file is part of wgu-gpa-calc.

    wgu-gpa-calc is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    wgu-gpa-calc is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wgu_gpa_calc
{
    class Course
    {
        // properties of course object
        private int minScore;
        private int maxScore;
        private String courseCode;
        private String courseDescription;
        private bool objectiveExam;

        // allow read access to all properties
        public int MinScore
        {
            get
            {
                return minScore;
            }
        }
        public int MaxScore
        {
            get
            {
                return maxScore;
            }
        }
        public String CourseCode
        {
            get
            {
                return courseCode;
            }
        }
        public String CourseDescription
        {
            get
            {
                return courseDescription;
            }
        }
        public bool ObjectiveExam
        {
            get
            {
                return objectiveExam;
            }
        }

        /// <summary>
        /// Constructor for objective exam courses
        /// </summary>
        /// <param name="min">Minimum passing score</param>
        /// <param name="max">Maximum passing score</param>
        /// <param name="code">Course code</param>
        /// <param name="desc">Course description</param>
        public Course(int min, int max, String code, String desc)
        {
            this.minScore = min;
            this.maxScore = max;
            this.courseCode = code;
            this.courseDescription = desc;
            this.objectiveExam = true;
        }

        /// <summary>
        /// Constructor for performance exam courses
        /// </summary>
        /// <param name="code">Course code</param>
        /// <param name="desc">Course description</param>
        public Course(String code, String desc)
        {
            this.courseCode = code;
            this.courseDescription = desc;
            this.objectiveExam = false;
        }

        /// <summary>
        /// Empty constructor to create a course to be filled in later
        /// </summary>
        public Course()
        {
        }
    }
}
