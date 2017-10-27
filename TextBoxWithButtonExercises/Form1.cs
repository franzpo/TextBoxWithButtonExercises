using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
