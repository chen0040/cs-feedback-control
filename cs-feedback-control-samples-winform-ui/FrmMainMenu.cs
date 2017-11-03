﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedbackControl.Fuzzy;
using FeedbackControl.Fuzzy.Memberships;
using FeedbackControl.PID.AnalyzeGUI;

namespace FeedbackControl.AnalyzeGUI
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnPID_Click(object sender, EventArgs e)
        {
            FrmAnalyzer frm = new FrmAnalyzer();
            frm.ShowDialog();
        }

        private void btnFuzzy_Click(object sender, EventArgs e)
        {
            RuleInferenceEngine rie = new RuleInferenceEngine();

            FuzzySet output = new FuzzySet("Output", -100, 100, 1);
            output.AddMembership("Cooling", new FuzzyReverseGrade(-50, 0));
            output.AddMembership("Zero", new FuzzyTriangle(-50, 0, 50));
            output.AddMembership("Heating", new FuzzyGrade(0, 50));
            rie.AddFuzzySet(output.Name, output);

            FuzzySet tempError = new FuzzySet("Temperature Error", -4, 4, 0.05);
            tempError.AddMembership("Negative", new FuzzyReverseGrade(-2, 0));
            tempError.AddMembership("Zero", new FuzzyTriangle(-2, 0, 2));
            tempError.AddMembership("Positive", new FuzzyGrade(0, 2));
            rie.AddFuzzySet(tempError.Name, tempError);


            FuzzySet tempErrorDot = new FuzzySet("Temperature Error", -10, 10, 0.1);
            tempErrorDot.AddMembership("Negative", new FuzzyReverseGrade(-5, 0));
            tempErrorDot.AddMembership("Zero", new FuzzyTriangle(-5, 0, 5));
            tempErrorDot.AddMembership("Positive", new FuzzyGrade(0, 5));
            rie.AddFuzzySet(tempErrorDot.Name, tempErrorDot);

            /*
		    1. If (e < 0) AND (er < 0) then Cool 0.5 & 0.0 = 0.0
		    2. If (e = 0) AND (er < 0) then Heat 0.5 & 0.0 = 0.0
		    3. If (e > 0) AND (er < 0) then Heat 0.0 & 0.0 = 0.0
		    4. If (e < 0) AND (er = 0) then Cool 0.5 & 0.5 = 0.5
		    5. If (e = 0) AND (er = 0) then No_Chng 0.5 & 0.5 = 0.5
		    6. If (e > 0) AND (er = 0) then Heat 0.0 & 0.5 = 0.0
		    7. If (e < 0) AND (er > 0) then Cool 0.5 & 0.5 = 0.5
		    8. If (e = 0) AND (er > 0) then Cool 0.5 & 0.5 = 0.5
		    9. If (e > 0) AND (er > 0) then Heat 0.0 & 0.5 = 0.0
		    */

            Rule rule = new Rule("Rule 1");
            rule.AddAntecedent(new Clause(tempError, "Is", "Negative"));
            rule.AddAntecedent(new Clause(tempErrorDot, "Is", "Negative"));
            rule.Consequent = new Clause(output, "Is", "Cooling");
            rie.AddRule(rule);

            rule = new Rule("Rule 2");
            rule.AddAntecedent(new Clause(tempError, "Is", "Zero"));
            rule.AddAntecedent(new Clause(tempErrorDot, "Is", "Negative"));
            rule.Consequent = new Clause(output, "Is", "Heating");
            rie.AddRule(rule);

            rule = new Fuzzy.Rule("Rule 3");
            rule.AddAntecedent(new Clause(tempError, "Is", "Positive"));
            rule.AddAntecedent(new Clause(tempErrorDot, "Is", "Negative"));
            rule.Consequent = new Clause(output, "Is", "Heating");
            rie.AddRule(rule);

            rule = new Rule("Rule 4");
            rule.AddAntecedent(new Clause(tempError, "Is", "Negative"));
            rule.AddAntecedent(new Clause(tempErrorDot, "Is", "Zero"));
            rule.Consequent = new Clause(output, "Is", "Cooling");
            rie.AddRule(rule);

            rule = new Rule("Rule 5");
            rule.AddAntecedent(new Clause(tempError, "Is", "Zero"));
            rule.AddAntecedent(new Clause(tempErrorDot, "Is", "Zero"));
            rule.Consequent = new Clause(output, "Is", "Zero");
            rie.AddRule(rule);

            rule = new Rule("Rule 6");
            rule.AddAntecedent(new Clause(tempError, "Is", "Positive"));
            rule.AddAntecedent(new Clause(tempErrorDot, "Is", "Zero"));
            rule.Consequent = new Clause(output, "Is", "Heating");
            rie.AddRule(rule);

            rule = new Rule("Rule 7");
            rule.AddAntecedent(new Clause(tempError, "Is", "Negative"));
            rule.AddAntecedent(new Clause(tempErrorDot, "Is", "Positive"));
            rule.Consequent = new Clause(output, "Is", "Cooling");
            rie.AddRule(rule);

            rule = new Rule("Rule 8");
            rule.AddAntecedent(new Clause(tempError, "Is", "Zero"));
            rule.AddAntecedent(new Clause(tempErrorDot, "Is", "Positive"));
            rule.Consequent = new Clause(output, "Is", "Cooling");
            rie.AddRule(rule);

            rule = new Rule("Rule 9");
            rule.AddAntecedent(new Clause(tempError, "Is", "Positive"));
            rule.AddAntecedent(new Clause(tempErrorDot, "Is", "Positive"));
            rule.Consequent = new Clause(output, "Is", "Heating");
            rie.AddRule(rule);

            tempError.X = -1.0;
            Console.WriteLine("For Temperature Error: {0}", tempError.X);
            Console.WriteLine("Negative: " + tempError.GetMembership("Negative").degree(-1.0));
            Console.WriteLine("Zero: " + tempError.GetMembership("Zero").degree(-1.0));
            Console.WriteLine("Positive: " + tempError.GetMembership("Positive").degree(-1.0));

            tempErrorDot.X = 2.5;
            Console.WriteLine("For Temperature Error Dot: {0}", tempErrorDot.X);
            Console.WriteLine("Negative: " + tempErrorDot.GetMembership("Negative").degree(2.5));
            Console.WriteLine("Zero: " + tempErrorDot.GetMembership("Zero").degree(2.5));
            Console.WriteLine("Positive: " + tempErrorDot.GetMembership("Positive").degree(2.5));

            rie.Infer(output);

            Console.WriteLine("output: " + output.X);



            FrmFuzzySet tempCanvas = new FrmFuzzySet("Output", output);
            FrmFuzzySet tempErrorCanvas = new FrmFuzzySet("Temp Error", tempError);
            FrmFuzzySet tempErrorDotCanvas = new FrmFuzzySet("Temp Error Dot", tempErrorDot);

            tempCanvas.Show();
            tempErrorCanvas.Show();
            tempErrorDotCanvas.Show();
        }
    }
}
