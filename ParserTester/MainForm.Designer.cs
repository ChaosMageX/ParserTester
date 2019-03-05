namespace ParserTester
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpNumStyles = new System.Windows.Forms.GroupBox();
            this.chkAllowHexSpec = new System.Windows.Forms.CheckBox();
            this.chkAllowCurSym = new System.Windows.Forms.CheckBox();
            this.chkAllowExponent = new System.Windows.Forms.CheckBox();
            this.chkAllowThousands = new System.Windows.Forms.CheckBox();
            this.chkAllowDecPoint = new System.Windows.Forms.CheckBox();
            this.chkAllowParentheses = new System.Windows.Forms.CheckBox();
            this.chkAllowTrailSign = new System.Windows.Forms.CheckBox();
            this.chkAllowLeadSign = new System.Windows.Forms.CheckBox();
            this.chkAllowTrailWhite = new System.Windows.Forms.CheckBox();
            this.chkAllowLeadWhite = new System.Windows.Forms.CheckBox();
            this.lblAttempt = new System.Windows.Forms.Label();
            this.txtAttempt = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTryParse = new System.Windows.Forms.Button();
            this.chkParseAsDec = new System.Windows.Forms.CheckBox();
            this.lblRegexPattern = new System.Windows.Forms.Label();
            this.txtRegexPattern = new System.Windows.Forms.TextBox();
            this.btnGenRegex = new System.Windows.Forms.Button();
            this.btnTryRegex = new System.Windows.Forms.Button();
            this.lblRegexResults = new System.Windows.Forms.Label();
            this.txtRegexResults = new System.Windows.Forms.TextBox();
            this.regexGroupBox = new System.Windows.Forms.GroupBox();
            this.regexSplitContainer = new System.Windows.Forms.SplitContainer();
            this.grpNumStyles.SuspendLayout();
            this.regexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regexSplitContainer)).BeginInit();
            this.regexSplitContainer.Panel1.SuspendLayout();
            this.regexSplitContainer.Panel2.SuspendLayout();
            this.regexSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNumStyles
            // 
            this.grpNumStyles.Controls.Add(this.chkAllowHexSpec);
            this.grpNumStyles.Controls.Add(this.chkAllowCurSym);
            this.grpNumStyles.Controls.Add(this.chkAllowExponent);
            this.grpNumStyles.Controls.Add(this.chkAllowThousands);
            this.grpNumStyles.Controls.Add(this.chkAllowDecPoint);
            this.grpNumStyles.Controls.Add(this.chkAllowParentheses);
            this.grpNumStyles.Controls.Add(this.chkAllowTrailSign);
            this.grpNumStyles.Controls.Add(this.chkAllowLeadSign);
            this.grpNumStyles.Controls.Add(this.chkAllowTrailWhite);
            this.grpNumStyles.Controls.Add(this.chkAllowLeadWhite);
            this.grpNumStyles.Location = new System.Drawing.Point(12, 12);
            this.grpNumStyles.Name = "grpNumStyles";
            this.grpNumStyles.Size = new System.Drawing.Size(300, 150);
            this.grpNumStyles.TabIndex = 0;
            this.grpNumStyles.TabStop = false;
            this.grpNumStyles.Text = "Number Styles";
            // 
            // chkAllowHexSpec
            // 
            this.chkAllowHexSpec.AutoSize = true;
            this.chkAllowHexSpec.Location = new System.Drawing.Point(157, 123);
            this.chkAllowHexSpec.Name = "chkAllowHexSpec";
            this.chkAllowHexSpec.Size = new System.Drawing.Size(117, 17);
            this.chkAllowHexSpec.TabIndex = 9;
            this.chkAllowHexSpec.Text = "Allow Hex Specifier";
            this.chkAllowHexSpec.UseVisualStyleBackColor = true;
            this.chkAllowHexSpec.CheckedChanged += new System.EventHandler(this.chkAllowHexSpec_CheckedChanged);
            // 
            // chkAllowCurSym
            // 
            this.chkAllowCurSym.AutoSize = true;
            this.chkAllowCurSym.Location = new System.Drawing.Point(17, 123);
            this.chkAllowCurSym.Name = "chkAllowCurSym";
            this.chkAllowCurSym.Size = new System.Drawing.Size(133, 17);
            this.chkAllowCurSym.TabIndex = 8;
            this.chkAllowCurSym.Text = "Allow Currency Symbol";
            this.chkAllowCurSym.UseVisualStyleBackColor = true;
            this.chkAllowCurSym.CheckedChanged += new System.EventHandler(this.chkAllowCurSym_CheckedChanged);
            // 
            // chkAllowExponent
            // 
            this.chkAllowExponent.AutoSize = true;
            this.chkAllowExponent.Location = new System.Drawing.Point(157, 99);
            this.chkAllowExponent.Name = "chkAllowExponent";
            this.chkAllowExponent.Size = new System.Drawing.Size(99, 17);
            this.chkAllowExponent.TabIndex = 7;
            this.chkAllowExponent.Text = "Allow Exponent";
            this.chkAllowExponent.UseVisualStyleBackColor = true;
            this.chkAllowExponent.CheckedChanged += new System.EventHandler(this.chkAllowExponent_CheckedChanged);
            // 
            // chkAllowThousands
            // 
            this.chkAllowThousands.AutoSize = true;
            this.chkAllowThousands.Location = new System.Drawing.Point(17, 99);
            this.chkAllowThousands.Name = "chkAllowThousands";
            this.chkAllowThousands.Size = new System.Drawing.Size(107, 17);
            this.chkAllowThousands.TabIndex = 6;
            this.chkAllowThousands.Text = "Allow Thousands";
            this.chkAllowThousands.UseVisualStyleBackColor = true;
            this.chkAllowThousands.CheckedChanged += new System.EventHandler(this.chkAllowThousands_CheckedChanged);
            // 
            // chkAllowDecPoint
            // 
            this.chkAllowDecPoint.AutoSize = true;
            this.chkAllowDecPoint.Location = new System.Drawing.Point(157, 75);
            this.chkAllowDecPoint.Name = "chkAllowDecPoint";
            this.chkAllowDecPoint.Size = new System.Drawing.Size(119, 17);
            this.chkAllowDecPoint.TabIndex = 5;
            this.chkAllowDecPoint.Text = "Allow Decimal Point";
            this.chkAllowDecPoint.UseVisualStyleBackColor = true;
            this.chkAllowDecPoint.CheckedChanged += new System.EventHandler(this.chkAllowDecPoint_CheckedChanged);
            // 
            // chkAllowParentheses
            // 
            this.chkAllowParentheses.AutoSize = true;
            this.chkAllowParentheses.Location = new System.Drawing.Point(17, 75);
            this.chkAllowParentheses.Name = "chkAllowParentheses";
            this.chkAllowParentheses.Size = new System.Drawing.Size(113, 17);
            this.chkAllowParentheses.TabIndex = 4;
            this.chkAllowParentheses.Text = "Allow Parentheses";
            this.chkAllowParentheses.UseVisualStyleBackColor = true;
            this.chkAllowParentheses.CheckedChanged += new System.EventHandler(this.chkAllowParentheses_CheckedChanged);
            // 
            // chkAllowTrailSign
            // 
            this.chkAllowTrailSign.AutoSize = true;
            this.chkAllowTrailSign.Location = new System.Drawing.Point(157, 51);
            this.chkAllowTrailSign.Name = "chkAllowTrailSign";
            this.chkAllowTrailSign.Size = new System.Drawing.Size(112, 17);
            this.chkAllowTrailSign.TabIndex = 3;
            this.chkAllowTrailSign.Text = "Allow Trailing Sign";
            this.chkAllowTrailSign.UseVisualStyleBackColor = true;
            this.chkAllowTrailSign.CheckedChanged += new System.EventHandler(this.chkAllowTrailSign_CheckedChanged);
            // 
            // chkAllowLeadSign
            // 
            this.chkAllowLeadSign.AutoSize = true;
            this.chkAllowLeadSign.Location = new System.Drawing.Point(17, 51);
            this.chkAllowLeadSign.Name = "chkAllowLeadSign";
            this.chkAllowLeadSign.Size = new System.Drawing.Size(116, 17);
            this.chkAllowLeadSign.TabIndex = 2;
            this.chkAllowLeadSign.Text = "Allow Leading Sign";
            this.chkAllowLeadSign.UseVisualStyleBackColor = true;
            this.chkAllowLeadSign.CheckedChanged += new System.EventHandler(this.chkAllowLeadSign_CheckedChanged);
            // 
            // chkAllowTrailWhite
            // 
            this.chkAllowTrailWhite.AutoSize = true;
            this.chkAllowTrailWhite.Location = new System.Drawing.Point(157, 27);
            this.chkAllowTrailWhite.Name = "chkAllowTrailWhite";
            this.chkAllowTrailWhite.Size = new System.Drawing.Size(119, 17);
            this.chkAllowTrailWhite.TabIndex = 1;
            this.chkAllowTrailWhite.Text = "Allow Trailing White";
            this.chkAllowTrailWhite.UseVisualStyleBackColor = true;
            this.chkAllowTrailWhite.CheckedChanged += new System.EventHandler(this.chkAllowTrailWhite_CheckedChanged);
            // 
            // chkAllowLeadWhite
            // 
            this.chkAllowLeadWhite.AutoSize = true;
            this.chkAllowLeadWhite.Location = new System.Drawing.Point(17, 27);
            this.chkAllowLeadWhite.Name = "chkAllowLeadWhite";
            this.chkAllowLeadWhite.Size = new System.Drawing.Size(123, 17);
            this.chkAllowLeadWhite.TabIndex = 0;
            this.chkAllowLeadWhite.Text = "Allow Leading White";
            this.chkAllowLeadWhite.UseVisualStyleBackColor = true;
            this.chkAllowLeadWhite.CheckedChanged += new System.EventHandler(this.chkAllowLeadWhite_CheckedChanged);
            // 
            // lblAttempt
            // 
            this.lblAttempt.AutoSize = true;
            this.lblAttempt.Location = new System.Drawing.Point(318, 30);
            this.lblAttempt.Name = "lblAttempt";
            this.lblAttempt.Size = new System.Drawing.Size(46, 13);
            this.lblAttempt.TabIndex = 1;
            this.lblAttempt.Text = "Attempt:";
            // 
            // txtAttempt
            // 
            this.txtAttempt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAttempt.Location = new System.Drawing.Point(370, 27);
            this.txtAttempt.Name = "txtAttempt";
            this.txtAttempt.Size = new System.Drawing.Size(302, 20);
            this.txtAttempt.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(318, 57);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(370, 54);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(302, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btnTryParse
            // 
            this.btnTryParse.Location = new System.Drawing.Point(12, 176);
            this.btnTryParse.Name = "btnTryParse";
            this.btnTryParse.Size = new System.Drawing.Size(75, 23);
            this.btnTryParse.TabIndex = 5;
            this.btnTryParse.Text = "Try Parse";
            this.btnTryParse.UseVisualStyleBackColor = true;
            this.btnTryParse.Click += new System.EventHandler(this.btnTryParse_Click);
            // 
            // chkParseAsDec
            // 
            this.chkParseAsDec.AutoSize = true;
            this.chkParseAsDec.Checked = true;
            this.chkParseAsDec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkParseAsDec.Location = new System.Drawing.Point(93, 180);
            this.chkParseAsDec.Name = "chkParseAsDec";
            this.chkParseAsDec.Size = new System.Drawing.Size(109, 17);
            this.chkParseAsDec.TabIndex = 6;
            this.chkParseAsDec.Text = "Parse As Decimal";
            this.chkParseAsDec.UseVisualStyleBackColor = true;
            // 
            // lblRegexPattern
            // 
            this.lblRegexPattern.AutoSize = true;
            this.lblRegexPattern.Location = new System.Drawing.Point(3, 7);
            this.lblRegexPattern.Name = "lblRegexPattern";
            this.lblRegexPattern.Size = new System.Drawing.Size(44, 13);
            this.lblRegexPattern.TabIndex = 7;
            this.lblRegexPattern.Text = "Pattern:";
            // 
            // txtRegexPattern
            // 
            this.txtRegexPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegexPattern.Location = new System.Drawing.Point(53, 4);
            this.txtRegexPattern.Multiline = true;
            this.txtRegexPattern.Name = "txtRegexPattern";
            this.txtRegexPattern.Size = new System.Drawing.Size(289, 53);
            this.txtRegexPattern.TabIndex = 8;
            // 
            // btnGenRegex
            // 
            this.btnGenRegex.Location = new System.Drawing.Point(93, 205);
            this.btnGenRegex.Name = "btnGenRegex";
            this.btnGenRegex.Size = new System.Drawing.Size(106, 23);
            this.btnGenRegex.TabIndex = 9;
            this.btnGenRegex.Text = "Generate Regex";
            this.btnGenRegex.UseVisualStyleBackColor = true;
            this.btnGenRegex.Click += new System.EventHandler(this.btnGenRegex_Click);
            // 
            // btnTryRegex
            // 
            this.btnTryRegex.Location = new System.Drawing.Point(12, 205);
            this.btnTryRegex.Name = "btnTryRegex";
            this.btnTryRegex.Size = new System.Drawing.Size(75, 23);
            this.btnTryRegex.TabIndex = 10;
            this.btnTryRegex.Text = "Try Regex";
            this.btnTryRegex.UseVisualStyleBackColor = true;
            this.btnTryRegex.Click += new System.EventHandler(this.btnTryRegex_Click);
            // 
            // lblRegexResults
            // 
            this.lblRegexResults.AutoSize = true;
            this.lblRegexResults.Location = new System.Drawing.Point(3, 5);
            this.lblRegexResults.Name = "lblRegexResults";
            this.lblRegexResults.Size = new System.Drawing.Size(45, 13);
            this.lblRegexResults.TabIndex = 12;
            this.lblRegexResults.Text = "Results:";
            // 
            // txtRegexResults
            // 
            this.txtRegexResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegexResults.Location = new System.Drawing.Point(53, 5);
            this.txtRegexResults.Multiline = true;
            this.txtRegexResults.Name = "txtRegexResults";
            this.txtRegexResults.ReadOnly = true;
            this.txtRegexResults.Size = new System.Drawing.Size(289, 49);
            this.txtRegexResults.TabIndex = 13;
            // 
            // regexGroupBox
            // 
            this.regexGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regexGroupBox.Controls.Add(this.regexSplitContainer);
            this.regexGroupBox.Location = new System.Drawing.Point(321, 80);
            this.regexGroupBox.Name = "regexGroupBox";
            this.regexGroupBox.Size = new System.Drawing.Size(351, 141);
            this.regexGroupBox.TabIndex = 14;
            this.regexGroupBox.TabStop = false;
            this.regexGroupBox.Text = "Regex";
            // 
            // regexSplitContainer
            // 
            this.regexSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regexSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.regexSplitContainer.Name = "regexSplitContainer";
            this.regexSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // regexSplitContainer.Panel1
            // 
            this.regexSplitContainer.Panel1.Controls.Add(this.lblRegexPattern);
            this.regexSplitContainer.Panel1.Controls.Add(this.txtRegexPattern);
            // 
            // regexSplitContainer.Panel2
            // 
            this.regexSplitContainer.Panel2.Controls.Add(this.lblRegexResults);
            this.regexSplitContainer.Panel2.Controls.Add(this.txtRegexResults);
            this.regexSplitContainer.Size = new System.Drawing.Size(345, 122);
            this.regexSplitContainer.SplitterDistance = 61;
            this.regexSplitContainer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 236);
            this.Controls.Add(this.regexGroupBox);
            this.Controls.Add(this.btnTryRegex);
            this.Controls.Add(this.btnGenRegex);
            this.Controls.Add(this.chkParseAsDec);
            this.Controls.Add(this.btnTryParse);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtAttempt);
            this.Controls.Add(this.lblAttempt);
            this.Controls.Add(this.grpNumStyles);
            this.MinimumSize = new System.Drawing.Size(700, 275);
            this.Name = "MainForm";
            this.Text = "Parser Tester";
            this.grpNumStyles.ResumeLayout(false);
            this.grpNumStyles.PerformLayout();
            this.regexGroupBox.ResumeLayout(false);
            this.regexSplitContainer.Panel1.ResumeLayout(false);
            this.regexSplitContainer.Panel1.PerformLayout();
            this.regexSplitContainer.Panel2.ResumeLayout(false);
            this.regexSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regexSplitContainer)).EndInit();
            this.regexSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNumStyles;
        private System.Windows.Forms.CheckBox chkAllowLeadWhite;
        private System.Windows.Forms.CheckBox chkAllowTrailWhite;
        private System.Windows.Forms.CheckBox chkAllowTrailSign;
        private System.Windows.Forms.CheckBox chkAllowLeadSign;
        private System.Windows.Forms.CheckBox chkAllowParentheses;
        private System.Windows.Forms.CheckBox chkAllowHexSpec;
        private System.Windows.Forms.CheckBox chkAllowCurSym;
        private System.Windows.Forms.CheckBox chkAllowExponent;
        private System.Windows.Forms.CheckBox chkAllowThousands;
        private System.Windows.Forms.CheckBox chkAllowDecPoint;
        private System.Windows.Forms.Label lblAttempt;
        private System.Windows.Forms.TextBox txtAttempt;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTryParse;
        private System.Windows.Forms.CheckBox chkParseAsDec;
        private System.Windows.Forms.Label lblRegexPattern;
        private System.Windows.Forms.TextBox txtRegexPattern;
        private System.Windows.Forms.Button btnGenRegex;
        private System.Windows.Forms.Button btnTryRegex;
        private System.Windows.Forms.Label lblRegexResults;
        private System.Windows.Forms.TextBox txtRegexResults;
        private System.Windows.Forms.GroupBox regexGroupBox;
        private System.Windows.Forms.SplitContainer regexSplitContainer;
    }
}

