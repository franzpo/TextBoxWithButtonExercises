using ActionTextBox;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ActionTextBox.SecialUnicodeCharacter;

namespace Pandora.UserControls {

    /// <summary>
    /// A custom TextBox with built-in button
    /// </summary>
    public partial class PActionTextBox : UserControl {

        /// <summary>
        /// Enumerates the types of submission the hosted Button does in this context
        /// </summary>
        public enum PActionTextBoxSumbitTypes {
            /// <summary>
            /// When this context is used for searching
            /// </summary>
            Search = 0,
            /// <summary>
            /// When this context is used for anything other than searching
            /// </summary>
            Go = 1,
            /// <summary>
            /// When this context is used to launch anything
            /// </summary>
            Launcher = 2,
            /// <summary>
            /// When this context is used to add the field's value
            /// </summary>
            Add = 3
        }

        /// <summary>
        /// Private field representing the <see cref="SubmitType"/>
        /// </summary>
        public PActionTextBox.PActionTextBoxSumbitTypes _submitType;

        /// <summary>
        /// Gets or sets the <see cref="PActionTextBox.PActionTextBoxSumbitTypes"/> of the HostedButton
        /// </summary>
        public PActionTextBox.PActionTextBoxSumbitTypes SubmitType {
            get { return this._submitType; }
            set {
                this._submitType = value;
                this.SetHostedButtonIcon(this._submitType);
                this.Invalidate(true);
            }
        }

        /// <summary>
        /// Gets or sets the HostedButton's color
        /// </summary>
        public Color HostedButtonColor {
            get { return this.HostedButton.BackColor; }
            set {
                this.HostedButton.BackColor = value;
                this.Invalidate(true);
            }
        }

        /// <summary>
        /// Points to the method called when event HostedButtonClicked is raised
        /// </summary>
        public delegate void HostedButtonClickedEventHandler(object sender, HostedButtonClickedEventArgs e);

        /// <summary>
        /// Is raised whenever the actual <see cref="HostedButton"/> is clicked (a redundancy)
        /// </summary>
        public event HostedButtonClickedEventHandler HostedButtonClicked;

        /// <summary>
        /// Tooltip used privately during validation
        /// </summary>
        private ToolTip _tip;

        /// <summary>
        /// Creates an instance of the APSTextBox
        /// </summary>
        public PActionTextBox() => InitializeComponent();

        /// <summary>
        /// Allows CTRL+Backspace and Select All
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            const int WM_KEYDOWN = 0x100;

            var keyCode = (Keys)(msg.WParam.ToInt32() &
                                  Convert.ToInt32(Keys.KeyCode));

