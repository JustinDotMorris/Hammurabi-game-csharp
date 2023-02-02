namespace Hammurabi_Attempt_2
{
    partial class High_Score_Pop_Up
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
            this.TxtNameSubmit = new System.Windows.Forms.TextBox();
            this.LblNameEnter = new System.Windows.Forms.Label();
            this.BtnNameSubmit = new System.Windows.Forms.Button();
            this.LblScorePopUp = new System.Windows.Forms.Label();
            this.LblCongratulations = new System.Windows.Forms.Label();
            this.Lblgoodbad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNameSubmit
            // 
            this.TxtNameSubmit.Location = new System.Drawing.Point(95, 135);
            this.TxtNameSubmit.Name = "TxtNameSubmit";
            this.TxtNameSubmit.Size = new System.Drawing.Size(150, 22);
            this.TxtNameSubmit.TabIndex = 0;
            // 
            // LblNameEnter
            // 
            this.LblNameEnter.AutoSize = true;
            this.LblNameEnter.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameEnter.Location = new System.Drawing.Point(91, 108);
            this.LblNameEnter.Name = "LblNameEnter";
            this.LblNameEnter.Size = new System.Drawing.Size(154, 24);
            this.LblNameEnter.TabIndex = 2;
            this.LblNameEnter.Text = "Enter Your Name:";
            // 
            // BtnNameSubmit
            // 
            this.BtnNameSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnNameSubmit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNameSubmit.Location = new System.Drawing.Point(95, 261);
            this.BtnNameSubmit.Name = "BtnNameSubmit";
            this.BtnNameSubmit.Size = new System.Drawing.Size(150, 46);
            this.BtnNameSubmit.TabIndex = 3;
            this.BtnNameSubmit.Text = "Submit";
            this.BtnNameSubmit.UseVisualStyleBackColor = true;
            this.BtnNameSubmit.Click += new System.EventHandler(this.BtnNameSubmit_Click);
            // 
            // LblScorePopUp
            // 
            this.LblScorePopUp.AutoSize = true;
            this.LblScorePopUp.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScorePopUp.Location = new System.Drawing.Point(91, 160);
            this.LblScorePopUp.Name = "LblScorePopUp";
            this.LblScorePopUp.Size = new System.Drawing.Size(58, 24);
            this.LblScorePopUp.TabIndex = 2;
            this.LblScorePopUp.Text = "Score:";
            // 
            // LblCongratulations
            // 
            this.LblCongratulations.AutoSize = true;
            this.LblCongratulations.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCongratulations.Location = new System.Drawing.Point(12, 25);
            this.LblCongratulations.Name = "LblCongratulations";
            this.LblCongratulations.Size = new System.Drawing.Size(311, 48);
            this.LblCongratulations.TabIndex = 2;
            this.LblCongratulations.Text = "Congratulations! \r\nYour 10  year rule has come to an end!";
            this.LblCongratulations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lblgoodbad
            // 
            this.Lblgoodbad.AutoSize = true;
            this.Lblgoodbad.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblgoodbad.Location = new System.Drawing.Point(91, 202);
            this.Lblgoodbad.Name = "Lblgoodbad";
            this.Lblgoodbad.Size = new System.Drawing.Size(96, 24);
            this.Lblgoodbad.TabIndex = 2;
            this.Lblgoodbad.Text = "Well Done";
            this.Lblgoodbad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // High_Score_Pop_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 332);
            this.Controls.Add(this.BtnNameSubmit);
            this.Controls.Add(this.LblScorePopUp);
            this.Controls.Add(this.Lblgoodbad);
            this.Controls.Add(this.LblCongratulations);
            this.Controls.Add(this.LblNameEnter);
            this.Controls.Add(this.TxtNameSubmit);
            this.Name = "High_Score_Pop_Up";
            this.Text = "High_Score_Pop_Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnNameSubmit;
        internal System.Windows.Forms.TextBox TxtNameSubmit;
        internal System.Windows.Forms.Label LblNameEnter;
        internal System.Windows.Forms.Label LblScorePopUp;
        internal System.Windows.Forms.Label LblCongratulations;
        internal System.Windows.Forms.Label Lblgoodbad;
    }
}