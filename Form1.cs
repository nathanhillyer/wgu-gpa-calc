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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace wgu_gpa_calc
{
    /// <summary>
    /// 
    /// </summary>
    public partial class wgugpacalc : Form
    {
        // the minimum percentage considered for a passing score where gpa=3.0
        private const double basePercent = 85;
        // a list of all courses
        private List<Course> courses = new List<Course>();

        // passing score and maximum score for classes
        private const int WFV1minScore = 54;
        private const int WFV1maxScore = 85;

        private const int AGC1minScore = 64;
        private const int AGC1maxScore = 100;

        private const int BBC1minScore = 64;
        private const int BBC1maxScore = 100;

        private const int CLC1minScore = 60;
        private const int CLC1maxScore = 100;

        private const int AXV1minScore = 675;
        private const int AXV1maxScore = 900;

        private const int CPV1minScore = 700;
        private const int CPV1maxScore = 900;

        private const int INC1minScore = 58;
        private const int INC1maxScore = 100;

        private const int DFV1minScore = 70;
        private const int DFV1maxScore = 100;

        private const int CUV1minScore = 49;
        private const int CUV1maxScore = 70;

        private const int BVC1minScore = 71;
        private const int BVC1maxScore = 100;

        private const int GAC1minScore = 73;
        private const int GAC1maxScore = 100;

        private const int CRV1minScore = 720;
        private const int CRV1maxScore = 900;

        private const int DEV1minScore = 70;
        private const int DEV1maxScore = 100;

        private const int CTV1minScore = 750;
        private const int CTV1maxScore = 900;

        private const int DJV1minScore = 70;
        private const int DJV1maxScore = 100;

        private const int BOV1minScore = 41;
        private const int BOV1maxScore = 55;

        private const int BNC1minScore = 51;
        private const int BNC1maxScore = 100;

        private const int CWV1minScore = 70;
        private const int CWV1maxScore = 100;

        private const int CVV1minScore = 70;
        private const int CVV1maxScore = 100;

        private const int MGC1minScore = 52;
        private const int MGC1maxScore = 100;

        private const int CJV1minScore = 42;
        private const int CJV1maxScore = 50;

        private const int TPV1minScore = 710;
        private const int TPV1maxScore = 900;

        private const int DHV1minScore = 70;
        private const int DHV1maxScore = 100;

        private const int DIV1minScore = 41;
        private const int DIV1maxScore = 58;


        private ArrayList gpas = new ArrayList();

        public wgugpacalc()
        {
            InitializeComponent();
            addCourses();
        }

        /// <summary>
        /// Adds all the courses to the courses List
        /// </summary>

        private void addCourses()
        {
            // adds each course along with its minimum/maximum score
            // (if applicable), course code, and full name of course
            Course WFV1 = new Course(WFV1minScore, WFV1maxScore, "WFV1",
                "IT Fundamentals I (CIW Web Foundations Associate 1D0-510)");
            courses.Add(WFV1);

            Course AGC1 = new Course(AGC1minScore, AGC1maxScore, "AGC1",
                "Foundations of College Mathematics");
            courses.Add(AGC1);

            Course BBC1 = new Course(BBC1minScore, BBC1maxScore, "BBC1",
                "Communications Foundations");
            courses.Add(BBC1);

            Course CLC1 = new Course(CLC1minScore, CLC1maxScore, "CLC1",
                "Reasoning and Problem Solving");
            courses.Add(CLC1);

            Course AXV1 = new Course(AXV1minScore, AXV1maxScore, "AXV1",
                "IT Fundamentals II (CompTIA A+ Essentials 220-701)");
            courses.Add(AXV1);

            Course CPV1 = new Course(CPV1minScore, CPV1maxScore, "CPV1",
                "IT Fundamentals III (CompTIA A+ Practical Application 220-702)");
            courses.Add(CPV1);

            Course INC1 = new Course(INC1minScore, INC1maxScore, "INC1",
                "Integrated Natural Sciences");
            courses.Add(INC1);

            Course DFV1 = new Course(DFV1minScore, DFV1maxScore, "DFV1",
                "Web Development Fundamentals");
            courses.Add(DFV1);

            Course CUV1 = new Course(CUV1minScore, CUV1maxScore, "CUV1",
                "Web Technologies (CIW Web Design Specialist 1D0-520)");
            courses.Add(CUV1);

            Course BVC1 = new Course(BVC1minScore, BVC1maxScore, "BVC1",
                "Geography");
            courses.Add(BVC1);

            Course GAC1 = new Course(GAC1minScore, GAC1maxScore, "GAC1",
                "Finite Mathematics");
            courses.Add(GAC1);

            Course HHT1 = new Course("HHT1", 
                "Finite Mathematics Applications");
            courses.Add(HHT1);

            Course LAE1 = new Course("LAE1",
                "Language and Communication: Essay");
            courses.Add(LAE1);

            Course LUT1 = new Course("LUT1",
                "Language and Communication: Presentation");
            courses.Add(LUT1);

            Course QBT1 = new Course("QBT1",
                "Language and Communication: Research");
            courses.Add(QBT1);

            Course DHV1 = new Course(DHV1minScore, DHV1maxScore, "DHV1",
                "98-349 Windows Operating System Fundamentals");
            courses.Add(DHV1);

            Course DIV1 = new Course(DIV1minScore, DIV1maxScore, "DIV1",
                "Geography");
            courses.Add(DIV1);

            Course CWV1 = new Course(CWV1minScore, CWV1maxScore, "CWV1",
                "98-366 Network Fundamentals");
            courses.Add(CWV1);

            Course CRV1 = new Course(CRV1minScore, CRV1maxScore, "CRV1",
                "Networks (CompTIA Network+ 2009 N10-004)");
            courses.Add(CRV1);

            Course QLT1 = new Course("QLT1",
                "Quantitative Literacy: Quantitative Problem Solving and Applications");
            courses.Add(QLT1);

            Course DEV1 = new Course(DEV1minScore, DEV1maxScore, "DEV1",
                "98-367 Security Fundamentals");
            courses.Add(DEV1);

            Course CTV1 = new Course(CTV1minScore, CTV1maxScore, "CTV1",
                "CompTIA Security+ 2011 SY0-301, JK0-018)");
            courses.Add(CTV1);

            Course DJV1 = new Course(DJV1minScore, DJV1maxScore, "DJV1",
                "98-361 Software Development Fundamentals");
            courses.Add(DJV1);

            Course BOV1 = new Course(BOV1minScore, BOV1maxScore, "BOV1",
                "Web Programming (CIW JavaScript Specialist 1D0-520)");
            courses.Add(BOV1);

            Course BNC1 = new Course(BNC1minScore, BNC1maxScore, "BNC1",
                "Organizational Behavior and Leadership");
            courses.Add(BNC1);

            Course IWC1 = new Course("IWC1",
                "Literature, Arts and the Humanities");
            courses.Add(IWC1);

            Course IWT1 = new Course("IWT1",
                "Literature, Arts and the Humanities: Analysis and Interpretation");
            courses.Add(IWT1);

            Course INT1 = new Course("INT1",
                "Integrated Natural Science Applications");
            courses.Add(INT1);

            Course KET1 = new Course("KET1",
                "Introduction to Programming");
            courses.Add(KET1);

            Course CVV1 = new Course(CVV1minScore, CVV1maxScore, "CVV1",
                "98-364 Database Fundamentals");
            courses.Add(CVV1);

            Course MGC1 = new Course(MGC1minScore, MGC1maxScore, "MGC1",
                "Principles of Management");
            courses.Add(MGC1);

            Course RIT1 = new Course("RIT1",
                "98-366 Network Fundamentals");
            courses.Add(RIT1);

            Course CJV1 = new Course(CJV1minScore, CJV1maxScore, "CJV1",
                "Database I (CIW v5 Database Design Specialist 1D0-541)");
            courses.Add(CJV1);

            Course KFT1 = new Course("KFT1",
                "Object Oriented Design and Development");
            courses.Add(KFT1);

            Course TPV1 = new Course(TPV1minScore, TPV1maxScore, "TPV1",
                "Object Oriented Design and Development");
            courses.Add(TPV1);

            Course SBT1 = new Course("SBT1",
                "Technical Writing");
            courses.Add(SBT1);

            Course QZT1 = new Course("QZT1",
                "IT Capstone Written Project");
            courses.Add(QZT1);
        }

        /// <summary>
        /// Updates status bar and activates input once a class is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course course = FindCourse(cmbClass.Text);

            // opens up input for objective exam
            if (course.ObjectiveExam)
            {
                txtInput.Visible = true;
                lblScore.Text = "Score on Objective Exam";
                lblScore.Visible = true;
            }
            // if not objective, opens up input for performance exam
            else
            {
                cmbInput.Visible = true;
                lblScore.Text = "Number of Exam Attempts";
                lblScore.Visible = true;
            }

            // updates the status bar with course information
            UpdateStatus(course);
        }

        /// <summary>
        /// Finds a Course object based on a course code
        /// </summary>
        /// <param name="code">course code</param>
        /// <returns>course object containing code</returns>
        private Course FindCourse(String code)
        {
            foreach (Course course in courses)
            {
                // assigns course to target object once course code matches
                if (course.CourseCode.Equals(code))
                {
                    return course;
                }
            }
            return new Course();
        }

        /// <summary>
        /// Updates the status bar with course information
        /// </summary>
        /// <param name="course">Course to pull information from</param>

        private void UpdateStatus(Course course)
        {
            // clears status bar of any previous message
            lblStatus.Text = "";

            // update status bar with objective exam information
            if (course.ObjectiveExam)
            {
                lblStatus.Text = "Passing score range " + course.MinScore + " to "
                    + course.MaxScore + "    ::    ";
            }
            // if not objective exam, update status for performance exam info
            else
            {
                lblStatus.Text = "Performance Exam    ::    ";
            }
            lblStatus.Text += course.CourseDescription;
        }

        /// <summary>
        /// Attempts to validate text if user enters text into score textbox
        /// </summary>

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            Course course = FindCourse(cmbClass.Text);
            ValidateInput(course);
        }

        /// <summary>
        /// Start validating the textbox input
        /// </summary>
        /// <param name="course">Course to be used in validation</param>
        private void ValidateInput(Course course)
        {
            // clear label of previous validation message
            lblVal.Text = "";
            btnAdd.Visible = false;

            // validates entry if user has entered anything
            if (txtInput.Text.Length > 0)
            {
                // shows add button if validation passed
                if (InputIsValid(course))
                {
                    btnAdd.Visible = true;
                }
            }
        }

        private bool InputIsValid(Course course)
        {
            // number to be parsed from text box
            int number = 0;

            // attempts to parse text
            // sends integer out to number variable if succeeds
            // validation message will appear if parse fails
            if (!int.TryParse(txtInput.Text, out number))
            {
                lblVal.Text = "Please enter a numeric value.";
            }
            else
            {
                // if number parsed is out of min/max range of course
                // validation message will appear
                if (number < course.MinScore)
                {
                    lblVal.Text = "Please enter a passing score.";
                }
                if (number > course.MaxScore)
                {
                    lblVal.Text = "Please enter a score less than or equal to "
                        + course.MaxScore + ".";
                }
            }
            // returns true if number is within range, otherwise returns false
            if (number >= course.MinScore && number <= course.MaxScore)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Activates add button if user inputs value for performance exam
        /// </summary>

        private void cmbInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
        }

        /// <summary>
        /// Gets the gpa of course and adds it to gpa arraylist when user
        /// clicks add button
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // checks if performance exam
            if (cmbInput.Visible)
            {
                GetPerformanceScore();
                // removes exam from list to avoid duplicate entry
                cmbClass.Items.Remove(cmbClass.Text);
                // hides combobox in anticipation of next exam entry
                cmbInput.Visible = false;
                // resets combobox selection
                cmbInput.SelectedIndex = -1;
            }
            // checks if objective exam
            if (txtInput.Visible)
            {
                // finds the course based on combobox text
                Course course = FindCourse(cmbClass.Text);
                // attempts to get objective score
                // returns if exception is thrown
                try
                {
                    GetObjectiveScore(course);
                }
                catch
                {
                    return;
                }
                // hides input textbox in anticipation of next exam entry
                txtInput.Visible = false;
            }
            // hides label for exam entry, add button, gpa textbox
            // in anticipation of next exam entry
            lblScore.Visible = false;
            btnAdd.Visible = false;
            txtGPA.Visible = false;
            // opens up possibility of calculating gpa
            btnGPA.Visible = true;
        }

        /// <summary>
        /// Gets the performance exam score based on the number of attempts
        /// </summary>

        private void GetPerformanceScore()
        {
            // if the combobox is enabled, it must be a performance exam
            if (cmbInput.Enabled)
            {
                // calculate gpas based on what user selects
                switch (cmbInput.SelectedIndex)
                {
                    // 4.0 if passed on first attempt
                    case 0:
                        gpas.Add(4.0);
                        break;
                    // 3.67 if passed on second attempt
                    case 1:
                        gpas.Add(3.67);
                        break;
                    // 3.33 if passed on third attempt
                    case 2:
                        gpas.Add(3.33);
                        break;
                    // 3.0 if passed on four or more attempts
                    default:
                        gpas.Add(3.0);
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the score of the objective exam, calculates the gpa, and adds
        /// gpa to arraylist
        /// </summary>
        /// <param name="course">Course related to objective exam</param>

        private void GetObjectiveScore(Course course)
        {
            // attempt to parse score and handle any exceptions thrown
            try
            {
                // gets the score from text box
                int score = ParseScore();
                // convert the score to a percentage amount
                double percent = GetPercent(score, course);
                // convert the percentage to gpa and add to arraylist
                gpas.Add(PercentToGPA(percent));
                // removes course from combo box to avoid duplicate entries
                cmbClass.Items.Remove(cmbClass.Text);
                // clear out textbox for next input
                txtInput.Text = "";
            }
            // all other exceptions, clear textbox and throw exception
            catch (Exception ex)
            {
                txtInput.Text = "";
                throw ex;
            }
        }

        /// <summary>
        /// Parses an integer score from the score textbox
        /// </summary>
        /// <returns>the parsed integer</returns>
        private int ParseScore()
        {
            int score = 0;

            // attempts to parse an integer from the text entered in score text box
            // shows error message if fails
            try
            {
                score = int.Parse(txtInput.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a numeric value for "
                    + cmbClass.Text + ".");
                throw;
            }

            return score;
        }

        /// <summary>
        /// Gets the percentage points to be added to base percentage
        /// </summary>
        /// <param name="score">exam score</param>
        /// <param name="course">course related to exam</param>
        /// <returns>the percentage points to add</returns>
        private double GetPercent(int score, Course course)
        {
            // takes the user's score and subtracts it from the course's
            // minimum score for percentage point calculation
            score = score - course.MinScore;
            // calculates how many percentage points to add to the base percentage
            double percentToAdd = (double) score / (course.MaxScore - 
                course.MinScore) * (100 - basePercent);
            // adds the extra percentage to the base percentage
            double finalPercent = percentToAdd + basePercent;
            return finalPercent;
        }

        /// <summary>
        /// Converts a percentage score to a GPA score
        /// </summary>
        /// <param name="percent">percent to convert</param>
        /// <returns>gpa score</returns>
        private double PercentToGPA(double percent)
        {
            double gpa = 3.0;

            if (percent >= 93)
                gpa = 4.0;
            else if (percent >= 90)
                gpa = 3.67;
            else if (percent >= 87)
                gpa = 3.33;

            return gpa;
        }

        /// <summary>
        /// Calculates the gpa for all courses entered so far
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGPA_Click(object sender, EventArgs e)
        {
            double finalGPA = 0;
            // if gpas have been entered, they will be added together then
            // divided by the number of gpas to get the average
            if (gpas.Count > 0)
            {
                foreach (double d in gpas)
                {
                    finalGPA += d;
                }
                finalGPA /= gpas.Count;
            }

            if (finalGPA > 0)
            {
                // if we have a gpa, display it formatted to 2 decimal points
                txtGPA.Text = "GPA: " + finalGPA.ToString("F02");
                txtGPA.Visible = true;
            }
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Shows the about dialog box
        /// </summary>
        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }
    }
}
