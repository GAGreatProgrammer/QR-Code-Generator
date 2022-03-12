
namespace QR_Code_Generator
{
    partial class TextPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextPanel));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblEnterText = new System.Windows.Forms.Label();
            this.txtTextInput = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // lblEnterText
            // 
            this.lblEnterText.AutoSize = true;
            this.lblEnterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblEnterText.Location = new System.Drawing.Point(28, 25);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(154, 24);
            this.lblEnterText.TabIndex = 0;
            this.lblEnterText.Text = "Enter your Text";
            // 
            // txtTextInput
            // 
            this.txtTextInput.AcceptsReturn = false;
            this.txtTextInput.AcceptsTab = false;
            this.txtTextInput.AnimationSpeed = 200;
            this.txtTextInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTextInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTextInput.AutoSizeHeight = true;
            this.txtTextInput.BackColor = System.Drawing.Color.Transparent;
            this.txtTextInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTextInput.BackgroundImage")));
            this.txtTextInput.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtTextInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTextInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtTextInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtTextInput.BorderRadius = 30;
            this.txtTextInput.BorderThickness = 2;
            this.txtTextInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTextInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTextInput.DefaultFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextInput.DefaultText = "";
            this.txtTextInput.FillColor = System.Drawing.Color.White;
            this.txtTextInput.HideSelection = true;
            this.txtTextInput.IconLeft = null;
            this.txtTextInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTextInput.IconPadding = 10;
            this.txtTextInput.IconRight = null;
            this.txtTextInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTextInput.Lines = new string[0];
            this.txtTextInput.Location = new System.Drawing.Point(22, 52);
            this.txtTextInput.MaxLength = 32767;
            this.txtTextInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTextInput.Modified = false;
            this.txtTextInput.Multiline = true;
            this.txtTextInput.Name = "txtTextInput";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTextInput.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTextInput.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTextInput.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTextInput.OnIdleState = stateProperties4;
            this.txtTextInput.Padding = new System.Windows.Forms.Padding(3);
            this.txtTextInput.PasswordChar = '\0';
            this.txtTextInput.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTextInput.PlaceholderText = "";
            this.txtTextInput.ReadOnly = false;
            this.txtTextInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTextInput.SelectedText = "";
            this.txtTextInput.SelectionLength = 0;
            this.txtTextInput.SelectionStart = 0;
            this.txtTextInput.ShortcutsEnabled = true;
            this.txtTextInput.Size = new System.Drawing.Size(656, 500);
            this.txtTextInput.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTextInput.TabIndex = 1;
            this.txtTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTextInput.TextMarginBottom = 0;
            this.txtTextInput.TextMarginLeft = 3;
            this.txtTextInput.TextMarginTop = 1;
            this.txtTextInput.TextPlaceholder = "";
            this.txtTextInput.UseSystemPasswordChar = false;
            this.txtTextInput.WordWrap = true;
            // 
            // TextPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTextInput);
            this.Controls.Add(this.lblEnterText);
            this.Name = "TextPanel";
            this.Size = new System.Drawing.Size(700, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterText;
        private Bunifu.UI.WinForms.BunifuTextBox txtTextInput;
    }
}
