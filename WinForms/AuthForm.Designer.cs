namespace WinForms
{
    partial class AuthForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Step1GroupBox = new System.Windows.Forms.GroupBox();
            this.AuthenticateButton = new System.Windows.Forms.Button();
            this.Step2GroupBox = new System.Windows.Forms.GroupBox();
            this.VerifierTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CompleteAuthButton = new System.Windows.Forms.Button();
            this.Step1GroupBox.SuspendLayout();
            this.Step2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click the Authenticate button to start authentication. You will be taken to the F" +
    "lickr web site. Once you have authenticated copy the Verifier code into the box " +
    "and press Complete.";
            // 
            // Step1GroupBox
            // 
            this.Step1GroupBox.Controls.Add(this.AuthenticateButton);
            this.Step1GroupBox.Location = new System.Drawing.Point(50, 77);
            this.Step1GroupBox.Name = "Step1GroupBox";
            this.Step1GroupBox.Size = new System.Drawing.Size(200, 54);
            this.Step1GroupBox.TabIndex = 4;
            this.Step1GroupBox.TabStop = false;
            this.Step1GroupBox.Text = "Step 1";
            // 
            // AuthenticateButton
            // 
            this.AuthenticateButton.Location = new System.Drawing.Point(62, 19);
            this.AuthenticateButton.Name = "AuthenticateButton";
            this.AuthenticateButton.Size = new System.Drawing.Size(75, 23);
            this.AuthenticateButton.TabIndex = 1;
            this.AuthenticateButton.Text = "Authenticate";
            this.AuthenticateButton.UseVisualStyleBackColor = true;
            this.AuthenticateButton.Click += new System.EventHandler(this.AuthenticateButton_Click);
            // 
            // Step2GroupBox
            // 
            this.Step2GroupBox.Controls.Add(this.VerifierTextBox);
            this.Step2GroupBox.Controls.Add(this.label3);
            this.Step2GroupBox.Controls.Add(this.ResultLabel);
            this.Step2GroupBox.Controls.Add(this.CompleteAuthButton);
            this.Step2GroupBox.Enabled = false;
            this.Step2GroupBox.Location = new System.Drawing.Point(50, 137);
            this.Step2GroupBox.Name = "Step2GroupBox";
            this.Step2GroupBox.Size = new System.Drawing.Size(200, 133);
            this.Step2GroupBox.TabIndex = 5;
            this.Step2GroupBox.TabStop = false;
            this.Step2GroupBox.Text = "Step 2";
            // 
            // VerifierTextBox
            // 
            this.VerifierTextBox.Location = new System.Drawing.Point(62, 19);
            this.VerifierTextBox.Name = "VerifierTextBox";
            this.VerifierTextBox.Size = new System.Drawing.Size(100, 20);
            this.VerifierTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Verifier";
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(6, 79);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(188, 51);
            this.ResultLabel.TabIndex = 3;
            // 
            // CompleteAuthButton
            // 
            this.CompleteAuthButton.Location = new System.Drawing.Point(62, 47);
            this.CompleteAuthButton.Name = "CompleteAuthButton";
            this.CompleteAuthButton.Size = new System.Drawing.Size(75, 23);
            this.CompleteAuthButton.TabIndex = 2;
            this.CompleteAuthButton.Text = "Complete";
            this.CompleteAuthButton.UseVisualStyleBackColor = true;
            this.CompleteAuthButton.Click += new System.EventHandler(this.CompleteAuthButton_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 315);
            this.Controls.Add(this.Step2GroupBox);
            this.Controls.Add(this.Step1GroupBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.Text = "Authentication Form";
            this.Step1GroupBox.ResumeLayout(false);
            this.Step2GroupBox.ResumeLayout(false);
            this.Step2GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Step1GroupBox;
        private System.Windows.Forms.Button AuthenticateButton;
        private System.Windows.Forms.GroupBox Step2GroupBox;
        private System.Windows.Forms.TextBox VerifierTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CompleteAuthButton;

    }
}