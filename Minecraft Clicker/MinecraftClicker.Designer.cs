
namespace Minecraft_Clicker
{
    partial class MinecraftClicker
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinecraftClicker));
            this.Binding = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPSValue = new System.Windows.Forms.Label();
            this.bindBtn = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.randomTB = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.CPSTrackbar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.label3 = new System.Windows.Forms.Label();
            this.RGB = new System.Windows.Forms.Timer(this.components);
            this.clickSounds = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RGBtoggle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FluxTimer = new System.Windows.Forms.Timer(this.components);
            this.SendClick = new System.Windows.Forms.Timer(this.components);
            this.IsMouseDown = new System.Windows.Forms.Timer(this.components);
            this.iswindowjava = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btnToggle2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CPSTrackbar2 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.CPSValue2 = new System.Windows.Forms.Label();
            this.inventorycheck = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FluxTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SendClick2 = new System.Windows.Forms.Timer(this.components);
            this.IsMouseDown2 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.randomTB)).BeginInit();
            this.SuspendLayout();
            // 
            // Binding
            // 
            this.Binding.Enabled = true;
            this.Binding.Tick += new System.EventHandler(this.Binding_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seppuku\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left Click";
            // 
            // CPSValue
            // 
            this.CPSValue.AutoSize = true;
            this.CPSValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.CPSValue.Location = new System.Drawing.Point(180, 120);
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(44, 14);
            this.CPSValue.TabIndex = 7;
            this.CPSValue.Text = "8 CPS";
            // 
            // bindBtn
            // 
            this.bindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bindBtn.Font = new System.Drawing.Font("Verdana", 9F);
            this.bindBtn.Location = new System.Drawing.Point(152, 215);
            this.bindBtn.Margin = new System.Windows.Forms.Padding(0);
            this.bindBtn.Name = "bindBtn";
            this.bindBtn.Size = new System.Drawing.Size(66, 31);
            this.bindBtn.TabIndex = 999;
            this.bindBtn.Text = "none";
            this.bindBtn.Click += new System.EventHandler(this.bindBtn_Click);
            this.bindBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindBtn_KeyDown);
            // 
            // btnToggle
            // 
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnToggle.Location = new System.Drawing.Point(158, 75);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(0);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(66, 31);
            this.btnToggle.TabIndex = 15;
            this.btnToggle.Text = "enable";
            this.btnToggle.TextChanged += new System.EventHandler(this.btnToggle_TextChanged);
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // randomTB
            // 
            this.randomTB.Location = new System.Drawing.Point(-4, 374);
            this.randomTB.Maximum = 30;
            this.randomTB.Name = "randomTB";
            this.randomTB.Size = new System.Drawing.Size(233, 45);
            this.randomTB.TabIndex = 16;
            this.randomTB.Value = 12;
            this.randomTB.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F);
            this.label5.Location = new System.Drawing.Point(10, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Key Bind";
            // 
            // CPSTrackbar
            // 
            this.CPSTrackbar.AllowCursorChanges = true;
            this.CPSTrackbar.AllowHomeEndKeysDetection = false;
            this.CPSTrackbar.AllowIncrementalClickMoves = true;
            this.CPSTrackbar.AllowMouseDownEffects = false;
            this.CPSTrackbar.AllowMouseHoverEffects = false;
            this.CPSTrackbar.AllowScrollingAnimations = true;
            this.CPSTrackbar.AllowScrollKeysDetection = true;
            this.CPSTrackbar.AllowScrollOptionsMenu = true;
            this.CPSTrackbar.AllowShrinkingOnFocusLost = false;
            this.CPSTrackbar.BackColor = System.Drawing.Color.Transparent;
            this.CPSTrackbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CPSTrackbar.BackgroundImage")));
            this.CPSTrackbar.BindingContainer = null;
            this.CPSTrackbar.BorderRadius = 2;
            this.CPSTrackbar.BorderThickness = 1;
            this.CPSTrackbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CPSTrackbar.DrawThickBorder = false;
            this.CPSTrackbar.DurationBeforeShrink = 2000;
            this.CPSTrackbar.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.CPSTrackbar.LargeChange = 10;
            this.CPSTrackbar.Location = new System.Drawing.Point(16, 113);
            this.CPSTrackbar.Maximum = 20;
            this.CPSTrackbar.Minimum = 6;
            this.CPSTrackbar.MinimumSize = new System.Drawing.Size(0, 31);
            this.CPSTrackbar.MinimumThumbLength = 18;
            this.CPSTrackbar.Name = "CPSTrackbar";
            this.CPSTrackbar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.CPSTrackbar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.CPSTrackbar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.CPSTrackbar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CPSTrackbar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CPSTrackbar.ShrinkSizeLimit = 3;
            this.CPSTrackbar.Size = new System.Drawing.Size(161, 31);
            this.CPSTrackbar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CPSTrackbar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.CPSTrackbar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.CPSTrackbar.SmallChange = 1;
            this.CPSTrackbar.TabIndex = 1;
            this.CPSTrackbar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.CPSTrackbar.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.CPSTrackbar.ThumbLength = 108;
            this.CPSTrackbar.ThumbMargin = 1;
            this.CPSTrackbar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.CPSTrackbar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.CPSTrackbar.Value = 8;
            this.CPSTrackbar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.CPSTrackbar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(77, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "CPS";
            // 
            // RGB
            // 
            this.RGB.Interval = 240;
            this.RGB.Tick += new System.EventHandler(this.RGB_Tick);
            // 
            // clickSounds
            // 
            this.clickSounds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickSounds.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickSounds.Location = new System.Drawing.Point(152, 264);
            this.clickSounds.Margin = new System.Windows.Forms.Padding(0);
            this.clickSounds.Name = "clickSounds";
            this.clickSounds.Size = new System.Drawing.Size(66, 31);
            this.clickSounds.TabIndex = 20;
            this.clickSounds.Text = "enable";
            this.clickSounds.Click += new System.EventHandler(this.clickSounds_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F);
            this.label4.Location = new System.Drawing.Point(10, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Click Sounds";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(218, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(180, -1);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 31);
            this.button2.TabIndex = 23;
            this.button2.Text = "—";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 31);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // RGBtoggle
            // 
            this.RGBtoggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RGBtoggle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGBtoggle.Location = new System.Drawing.Point(152, 314);
            this.RGBtoggle.Margin = new System.Windows.Forms.Padding(0);
            this.RGBtoggle.Name = "RGBtoggle";
            this.RGBtoggle.Size = new System.Drawing.Size(66, 31);
            this.RGBtoggle.TabIndex = 1000;
            this.RGBtoggle.Text = "enable";
            this.RGBtoggle.Click += new System.EventHandler(this.RGBtoggle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F);
            this.label6.Location = new System.Drawing.Point(10, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 1001;
            this.label6.Text = "RGB Mode";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 1002;
            this.textBox1.Text = "8";
            this.textBox1.Visible = false;
            // 
            // FluxTimer
            // 
            this.FluxTimer.Interval = 50;
            this.FluxTimer.Tick += new System.EventHandler(this.FluxTimer_Tick);
            // 
            // SendClick
            // 
            this.SendClick.Tick += new System.EventHandler(this.SendClick_Tick);
            // 
            // IsMouseDown
            // 
            this.IsMouseDown.Enabled = true;
            this.IsMouseDown.Interval = 500;
            this.IsMouseDown.Tick += new System.EventHandler(this.IsMouseDown_Tick);
            // 
            // iswindowjava
            // 
            this.iswindowjava.Interval = 1000;
            this.iswindowjava.Tick += new System.EventHandler(this.iswindowjava_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.label7.Location = new System.Drawing.Point(84, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 14);
            this.label7.TabIndex = 1006;
            this.label7.Text = "CPS";
            // 
            // btnToggle2
            // 
            this.btnToggle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle2.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnToggle2.Location = new System.Drawing.Point(158, 139);
            this.btnToggle2.Margin = new System.Windows.Forms.Padding(0);
            this.btnToggle2.Name = "btnToggle2";
            this.btnToggle2.Size = new System.Drawing.Size(66, 31);
            this.btnToggle2.TabIndex = 1005;
            this.btnToggle2.Text = "enable";
            this.btnToggle2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 1003;
            this.label8.Text = "Right Click";
            // 
            // CPSTrackbar2
            // 
            this.CPSTrackbar2.AllowCursorChanges = true;
            this.CPSTrackbar2.AllowHomeEndKeysDetection = false;
            this.CPSTrackbar2.AllowIncrementalClickMoves = true;
            this.CPSTrackbar2.AllowMouseDownEffects = false;
            this.CPSTrackbar2.AllowMouseHoverEffects = false;
            this.CPSTrackbar2.AllowScrollingAnimations = true;
            this.CPSTrackbar2.AllowScrollKeysDetection = true;
            this.CPSTrackbar2.AllowScrollOptionsMenu = true;
            this.CPSTrackbar2.AllowShrinkingOnFocusLost = false;
            this.CPSTrackbar2.BackColor = System.Drawing.Color.Transparent;
            this.CPSTrackbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CPSTrackbar2.BackgroundImage")));
            this.CPSTrackbar2.BindingContainer = null;
            this.CPSTrackbar2.BorderRadius = 2;
            this.CPSTrackbar2.BorderThickness = 1;
            this.CPSTrackbar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CPSTrackbar2.DrawThickBorder = false;
            this.CPSTrackbar2.DurationBeforeShrink = 2000;
            this.CPSTrackbar2.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.CPSTrackbar2.LargeChange = 10;
            this.CPSTrackbar2.Location = new System.Drawing.Point(16, 177);
            this.CPSTrackbar2.Maximum = 20;
            this.CPSTrackbar2.Minimum = 6;
            this.CPSTrackbar2.MinimumSize = new System.Drawing.Size(0, 31);
            this.CPSTrackbar2.MinimumThumbLength = 18;
            this.CPSTrackbar2.Name = "CPSTrackbar2";
            this.CPSTrackbar2.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.CPSTrackbar2.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.CPSTrackbar2.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.CPSTrackbar2.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CPSTrackbar2.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CPSTrackbar2.ShrinkSizeLimit = 3;
            this.CPSTrackbar2.Size = new System.Drawing.Size(161, 31);
            this.CPSTrackbar2.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CPSTrackbar2.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.CPSTrackbar2.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.CPSTrackbar2.SmallChange = 1;
            this.CPSTrackbar2.TabIndex = 1004;
            this.CPSTrackbar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.CPSTrackbar2.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.CPSTrackbar2.ThumbLength = 108;
            this.CPSTrackbar2.ThumbMargin = 1;
            this.CPSTrackbar2.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.CPSTrackbar2.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.CPSTrackbar2.Value = 6;
            this.CPSTrackbar2.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSlider1_Scroll);
            // 
            // CPSValue2
            // 
            this.CPSValue2.AutoSize = true;
            this.CPSValue2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSValue2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.CPSValue2.Location = new System.Drawing.Point(180, 186);
            this.CPSValue2.Name = "CPSValue2";
            this.CPSValue2.Size = new System.Drawing.Size(44, 14);
            this.CPSValue2.TabIndex = 1007;
            this.CPSValue2.Text = "6 CPS";
            // 
            // inventorycheck
            // 
            this.inventorycheck.Enabled = true;
            this.inventorycheck.Interval = 200;
            this.inventorycheck.Tick += new System.EventHandler(this.inventorycheck_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 1008;
            this.textBox2.Text = "6";
            this.textBox2.Visible = false;
            // 
            // FluxTimer2
            // 
            this.FluxTimer2.Interval = 50;
            this.FluxTimer2.Tick += new System.EventHandler(this.FluxTimer2_Tick);
            // 
            // SendClick2
            // 
            this.SendClick2.Tick += new System.EventHandler(this.SendClick2_Tick);
            // 
            // IsMouseDown2
            // 
            this.IsMouseDown2.Enabled = true;
            this.IsMouseDown2.Interval = 500;
            this.IsMouseDown2.Tick += new System.EventHandler(this.IsMouseDown2_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 1009;
            this.label9.Text = "Clicker";
            // 
            // MinecraftClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(255, 370);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CPSValue2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnToggle2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CPSTrackbar2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RGBtoggle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.randomTB);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.CPSValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CPSTrackbar);
            this.Controls.Add(this.bindBtn);
            this.Controls.Add(this.clickSounds);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MinecraftClicker";
            this.Text = "Minecraft Clicker";
            this.Load += new System.EventHandler(this.MinecraftClicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randomTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CPSValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bindBtn;

        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.TrackBar randomTB;
        private System.Windows.Forms.Timer Binding;
        private Bunifu.UI.WinForms.BunifuHSlider CPSTrackbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer RGB;
        private System.Windows.Forms.Button clickSounds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RGBtoggle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer FluxTimer;
        private System.Windows.Forms.Timer SendClick;
        private System.Windows.Forms.Timer IsMouseDown;
        private System.Windows.Forms.Timer iswindowjava;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnToggle2;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuHSlider CPSTrackbar2;
        private System.Windows.Forms.Label CPSValue2;
        private System.Windows.Forms.Timer inventorycheck;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer FluxTimer2;
        private System.Windows.Forms.Timer SendClick2;
        private System.Windows.Forms.Timer IsMouseDown2;
        private System.Windows.Forms.Label label9;
    }
}
