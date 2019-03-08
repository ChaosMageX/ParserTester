using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            {
                mNumStyles |= NumberStyles.AllowHexSpecifier;
                chkAllowLeadSign.Enabled = false;
                chkAllowTrailSign.Enabled = false;
                chkAllowParentheses.Enabled = false;
                chkAllowDecPoint.Enabled = false;
                chkAllowThousands.Enabled = false;
                chkAllowExponent.Enabled = false;
                chkAllowCurSym.Enabled = false;
            }
            else
            {
                mNumStyles &= ~NumberStyles.AllowHexSpecifier;
                chkAllowLeadSign.Enabled = true;
                chkAllowTrailSign.Enabled = true;
                chkAllowParentheses.Enabled = true;
                chkAllowDecPoint.Enabled = true;
                chkAllowThousands.Enabled = true;
                chkAllowExponent.Enabled = true;
                chkAllowCurSym.Enabled = true;
            }
        }
        #endregion

        private void btnTryParse_Click(object sender, EventArgs e)
        {
            txtResult.Text = Parse(txtAttempt.Text);
        }

        private string Parse(string text)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            if ((mNumStyles & NumberStyles.AllowHexSpecifier) == NumberStyles.None)
            {
                if (chkParseAsDec.Checked)
                {
                    decimal result;
                    if (decimal.TryParse(text, mNumStyles, cultureInfo, out result))
                        return result.ToString(cultureInfo);
                    else
                        return "NaN";
                }
                else
                {
                    double result;
                    if (double.TryParse(text, mNumStyles, cultureInfo, out result))
                        return result.ToString(cultureInfo);
                    else
                        return "NaN";
                }
            }
            else
            {
                NumberStyles numStyles = NumberStyles.AllowHexSpecifier;
                if (chkAllowLeadWhite.Checked)
                    numStyles |= NumberStyles.AllowLeadingWhite;
                if (chkAllowTrailWhite.Checked)
                    numStyles |= NumberStyles.AllowTrailingWhite;

                ulong result;
                if (ulong.TryParse(text, numStyles, cultureInfo, out result))
                    return result.ToString(cultureInfo);
                else
                    return "NaN";
            }
        }

        private void btnGenRegex_Click(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            txtRegexPattern.Text = GenerateNumberRegex(
                mNumStyles, cultureInfo, chkReadableRegex.Checked);
        }

        /// <summary>
        /// Generates a regular expression pattern string 
        /// that can be used to find numbers in strings 
        /// which are parseable with the given 
        /// number <paramref name="style"/> flags 
        /// and format <paramref name="provider"/>.
        /// </summary>
        /// <param name="style">
        /// The same <see cref="NumberStyles"/> flags 
        /// that will be used to parse numbers found 
        /// with the generated regular expression pattern.
        /// </param>
        /// <param name="provider">
        /// The same <see cref="IFormatProvider"/> instance 
        /// that will be used to parse numbers found 
        /// with the generated regular expression pattern.
        /// </param>
        /// <param name="humanReadable">
        /// Determines whether the generated regular expression 
        /// pattern is made human readable with multiple lines 
        /// and comments on each line to explain the function 
        /// of various parts of the generated pattern.
        /// </param>
        /// <returns>
        /// A regular expression pattern string that can be 
        /// used to extract parseable numbers from strings.
        /// </returns>
        /// <remarks>
        /// Note that if the <paramref name="humanReadable"/> parameter 
        /// is set to <see langword="true"/>, you will have to use 
        /// the <see cref="RegexOptions.IgnorePatternWhitespace"/> flag 
        /// in order to actually use the generated regular expression 
        /// pattern string in a <see cref="Regex"/> instance.
        /// </remarks>
        public static string GenerateNumberRegex(
            NumberStyles style, IFormatProvider provider, 
            bool humanReadable = false)
        {
            const NumberStyles cHasLeadingSign
                = NumberStyles.AllowLeadingSign
                | NumberStyles.AllowParentheses;
            const NumberStyles cHasTrailingSign
                = NumberStyles.AllowTrailingSign
                | NumberStyles.AllowParentheses;

            int len = 0;
            StringBuilder regexSB = new StringBuilder();
            if ((style & NumberStyles.AllowHexSpecifier) 
                != NumberStyles.None)
            {
                regexSB.Append("[0-9a-fA-F]+");
                if (humanReadable)
                    regexSB.Append(" # Find Allowable Hex Numbers");
                return regexSB.ToString();
            }
            NumberFormatInfo nfi = NumberFormatInfo.GetInstance(provider);
            string sign = Regex.Escape(nfi.NegativeSign)
                        + Regex.Escape(nfi.PositiveSign);
            string decSep = Regex.Escape(nfi.NumberDecimalSeparator);
            string grpSep = Regex.Escape(nfi.NumberGroupSeparator);
            string curSym = null;
            if ((style & NumberStyles.AllowCurrencySymbol) 
                != NumberStyles.None)
            {
                decSep += Regex.Escape(nfi.CurrencyDecimalSeparator);
                grpSep += Regex.Escape(nfi.CurrencyGroupSeparator);
                curSym = Regex.Escape(nfi.CurrencySymbol);
            }
            
            if (curSym != null)
            {
                len = regexSB.Length;
                regexSB.Append("(?<cur>");
                regexSB.Append(curSym);
                regexSB.Append(")?");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.AppendLine("# Find currency symbol");
                }
            }

            if ((style & NumberStyles.AllowLeadingSign) 
                != NumberStyles.None)
            {
                len = regexSB.Length;
                regexSB.Append("(?:(?<sgn>[");
                regexSB.Append(sign);
                regexSB.Append("])");
                if ((style & NumberStyles.AllowParentheses) 
                    != NumberStyles.None)
                    regexSB.Append("|(?<par>\\()");
                regexSB.Append(")?");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.Append("# Find leading sign");
                    if ((style & NumberStyles.AllowParentheses) 
                        != NumberStyles.None)
                        regexSB.Append(" and opening parenthesis");
                    regexSB.AppendLine();
                }
            }
            else if ((style & NumberStyles.AllowParentheses) 
                     != NumberStyles.None)
            {
                len = regexSB.Length;
                regexSB.Append("(?<par>\\()?");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.AppendLine("# Find opening parenthesis");
                }
            }

            if (curSym != null && 
                (style & cHasLeadingSign) != NumberStyles.None)
            {
                len = regexSB.Length;
                regexSB.Append("(?(");
                regexSB.Append(curSym);
                regexSB.Append(")(?(cur)(?!)|(?<cur>");
                regexSB.Append(curSym);
                regexSB.Append(")))");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.Append("# Find currency symbol");
                    regexSB.AppendLine("; Fail if already found");
                }
            }

            len = regexSB.Length;
            regexSB.Append("(?<num>");

            /*if (humanReadable)
            {
                regexSB.Append(' ', len + 45 - regexSB.Length);
                regexSB.AppendLine("# Begin finding numeric part");
            }/* */

            len = regexSB.Length;
            if ((style & NumberStyles.AllowThousands) 
                != NumberStyles.None)
            {
                if ((style & NumberStyles.AllowDecimalPoint) 
                    != NumberStyles.None)
                {
                    regexSB.Append("(?:[0-9]+[0-9");
                    regexSB.Append(grpSep);
                    regexSB.Append("]*)?[");
                    regexSB.Append(decSep);
                    regexSB.Append("]?[0-9]+");
                }
                else
                {
                    regexSB.Append("[0-9]+[0-9");
                    regexSB.Append(grpSep);
                    regexSB.Append("]*");
                }
            }
            else if ((style & NumberStyles.AllowDecimalPoint) 
                     != NumberStyles.None)
            {
                regexSB.Append("[0-9]*[");
                regexSB.Append(decSep);
                regexSB.Append("]?[0-9]+");
            }
            else
            {
                regexSB.Append("[0-9]+");
            }
            if (humanReadable)
            {
                regexSB.Append(' ', len + 45 - regexSB.Length);
                regexSB.Append("# Find number");
                if ((style & NumberStyles.AllowDecimalPoint) 
                    != NumberStyles.None)
                    regexSB.Append(" with decimal");
                regexSB.AppendLine();
            }

            if ((style & NumberStyles.AllowExponent) 
                != NumberStyles.None)
            {
                len = regexSB.Length;
                regexSB.Append("(?:[eE][");
                regexSB.Append(sign);
                regexSB.Append("]?[0-9]+)?");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.AppendLine("# Find exponent");
                }
            }

            len = regexSB.Length;
            regexSB.Append(")");

            /*if (humanReadable)
            {
                regexSB.Append(' ', len + 45 - regexSB.Length);
                regexSB.AppendLine("# End finding numeric part");
            }/* */
            
            if (curSym != null)
            {
                len = regexSB.Length;
                regexSB.Append("(?(");
                regexSB.Append(curSym);
                regexSB.Append(")(?(cur)(?!)|(?<cur>");
                regexSB.Append(curSym);
                regexSB.Append(")))");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.Append("# Find currency symbol");
                    regexSB.AppendLine("; Fail if already found");
                }
            }

            if ((style & NumberStyles.AllowTrailingSign) 
                != NumberStyles.None)
            {
                len = regexSB.Length;
                regexSB.Append("(?:");
                if ((style & NumberStyles.AllowLeadingSign) 
                    != NumberStyles.None)
                {
                    regexSB.Append("(?(sgn)(?!)|(?<sgn>[");
                    regexSB.Append(sign);
                    regexSB.Append("]))");
                }
                else
                {
                    regexSB.Append("(?<sgn>[");
                    regexSB.Append(sign);
                    regexSB.Append("])");
                }
                if ((style & NumberStyles.AllowParentheses) 
                    != NumberStyles.None)
                    regexSB.Append("|(?<-par>\\))");
                regexSB.Append(")?");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.Append("# Find trailing sign");
                    if ((style & NumberStyles.AllowParentheses) 
                        != NumberStyles.None)
                        regexSB.Append(" and closing parenthesis");
                    regexSB.AppendLine();
                }
            }
            else if ((style & NumberStyles.AllowParentheses) 
                     != NumberStyles.None)
            {
                len = regexSB.Length;
                regexSB.Append("(?<-par>\\))?");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.AppendLine("# Find closing parenthesis");
                }
            }

            if (curSym != null && 
                (style & cHasTrailingSign) != NumberStyles.None)
            {
                len = regexSB.Length;
                regexSB.Append("(?(");
                regexSB.Append(curSym);
                regexSB.Append(")(?(cur)(?!)|(?<cur>");
                regexSB.Append(curSym);
                regexSB.Append(")))");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.Append("# Find currency symbol");
                    regexSB.AppendLine("; Fail if already found");
                }
            }

            if ((style & NumberStyles.AllowParentheses) 
                != NumberStyles.None)
            {
                len = regexSB.Length;
                regexSB.Append("(?(par)(?!))");

                if (humanReadable)
                {
                    regexSB.Append(' ', len + 45 - regexSB.Length);
                    regexSB.AppendLine(
                        "# Fail if parentheses isn't closed");
                }
            }

            return regexSB.ToString();
        }

        private void btnTryRegex_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(txtRegexPattern.Text, 
                RegexOptions.IgnorePatternWhitespace);
            MatchCollection matches = regex.Matches(txtAttempt.Text, 0);
            StringBuilder sb = new StringBuilder();
            foreach (Match match in matches)
            {
                sb.Append("Match \"");
                sb.Append(match.Name);
                sb.Append("\": Index: ");
                sb.Append(match.Index);
                sb.Append(" Length: ");
                sb.Append(match.Length);
                sb.Append(" Value: ");
                sb.Append(match.Value);
                sb.Append(" Parsed: ");
                sb.AppendLine(Parse(match.Value));
                foreach (Group group in match.Groups)
                {
                    sb.Append("  Group \"");
                    sb.Append(group.Name);
                    sb.Append("\": Index: ");
                    sb.Append(group.Index);
                    sb.Append(" Length: ");
                    sb.Append(group.Length);
                    sb.Append(" Value: ");
                    sb.AppendLine(group.Value);
                    foreach (Capture capture in group.Captures)
                    {
                        sb.Append("    Capture ");
                        sb.Append(capture.Index);
                        sb.Append(": Length: ");
                        sb.Append(capture.Length);
                        sb.Append(" Value: ");
                        sb.AppendLine(capture.Value);
                    }
                }
            }
            txtRegexResults.Text = sb.ToString();
        }
    }
}
