namespace Project_LyGet
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clockLabel = new MetroFramework.Controls.MetroLabel();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.cpuProg = new MetroFramework.Controls.MetroProgressSpinner();
            this.memProg = new MetroFramework.Controls.MetroProgressSpinner();
            this.upProg = new MetroFramework.Controls.MetroProgressSpinner();
            this.volProg = new MetroFramework.Controls.MetroProgressSpinner();
            this.counTimer = new System.Windows.Forms.Timer(this.components);
            this.cpuText = new MetroFramework.Controls.MetroLabel();
            this.memText = new MetroFramework.Controls.MetroLabel();
            this.hourText = new MetroFramework.Controls.MetroLabel();
            this.volText = new MetroFramework.Controls.MetroLabel();
            this.rightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourLabel = new MetroFramework.Controls.MetroLabel();
            this.volLabel = new MetroFramework.Controls.MetroLabel();
            this.cpuLabel = new MetroFramework.Controls.MetroLabel();
            this.memLabel = new MetroFramework.Controls.MetroLabel();
            this.rightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.clockLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clockLabel.Location = new System.Drawing.Point(57, 59);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(49, 25);
            this.clockLabel.Style = MetroFramework.MetroColorStyle.White;
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "TIME";
            this.clockLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.clockLabel.UseCustomForeColor = true;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // cpuProg
            // 
            this.cpuProg.Location = new System.Drawing.Point(23, 180);
            this.cpuProg.Maximum = 100;
            this.cpuProg.Name = "cpuProg";
            this.cpuProg.Size = new System.Drawing.Size(83, 82);
            this.cpuProg.Spinning = false;
            this.cpuProg.Style = MetroFramework.MetroColorStyle.White;
            this.cpuProg.TabIndex = 1;
            this.cpuProg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cpuProg.UseSelectable = true;
            this.cpuProg.UseStyleColors = true;
            this.cpuProg.Value = 100;
            // 
            // memProg
            // 
            this.memProg.Location = new System.Drawing.Point(158, 180);
            this.memProg.Maximum = 100;
            this.memProg.Name = "memProg";
            this.memProg.Size = new System.Drawing.Size(83, 82);
            this.memProg.Spinning = false;
            this.memProg.Style = MetroFramework.MetroColorStyle.White;
            this.memProg.TabIndex = 2;
            this.memProg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.memProg.UseSelectable = true;
            this.memProg.UseStyleColors = true;
            this.memProg.Value = 100;
            // 
            // upProg
            // 
            this.upProg.Location = new System.Drawing.Point(27, 323);
            this.upProg.Maximum = 100;
            this.upProg.Name = "upProg";
            this.upProg.Size = new System.Drawing.Size(83, 82);
            this.upProg.Spinning = false;
            this.upProg.Style = MetroFramework.MetroColorStyle.White;
            this.upProg.TabIndex = 3;
            this.upProg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.upProg.UseSelectable = true;
            this.upProg.UseStyleColors = true;
            this.upProg.Value = 100;
            // 
            // volProg
            // 
            this.volProg.Location = new System.Drawing.Point(158, 323);
            this.volProg.Maximum = 100;
            this.volProg.Name = "volProg";
            this.volProg.Size = new System.Drawing.Size(83, 82);
            this.volProg.Spinning = false;
            this.volProg.Style = MetroFramework.MetroColorStyle.White;
            this.volProg.TabIndex = 4;
            this.volProg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.volProg.UseSelectable = true;
            this.volProg.UseStyleColors = true;
            this.volProg.Value = 100;
            // 
            // counTimer
            // 
            this.counTimer.Enabled = true;
            this.counTimer.Interval = 50;
            this.counTimer.Tick += new System.EventHandler(this.counTimer_Tick);
            // 
            // cpuText
            // 
            this.cpuText.AutoSize = true;
            this.cpuText.FontSize = MetroFramework.MetroLabelSize.Small;
            this.cpuText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cpuText.Location = new System.Drawing.Point(30, 152);
            this.cpuText.Name = "cpuText";
            this.cpuText.Size = new System.Drawing.Size(68, 15);
            this.cpuText.Style = MetroFramework.MetroColorStyle.White;
            this.cpuText.TabIndex = 5;
            this.cpuText.Text = "CPU USAGE";
            this.cpuText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cpuText.UseCustomForeColor = true;
            // 
            // memText
            // 
            this.memText.AutoSize = true;
            this.memText.FontSize = MetroFramework.MetroLabelSize.Small;
            this.memText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.memText.Location = new System.Drawing.Point(158, 152);
            this.memText.Name = "memText";
            this.memText.Size = new System.Drawing.Size(71, 15);
            this.memText.Style = MetroFramework.MetroColorStyle.White;
            this.memText.TabIndex = 6;
            this.memText.Text = "RAM USAGE";
            this.memText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.memText.UseCustomForeColor = true;
            // 
            // hourText
            // 
            this.hourText.AutoSize = true;
            this.hourText.FontSize = MetroFramework.MetroLabelSize.Small;
            this.hourText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hourText.Location = new System.Drawing.Point(38, 305);
            this.hourText.Name = "hourText";
            this.hourText.Size = new System.Drawing.Size(64, 15);
            this.hourText.Style = MetroFramework.MetroColorStyle.White;
            this.hourText.TabIndex = 7;
            this.hourText.Text = "PC UPTIME";
            this.hourText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hourText.UseCustomForeColor = true;
            // 
            // volText
            // 
            this.volText.AutoSize = true;
            this.volText.FontSize = MetroFramework.MetroLabelSize.Small;
            this.volText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.volText.Location = new System.Drawing.Point(160, 305);
            this.volText.Name = "volText";
            this.volText.Size = new System.Drawing.Size(84, 15);
            this.volText.Style = MetroFramework.MetroColorStyle.White;
            this.volText.TabIndex = 8;
            this.volText.Text = "VOLUME LEVEL";
            this.volText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.volText.UseCustomForeColor = true;
            // 
            // rightMenu
            // 
            this.rightMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rightMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.rightMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.rightMenu.Name = "rightMenu";
            this.rightMenu.Size = new System.Drawing.Size(117, 48);
            this.rightMenu.Text = "Settings";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Image = global::Project_LyGet.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Project_LyGet.Properties.Resources._458594;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.hourLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hourLabel.Location = new System.Drawing.Point(52, 357);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(22, 15);
            this.hourLabel.Style = MetroFramework.MetroColorStyle.White;
            this.hourLabel.TabIndex = 9;
            this.hourLabel.Text = "HR";
            this.hourLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hourLabel.UseCustomForeColor = true;
            // 
            // volLabel
            // 
            this.volLabel.AutoSize = true;
            this.volLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.volLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.volLabel.Location = new System.Drawing.Point(189, 357);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(21, 15);
            this.volLabel.Style = MetroFramework.MetroColorStyle.White;
            this.volLabel.TabIndex = 10;
            this.volLabel.Text = "vol";
            this.volLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.volLabel.UseCustomForeColor = true;
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.cpuLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cpuLabel.Location = new System.Drawing.Point(52, 209);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(25, 15);
            this.cpuLabel.Style = MetroFramework.MetroColorStyle.White;
            this.cpuLabel.TabIndex = 11;
            this.cpuLabel.Text = "cpu";
            this.cpuLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cpuLabel.UseCustomForeColor = true;
            // 
            // memLabel
            // 
            this.memLabel.AutoSize = true;
            this.memLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.memLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.memLabel.Location = new System.Drawing.Point(189, 209);
            this.memLabel.Name = "memLabel";
            this.memLabel.Size = new System.Drawing.Size(33, 15);
            this.memLabel.Style = MetroFramework.MetroColorStyle.White;
            this.memLabel.TabIndex = 12;
            this.memLabel.Text = "mem";
            this.memLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.memLabel.UseCustomForeColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 443);
            this.ContextMenuStrip = this.rightMenu;
            this.ControlBox = false;
            this.Controls.Add(this.memLabel);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.volLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.volText);
            this.Controls.Add(this.hourText);
            this.Controls.Add(this.memText);
            this.Controls.Add(this.cpuText);
            this.Controls.Add(this.volProg);
            this.Controls.Add(this.upProg);
            this.Controls.Add(this.memProg);
            this.Controls.Add(this.cpuProg);
            this.Controls.Add(this.clockLabel);
            this.Movable = false;
            this.Name = "Main";
            this.Opacity = 0.96D;
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Lyget Info";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rightMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private MetroFramework.Controls.MetroProgressSpinner cpuProg;
        private MetroFramework.Controls.MetroProgressSpinner memProg;
        private MetroFramework.Controls.MetroProgressSpinner upProg;
        private MetroFramework.Controls.MetroProgressSpinner volProg;
        private System.Windows.Forms.Timer counTimer;
        private MetroFramework.Controls.MetroLabel cpuText;
        private MetroFramework.Controls.MetroLabel memText;
        private MetroFramework.Controls.MetroLabel hourText;
        private MetroFramework.Controls.MetroLabel volText;
        private System.Windows.Forms.ContextMenuStrip rightMenu;
        private MetroFramework.Controls.MetroLabel hourLabel;
        private MetroFramework.Controls.MetroLabel volLabel;
        private MetroFramework.Controls.MetroLabel cpuLabel;
        private MetroFramework.Controls.MetroLabel memLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

