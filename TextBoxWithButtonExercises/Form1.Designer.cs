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
            this.actionTextBox1 = new Pandora.UserControls.ActionTextBox();
            this.actionTextBox2 = new Pandora.UserControls.ActionTextBox();
            this.actionTextBox3 = new Pandora.UserControls.ActionTextBox();
            this.actionTextBox4 = new Pandora.UserControls.ActionTextBox();
            this.SuspendLayout();
            // 
            // actionTextBox1
            // 
            this.actionTextBox1.BackColor = System.Drawing.Color.White;
            this.actionTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTextBox1.HistedTextBoxReadOnly = false;
            this.actionTextBox1.HostedButtonColor = System.Drawing.Color.WhiteSmoke;
            this.actionTextBox1.HostedTextBoxCue = null;
            this.actionTextBox1.HostedTextBoxFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTextBox1.HostedTextBoxMaxChar = 32767;
            this.actionTextBox1.HostedTextBoxText = "";
            this.actionTextBox1.Location = new System.Drawing.Point(116, 120);
            this.actionTextBox1.Name = "actionTextBox1";
            this.actionTextBox1.Size = new System.Drawing.Size(280, 30);
            this.actionTextBox1.SubmitType = Pandora.UserControls.ActionTextBox.PActionTextBoxSumbitTypes.Search;
            this.actionTextBox1.TabIndex = 0;
            // 
            // actionTextBox2
            // 
            this.actionTextBox2.BackColor = System.Drawing.Color.White;
            this.actionTextBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTextBox2.HistedTextBoxReadOnly = false;
            this.actionTextBox2.HostedButtonColor = System.Drawing.Color.WhiteSmoke;
            this.actionTextBox2.HostedTextBoxCue = null;
            this.actionTextBox2.HostedTextBoxFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTextBox2.HostedTextBoxMaxChar = 32767;
            this.actionTextBox2.HostedTextBoxText = "";
            this.actionTextBox2.Location = new System.Drawing.Point(116, 156);
            this.actionTextBox2.Name = "actionTextBox2";
            this.actionTextBox2.Size = new System.Drawing.Size(280, 30);
            this.actionTextBox2.SubmitType = Pandora.UserControls.ActionTextBox.PActionTextBoxSumbitTypes.Search;
            this.actionTextBox2.TabIndex = 1;
            // 
            // actionTextBox3
            // 
            this.actionTextBox3.BackColor = System.Drawing.Color.White;
            this.actionTextBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTextBox3.HistedTextBoxReadOnly = false;
            this.actionTextBox3.HostedButtonColor = System.Drawing.Color.WhiteSmoke;
            this.actionTextBox3.HostedTextBoxCue = null;
            this.actionTextBox3.HostedTextBoxFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTextBox3.HostedTextBoxMaxChar = 32767;
            this.actionTextBox3.HostedTextBoxText = "";
            this.actionTextBox3.Location = new System.Drawing.Point(116, 192);
            this.actionTextBox3.Name = "actionTextBox3";
            this.actionTextBox3.Size = new System.Drawing.Size(280, 30);
            this.actionTextBox3.SubmitType = Pandora.UserControls.ActionTextBox.PActionTextBoxSumbitTypes.Search;
            this.actionTextBox3.TabIndex = 2;
            // 
            // actionTextBox4
            // 
            this.actionTextBox4.BackColor = System.Drawing.Color.White;
            this.actionTextBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTextBox4.HistedTextBoxReadOnly = false;
            this.actionTextBox4.HostedButtonColor = System.Drawing.Color.WhiteSmoke;
            this.actionTextBox4.HostedTextBoxCue = null;
            this.actionTextBox4.HostedTextBoxFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionTextBox4.HostedTextBoxMaxChar = 32767;
            this.actionTextBox4.HostedTextBoxText = "";
            this.actionTextBox4.Location = new System.Drawing.Point(116, 228);
            this.actionTextBox4.Name = "actionTextBox4";
            this.actionTextBox4.Size = new System.Drawing.Size(280, 30);
            this.actionTextBox4.SubmitType = Pandora.UserControls.ActionTextBox.PActionTextBoxSumbitTypes.Search;
            this.actionTextBox4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 440);
            this.Controls.Add(this.actionTextBox4);
            this.Controls.Add(this.actionTextBox3);
            this.Controls.Add(this.actionTextBox2);
            this.Controls.Add(this.actionTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Pandora.UserControls.ActionTextBox actionTextBox1;
        private Pandora.UserControls.ActionTextBox actionTextBox2;
        private Pandora.UserControls.ActionTextBox actionTextBox3;
        private Pandora.UserControls.ActionTextBox actionTextBox4;
    }
}

