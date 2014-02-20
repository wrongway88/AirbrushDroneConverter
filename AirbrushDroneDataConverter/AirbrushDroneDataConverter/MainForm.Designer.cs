namespace AirbrushDroneDataConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listViewFlights = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.airplane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waypointCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorkerLoadFiles = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFlights
            // 
            this.listViewFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.airplane,
            this.date,
            this.waypointCount});
            this.listViewFlights.Location = new System.Drawing.Point(12, 27);
            this.listViewFlights.Name = "listViewFlights";
            this.listViewFlights.Size = new System.Drawing.Size(482, 286);
            this.listViewFlights.TabIndex = 1;
            this.listViewFlights.UseCompatibleStateImageBehavior = false;
            this.listViewFlights.View = System.Windows.Forms.View.Details;
            this.listViewFlights.DoubleClick += new System.EventHandler(this.listViewFlights_DoubleClick);
            // 
            // id
            // 
            this.id.Tag = "Id";
            // 
            // airplane
            // 
            this.airplane.Tag = "airplane";
            this.airplane.Width = 140;
            // 
            // date
            // 
            this.date.Tag = "date";
            this.date.Width = 140;
            // 
            // waypointCount
            // 
            this.waypointCount.Tag = "waypoints";
            this.waypointCount.Width = 140;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.flightsToolStripMenuItem.Text = "Flights";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.settingsToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.dateToolStripMenuItem.Text = "Edit";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // backgroundWorkerLoadFiles
            // 
            this.backgroundWorkerLoadFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadFiles_DoWork);
            this.backgroundWorkerLoadFiles.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerLoadFiles_ProgressChanged);
            this.backgroundWorkerLoadFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadFiles_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(151, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 325);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listViewFlights);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Airbrush DroneDataConverter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFlights;
        private System.Windows.Forms.ColumnHeader airplane;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader waypointCount;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadFiles;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

