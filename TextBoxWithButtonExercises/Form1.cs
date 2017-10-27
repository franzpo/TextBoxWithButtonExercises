using System;
using System.Windows.Forms;

namespace TextBoxWithButtonExercises {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void pActionTextBox1_HostedButtonClicked(object sender, ActionTextBox.HostedButtonClickedEventArgs e) {
            MessageBox.Show(e.Value);
        }
    }
}
