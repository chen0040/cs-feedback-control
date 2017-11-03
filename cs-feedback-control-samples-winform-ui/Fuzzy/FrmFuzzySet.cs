using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FeedbackControl.Fuzzy
{
    public partial class FrmFuzzySet : Form
    {
        public FrmFuzzySet()
        {
            InitializeComponent();
        }

        private FuzzySet mFuzzySet = null;
        private string mFuzzySetName;

        public FrmFuzzySet(string name, FuzzySet fuzzy_set)
        {
            InitializeComponent();
            mFuzzySetName = name;
            mFuzzySet = fuzzy_set;
            mFuzzySetView.FuzzySet = fuzzy_set;
            mFuzzySetView.FuzzySetName = name;
            Text = name;
        }
    }
}
