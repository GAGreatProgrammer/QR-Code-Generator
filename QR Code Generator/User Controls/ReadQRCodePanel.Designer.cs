
namespace QR_Code_Generator.User_Controls
{
    partial class ReadQRCodePanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadQRCodePanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.CameraImage = new System.Windows.Forms.PictureBox();
            this.btnRead = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnUploadQRCodeImage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cboCamera = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnReload = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRCode.Location = new System.Drawing.Point(110, 15);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(190, 29);
            this.lblQRCode.TabIndex = 1;
            this.lblQRCode.Text = "Read QR Code";
            // 
            // Panel
            // 
            this.Panel.BackgroundColor = System.Drawing.Color.Transparent;
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.Panel.BorderRadius = 30;
            this.Panel.BorderThickness = 2;
            this.Panel.Controls.Add(this.CameraImage);
            this.Panel.Location = new System.Drawing.Point(15, 112);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(405, 310);
            this.Panel.TabIndex = 5;
            // 
            // CameraImage
            // 
            this.CameraImage.Location = new System.Drawing.Point(10, 10);
            this.CameraImage.Name = "CameraImage";
            this.CameraImage.Size = new System.Drawing.Size(385, 290);
            this.CameraImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CameraImage.TabIndex = 46;
            this.CameraImage.TabStop = false;
            // 
            // btnRead
            // 
            this.btnRead.AllowAnimations = true;
            this.btnRead.AllowMouseEffects = true;
            this.btnRead.AllowToggling = false;
            this.btnRead.AnimationSpeed = 200;
            this.btnRead.AutoGenerateColors = false;
            this.btnRead.AutoRoundBorders = false;
            this.btnRead.AutoSizeLeftIcon = true;
            this.btnRead.AutoSizeRightIcon = true;
            this.btnRead.BackColor = System.Drawing.Color.Transparent;
            this.btnRead.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnRead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRead.BackgroundImage")));
            this.btnRead.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRead.ButtonText = "Read";
            this.btnRead.ButtonTextMarginLeft = 0;
            this.btnRead.ColorContrastOnClick = 45;
            this.btnRead.ColorContrastOnHover = 45;
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRead.CustomizableEdges = borderEdges1;
            this.btnRead.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRead.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRead.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnRead.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnRead.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRead.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.IconLeft = null;
            this.btnRead.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRead.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRead.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRead.IconMarginLeft = 11;
            this.btnRead.IconPadding = 10;
            this.btnRead.IconRight = null;
            this.btnRead.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRead.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRead.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRead.IconSize = 25;
            this.btnRead.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnRead.IdleBorderRadius = 0;
            this.btnRead.IdleBorderThickness = 0;
            this.btnRead.IdleFillColor = System.Drawing.Color.Empty;
            this.btnRead.IdleIconLeftImage = null;
            this.btnRead.IdleIconRightImage = null;
            this.btnRead.IndicateFocus = false;
            this.btnRead.Location = new System.Drawing.Point(15, 575);
            this.btnRead.Name = "btnRead";
            this.btnRead.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRead.OnDisabledState.BorderRadius = 30;
            this.btnRead.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRead.OnDisabledState.BorderThickness = 1;
            this.btnRead.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRead.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRead.OnDisabledState.IconLeftImage = null;
            this.btnRead.OnDisabledState.IconRightImage = null;
            this.btnRead.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnRead.onHoverState.BorderRadius = 30;
            this.btnRead.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRead.onHoverState.BorderThickness = 1;
            this.btnRead.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnRead.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRead.onHoverState.IconLeftImage = null;
            this.btnRead.onHoverState.IconRightImage = null;
            this.btnRead.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnRead.OnIdleState.BorderRadius = 30;
            this.btnRead.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRead.OnIdleState.BorderThickness = 1;
            this.btnRead.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnRead.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRead.OnIdleState.IconLeftImage = null;
            this.btnRead.OnIdleState.IconRightImage = null;
            this.btnRead.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnRead.OnPressedState.BorderRadius = 30;
            this.btnRead.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRead.OnPressedState.BorderThickness = 1;
            this.btnRead.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnRead.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRead.OnPressedState.IconLeftImage = null;
            this.btnRead.OnPressedState.IconRightImage = null;
            this.btnRead.Size = new System.Drawing.Size(130, 40);
            this.btnRead.TabIndex = 8;
            this.btnRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRead.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRead.TextMarginLeft = 0;
            this.btnRead.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRead.UseDefaultRadiusAndThickness = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.AllowAnimations = true;
            this.btnClear.AllowMouseEffects = true;
            this.btnClear.AllowToggling = false;
            this.btnClear.AnimationSpeed = 200;
            this.btnClear.AutoGenerateColors = false;
            this.btnClear.AutoRoundBorders = false;
            this.btnClear.AutoSizeLeftIcon = true;
            this.btnClear.AutoSizeRightIcon = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.ButtonTextMarginLeft = 0;
            this.btnClear.ColorContrastOnClick = 45;
            this.btnClear.ColorContrastOnHover = 45;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnClear.CustomizableEdges = borderEdges2;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClear.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClear.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconLeft = null;
            this.btnClear.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClear.IconMarginLeft = 11;
            this.btnClear.IconPadding = 10;
            this.btnClear.IconRight = null;
            this.btnClear.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClear.IconSize = 25;
            this.btnClear.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClear.IdleBorderRadius = 0;
            this.btnClear.IdleBorderThickness = 0;
            this.btnClear.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClear.IdleIconLeftImage = null;
            this.btnClear.IdleIconRightImage = null;
            this.btnClear.IndicateFocus = false;
            this.btnClear.Location = new System.Drawing.Point(290, 575);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClear.OnDisabledState.BorderRadius = 30;
            this.btnClear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnDisabledState.BorderThickness = 1;
            this.btnClear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClear.OnDisabledState.IconLeftImage = null;
            this.btnClear.OnDisabledState.IconRightImage = null;
            this.btnClear.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnClear.onHoverState.BorderRadius = 30;
            this.btnClear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.onHoverState.BorderThickness = 1;
            this.btnClear.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnClear.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.onHoverState.IconLeftImage = null;
            this.btnClear.onHoverState.IconRightImage = null;
            this.btnClear.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.OnIdleState.BorderRadius = 30;
            this.btnClear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnIdleState.BorderThickness = 1;
            this.btnClear.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClear.OnIdleState.IconLeftImage = null;
            this.btnClear.OnIdleState.IconRightImage = null;
            this.btnClear.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.OnPressedState.BorderRadius = 30;
            this.btnClear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnPressedState.BorderThickness = 1;
            this.btnClear.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClear.OnPressedState.IconLeftImage = null;
            this.btnClear.OnPressedState.IconRightImage = null;
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.TextMarginLeft = 0;
            this.btnClear.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClear.UseDefaultRadiusAndThickness = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUploadQRCodeImage
            // 
            this.btnUploadQRCodeImage.AllowAnimations = true;
            this.btnUploadQRCodeImage.AllowMouseEffects = true;
            this.btnUploadQRCodeImage.AllowToggling = false;
            this.btnUploadQRCodeImage.AnimationSpeed = 200;
            this.btnUploadQRCodeImage.AutoGenerateColors = false;
            this.btnUploadQRCodeImage.AutoRoundBorders = false;
            this.btnUploadQRCodeImage.AutoSizeLeftIcon = true;
            this.btnUploadQRCodeImage.AutoSizeRightIcon = true;
            this.btnUploadQRCodeImage.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadQRCodeImage.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnUploadQRCodeImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadQRCodeImage.BackgroundImage")));
            this.btnUploadQRCodeImage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnUploadQRCodeImage.ButtonText = "";
            this.btnUploadQRCodeImage.ButtonTextMarginLeft = 0;
            this.btnUploadQRCodeImage.ColorContrastOnClick = 45;
            this.btnUploadQRCodeImage.ColorContrastOnHover = 45;
            this.btnUploadQRCodeImage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnUploadQRCodeImage.CustomizableEdges = borderEdges3;
            this.btnUploadQRCodeImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUploadQRCodeImage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUploadQRCodeImage.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnUploadQRCodeImage.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnUploadQRCodeImage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUploadQRCodeImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadQRCodeImage.ForeColor = System.Drawing.Color.Black;
            this.btnUploadQRCodeImage.IconLeft = global::QR_Code_Generator.Properties.Resources.UploadQRCodeImage;
            this.btnUploadQRCodeImage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadQRCodeImage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUploadQRCodeImage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUploadQRCodeImage.IconMarginLeft = 11;
            this.btnUploadQRCodeImage.IconPadding = 10;
            this.btnUploadQRCodeImage.IconRight = null;
            this.btnUploadQRCodeImage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUploadQRCodeImage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUploadQRCodeImage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUploadQRCodeImage.IconSize = 25;
            this.btnUploadQRCodeImage.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnUploadQRCodeImage.IdleBorderRadius = 0;
            this.btnUploadQRCodeImage.IdleBorderThickness = 0;
            this.btnUploadQRCodeImage.IdleFillColor = System.Drawing.Color.Empty;
            this.btnUploadQRCodeImage.IdleIconLeftImage = global::QR_Code_Generator.Properties.Resources.UploadQRCodeImage;
            this.btnUploadQRCodeImage.IdleIconRightImage = null;
            this.btnUploadQRCodeImage.IndicateFocus = false;
            this.btnUploadQRCodeImage.Location = new System.Drawing.Point(15, 445);
            this.btnUploadQRCodeImage.Name = "btnUploadQRCodeImage";
            this.btnUploadQRCodeImage.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUploadQRCodeImage.OnDisabledState.BorderRadius = 30;
            this.btnUploadQRCodeImage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUploadQRCodeImage.OnDisabledState.BorderThickness = 2;
            this.btnUploadQRCodeImage.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUploadQRCodeImage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUploadQRCodeImage.OnDisabledState.IconLeftImage = null;
            this.btnUploadQRCodeImage.OnDisabledState.IconRightImage = null;
            this.btnUploadQRCodeImage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnUploadQRCodeImage.onHoverState.BorderRadius = 30;
            this.btnUploadQRCodeImage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnUploadQRCodeImage.onHoverState.BorderThickness = 2;
            this.btnUploadQRCodeImage.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnUploadQRCodeImage.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUploadQRCodeImage.onHoverState.IconLeftImage = null;
            this.btnUploadQRCodeImage.onHoverState.IconRightImage = null;
            this.btnUploadQRCodeImage.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnUploadQRCodeImage.OnIdleState.BorderRadius = 30;
            this.btnUploadQRCodeImage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnUploadQRCodeImage.OnIdleState.BorderThickness = 2;
            this.btnUploadQRCodeImage.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnUploadQRCodeImage.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnUploadQRCodeImage.OnIdleState.IconLeftImage = global::QR_Code_Generator.Properties.Resources.UploadQRCodeImage;
            this.btnUploadQRCodeImage.OnIdleState.IconRightImage = null;
            this.btnUploadQRCodeImage.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnUploadQRCodeImage.OnPressedState.BorderRadius = 30;
            this.btnUploadQRCodeImage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnUploadQRCodeImage.OnPressedState.BorderThickness = 2;
            this.btnUploadQRCodeImage.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnUploadQRCodeImage.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUploadQRCodeImage.OnPressedState.IconLeftImage = null;
            this.btnUploadQRCodeImage.OnPressedState.IconRightImage = null;
            this.btnUploadQRCodeImage.Size = new System.Drawing.Size(405, 100);
            this.btnUploadQRCodeImage.TabIndex = 10;
            this.btnUploadQRCodeImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadQRCodeImage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUploadQRCodeImage.TextMarginLeft = 0;
            this.btnUploadQRCodeImage.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUploadQRCodeImage.UseDefaultRadiusAndThickness = true;
            this.btnUploadQRCodeImage.Click += new System.EventHandler(this.btnUploadQRCodeImage_Click);
            // 
            // cboCamera
            // 
            this.cboCamera.BackColor = System.Drawing.Color.Transparent;
            this.cboCamera.BackgroundColor = System.Drawing.Color.White;
            this.cboCamera.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cboCamera.BorderRadius = 17;
            this.cboCamera.Color = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cboCamera.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cboCamera.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboCamera.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cboCamera.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboCamera.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cboCamera.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cboCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCamera.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboCamera.FillDropDown = true;
            this.cboCamera.FillIndicator = false;
            this.cboCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCamera.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamera.ForeColor = System.Drawing.Color.Black;
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Icon = null;
            this.cboCamera.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboCamera.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cboCamera.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboCamera.IndicatorThickness = 2;
            this.cboCamera.IsDropdownOpened = false;
            this.cboCamera.ItemBackColor = System.Drawing.Color.White;
            this.cboCamera.ItemBorderColor = System.Drawing.Color.White;
            this.cboCamera.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cboCamera.ItemHeight = 34;
            this.cboCamera.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cboCamera.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cboCamera.ItemTopMargin = 3;
            this.cboCamera.Location = new System.Drawing.Point(15, 53);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(335, 40);
            this.cboCamera.TabIndex = 45;
            this.cboCamera.Text = null;
            this.cboCamera.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboCamera.TextLeftMargin = 5;
            // 
            // btnReload
            // 
            this.btnReload.AllowAnimations = true;
            this.btnReload.AllowMouseEffects = true;
            this.btnReload.AllowToggling = false;
            this.btnReload.AnimationSpeed = 200;
            this.btnReload.AutoGenerateColors = false;
            this.btnReload.AutoRoundBorders = false;
            this.btnReload.AutoSizeLeftIcon = true;
            this.btnReload.AutoSizeRightIcon = true;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.ButtonText = "";
            this.btnReload.ButtonTextMarginLeft = 0;
            this.btnReload.ColorContrastOnClick = 45;
            this.btnReload.ColorContrastOnHover = 45;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnReload.CustomizableEdges = borderEdges4;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnReload.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnReload.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.IconLeft = global::QR_Code_Generator.Properties.Resources.ReloadCamera;
            this.btnReload.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReload.IconMarginLeft = 11;
            this.btnReload.IconPadding = 8;
            this.btnReload.IconRight = null;
            this.btnReload.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReload.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReload.IconSize = 25;
            this.btnReload.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnReload.IdleBorderRadius = 0;
            this.btnReload.IdleBorderThickness = 0;
            this.btnReload.IdleFillColor = System.Drawing.Color.Empty;
            this.btnReload.IdleIconLeftImage = global::QR_Code_Generator.Properties.Resources.ReloadCamera;
            this.btnReload.IdleIconRightImage = null;
            this.btnReload.IndicateFocus = false;
            this.btnReload.Location = new System.Drawing.Point(360, 53);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReload.OnDisabledState.BorderRadius = 30;
            this.btnReload.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnDisabledState.BorderThickness = 1;
            this.btnReload.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReload.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReload.OnDisabledState.IconLeftImage = null;
            this.btnReload.OnDisabledState.IconRightImage = null;
            this.btnReload.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReload.onHoverState.BorderRadius = 30;
            this.btnReload.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.onHoverState.BorderThickness = 1;
            this.btnReload.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReload.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReload.onHoverState.IconLeftImage = null;
            this.btnReload.onHoverState.IconRightImage = null;
            this.btnReload.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnReload.OnIdleState.BorderRadius = 30;
            this.btnReload.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnIdleState.BorderThickness = 1;
            this.btnReload.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnReload.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReload.OnIdleState.IconLeftImage = global::QR_Code_Generator.Properties.Resources.ReloadCamera;
            this.btnReload.OnIdleState.IconRightImage = null;
            this.btnReload.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnReload.OnPressedState.BorderRadius = 30;
            this.btnReload.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReload.OnPressedState.BorderThickness = 1;
            this.btnReload.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnReload.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReload.OnPressedState.IconLeftImage = null;
            this.btnReload.OnPressedState.IconRightImage = null;
            this.btnReload.Size = new System.Drawing.Size(60, 40);
            this.btnReload.TabIndex = 46;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReload.TextMarginLeft = 0;
            this.btnReload.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReload.UseDefaultRadiusAndThickness = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStop
            // 
            this.btnStop.AllowAnimations = true;
            this.btnStop.AllowMouseEffects = true;
            this.btnStop.AllowToggling = false;
            this.btnStop.AnimationSpeed = 200;
            this.btnStop.AutoGenerateColors = false;
            this.btnStop.AutoRoundBorders = false;
            this.btnStop.AutoSizeLeftIcon = true;
            this.btnStop.AutoSizeRightIcon = true;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.ButtonText = "Stop";
            this.btnStop.ButtonTextMarginLeft = 0;
            this.btnStop.ColorContrastOnClick = 45;
            this.btnStop.ColorContrastOnHover = 45;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnStop.CustomizableEdges = borderEdges5;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStop.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnStop.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnStop.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.IconLeft = null;
            this.btnStop.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnStop.IconMarginLeft = 11;
            this.btnStop.IconPadding = 10;
            this.btnStop.IconRight = null;
            this.btnStop.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnStop.IconSize = 25;
            this.btnStop.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnStop.IdleBorderRadius = 0;
            this.btnStop.IdleBorderThickness = 0;
            this.btnStop.IdleFillColor = System.Drawing.Color.Empty;
            this.btnStop.IdleIconLeftImage = null;
            this.btnStop.IdleIconRightImage = null;
            this.btnStop.IndicateFocus = false;
            this.btnStop.Location = new System.Drawing.Point(153, 575);
            this.btnStop.Name = "btnStop";
            this.btnStop.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStop.OnDisabledState.BorderRadius = 30;
            this.btnStop.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.OnDisabledState.BorderThickness = 1;
            this.btnStop.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStop.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnStop.OnDisabledState.IconLeftImage = null;
            this.btnStop.OnDisabledState.IconRightImage = null;
            this.btnStop.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnStop.onHoverState.BorderRadius = 30;
            this.btnStop.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.onHoverState.BorderThickness = 1;
            this.btnStop.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnStop.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnStop.onHoverState.IconLeftImage = null;
            this.btnStop.onHoverState.IconRightImage = null;
            this.btnStop.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnStop.OnIdleState.BorderRadius = 30;
            this.btnStop.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.OnIdleState.BorderThickness = 1;
            this.btnStop.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnStop.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnStop.OnIdleState.IconLeftImage = null;
            this.btnStop.OnIdleState.IconRightImage = null;
            this.btnStop.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnStop.OnPressedState.BorderRadius = 30;
            this.btnStop.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStop.OnPressedState.BorderThickness = 1;
            this.btnStop.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnStop.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnStop.OnPressedState.IconLeftImage = null;
            this.btnStop.OnPressedState.IconRightImage = null;
            this.btnStop.Size = new System.Drawing.Size(130, 40);
            this.btnStop.TabIndex = 47;
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStop.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStop.TextMarginLeft = 0;
            this.btnStop.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnStop.UseDefaultRadiusAndThickness = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ReadQRCodePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.btnUploadQRCodeImage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.lblQRCode);
            this.Name = "ReadQRCodePanel";
            this.Size = new System.Drawing.Size(445, 645);
            this.Load += new System.EventHandler(this.ReadQRCodePanel_Load);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CameraImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQRCode;
        private Bunifu.UI.WinForms.BunifuPanel Panel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRead;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClear;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUploadQRCodeImage;
        private Bunifu.UI.WinForms.BunifuDropdown cboCamera;
        private System.Windows.Forms.PictureBox CameraImage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReload;
        private System.Windows.Forms.Timer timer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnStop;
    }
}
