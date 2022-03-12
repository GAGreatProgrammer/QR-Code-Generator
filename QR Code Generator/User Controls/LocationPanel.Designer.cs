
namespace QR_Code_Generator
{
    partial class LocationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationPanel));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnFindAddress = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtLongitude = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLatitude = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.pnlMap = new Bunifu.UI.WinForms.BunifuPanel();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindAddress
            // 
            this.btnFindAddress.AllowAnimations = true;
            this.btnFindAddress.AllowMouseEffects = true;
            this.btnFindAddress.AllowToggling = false;
            this.btnFindAddress.AnimationSpeed = 200;
            this.btnFindAddress.AutoGenerateColors = false;
            this.btnFindAddress.AutoRoundBorders = false;
            this.btnFindAddress.AutoSizeLeftIcon = true;
            this.btnFindAddress.AutoSizeRightIcon = true;
            this.btnFindAddress.BackColor = System.Drawing.Color.Transparent;
            this.btnFindAddress.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnFindAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindAddress.BackgroundImage")));
            this.btnFindAddress.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAddress.ButtonText = "Find";
            this.btnFindAddress.ButtonTextMarginLeft = 0;
            this.btnFindAddress.ColorContrastOnClick = 45;
            this.btnFindAddress.ColorContrastOnHover = 45;
            this.btnFindAddress.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnFindAddress.CustomizableEdges = borderEdges1;
            this.btnFindAddress.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFindAddress.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFindAddress.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnFindAddress.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnFindAddress.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFindAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAddress.ForeColor = System.Drawing.Color.White;
            this.btnFindAddress.IconLeft = null;
            this.btnFindAddress.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindAddress.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFindAddress.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFindAddress.IconMarginLeft = 11;
            this.btnFindAddress.IconPadding = 10;
            this.btnFindAddress.IconRight = null;
            this.btnFindAddress.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindAddress.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFindAddress.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFindAddress.IconSize = 25;
            this.btnFindAddress.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnFindAddress.IdleBorderRadius = 0;
            this.btnFindAddress.IdleBorderThickness = 0;
            this.btnFindAddress.IdleFillColor = System.Drawing.Color.Empty;
            this.btnFindAddress.IdleIconLeftImage = null;
            this.btnFindAddress.IdleIconRightImage = null;
            this.btnFindAddress.IndicateFocus = false;
            this.btnFindAddress.Location = new System.Drawing.Point(551, 52);
            this.btnFindAddress.Name = "btnFindAddress";
            this.btnFindAddress.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFindAddress.OnDisabledState.BorderRadius = 30;
            this.btnFindAddress.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAddress.OnDisabledState.BorderThickness = 1;
            this.btnFindAddress.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFindAddress.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFindAddress.OnDisabledState.IconLeftImage = null;
            this.btnFindAddress.OnDisabledState.IconRightImage = null;
            this.btnFindAddress.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(238)))), ((int)(((byte)(161)))));
            this.btnFindAddress.onHoverState.BorderRadius = 30;
            this.btnFindAddress.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAddress.onHoverState.BorderThickness = 1;
            this.btnFindAddress.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(238)))), ((int)(((byte)(161)))));
            this.btnFindAddress.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFindAddress.onHoverState.IconLeftImage = null;
            this.btnFindAddress.onHoverState.IconRightImage = null;
            this.btnFindAddress.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnFindAddress.OnIdleState.BorderRadius = 30;
            this.btnFindAddress.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAddress.OnIdleState.BorderThickness = 1;
            this.btnFindAddress.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnFindAddress.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFindAddress.OnIdleState.IconLeftImage = null;
            this.btnFindAddress.OnIdleState.IconRightImage = null;
            this.btnFindAddress.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnFindAddress.OnPressedState.BorderRadius = 30;
            this.btnFindAddress.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFindAddress.OnPressedState.BorderThickness = 1;
            this.btnFindAddress.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(219)))), ((int)(((byte)(135)))));
            this.btnFindAddress.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFindAddress.OnPressedState.IconLeftImage = null;
            this.btnFindAddress.OnPressedState.IconRightImage = null;
            this.btnFindAddress.Size = new System.Drawing.Size(120, 40);
            this.btnFindAddress.TabIndex = 9;
            this.btnFindAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFindAddress.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFindAddress.TextMarginLeft = 0;
            this.btnFindAddress.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFindAddress.UseDefaultRadiusAndThickness = true;
            this.btnFindAddress.Click += new System.EventHandler(this.btnClearAddress_Click);
            // 
            // txtLongitude
            // 
            this.txtLongitude.AcceptsReturn = false;
            this.txtLongitude.AcceptsTab = false;
            this.txtLongitude.AnimationSpeed = 200;
            this.txtLongitude.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLongitude.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLongitude.AutoSizeHeight = true;
            this.txtLongitude.BackColor = System.Drawing.Color.Transparent;
            this.txtLongitude.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLongitude.BackgroundImage")));
            this.txtLongitude.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtLongitude.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLongitude.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtLongitude.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtLongitude.BorderRadius = 30;
            this.txtLongitude.BorderThickness = 2;
            this.txtLongitude.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLongitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLongitude.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.DefaultText = "";
            this.txtLongitude.FillColor = System.Drawing.Color.White;
            this.txtLongitude.HideSelection = true;
            this.txtLongitude.IconLeft = null;
            this.txtLongitude.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLongitude.IconPadding = 10;
            this.txtLongitude.IconRight = null;
            this.txtLongitude.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLongitude.Lines = new string[0];
            this.txtLongitude.Location = new System.Drawing.Point(293, 52);
            this.txtLongitude.MaxLength = 32767;
            this.txtLongitude.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLongitude.Modified = false;
            this.txtLongitude.Multiline = false;
            this.txtLongitude.Name = "txtLongitude";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLongitude.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtLongitude.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLongitude.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLongitude.OnIdleState = stateProperties4;
            this.txtLongitude.Padding = new System.Windows.Forms.Padding(3);
            this.txtLongitude.PasswordChar = '\0';
            this.txtLongitude.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLongitude.PlaceholderText = "";
            this.txtLongitude.ReadOnly = false;
            this.txtLongitude.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLongitude.SelectedText = "";
            this.txtLongitude.SelectionLength = 0;
            this.txtLongitude.SelectionStart = 0;
            this.txtLongitude.ShortcutsEnabled = true;
            this.txtLongitude.Size = new System.Drawing.Size(250, 40);
            this.txtLongitude.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtLongitude.TabIndex = 29;
            this.txtLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLongitude.TextMarginBottom = 0;
            this.txtLongitude.TextMarginLeft = 3;
            this.txtLongitude.TextMarginTop = 1;
            this.txtLongitude.TextPlaceholder = "";
            this.txtLongitude.UseSystemPasswordChar = false;
            this.txtLongitude.WordWrap = true;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblLongitude.Location = new System.Drawing.Point(293, 25);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(89, 20);
            this.lblLongitude.TabIndex = 28;
            this.lblLongitude.Text = "Longitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.AcceptsReturn = false;
            this.txtLatitude.AcceptsTab = false;
            this.txtLatitude.AnimationSpeed = 200;
            this.txtLatitude.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLatitude.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLatitude.AutoSizeHeight = true;
            this.txtLatitude.BackColor = System.Drawing.Color.Transparent;
            this.txtLatitude.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLatitude.BackgroundImage")));
            this.txtLatitude.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtLatitude.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLatitude.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtLatitude.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.txtLatitude.BorderRadius = 30;
            this.txtLatitude.BorderThickness = 2;
            this.txtLatitude.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLatitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLatitude.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.DefaultText = "";
            this.txtLatitude.FillColor = System.Drawing.Color.White;
            this.txtLatitude.HideSelection = true;
            this.txtLatitude.IconLeft = null;
            this.txtLatitude.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLatitude.IconPadding = 10;
            this.txtLatitude.IconRight = null;
            this.txtLatitude.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLatitude.Lines = new string[0];
            this.txtLatitude.Location = new System.Drawing.Point(21, 52);
            this.txtLatitude.MaxLength = 32767;
            this.txtLatitude.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLatitude.Modified = false;
            this.txtLatitude.Multiline = false;
            this.txtLatitude.Name = "txtLatitude";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLatitude.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtLatitude.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLatitude.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLatitude.OnIdleState = stateProperties8;
            this.txtLatitude.Padding = new System.Windows.Forms.Padding(3);
            this.txtLatitude.PasswordChar = '\0';
            this.txtLatitude.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLatitude.PlaceholderText = "";
            this.txtLatitude.ReadOnly = false;
            this.txtLatitude.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLatitude.SelectedText = "";
            this.txtLatitude.SelectionLength = 0;
            this.txtLatitude.SelectionStart = 0;
            this.txtLatitude.ShortcutsEnabled = true;
            this.txtLatitude.Size = new System.Drawing.Size(250, 40);
            this.txtLatitude.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtLatitude.TabIndex = 27;
            this.txtLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLatitude.TextMarginBottom = 0;
            this.txtLatitude.TextMarginLeft = 3;
            this.txtLatitude.TextMarginTop = 1;
            this.txtLatitude.TextPlaceholder = "";
            this.txtLatitude.UseSystemPasswordChar = false;
            this.txtLatitude.WordWrap = true;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblLatitude.Location = new System.Drawing.Point(28, 25);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(75, 20);
            this.lblLatitude.TabIndex = 26;
            this.lblLatitude.Text = "Latitude";
            // 
            // pnlMap
            // 
            this.pnlMap.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMap.BackgroundImage")));
            this.pnlMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.pnlMap.BorderRadius = 30;
            this.pnlMap.BorderThickness = 2;
            this.pnlMap.Controls.Add(this.Map);
            this.pnlMap.Location = new System.Drawing.Point(29, 122);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.ShowBorders = true;
            this.pnlMap.Size = new System.Drawing.Size(642, 430);
            this.pnlMap.TabIndex = 30;
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(13, 13);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 100;
            this.Map.MinZoom = 1;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(615, 405);
            this.Map.TabIndex = 31;
            this.Map.Zoom = 2D;
            // 
            // LocationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.btnFindAddress);
            this.Name = "LocationPanel";
            this.Size = new System.Drawing.Size(700, 570);
            this.Load += new System.EventHandler(this.LocationPanel_Load);
            this.pnlMap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFindAddress;
        private Bunifu.UI.WinForms.BunifuTextBox txtLongitude;
        private System.Windows.Forms.Label lblLongitude;
        private Bunifu.UI.WinForms.BunifuTextBox txtLatitude;
        private System.Windows.Forms.Label lblLatitude;
        private Bunifu.UI.WinForms.BunifuPanel pnlMap;
        private GMap.NET.WindowsForms.GMapControl Map;
    }
}
