﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserTester
{
    public partial class MainForm : Form
    {
        private NumberStyles mNumStyles = NumberStyles.None;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Number Styles Check Boxes
        private void chkAllowLeadWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowLeadWhite.Checked)
                mNumStyles |= NumberStyles.AllowLeadingWhite;
            else
                mNumStyles &= ~NumberStyles.AllowLeadingWhite;
        }

        private void chkAllowTrailWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowTrailWhite.Checked)
                mNumStyles |= NumberStyles.AllowTrailingWhite;
            else
                mNumStyles &= ~NumberStyles.AllowTrailingWhite;
        }

        private void chkAllowLeadSign_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowLeadSign.Checked)
                mNumStyles |= NumberStyles.AllowLeadingSign;
            else
                mNumStyles &= ~NumberStyles.AllowLeadingSign;
        }

        private void chkAllowTrailSign_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowTrailSign.Checked)
                mNumStyles |= NumberStyles.AllowTrailingSign;
            else
                mNumStyles &= ~NumberStyles.AllowTrailingSign;
        }

        private void chkAllowParentheses_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowParentheses.Checked)
                mNumStyles |= NumberStyles.AllowParentheses;
            else
                mNumStyles &= ~NumberStyles.AllowParentheses;
        }

        private void chkAllowDecPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowDecPoint.Checked)
                mNumStyles |= NumberStyles.AllowDecimalPoint;
            else
                mNumStyles &= ~NumberStyles.AllowDecimalPoint;
        }

        private void chkAllowThousands_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowThousands.Checked)
                mNumStyles |= NumberStyles.AllowThousands;
            else
                mNumStyles &= ~NumberStyles.AllowThousands;
        }

        private void chkAllowExponent_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowExponent.Checked)
                mNumStyles |= NumberStyles.AllowExponent;
            else
                mNumStyles &= ~NumberStyles.AllowExponent;
        }

        private void chkAllowCurSym_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowCurSym.Checked)
                mNumStyles |= NumberStyles.AllowCurrencySymbol;
            else
                mNumStyles &= ~NumberStyles.AllowCurrencySymbol;
        }

        private void chkAllowHexSpec_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllowHexSpec.Checked)
                mNumStyles |= NumberStyles.AllowHexSpecifier;
            else
                mNumStyles &= ~NumberStyles.AllowHexSpecifier;
        }
        #endregion

        private void btnTryParse_Click(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            string numStr = txtAttempt.Text;
            decimal result;
            if (decimal.TryParse(numStr, mNumStyles, cultureInfo, out result))
            {
                txtResult.Text = result.ToString(cultureInfo);
            }
            else
            {
                txtResult.Text = "NaN";
            }
        }
    }
}