            if ((msg.Msg == WM_KEYDOWN && keyCode == Keys.A)
                && (ModifierKeys == Keys.Control)
                && HostedTextBox.Focused) {
                HostedTextBox.SelectAll();
                return true;
            } else if (keyData == (Keys.Control | Keys.Back)) {
                SendKeys.SendWait("^+{LEFT}{BACKSPACE}");
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region PROPERTIES

        /// <summary>
        /// Gets or sets the hosted TextBox's Font
        /// </summary>
        public int HostedTextBoxMaxChar {
            get {
                return this.HostedTextBox.MaxLength;
            }
            set {
                this.HostedTextBox.MaxLength = value;
            }
        }

        /// <summary>
        /// Gets or sets the hosted TextBox's Font
        /// </summary>
        public Font HostedTextBoxFont {
            get {
                return this.HostedTextBox.Font;
            }
            set {
                this.HostedTextBox.Font = value;
            }
        }

        /// <summary>
        /// Gets or sets the hosted TextBox's Text
        /// </summary>
        public string HostedTextBoxText {
            get {
                return this.HostedTextBox.Text;
            }
            set {
                this.HostedTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the hosted TextBox's Cue Banner
        /// </summary>
        public string HostedTextBoxCue {
            get {
                return this.HostedTextBox.Cue;
            }
            set {
                this.HostedTextBox.Cue = value;
            }
        }

        /// <summary>
        /// Gets or sets the hosted TextBox's Read Only property
        /// </summary>
        public bool HistedTextBoxReadOnly {
            get {
                return this.HostedTextBox.ReadOnly;
            }
            set {
                this.HostedTextBox.ReadOnly = value;
            }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Gives highlight to this control when the hosted TextBox gets focus
        /// </summary>
        private void HostedTextBox_Enter(object sender, EventArgs e) {
            this.panMain.BorderColor = Color.DodgerBlue;
            this.panMain.Refresh();
        }

        /// <summary>
        /// Removes highlight from this control when the hosted TextBox lost focus
        /// </summary>
        private void HostedTextBox_Leave(object sender, EventArgs e) {
            this.panMain.BorderColor = Color.LightGray;
            this.panMain.Refresh();
            this.ForceHideToolTip();
        }

        /// <summary>
        /// Resets whatever border color was implemented by the HostedTextBoxInformationValidated event
        /// </summary>
        private void HostedTextBox_TextChanged(object sender, EventArgs e) {
            this.panMain.BorderColor = Color.DodgerBlue;
            this.panMain.Refresh();
            this.ForceHideToolTip();
        }

        /// <summary>
        /// Main entry-point to raising the event <see cref="HostedButtonClicked"/>
        /// </summary>
        private void HostedButton_Click(object sender, EventArgs e) {
            this.HostedButtonClicked?.Invoke(this,
                new HostedButtonClickedEventArgs(this.HostedTextBox.Text));
        }

        /// <summary>
        /// Public method that should be called to 
        /// </summary>
        /// <param name="bordercolor">Nullable <see cref="System.Color"/> type for user to highlight the control </param>
        public virtual void OnHostedTextBoxInformationValidated(string title, string message, Color? bordercolor = null) {

            if (this.IsHandleCreated) {

                if (bordercolor != null) {

                    if (bordercolor.HasValue) {

                        if (this.InvokeRequired) {
                            this.BeginInvoke((MethodInvoker)delegate () {
                                this.panMain.BorderColor = bordercolor.Value;
                                this.panMain.Refresh();
                            });
                        } else {
                            this.panMain.BorderColor = bordercolor.Value;
                            this.panMain.Refresh();
                        }

                    }
                }

                this.ForceHideToolTip();

                this._tip = new ToolTip() {
                    UseAnimation = true, UseFading = true, IsBalloon = true, ToolTipTitle = title
                };

                if (this.InvokeRequired) {
                    this.BeginInvoke((MethodInvoker)delegate () { this._tip.Show(message, this.HostedTextBox, 30, -90, 3500); });
                } else {
                    this._tip.Show(message, this.HostedTextBox, 30, -90);
                }

            }

        }

        /// <summary>
        /// Forces the tooltip, when not null, to be hidden
        /// </summary>
        public void ForceHideToolTip() {
            if (this._tip != null) {
                this._tip.Hide(this.HostedTextBox);
                this._tip.Dispose();
                this._tip = null;
            }
        }

        /// <summary>
        /// Changes the single-char text of the hosted Button
        /// </summary>
        private void SetHostedButtonIcon(PActionTextBox.PActionTextBoxSumbitTypes submitType) {
            switch (submitType) {
                case PActionTextBoxSumbitTypes.Search:
                    this.HostedButton.Text = LEFTP_MAGGLASS;
                    break;
                case PActionTextBoxSumbitTypes.Go:
                    this.HostedButton.Text = RIGHTP_TRIANG;
                    break;
                case PActionTextBoxSumbitTypes.Launcher:
                    this.HostedButton.Text = MID_ELPSIS;
                    break;
                case PActionTextBoxSumbitTypes.Add:
                    this.HostedButton.Text = HEAVY_PLUS;
                    break;
                default:
                    this.HostedButton.Text = string.Empty;
                    break;
            }
        }

        /// <summary>
        /// Sets the tooltip for the hosted Button
        /// </summary>
        public void SetHostedButtonTip(string tipMsg) => this.tip.SetToolTip(this.HostedButton, tipMsg);

        #endregion

    }
}
