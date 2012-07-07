using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wgu_gpa_calc
{
    public partial class Form1 : Form
    {
        private const double basePercent = 85;
        // passing score and maximum score for WFV1 class
        private const int WFV1minScore = 54;
        private const int WFV1maxScore = 85;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblWFV1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // loads CIW website for description of certification
            VisitLink("http://www.ciwcertified.com/certifications/web_foundations_series/associate.php", lblWFV1);
        }

        // loads a link when label obj is clicked
        private void VisitLink(String url, LinkLabel obj)
        {
            try
            {
                // opens up link in default web browser
                System.Diagnostics.Process.Start(url);
                obj.LinkVisited = true;
            }
            catch
            {
                // displays error message if link doesn't open
                MessageBox.Show("Unable to open link from a partial-trust environment (such as a shared drive).");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double WFV1Percent = 80;

            try
            {
                WFV1Percent = GetPercent(WFV1minScore, WFV1maxScore, txtWFV1);
            }
            catch
            {
                return;
            }
            
            double gpa = PercentToGPA(WFV1Percent);
            
            textBox1.Text = "GPA = " + gpa;
        }

        private void txtWFV1_TextChanged(object sender, EventArgs e)
        {
            // clear label of previous validation message
            lblWFV1val.Text = "";

            // validates entry if user has entered anything
            if (txtWFV1.Text.Length > 0)
            {
                Validate(WFV1minScore, WFV1maxScore);
            }
        }

        private double GetPercent(int minScore, int maxScore, TextBox txt)
        {
            int score = 0;

            // attempts to parse an integer from the text entered in WFV1 score text box
            // shows error message if fails
            try
            {
                score = int.Parse(txt.Text);

                // subtracts score from the minimum score for gpa calculation
                score = score - minScore;
            }
            catch
            {
                MessageBox.Show("Please enter a numeric value for WFV1.");
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
            // number to be parsed from WFV1 text box
            int number;

            // if parse fails
            if (!int.TryParse(txtWFV1.Text, out number))
            {
                // validation message will appear
                lblWFV1val.Text = "Please enter a numeric value.";
            }
            else
            {
                if (number < minScore)
                {
                    lblWFV1val.Text = "Please enter a passing score.";
                }
                if (number > maxScore)
                {
                    lblWFV1val.Text = "Please enter a score less than or equal to 85.";
                }
            }
        }
    }
}
