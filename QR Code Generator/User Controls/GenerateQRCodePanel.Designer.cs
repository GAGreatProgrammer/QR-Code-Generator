
namespace QR_Code_Generator.User_Controls
{
    partial class GenerateQRCodePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateQRCodePanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.QRCode = new System.Windows.Forms.PictureBox();
            this.SliderPixelsPerModule = new Bunifu.UI.WinForms.BunifuHSlider();
            this.lblPixelsPerModule = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateQRCode = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDownloadImage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRCode.Location = new System.Drawing.Point(153, 15);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(121, 29);
            this.lblQRCode.TabIndex = 0;
            this.lblQRCode.Text = "QR Code";
            // 
            // Panel
            // 
            this.Panel.BackgroundColor = System.Drawing.Color.Transparent;
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.Panel.BorderRadius = 30;
            this.Panel.BorderThickness = 2;
            this.Panel.Controls.Add(this.QRCode);
            this.Panel.Location = new System.Drawing.Point(15, 47);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(405, 405);
            this.Panel.TabIndex = 1;
            // 
            // QRCode
            // 
            this.QRCode.Location = new System.Drawing.Point(10, 10);
            this.QRCode.Name = "QRCode";
            this.QRCode.Size = new System.Drawing.Size(385, 385);
            this.QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRCode.TabIndex = 0;
            this.QRCode.TabStop = false;
            // 
            // SliderPixelsPerModule
            // 
            this.SliderPixelsPerModule.AllowCursorChanges = true;
            this.SliderPixelsPerModule.AllowHomeEndKeysDetection = false;
            this.SliderPixelsPerModule.AllowIncrementalClickMoves = true;
            this.SliderPixelsPerModule.AllowMouseDownEffects = false;
            this.SliderPixelsPerModule.AllowMouseHoverEffects = false;
            this.SliderPixelsPerModule.AllowScrollingAnimations = true;
            this.SliderPixelsPerModule.AllowScrollKeysDetection = true;
            this.SliderPixelsPerModule.AllowScrollOptionsMenu = true;
            this.SliderPixelsPerModule.AllowShrinkingOnFocusLost = false;
            this.SliderPixelsPerModule.BackColor = System.Drawing.Color.Transparent;
            this.SliderPixelsPerModule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SliderPixelsPerModule.BackgroundImage")));
            this.SliderPixelsPerModule.BindingContainer = null;
            this.SliderPixelsPerModule.BorderRadius = 2;
            this.SliderPixelsPerModule.BorderThickness = 1;
            this.SliderPixelsPerModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SliderPixelsPerModule.DrawThickBorder = false;
            this.SliderPixelsPerModule.DurationBeforeShrink = 2000;
            this.SliderPixelsPerModule.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.SliderPixelsPerModule.LargeChange = 10;
            this.SliderPixelsPerModule.Location = new System.Drawing.Point(40, 470);
            this.SliderPixelsPerModule.Maximum = 100;
            this.SliderPixelsPerModule.Minimum = 1;
            this.SliderPixelsPerModule.MinimumSize = new System.Drawing.Size(0, 31);
            this.SliderPixelsPerModule.MinimumThumbLength = 18;
            this.SliderPixelsPerModule.Name = "SliderPixelsPerModule";
            this.SliderPixelsPerModule.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.SliderPixelsPerModule.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.SliderPixelsPerModule.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.SliderPixelsPerModule.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.SliderPixelsPerModule.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.SliderPixelsPerModule.ShrinkSizeLimit = 3;
            this.SliderPixelsPerModule.Size = new System.Drawing.Size(360, 31);
            this.SliderPixelsPerModule.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.SliderPixelsPerModule.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.SliderPixelsPerModule.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.SliderPixelsPerModule.SmallChange = 1;
            this.SliderPixelsPerModule.TabIndex = 2;
            this.SliderPixelsPerModule.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.SliderPixelsPerModule.ThumbFillColor = System.Drawing.Color.White;
            this.SliderPixelsPerModule.ThumbLength = 36;
            this.SliderPixelsPerModule.ThumbMargin = 1;
            this.SliderPixelsPerModule.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.SliderPixelsPerModule.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.SliderPixelsPerModule.Value = 50;
            this.SliderPixelsPerModule.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.SliderPixelsPerModule_Scroll);
            // 
            // lblPixelsPerModule
            // 
            this.lblPixelsPerModule.AutoSize = true;
            this.lblPixelsPerModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPixelsPerModule.Location = new System.Drawing.Point(193, 505);
            this.lblPixelsPerModule.Name = "lblPixelsPerModule";
            this.lblPixelsPerModule.Size = new System.Drawing.Size(57, 20);
            this.lblPixelsPerModule.TabIndex = 3;
            this.lblPixelsPerModule.Text = "50 PX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(10, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Low Quality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(323, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "High Quality";
            // 
            // btnCreateQRCode
            // 
            this.btnCreateQRCode.AllowAnimations = true;
            this.btnCreateQRCode.AllowMouseEffects = true;
            this.btnCreateQRCode.AllowToggling = false;
            this.btnCreateQRCode.AnimationSpeed = 200;
            this.btnCreateQRCode.AutoGenerateColors = false;
            this.btnCreateQRCode.AutoRoundBorders = false;
            this.btnCreateQRCode.AutoSizeLeftIcon = true;
            this.btnCreateQRCode.AutoSizeRightIcon = true;
            this.btnCreateQRCode.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateQRCode.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCreateQRCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateQRCode.BackgroundImage")));
            this.btnCreateQRCode.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateQRCode.ButtonText = "Create QR Code";
            this.btnCreateQRCode.ButtonTextMarginLeft = 0;
            this.btnCreateQRCode.ColorContrastOnClick = 45;
            this.btnCreateQRCode.ColorContrastOnHover = 45;
            this.btnCreateQRCode.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCreateQRCode.CustomizableEdges = borderEdges1;
            this.btnCreateQRCode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateQRCode.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreateQRCode.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCreateQRCode.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCreateQRCode.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCreateQRCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQRCode.ForeColor = System.Drawing.Color.White;
            this.btnCreateQRCode.IconLeft = null;
            this.btnCreateQRCode.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateQRCode.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateQRCode.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCreateQRCode.IconMarginLeft = 11;
            this.btnCreateQRCode.IconPadding = 10;
            this.btnCreateQRCode.IconRight = null;
            this.btnCreateQRCode.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateQRCode.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateQRCode.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCreateQRCode.IconSize = 25;
            this.btnCreateQRCode.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCreateQRCode.IdleBorderRadius = 0;
            this.btnCreateQRCode.IdleBorderThickness = 0;
            this.btnCreateQRCode.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCreateQRCode.IdleIconLeftImage = null;
            this.btnCreateQRCode.IdleIconRightImage = null;
            this.btnCreateQRCode.IndicateFocus = false;
            this.btnCreateQRCode.Location = new System.Drawing.Point(15, 565);
            this.btnCreateQRCode.Name = "btnCreateQRCode";
            this.btnCreateQRCode.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreateQRCode.OnDisabledState.BorderRadius = 30;
            this.btnCreateQRCode.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateQRCode.OnDisabledState.BorderThickness = 1;
            this.btnCreateQRCode.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreateQRCode.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreateQRCode.OnDisabledState.IconLeftImage = null;
            this.btnCreateQRCode.OnDisabledState.IconRightImage = null;
            this.btnCreateQRCode.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(238)))), ((int)(((byte)(161)))));
            this.btnCreateQRCode.onHoverState.BorderRadius = 30;
            this.btnCreateQRCode.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateQRCode.onHoverState.BorderThickness = 1;
            this.btnCreateQRCode.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(238)))), ((int)(((byte)(161)))));
            this.btnCreateQRCode.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCreateQRCode.onHoverState.IconLeftImage = null;
            this.btnCreateQRCode.onHoverState.IconRightImage = null;
            this.btnCreateQRCode.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnCreateQRCode.OnIdleState.BorderRadius = 30;
            this.btnCreateQRCode.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateQRCode.OnIdleState.BorderThickness = 1;
            this.btnCreateQRCode.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnCreateQRCode.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCreateQRCode.OnIdleState.IconLeftImage = null;
            this.btnCreateQRCode.OnIdleState.IconRightImage = null;
            this.btnCreateQRCode.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnCreateQRCode.OnPressedState.BorderRadius = 30;
            this.btnCreateQRCode.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateQRCode.OnPressedState.BorderThickness = 1;
            this.btnCreateQRCode.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnCreateQRCode.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCreateQRCode.OnPressedState.IconLeftImage = null;
            this.btnCreateQRCode.OnPressedState.IconRightImage = null;
            this.btnCreateQRCode.Size = new System.Drawing.Size(179, 49);
            this.btnCreateQRCode.TabIndex = 6;
            this.btnCreateQRCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateQRCode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateQRCode.TextMarginLeft = 0;
            this.btnCreateQRCode.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCreateQRCode.UseDefaultRadiusAndThickness = true;
            this.btnCreateQRCode.Click += new System.EventHandler(this.btnCreateQRCode_Click);
            // 
            // btnDownloadImage
            // 
            this.btnDownloadImage.AllowAnimations = true;
            this.btnDownloadImage.AllowMouseEffects = true;
            this.btnDownloadImage.AllowToggling = false;
            this.btnDownloadImage.AnimationSpeed = 200;
            this.btnDownloadImage.AutoGenerateColors = false;
            this.btnDownloadImage.AutoRoundBorders = false;
            this.btnDownloadImage.AutoSizeLeftIcon = true;
            this.btnDownloadImage.AutoSizeRightIcon = true;
            this.btnDownloadImage.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadImage.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDownloadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownloadImage.BackgroundImage")));
            this.btnDownloadImage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDownloadImage.ButtonText = "Download Image";
            this.btnDownloadImage.ButtonTextMarginLeft = 0;
            this.btnDownloadImage.ColorContrastOnClick = 45;
            this.btnDownloadImage.ColorContrastOnHover = 45;
            this.btnDownloadImage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDownloadImage.CustomizableEdges = borderEdges2;
            this.btnDownloadImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDownloadImage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDownloadImage.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDownloadImage.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDownloadImage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDownloadImage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadImage.ForeColor = System.Drawing.Color.White;
            this.btnDownloadImage.IconLeft = null;
            this.btnDownloadImage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadImage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDownloadImage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDownloadImage.IconMarginLeft = 11;
            this.btnDownloadImage.IconPadding = 10;
            this.btnDownloadImage.IconRight = null;
            this.btnDownloadImage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadImage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDownloadImage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDownloadImage.IconSize = 25;
            this.btnDownloadImage.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDownloadImage.IdleBorderRadius = 0;
            this.btnDownloadImage.IdleBorderThickness = 0;
            this.btnDownloadImage.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDownloadImage.IdleIconLeftImage = null;
            this.btnDownloadImage.IdleIconRightImage = null;
            this.btnDownloadImage.IndicateFocus = false;
            this.btnDownloadImage.Location = new System.Drawing.Point(240, 565);
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDownloadImage.OnDisabledState.BorderRadius = 30;
            this.btnDownloadImage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDownloadImage.OnDisabledState.BorderThickness = 1;
            this.btnDownloadImage.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDownloadImage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDownloadImage.OnDisabledState.IconLeftImage = null;
            this.btnDownloadImage.OnDisabledState.IconRightImage = null;
            this.btnDownloadImage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(170)))), ((int)(((byte)(248)))));
            this.btnDownloadImage.onHoverState.BorderRadius = 30;
            this.btnDownloadImage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDownloadImage.onHoverState.BorderThickness = 1;
            this.btnDownloadImage.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(170)))), ((int)(((byte)(248)))));
            this.btnDownloadImage.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDownloadImage.onHoverState.IconLeftImage = null;
            this.btnDownloadImage.onHoverState.IconRightImage = null;
            this.btnDownloadImage.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnDownloadImage.OnIdleState.BorderRadius = 30;
            this.btnDownloadImage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDownloadImage.OnIdleState.BorderThickness = 1;
            this.btnDownloadImage.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnDownloadImage.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDownloadImage.OnIdleState.IconLeftImage = null;
            this.btnDownloadImage.OnIdleState.IconRightImage = null;
            this.btnDownloadImage.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnDownloadImage.OnPressedState.BorderRadius = 30;
            this.btnDownloadImage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDownloadImage.OnPressedState.BorderThickness = 1;
            this.btnDownloadImage.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnDownloadImage.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDownloadImage.OnPressedState.IconLeftImage = null;
            this.btnDownloadImage.OnPressedState.IconRightImage = null;
            this.btnDownloadImage.Size = new System.Drawing.Size(179, 49);
            this.btnDownloadImage.TabIndex = 7;
            this.btnDownloadImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDownloadImage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDownloadImage.TextMarginLeft = 0;
            this.btnDownloadImage.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDownloadImage.UseDefaultRadiusAndThickness = true;
            this.btnDownloadImage.Click += new System.EventHandler(this.btnDownloadImage_Click);
            // 
            // GenerateQRCodePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDownloadImage);
            this.Controls.Add(this.btnCreateQRCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPixelsPerModule);
            this.Controls.Add(this.SliderPixelsPerModule);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.lblQRCode);
            this.Name = "GenerateQRCodePanel";
            this.Size = new System.Drawing.Size(445, 645);
            this.Load += new System.EventHandler(this.GenerateQRCodePanel_Load);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQRCode;
        private Bunifu.UI.WinForms.BunifuPanel Panel;
        private Bunifu.UI.WinForms.BunifuHSlider SliderPixelsPerModule;
        private System.Windows.Forms.Label lblPixelsPerModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCreateQRCode;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDownloadImage;
        private System.Windows.Forms.PictureBox QRCode;
    }
}
