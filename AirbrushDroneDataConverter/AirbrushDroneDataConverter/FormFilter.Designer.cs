namespace AirbrushDroneDataConverter
{
    partial class FormFilter
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
            this.propertyGridFilter = new System.Windows.Forms.PropertyGrid();
            this.propertyGridMinDate = new System.Windows.Forms.PropertyGrid();
            this.propertyGridMaxDate = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // propertyGridFilter
            // 
            this.propertyGridFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridFilter.Location = new System.Drawing.Point(12, 12);
            this.propertyGridFilter.Name = "propertyGridFilter";
            this.propertyGridFilter.Size = new System.Drawing.Size(260, 179);
            this.propertyGridFilter.TabIndex = 0;
            this.propertyGridFilter.Click += new System.EventHandler(this.propertyGridFilter_Click);
            // 
            // propertyGridMinDate
            // 
            this.propertyGridMinDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridMinDate.Location = new System.Drawing.Point(13, 214);
            this.propertyGridMinDate.Name = "propertyGridMinDate";
            this.propertyGridMinDate.Size = new System.Drawing.Size(260, 160);
            this.propertyGridMinDate.TabIndex = 1;
            this.propertyGridMinDate.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridMinDate_PropertyValueChanged);
            this.propertyGridMinDate.SelectedObjectsChanged += new System.EventHandler(this.propertyGridMinDate_SelectedObjectsChanged);
            // 
            // propertyGridMaxDate
            // 
            this.propertyGridMaxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridMaxDate.Location = new System.Drawing.Point(12, 397);
            this.propertyGridMaxDate.Name = "propertyGridMaxDate";
            this.propertyGridMaxDate.Size = new System.Drawing.Size(259, 160);
            this.propertyGridMaxDate.TabIndex = 2;
            this.propertyGridMaxDate.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridMaxDate_PropertyValueChanged);
            this.propertyGridMaxDate.SelectedObjectsChanged += new System.EventHandler(this.propertyGridMaxDate_SelectedObjectsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minimum Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maximum Date";
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propertyGridMaxDate);
            this.Controls.Add(this.propertyGridMinDate);
            this.Controls.Add(this.propertyGridFilter);
            this.Name = "FormFilter";
            this.Text = "FormFilter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFilter_Close);
            this.Load += new System.EventHandler(this.FormFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGridFilter;
        private System.Windows.Forms.PropertyGrid propertyGridMinDate;
        private System.Windows.Forms.PropertyGrid propertyGridMaxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}