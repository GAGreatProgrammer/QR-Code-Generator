
namespace QR_Code_Generator.User_Controls
{
    partial class RetrievedDataPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrievedDataPanel));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblEnterText = new System.Windows.Forms.Label();
            this.txtQRCodeData = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // lblEnterText
            // 
            this.lblEnterText.AutoSize = true;
            this.lblEnterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblEnterText.Location = new System.Drawing.Point(28, 25);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(143, 24);
            this.lblEnterText.TabIndex = 2;
            this.lblEnterText.Text = "QR Code Data";
            // 
            // txtQRCodeData
            // 
            this.txtQRCodeData.AcceptsReturn = false;
            this.txtQRCodeData.AcceptsTab = false;
            this.txtQRCodeData.AnimationSpeed = 200;
            this.txtQRCodeData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQRCodeData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQRCodeData.AutoSizeHeight = true;
            this.txtQRCodeData.BackColor = System.Drawing.Color.Transparent;
            this.txtQRCodeData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtQRCodeData.BackgroundImage")));
            this.txtQRCodeData.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtQRCodeData.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQRCodeData.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtQRCodeData.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtQRCodeData.BorderRadius = 30;
            this.txtQRCodeData.BorderThickness = 2;
            this.txtQRCodeData.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQRCodeData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQRCodeData.DefaultFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQRCodeData.DefaultText = "";
            this.txtQRCodeData.FillColor = System.Drawing.Color.White;
            this.txtQRCodeData.HideSelection = true;
            this.txtQRCodeData.IconLeft = null;
            this.txtQRCodeData.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQRCodeData.IconPadding = 10;
            this.txtQRCodeData.IconRight = null;
            this.txtQRCodeData.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQRCodeData.Lines = new string[0];
            this.txtQRCodeData.Location = new System.Drawing.Point(22, 52);
            this.txtQRCodeData.MaxLength = 32767;
            this.txtQRCodeData.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtQRCodeData.Modified = false;
            this.txtQRCodeData.Multiline = true;
            this.txtQRCodeData.Name = "txtQRCodeData";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQRCodeData.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtQRCodeData.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQRCodeData.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQRCodeData.OnIdleState = stateProperties4;
            this.txtQRCodeData.Padding = new System.Windows.Forms.Padding(3);
            this.txtQRCodeData.PasswordChar = '\0';
            this.txtQRCodeData.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtQRCodeData.PlaceholderText = "";
            this.txtQRCodeData.ReadOnly = false;
            this.txtQRCodeData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQRCodeData.SelectedText = "";
            this.txtQRCodeData.SelectionLength = 0;
            this.txtQRCodeData.SelectionStart = 0;
            this.txtQRCodeData.ShortcutsEnabled = true;
            this.txtQRCodeData.Size = new System.Drawing.Size(656, 500);
            this.txtQRCodeData.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtQRCodeData.TabIndex = 3;
            this.txtQRCodeData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQRCodeData.TextMarginBottom = 0;
            this.txtQRCodeData.TextMarginLeft = 3;
            this.txtQRCodeData.TextMarginTop = 1;
            this.txtQRCodeData.TextPlaceholder = "";
            this.txtQRCodeData.UseSystemPasswordChar = false;
            this.txtQRCodeData.WordWrap = true;
            // 
            // RetrievedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtQRCodeData);
            this.Controls.Add(this.lblEnterText);
            this.Name = "RetrievedData";
            this.Size = new System.Drawing.Size(700, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txtQRCodeData;
        private System.Windows.Forms.Label lblEnterText;
    }
}
