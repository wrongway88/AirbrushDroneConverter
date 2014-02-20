namespace AirbrushDroneDataConverter
{
    partial class FormPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreferences));
            this.propertyGridLoginData = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // propertyGridLoginData
            // 
            this.propertyGridLoginData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridLoginData.Location = new System.Drawing.Point(12, 12);
            this.propertyGridLoginData.Name = "propertyGridLoginData";
            this.propertyGridLoginData.Size = new System.Drawing.Size(300, 173);
            this.propertyGridLoginData.TabIndex = 0;
            this.propertyGridLoginData.Click += new System.EventHandler(this.propertyGridLoginData_Click);
            // 
            // FormPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 197);
            this.Controls.Add(this.propertyGridLoginData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPreferences";
            this.Text = "FormLoginData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoginData_Close);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGridLoginData;



    }
}