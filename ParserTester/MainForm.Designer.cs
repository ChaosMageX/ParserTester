﻿namespace ParserTester
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
            this.chkReadableRegex = new System.Windows.Forms.CheckBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.chkIncludeNaNs = new System.Windows.Forms.CheckBox();
            this.grpNumStyles.SuspendLayout();
            this.regexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regexSplitContainer)).BeginInit();
            this.regexSplitContainer.Panel1.SuspendLayout();
            this.regexSplitContainer.Panel2.SuspendLayout();
            this.regexSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
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
            this.grpNumStyles.Location = new System.Drawing.Point(3, 3);
            this.grpNumStyles.Name = "grpNumStyles";
            this.grpNumStyles.Size = new System.Drawing.Size(285, 150);
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
            this.lblAttempt.Location = new System.Drawing.Point(3, 162);
            this.lblAttempt.Name = "lblAttempt";
            this.lblAttempt.Size = new System.Drawing.Size(46, 13);
            this.lblAttempt.TabIndex = 1;
            this.lblAttempt.Text = "Attempt:";
            // 
            // txtAttempt
            // 
            this.txtAttempt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAttempt.Location = new System.Drawing.Point(55, 159);
            this.txtAttempt.Multiline = true;
            this.txtAttempt.Name = "txtAttempt";
            this.txtAttempt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAttempt.Size = new System.Drawing.Size(237, 112);
            this.txtAttempt.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 280);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(55, 277);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(237, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btnTryParse
            // 
            this.btnTryParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTryParse.Location = new System.Drawing.Point(6, 303);
            this.btnTryParse.Name = "btnTryParse";
            this.btnTryParse.Size = new System.Drawing.Size(75, 23);
            this.btnTryParse.TabIndex = 5;
            this.btnTryParse.Text = "Try Parse";
            this.btnTryParse.UseVisualStyleBackColor = true;
            this.btnTryParse.Click += new System.EventHandler(this.btnTryParse_Click);
            // 
            // chkParseAsDec
            // 
            this.chkParseAsDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkParseAsDec.AutoSize = true;
            this.chkParseAsDec.Checked = true;
            this.chkParseAsDec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkParseAsDec.Location = new System.Drawing.Point(87, 307);
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
            this.txtRegexPattern.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegexPattern.Location = new System.Drawing.Point(53, 4);
            this.txtRegexPattern.Multiline = true;
            this.txtRegexPattern.Name = "txtRegexPattern";
            this.txtRegexPattern.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegexPattern.Size = new System.Drawing.Size(417, 160);
            this.txtRegexPattern.TabIndex = 8;
            // 
            // btnGenRegex
            // 
            this.btnGenRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenRegex.Location = new System.Drawing.Point(87, 332);
            this.btnGenRegex.Name = "btnGenRegex";
            this.btnGenRegex.Size = new System.Drawing.Size(106, 23);
            this.btnGenRegex.TabIndex = 9;
            this.btnGenRegex.Text = "Generate Regex";
            this.btnGenRegex.UseVisualStyleBackColor = true;
            this.btnGenRegex.Click += new System.EventHandler(this.btnGenRegex_Click);
            // 
            // btnTryRegex
            // 
            this.btnTryRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTryRegex.Location = new System.Drawing.Point(6, 332);
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
            this.txtRegexResults.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegexResults.Location = new System.Drawing.Point(53, 5);
            this.txtRegexResults.Multiline = true;
            this.txtRegexResults.Name = "txtRegexResults";
            this.txtRegexResults.ReadOnly = true;
            this.txtRegexResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegexResults.Size = new System.Drawing.Size(417, 156);
            this.txtRegexResults.TabIndex = 13;
            // 
            // regexGroupBox
            // 
            this.regexGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regexGroupBox.Controls.Add(this.regexSplitContainer);
            this.regexGroupBox.Location = new System.Drawing.Point(3, 3);
            this.regexGroupBox.Name = "regexGroupBox";
            this.regexGroupBox.Size = new System.Drawing.Size(479, 355);
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
            this.regexSplitContainer.Size = new System.Drawing.Size(473, 336);
            this.regexSplitContainer.SplitterDistance = 168;
            this.regexSplitContainer.TabIndex = 0;
            // 
            // chkReadableRegex
            // 
            this.chkReadableRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkReadableRegex.AutoSize = true;
            this.chkReadableRegex.Location = new System.Drawing.Point(200, 335);
            this.chkReadableRegex.Name = "chkReadableRegex";
            this.chkReadableRegex.Size = new System.Drawing.Size(72, 17);
            this.chkReadableRegex.TabIndex = 15;
            this.chkReadableRegex.Text = "Readable";
            this.chkReadableRegex.UseVisualStyleBackColor = true;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.chkIncludeNaNs);
            this.mainSplitContainer.Panel1.Controls.Add(this.grpNumStyles);
            this.mainSplitContainer.Panel1.Controls.Add(this.lblResult);
            this.mainSplitContainer.Panel1.Controls.Add(this.txtResult);
            this.mainSplitContainer.Panel1.Controls.Add(this.chkParseAsDec);
            this.mainSplitContainer.Panel1.Controls.Add(this.chkReadableRegex);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnTryParse);
            this.mainSplitContainer.Panel1.Controls.Add(this.txtAttempt);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnGenRegex);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnTryRegex);
            this.mainSplitContainer.Panel1.Controls.Add(this.lblAttempt);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.regexGroupBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 361);
            this.mainSplitContainer.SplitterDistance = 295;
            this.mainSplitContainer.TabIndex = 16;
            // 
            // chkIncludeNaNs
            // 
            this.chkIncludeNaNs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkIncludeNaNs.AutoSize = true;
            this.chkIncludeNaNs.Location = new System.Drawing.Point(200, 307);
            this.chkIncludeNaNs.Name = "chkIncludeNaNs";
            this.chkIncludeNaNs.Size = new System.Drawing.Size(91, 17);
            this.chkIncludeNaNs.TabIndex = 16;
            this.chkIncludeNaNs.Text = "Include NaNs";
            this.chkIncludeNaNs.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.mainSplitContainer);
            this.MinimumSize = new System.Drawing.Size(800, 400);
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
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox chkReadableRegex;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.CheckBox chkIncludeNaNs;
    }
}

