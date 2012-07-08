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

        private ArrayList gpas = new ArrayList();

        public wgugpacalc()
        {
            InitializeComponent();
            var txtDelegate = new EventHandler(txt_TextChanged);
            foreach (var ctrl in this.Controls)
            {
                var txtBox = ctrl as TextBox;
                if (txtBox != null && txtBox.Name != "txtGPA")
                    txtBox.TextChanged += txtDelegate;
            }

            var chkDelegate = new EventHandler(chk_CheckChanged);
            foreach (var ctrl in this.Controls)
            {
                var chkBox = ctrl as CheckBox;
                if (chkBox != null)
                    chkBox.CheckedChanged += chkDelegate;
            }

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
        }

        private void lnkWFV1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // loads CIW website for description of certification
            VisitLink("http://www.ciwcertified.com/certifications/web_foundations_series/associate.php", lnkWFV1);
        }

        // loads a link when label obj is clicked
        private void VisitLink(String url, LinkLabel lnk)
        {
            try
            {
                // opens up link in default web browser
                System.Diagnostics.Process.Start(url);
                lnk.LinkVisited = true;
            }
            catch
            {
                // displays error message if link doesn't open
                MessageBox.Show("Unable to open link from a partial-trust environment (such as a shared drive).");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpas = new ArrayList();
            try
            {
                GetScores();
            }
            catch
            {
                return;
            }

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

        private void txtWFV1_TextChanged(object sender, EventArgs e)
        {
            ValidationStart(lblWFV1val, txtWFV1, WFV1minScore, WFV1maxScore);
        }

        private void ValidationStart(Label lbl, TextBox txt, int min, int max)
        {
            // clear label of previous validation message
            lbl.Text = "";

            // validates entry if user has entered anything
            if (txt.Text.Length > 0)
            {
                Validate(min, max, lbl, txt);
            }
        }

        private void GetScores()
        {
            try
            {
                GetObjectiveScore(WFV1minScore, WFV1maxScore, txtWFV1, chkWFV1);
                GetObjectiveScore(AGC1minScore, AGC1maxScore, txtAGC1, chkAGC1);
                GetObjectiveScore(BBC1minScore, BBC1maxScore, txtBBC1, chkBBC1);
                GetObjectiveScore(CLC1minScore, CLC1maxScore, txtCLC1, chkCLC1);
                GetPerformanceScore(cmbLAE1);
                GetPerformanceScore(cmbLUT1);
                GetPerformanceScore(cmbQBT1);
                GetObjectiveScore(AXV1minScore, AXV1maxScore, txtAXV1, chkAXV1);
                GetObjectiveScore(CPV1minScore, CPV1maxScore, txtCPV1, chkCPV1);
                GetObjectiveScore(INC1minScore, INC1maxScore, txtINC1, chkINC1);
                GetPerformanceScore(cmbINT1);
                GetObjectiveScore(DFV1minScore, DFV1maxScore, txtDFV1, chkDFV1);
                GetObjectiveScore(CUV1minScore, CUV1maxScore, txtCUV1, chkCUV1);
                GetObjectiveScore(BVC1minScore, BVC1maxScore, txtBVC1, chkBVC1);
                GetObjectiveScore(GAC1minScore, GAC1maxScore, txtGAC1, chkGAC1);
            }
            catch
            {
                throw;
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

        private void GetObjectiveScore(int min, int max, TextBox txt, CheckBox chk)
        {
            try
            {
                if (chk.Checked)
                {
                    double percent = GetPercent(min, max, txt);
                    gpas.Add(PercentToGPA(percent));
                }
            }
            catch
            {
                throw;
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
                MessageBox.Show("Please enter a numeric value for " + txt.Name + ".");
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

        private void Validate(int minScore, int maxScore, Label lbl, TextBox txt)
        {
            // number to be parsed from text box
            int number;

            // if parse fails
            if (!int.TryParse(txt.Text, out number))
            {
                // validation message will appear
                lbl.Text = "Please enter a numeric value.";
            }
            else
            {
                if (number < minScore)
                {
                    lbl.Text = "Please enter a passing score.";
                }
                if (number > maxScore)
                {
                    lbl.Text = "Please enter a score less than or equal to " + maxScore + ".";
                }
            }
        }

        private void EnableDisable(CheckBox chk, TextBox txt)
        {
            if (chk.Checked)
                txt.Enabled = true;
            else
                txt.Enabled = false;
        }

        private void EnableDisable(CheckBox chk, ComboBox cmb)
        {
            if (chk.Checked)
                cmb.Enabled = true;
            else
                cmb.Enabled = false;
        }

        private void chk_CheckChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            String classcode = chk.Name.Substring(3);
            
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    var txtFound = ctrl as TextBox;
                    if (txtFound.Name.Equals("txt" + classcode))
                    {
                        EnableDisable(chk, txtFound);
                        break;
                    }
                }
                else if (ctrl is ComboBox)
                {
                    var cmbFound = ctrl as ComboBox;
                    if (cmbFound.Name.Equals("cmb" + classcode))
                    {
                        EnableDisable(chk, cmbFound);
                        break;
                    }
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            String classcode = txt.Name.Substring(3);
            String lbl = "lbl" + classcode;
            Label lblLookingFor = new Label();
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    Label lblfound = (Label) ctrl;
                    if (lblfound.Name.Equals("lbl" + classcode + "val"))
                        lblLookingFor = lblfound;
                }
            }
            int minScore = scoresDict[classcode + "minScore"];
            int maxScore = scoresDict[classcode + "maxScore"];

            ValidationStart(lblLookingFor, (TextBox)sender, minScore, maxScore);
        }

        private void lblAXV1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink("http://certification.comptia.org/Aplus", lblAXV1);
        }

        private void lblCPV1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink("http://certification.comptia.org/Aplus", lblCPV1);
        }
    }
}
