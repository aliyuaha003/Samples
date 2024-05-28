namespace FTHGCentralStore
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activePanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnShopKeeper = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProducts = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCategories = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnOrders = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btnShopKeeper);
            this.panel1.Controls.Add(this.activePanel);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 600);
            this.panel1.TabIndex = 0;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.White;
            this.activePanel.Location = new System.Drawing.Point(0, 227);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(7, 52);
            this.activePanel.TabIndex = 0;
            // 
            // header
            // 
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.btnMinimize);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(218, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(882, 49);
            this.header.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(218, 551);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 49);
            this.panel3.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(218, 49);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(882, 502);
            this.panelContainer.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::FTHGCentralStore.Properties.Resources.icons8_multiply_208px_1;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 5;
            this.btnClose.ImageSize = new System.Drawing.Size(22, 22);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(27, 27);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(826, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 5;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveImage = null;
            this.btnMinimize.AllowAnimations = true;
            this.btnMinimize.AllowBuffering = false;
            this.btnMinimize.AllowToggling = false;
            this.btnMinimize.AllowZooming = true;
            this.btnMinimize.AllowZoomingOnFocus = false;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ErrorImage")));
            this.btnMinimize.FadeWhenInactive = false;
            this.btnMinimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMinimize.Image = global::FTHGCentralStore.Properties.Resources.icons8_subtract_208px_2;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.ImageLocation = null;
            this.btnMinimize.ImageMargin = 5;
            this.btnMinimize.ImageSize = new System.Drawing.Size(22, 22);
            this.btnMinimize.ImageZoomSize = new System.Drawing.Size(27, 27);
            this.btnMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.InitialImage")));
            this.btnMinimize.Location = new System.Drawing.Point(777, 9);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0;
            this.btnMinimize.ShowActiveImage = true;
            this.btnMinimize.ShowCursorChanges = true;
            this.btnMinimize.ShowImageBorders = true;
            this.btnMinimize.ShowSizeMarkers = false;
            this.btnMinimize.Size = new System.Drawing.Size(27, 27);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.ToolTipText = "";
            this.btnMinimize.WaitOnLoad = false;
            this.btnMinimize.Zoom = 5;
            this.btnMinimize.ZoomSpeed = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnShopKeeper
            // 
            this.btnShopKeeper.AllowAnimations = true;
            this.btnShopKeeper.AllowMouseEffects = true;
            this.btnShopKeeper.AllowToggling = false;
            this.btnShopKeeper.AnimationSpeed = 200;
            this.btnShopKeeper.AutoGenerateColors = false;
            this.btnShopKeeper.AutoRoundBorders = false;
            this.btnShopKeeper.AutoSizeLeftIcon = true;
            this.btnShopKeeper.AutoSizeRightIcon = true;
            this.btnShopKeeper.BackColor = System.Drawing.Color.Transparent;
            this.btnShopKeeper.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnShopKeeper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShopKeeper.BackgroundImage")));
            this.btnShopKeeper.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShopKeeper.ButtonText = "Shop keeper";
            this.btnShopKeeper.ButtonTextMarginLeft = 0;
            this.btnShopKeeper.ColorContrastOnClick = 45;
            this.btnShopKeeper.ColorContrastOnHover = 45;
            this.btnShopKeeper.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnShopKeeper.CustomizableEdges = borderEdges1;
            this.btnShopKeeper.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShopKeeper.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnShopKeeper.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnShopKeeper.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnShopKeeper.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnShopKeeper.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopKeeper.ForeColor = System.Drawing.Color.White;
            this.btnShopKeeper.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShopKeeper.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnShopKeeper.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnShopKeeper.IconMarginLeft = 11;
            this.btnShopKeeper.IconPadding = 10;
            this.btnShopKeeper.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShopKeeper.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnShopKeeper.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnShopKeeper.IconSize = 20;
            this.btnShopKeeper.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnShopKeeper.IdleBorderRadius = 5;
            this.btnShopKeeper.IdleBorderThickness = 1;
            this.btnShopKeeper.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnShopKeeper.IdleIconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_purchase_order_208px;
            this.btnShopKeeper.IdleIconRightImage = null;
            this.btnShopKeeper.IndicateFocus = false;
            this.btnShopKeeper.Location = new System.Drawing.Point(12, 522);
            this.btnShopKeeper.Name = "btnShopKeeper";
            this.btnShopKeeper.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnShopKeeper.OnDisabledState.BorderRadius = 5;
            this.btnShopKeeper.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShopKeeper.OnDisabledState.BorderThickness = 1;
            this.btnShopKeeper.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnShopKeeper.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnShopKeeper.OnDisabledState.IconLeftImage = null;
            this.btnShopKeeper.OnDisabledState.IconRightImage = null;
            this.btnShopKeeper.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnShopKeeper.onHoverState.BorderRadius = 5;
            this.btnShopKeeper.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShopKeeper.onHoverState.BorderThickness = 1;
            this.btnShopKeeper.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnShopKeeper.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnShopKeeper.onHoverState.IconLeftImage = null;
            this.btnShopKeeper.onHoverState.IconRightImage = null;
            this.btnShopKeeper.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnShopKeeper.OnIdleState.BorderRadius = 5;
            this.btnShopKeeper.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShopKeeper.OnIdleState.BorderThickness = 1;
            this.btnShopKeeper.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnShopKeeper.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnShopKeeper.OnIdleState.IconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_purchase_order_208px;
            this.btnShopKeeper.OnIdleState.IconRightImage = null;
            this.btnShopKeeper.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnShopKeeper.OnPressedState.BorderRadius = 5;
            this.btnShopKeeper.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnShopKeeper.OnPressedState.BorderThickness = 1;
            this.btnShopKeeper.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnShopKeeper.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnShopKeeper.OnPressedState.IconLeftImage = null;
            this.btnShopKeeper.OnPressedState.IconRightImage = null;
            this.btnShopKeeper.Size = new System.Drawing.Size(206, 52);
            this.btnShopKeeper.TabIndex = 10;
            this.btnShopKeeper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShopKeeper.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShopKeeper.TextMarginLeft = 0;
            this.btnShopKeeper.TextPadding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnShopKeeper.UseDefaultRadiusAndThickness = true;
            this.btnShopKeeper.Click += new System.EventHandler(this.btnShopKeeper_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowMouseEffects = true;
            this.btnSettings.AllowToggling = false;
            this.btnSettings.AnimationSpeed = 200;
            this.btnSettings.AutoGenerateColors = false;
            this.btnSettings.AutoRoundBorders = false;
            this.btnSettings.AutoSizeLeftIcon = true;
            this.btnSettings.AutoSizeRightIcon = true;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.ButtonText = "Settings";
            this.btnSettings.ButtonTextMarginLeft = 0;
            this.btnSettings.ColorContrastOnClick = 45;
            this.btnSettings.ColorContrastOnHover = 45;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSettings.CustomizableEdges = borderEdges2;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSettings.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSettings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnSettings.IconMarginLeft = 11;
            this.btnSettings.IconPadding = 10;
            this.btnSettings.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSettings.IconSize = 20;
            this.btnSettings.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnSettings.IdleBorderRadius = 5;
            this.btnSettings.IdleBorderThickness = 1;
            this.btnSettings.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnSettings.IdleIconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_services_208px;
            this.btnSettings.IdleIconRightImage = null;
            this.btnSettings.IndicateFocus = false;
            this.btnSettings.Location = new System.Drawing.Point(11, 464);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.OnDisabledState.BorderRadius = 5;
            this.btnSettings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnDisabledState.BorderThickness = 1;
            this.btnSettings.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSettings.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSettings.OnDisabledState.IconLeftImage = null;
            this.btnSettings.OnDisabledState.IconRightImage = null;
            this.btnSettings.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnSettings.onHoverState.BorderRadius = 5;
            this.btnSettings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.onHoverState.BorderThickness = 1;
            this.btnSettings.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnSettings.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.onHoverState.IconLeftImage = null;
            this.btnSettings.onHoverState.IconRightImage = null;
            this.btnSettings.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnSettings.OnIdleState.BorderRadius = 5;
            this.btnSettings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnIdleState.BorderThickness = 1;
            this.btnSettings.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnSettings.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.OnIdleState.IconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_services_208px;
            this.btnSettings.OnIdleState.IconRightImage = null;
            this.btnSettings.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnSettings.OnPressedState.BorderRadius = 5;
            this.btnSettings.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnPressedState.BorderThickness = 1;
            this.btnSettings.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnSettings.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.OnPressedState.IconLeftImage = null;
            this.btnSettings.OnPressedState.IconRightImage = null;
            this.btnSettings.Size = new System.Drawing.Size(206, 52);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSettings.TextMarginLeft = 0;
            this.btnSettings.TextPadding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnSettings.UseDefaultRadiusAndThickness = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.AllowAnimations = true;
            this.btnProducts.AllowMouseEffects = true;
            this.btnProducts.AllowToggling = false;
            this.btnProducts.AnimationSpeed = 200;
            this.btnProducts.AutoGenerateColors = false;
            this.btnProducts.AutoRoundBorders = false;
            this.btnProducts.AutoSizeLeftIcon = true;
            this.btnProducts.AutoSizeRightIcon = true;
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.BackgroundImage")));
            this.btnProducts.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProducts.ButtonText = "Products";
            this.btnProducts.ButtonTextMarginLeft = 0;
            this.btnProducts.ColorContrastOnClick = 45;
            this.btnProducts.ColorContrastOnHover = 45;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnProducts.CustomizableEdges = borderEdges3;
            this.btnProducts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProducts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProducts.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProducts.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProducts.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProducts.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnProducts.IconMarginLeft = 11;
            this.btnProducts.IconPadding = 10;
            this.btnProducts.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProducts.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProducts.IconSize = 20;
            this.btnProducts.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnProducts.IdleBorderRadius = 5;
            this.btnProducts.IdleBorderThickness = 1;
            this.btnProducts.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnProducts.IdleIconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_product_208px;
            this.btnProducts.IdleIconRightImage = null;
            this.btnProducts.IndicateFocus = false;
            this.btnProducts.Location = new System.Drawing.Point(12, 404);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProducts.OnDisabledState.BorderRadius = 5;
            this.btnProducts.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProducts.OnDisabledState.BorderThickness = 1;
            this.btnProducts.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProducts.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProducts.OnDisabledState.IconLeftImage = null;
            this.btnProducts.OnDisabledState.IconRightImage = null;
            this.btnProducts.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnProducts.onHoverState.BorderRadius = 5;
            this.btnProducts.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProducts.onHoverState.BorderThickness = 1;
            this.btnProducts.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnProducts.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnProducts.onHoverState.IconLeftImage = null;
            this.btnProducts.onHoverState.IconRightImage = null;
            this.btnProducts.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnProducts.OnIdleState.BorderRadius = 5;
            this.btnProducts.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProducts.OnIdleState.BorderThickness = 1;
            this.btnProducts.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnProducts.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProducts.OnIdleState.IconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_product_208px;
            this.btnProducts.OnIdleState.IconRightImage = null;
            this.btnProducts.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnProducts.OnPressedState.BorderRadius = 5;
            this.btnProducts.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProducts.OnPressedState.BorderThickness = 1;
            this.btnProducts.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnProducts.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnProducts.OnPressedState.IconLeftImage = null;
            this.btnProducts.OnPressedState.IconRightImage = null;
            this.btnProducts.Size = new System.Drawing.Size(206, 52);
            this.btnProducts.TabIndex = 8;
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProducts.TextMarginLeft = 0;
            this.btnProducts.TextPadding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnProducts.UseDefaultRadiusAndThickness = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.AllowAnimations = true;
            this.btnCategories.AllowMouseEffects = true;
            this.btnCategories.AllowToggling = false;
            this.btnCategories.AnimationSpeed = 200;
            this.btnCategories.AutoGenerateColors = false;
            this.btnCategories.AutoRoundBorders = false;
            this.btnCategories.AutoSizeLeftIcon = true;
            this.btnCategories.AutoSizeRightIcon = true;
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnCategories.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCategories.BackgroundImage")));
            this.btnCategories.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.ButtonText = "Categories";
            this.btnCategories.ButtonTextMarginLeft = 0;
            this.btnCategories.ColorContrastOnClick = 45;
            this.btnCategories.ColorContrastOnHover = 45;
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnCategories.CustomizableEdges = borderEdges4;
            this.btnCategories.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategories.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCategories.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCategories.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCategories.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCategories.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnCategories.IconMarginLeft = 11;
            this.btnCategories.IconPadding = 10;
            this.btnCategories.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategories.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCategories.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCategories.IconSize = 20;
            this.btnCategories.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnCategories.IdleBorderRadius = 5;
            this.btnCategories.IdleBorderThickness = 1;
            this.btnCategories.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnCategories.IdleIconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_opened_folder_208px_1;
            this.btnCategories.IdleIconRightImage = null;
            this.btnCategories.IndicateFocus = false;
            this.btnCategories.Location = new System.Drawing.Point(11, 344);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCategories.OnDisabledState.BorderRadius = 5;
            this.btnCategories.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.OnDisabledState.BorderThickness = 1;
            this.btnCategories.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCategories.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCategories.OnDisabledState.IconLeftImage = null;
            this.btnCategories.OnDisabledState.IconRightImage = null;
            this.btnCategories.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnCategories.onHoverState.BorderRadius = 5;
            this.btnCategories.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.onHoverState.BorderThickness = 1;
            this.btnCategories.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnCategories.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCategories.onHoverState.IconLeftImage = null;
            this.btnCategories.onHoverState.IconRightImage = null;
            this.btnCategories.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnCategories.OnIdleState.BorderRadius = 5;
            this.btnCategories.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.OnIdleState.BorderThickness = 1;
            this.btnCategories.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnCategories.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCategories.OnIdleState.IconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_opened_folder_208px_1;
            this.btnCategories.OnIdleState.IconRightImage = null;
            this.btnCategories.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnCategories.OnPressedState.BorderRadius = 5;
            this.btnCategories.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.OnPressedState.BorderThickness = 1;
            this.btnCategories.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnCategories.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCategories.OnPressedState.IconLeftImage = null;
            this.btnCategories.OnPressedState.IconRightImage = null;
            this.btnCategories.Size = new System.Drawing.Size(206, 52);
            this.btnCategories.TabIndex = 7;
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCategories.TextMarginLeft = 0;
            this.btnCategories.TextPadding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnCategories.UseDefaultRadiusAndThickness = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.AllowAnimations = true;
            this.btnOrders.AllowMouseEffects = true;
            this.btnOrders.AllowToggling = false;
            this.btnOrders.AnimationSpeed = 200;
            this.btnOrders.AutoGenerateColors = false;
            this.btnOrders.AutoRoundBorders = false;
            this.btnOrders.AutoSizeLeftIcon = true;
            this.btnOrders.AutoSizeRightIcon = true;
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrders.BackgroundImage")));
            this.btnOrders.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrders.ButtonText = "Orders";
            this.btnOrders.ButtonTextMarginLeft = 0;
            this.btnOrders.ColorContrastOnClick = 45;
            this.btnOrders.ColorContrastOnHover = 45;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnOrders.CustomizableEdges = borderEdges5;
            this.btnOrders.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrders.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOrders.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOrders.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOrders.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOrders.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnOrders.IconMarginLeft = 11;
            this.btnOrders.IconPadding = 10;
            this.btnOrders.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOrders.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOrders.IconSize = 20;
            this.btnOrders.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnOrders.IdleBorderRadius = 5;
            this.btnOrders.IdleBorderThickness = 1;
            this.btnOrders.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnOrders.IdleIconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_purchase_order_208px;
            this.btnOrders.IdleIconRightImage = null;
            this.btnOrders.IndicateFocus = false;
            this.btnOrders.Location = new System.Drawing.Point(11, 285);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOrders.OnDisabledState.BorderRadius = 5;
            this.btnOrders.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrders.OnDisabledState.BorderThickness = 1;
            this.btnOrders.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOrders.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOrders.OnDisabledState.IconLeftImage = null;
            this.btnOrders.OnDisabledState.IconRightImage = null;
            this.btnOrders.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnOrders.onHoverState.BorderRadius = 5;
            this.btnOrders.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrders.onHoverState.BorderThickness = 1;
            this.btnOrders.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnOrders.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOrders.onHoverState.IconLeftImage = null;
            this.btnOrders.onHoverState.IconRightImage = null;
            this.btnOrders.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnOrders.OnIdleState.BorderRadius = 5;
            this.btnOrders.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrders.OnIdleState.BorderThickness = 1;
            this.btnOrders.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnOrders.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOrders.OnIdleState.IconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_purchase_order_208px;
            this.btnOrders.OnIdleState.IconRightImage = null;
            this.btnOrders.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnOrders.OnPressedState.BorderRadius = 5;
            this.btnOrders.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrders.OnPressedState.BorderThickness = 1;
            this.btnOrders.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnOrders.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOrders.OnPressedState.IconLeftImage = null;
            this.btnOrders.OnPressedState.IconRightImage = null;
            this.btnOrders.Size = new System.Drawing.Size(206, 51);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOrders.TextMarginLeft = 0;
            this.btnOrders.TextPadding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnOrders.UseDefaultRadiusAndThickness = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AllowAnimations = true;
            this.btnDashboard.AllowMouseEffects = true;
            this.btnDashboard.AllowToggling = false;
            this.btnDashboard.AnimationSpeed = 200;
            this.btnDashboard.AutoGenerateColors = false;
            this.btnDashboard.AutoRoundBorders = false;
            this.btnDashboard.AutoSizeLeftIcon = true;
            this.btnDashboard.AutoSizeRightIcon = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.ButtonTextMarginLeft = 0;
            this.btnDashboard.ColorContrastOnClick = 45;
            this.btnDashboard.ColorContrastOnHover = 45;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnDashboard.CustomizableEdges = borderEdges6;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashboard.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconLeftPadding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnDashboard.IconMarginLeft = 11;
            this.btnDashboard.IconPadding = 10;
            this.btnDashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDashboard.IconSize = 20;
            this.btnDashboard.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnDashboard.IdleBorderRadius = 5;
            this.btnDashboard.IdleBorderThickness = 1;
            this.btnDashboard.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnDashboard.IdleIconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_home_26px;
            this.btnDashboard.IdleIconRightImage = null;
            this.btnDashboard.IndicateFocus = false;
            this.btnDashboard.Location = new System.Drawing.Point(12, 225);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.OnDisabledState.BorderRadius = 5;
            this.btnDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnDisabledState.BorderThickness = 1;
            this.btnDashboard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashboard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashboard.OnDisabledState.IconLeftImage = null;
            this.btnDashboard.OnDisabledState.IconRightImage = null;
            this.btnDashboard.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnDashboard.onHoverState.BorderRadius = 5;
            this.btnDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.onHoverState.BorderThickness = 1;
            this.btnDashboard.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(134)))));
            this.btnDashboard.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.onHoverState.IconLeftImage = null;
            this.btnDashboard.onHoverState.IconRightImage = null;
            this.btnDashboard.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnDashboard.OnIdleState.BorderRadius = 5;
            this.btnDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnIdleState.BorderThickness = 1;
            this.btnDashboard.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnDashboard.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnIdleState.IconLeftImage = global::FTHGCentralStore.Properties.Resources.icons8_home_26px;
            this.btnDashboard.OnIdleState.IconRightImage = null;
            this.btnDashboard.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnDashboard.OnPressedState.BorderRadius = 5;
            this.btnDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnPressedState.BorderThickness = 1;
            this.btnDashboard.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnDashboard.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnPressedState.IconLeftImage = null;
            this.btnDashboard.OnPressedState.IconRightImage = null;
            this.btnDashboard.Size = new System.Drawing.Size(206, 52);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.TextMarginLeft = 0;
            this.btnDashboard.TextPadding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnDashboard.UseDefaultRadiusAndThickness = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FTHGCentralStore.Properties.Resources.fthlogo2;
            this.pictureBox1.Location = new System.Drawing.Point(48, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashboard;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProducts;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCategories;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOrders;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSettings;
        private System.Windows.Forms.Panel header;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelContainer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel activePanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnShopKeeper;
    }
}