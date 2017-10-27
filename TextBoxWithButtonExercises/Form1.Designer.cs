namespace TextBoxWithButtonExercises {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pActionTextBox1 = new Pandora.UserControls.PActionTextBox();
            this.SuspendLayout();
            // 
            // pActionTextBox1
            // 
            this.pActionTextBox1.BackColor = System.Drawing.Color.White;
            this.pActionTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pActionTextBox1.HistedTextBoxReadOnly = false;
            this.pActionTextBox1.HostedButtonColor = System.Drawing.Color.WhiteSmoke;
            this.pActionTextBox1.HostedTextBoxCue = null;
            this.pActionTextBox1.HostedTextBoxFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pActionTextBox1.HostedTextBoxMaxChar = 32767;
            this.pActionTextBox1.HostedTextBoxText = "";
            this.pActionTextBox1.Location = new System.Drawing.Point(98, 60);
            this.pActionTextBox1.Name = "pActionTextBox1";
            this.pActionTextBox1.Size = new System.Drawing.Size(280, 30);
            this.pActionTextBox1.SubmitType = Pandora.UserControls.PActionTextBox.PActionTextBoxSumbitTypes.Add;
            this.pActionTextBox1.TabIndex = 0;
            this.pActionTextBox1.HostedButtonClicked += new Pandora.UserControls.PActionTextBox.HostedButtonClickedEventHandler(this.pActionTextBox1_HostedButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 267);
            this.Controls.Add(this.pActionTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Pandora.UserControls.PActionTextBox pActionTextBox1;
    }
}

