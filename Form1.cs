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
    public partial class wgugpacalc : Form
    {
        private const double basePercent = 85;
        private Dictionary<String, int> scoresDict = new Dictionary<string,int>();

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

        private ArrayList gpas = new ArrayList();

        public wgugpacalc()
        {
            InitializeComponent();
            scoresDict.Add("WFV1minScore", WFV1minScore);
            scoresDict.Add("WFV1maxScore", WFV1maxScore);

            scoresDict.Add("AGC1minScore", AGC1minScore);
            scoresDict.Add("AGC1maxScore", AGC1maxScore);

            scoresDict.Add("BBC1minScore", BBC1minScore);
            scoresDict.Add("BBC1maxScore", BBC1maxScore);

            scoresDict.Add("CLC1minScore", CLC1minScore);
            scoresDict.Add("CLC1maxScore", CLC1maxScore);

            scoresDict.Add("AXV1minScore", AXV1minScore);
            scoresDict.Add("AXV1maxScore", AXV1maxScore);

            scoresDict.Add("CPV1minScore", CPV1minScore);
            scoresDict.Add("CPV1maxScore", CPV1maxScore);

            scoresDict.Add("INC1minScore", INC1minScore);
            scoresDict.Add("INC1maxScore", INC1maxScore);

            scoresDict.Add("DFV1minScore", DFV1minScore);
            scoresDict.Add("DFV1maxScore", DFV1maxScore);

            scoresDict.Add("CUV1minScore", CUV1minScore);
            scoresDict.Add("CUV1maxScore", CUV1maxScore);

            scoresDict.Add("BVC1minScore", BVC1minScore);
            scoresDict.Add("BVC1maxScore", BVC1maxScore);

            scoresDict.Add("GAC1minScore", GAC1minScore);
            scoresDict.Add("GAC1maxScore", GAC1maxScore);

            scoresDict.Add("CRV1minScore", CRV1minScore);
            scoresDict.Add("CRV1maxScore", CRV1maxScore);

            scoresDict.Add("DEV1minScore", DEV1minScore);
            scoresDict.Add("DEV1maxScore", DEV1maxScore);

            scoresDict.Add("CTV1minScore", CTV1minScore);
            scoresDict.Add("CTV1maxScore", CTV1maxScore);

            scoresDict.Add("DJV1minScore", DJV1minScore);
            scoresDict.Add("DJV1maxScore", DJV1maxScore);

            scoresDict.Add("BOV1minScore", BOV1minScore);
            scoresDict.Add("BOV1maxScore", BOV1maxScore);

            scoresDict.Add("BNC1minScore", BNC1minScore);
            scoresDict.Add("BNC1maxScore", BNC1maxScore);

            scoresDict.Add("CWV1minScore", CWV1minScore);
            scoresDict.Add("CWV1maxScore", CWV1maxScore);

            scoresDict.Add("CVV1minScore", CVV1minScore);
            scoresDict.Add("CVV1maxScore", CVV1maxScore);

            scoresDict.Add("MGC1minScore", MGC1minScore);
            scoresDict.Add("MGC1maxScore", MGC1maxScore);

            scoresDict.Add("CJV1minScore", CJV1minScore);
            scoresDict.Add("CJV1maxScore", CJV1maxScore);

            scoresDict.Add("TPV1minScore", TPV1minScore);
            scoresDict.Add("TPV1maxScore", TPV1maxScore);
        }

        private void btnGPA_Click(object sender, EventArgs e)
        {
            double finalGPA = 0;
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
                txtGPA.Text = "GPA: " + finalGPA.ToString("F02");
            }
        }

        private void ValidationStart(int min, int max)
        {
            // clear label of previous validation message
            lblVal.Text = "";

            // validates entry if user has entered anything
            if (txtInput.Text.Length > 0)
            {
                Validate(min, max);
            }
        }

        private void GetPerformanceScore(ComboBox cmb)
        {
            if (cmb.Enabled)
            {
                switch (cmb.SelectedIndex)
                {
                    case 0:
                        gpas.Add(4.0);
                        break;
                    case 1:
                        gpas.Add(3.67);
                        break;
                    case 2:
                        gpas.Add(3.33);
                        break;
                    default:
                        gpas.Add(3.0);
                        break;
                }
            }
        }

        private void GetObjectiveScore(int min, int max)
        {
            try
            {
                double percent = GetPercent(min, max);
                gpas.Add(PercentToGPA(percent));
                cmbClass.Items.Remove(cmbClass.Text);
                txtInput.Text = "";
            }
            catch
            {
                txtInput.Text = "";
                return;
            }
        }

        private double GetPercent(int minScore, int maxScore)
        {
            int score = 0;

            // attempts to parse an integer from the text entered in WFV1 score text box
            // shows error message if fails
            try
            {
                score = int.Parse(txtInput.Text);

                // subtracts score from the minimum score for gpa calculation
                score = score - minScore;
            }
            catch
            {
                MessageBox.Show("Please enter a numeric value for " + cmbClass.Text + ".");
                throw;
            }
            // calculates how many percentage points to add to the base percentage
            double percentToAdd = (double)score / (maxScore - minScore) * (100 - basePercent);
            double finalPercent = percentToAdd + basePercent;
            return finalPercent;
        }

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

        private void Validate(int minScore, int maxScore)
        {
            // number to be parsed from text box
            int number;

            // if parse fails
            if (!int.TryParse(txtInput.Text, out number))
            {
                // validation message will appear
                lblVal.Text = "Please enter a numeric value.";
            }
            else
            {
                if (number < minScore)
                {
                    lblVal.Text = "Please enter a passing score.";
                }
                if (number > maxScore)
                {
                    lblVal.Text = "Please enter a score less than or equal to " + maxScore + ".";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbInput.Visible)
            {
                GetPerformanceScore(cmbInput);
                cmbClass.Items.Remove(cmbClass.Text);
                cmbInput.Visible = false;
                cmbInput.SelectedIndex = -1;
            }
            if (txtInput.Visible)
            {
                String course = cmbClass.Text;
                int min = scoresDict[course + "minScore"];
                int max = scoresDict[course + "maxScore"];
                GetObjectiveScore(min, max);
                txtInput.Visible = false;
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInput.Visible = false;
            cmbInput.Visible = false;
            String course = cmbClass.Text;
            if (course.Equals("WFV1") || course.Equals("AGC1") || course.Equals("BBC1") ||
                course.Equals("CLC1") || course.Equals("AXV1") || course.Equals("CPV1") ||
                course.Equals("INC1") || course.Equals("DFV1") || course.Equals("CUV1") ||
                course.Equals("BVC1") || course.Equals("GAC1") || course.Equals("DHV1") ||
                course.Equals("CWV1") || course.Equals("CRV1") || course.Equals("DEV1") ||
                course.Equals("CTV1") || course.Equals("DJV1") || course.Equals("BOV1") ||
                course.Equals("BNC1") || course.Equals("CVV1") || course.Equals("MGC1") ||
                course.Equals("CJV1") || course.Equals("TPV1"))
            {
                txtInput.Visible = true;
            }
            else
            {
                cmbInput.Visible = true;
            }
            UpdateStatus(course);
        }

        private void UpdateStatus(String course)
        {
            lblStatus.Text = "";
            switch (course)
            {
                case "WFV1":
                    lblStatus.Text = "Passing score range 54 to 85 :: IT Fundamentals I (CIW Web Foundations Associate 1D0-510)";
                    break;
                case "AGC1":
                    lblStatus.Text = "Passing score range 64 to 100 :: Foundations of College Mathematics";
                    break;
                case "BBC1":
                    lblStatus.Text = "Passing score range 64 to 100 :: Communications Foundations";
                    break;
                case "CLC1":
                    lblStatus.Text = "Passing score range 60 to 100 :: Reasoning and Problem Solving";
                    break;
                case "AXV1":
                    lblStatus.Text = "Passing score range 675 to 900 :: IT Fundamentals II (CompTIA A+ Essentials 220-701)";
                    break;
                case "CPV1":
                    lblStatus.Text = "Passing score range 700 to 900 :: IT Fundamentals III (CompTIA A+ Practical Application 220-702)";
                    break;
                case "LAE1":
                    lblStatus.Text = "Language and Communication: Essay";
                    break;
                case "QBT1":
                    lblStatus.Text = "Language and Communication: Research";
                    break;
                case "INC1":
                    lblStatus.Text = "Passing score range 58 to 100 :: Integrated Natural Sciences";
                    break;
                case "LUT1":
                    lblStatus.Text = "Language and Communication: Presentation";
                    break;
                case "INT1":
                    lblStatus.Text = "Integrated Natural Sciences Applications";
                    break;
                case "DFV1":
                    lblStatus.Text = "Passing score 70 to 100 :: 98-363 Web Developer Fundamentals";
                    break;
                case "CUV1":
                    lblStatus.Text = "Passing score 49 to 70 :: Web Technologies (CIW Web Design Specialist 1D0-520)";
                    break;
                case "BVC1":
                    lblStatus.Text = "Geography";
                    break;
                case "GAC1":
                    lblStatus.Text = "Finite Mathematics";
                    break;
                case "HHT1":
                    lblStatus.Text = "Finite Mathematics Applications";
                    break;
                case "DHV1":
                    lblStatus.Text = "Passing score 70 to 100 :: 98-349 Windows Operating System Fundamentals";
                    break;
                case "DIV1":
                    lblStatus.Text = "Passing score 70 to 100 :: 98-365 Windows Server Administration Fundamentals";
                    break;
                case "CWV1":
                    lblStatus.Text = "Passing score 70 to 100 :: 98-366 Network Fundamentals";
                    break;
                case "CRV1":
                    lblStatus.Text = "Passing score 720 to 900 :: Networks (CompTIA Network+ 2009 N10-004)";
                    break;
                case "QLT1":
                    lblStatus.Text = "Quantitative Literacy: Quantitative Problem Solving and Applications";
                    break;
                case "DEV1":
                    lblStatus.Text = "Passing score 70 to 100 :: 98-367 Security Fundamentals";
                    break;
                case "CTV1":
                    lblStatus.Text = "Passing score 750 to 900 :: CompTIA Security+ 2011 SY0-301, JK0-018)";
                    break;
                case "DJV1":
                    lblStatus.Text = "Passing score 70 to 100 :: 98-361 Software Development Fundamentals";
                    break;
                case "BOV1":
                    lblStatus.Text = "Passing score 41 to 55 :: Web Programming (CIW JavaScript Specialist 1D0-520)";
                    break;
                case "BNC1":
                    lblStatus.Text = "Passing score 51 to 100 :: Organizational Behavior and Leadership";
                    break;
                case "IWC1":
                    lblStatus.Text = "Literature, Arts and the Humanities";
                    break;
                case "IWT1":
                    lblStatus.Text = "Literature, Arts and the Humanities: Analysis and Interpretation";
                    break;
                case "KET1":
                    lblStatus.Text = "Introduction to Programming";
                    break;
                case "CVV1":
                    lblStatus.Text = "Passing score 70 to 100 :: 98-364 Database Fundamentals";
                    break;
                case "MGC1":
                    lblStatus.Text = "Passing score 52 to 100 :: Principles of Management";
                    break;
                case "RIT1":
                    lblStatus.Text = "Leadership Concepts and Applications";
                    break;
                case "CJV1":
                    lblStatus.Text = "Passing score 42 to 50 :: Database I (CIW v5 Database Design Specialist 1D0-541)";
                    break;
                case "KFT1":
                    lblStatus.Text = "Object Oriented Design and Development";
                    break;
                case "TPV1":
                    lblStatus.Text = "Passing score 710 to 900 :: Project Management (CompTIA Project+ 2009 PK0-003)";
                    break;
                case "SBT1":
                    lblStatus.Text = "Technical Writing";
                    break;
                case "QZT1":
                    lblStatus.Text = "IT Capstone Written Project";
                    break;
            }

        }

        private void wgugpacalc_Load(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            String course = cmbClass.Text;
            int min = scoresDict[course + "minScore"];
            int max = scoresDict[course + "maxScore"];
            ValidationStart(min, max);
        }

    }
}
