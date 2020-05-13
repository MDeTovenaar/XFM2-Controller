namespace XFM2_Controller
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ToolstripMain = new System.Windows.Forms.ToolStrip();
            this.ToolstripButtonAlgorithm = new System.Windows.Forms.ToolStripButton();
            this.ToolstripButtonOperator = new System.Windows.Forms.ToolStripButton();
            this.ToolstripButtonEnvelopes = new System.Windows.Forms.ToolStripButton();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.ToolstripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolstripMain
            // 
            this.ToolstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolstripButtonAlgorithm,
            this.ToolstripButtonOperator,
            this.ToolstripButtonEnvelopes});
            this.ToolstripMain.Location = new System.Drawing.Point(0, 0);
            this.ToolstripMain.Name = "ToolstripMain";
            this.ToolstripMain.Size = new System.Drawing.Size(800, 25);
            this.ToolstripMain.TabIndex = 0;
            // 
            // ToolstripButtonAlgorithm
            // 
            this.ToolstripButtonAlgorithm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolstripButtonAlgorithm.Image = ((System.Drawing.Image)(resources.GetObject("ToolstripButtonAlgorithm.Image")));
            this.ToolstripButtonAlgorithm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolstripButtonAlgorithm.Name = "ToolstripButtonAlgorithm";
            this.ToolstripButtonAlgorithm.Size = new System.Drawing.Size(23, 22);
            this.ToolstripButtonAlgorithm.Click += new System.EventHandler(this.ToolstripButtonAlgorithm_Click);
            // 
            // ToolstripButtonOperator
            // 
            this.ToolstripButtonOperator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolstripButtonOperator.Image = ((System.Drawing.Image)(resources.GetObject("ToolstripButtonOperator.Image")));
            this.ToolstripButtonOperator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolstripButtonOperator.Name = "ToolstripButtonOperator";
            this.ToolstripButtonOperator.Size = new System.Drawing.Size(23, 22);
            this.ToolstripButtonOperator.Text = "toolStripButton2";
            // 
            // ToolstripButtonEnvelopes
            // 
            this.ToolstripButtonEnvelopes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolstripButtonEnvelopes.Image = ((System.Drawing.Image)(resources.GetObject("ToolstripButtonEnvelopes.Image")));
            this.ToolstripButtonEnvelopes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolstripButtonEnvelopes.Name = "ToolstripButtonEnvelopes";
            this.ToolstripButtonEnvelopes.Size = new System.Drawing.Size(23, 22);
            this.ToolstripButtonEnvelopes.Text = "toolStripButton3";
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 25);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(800, 425);
            this.PanelContainer.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.ToolstripMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XFM2 Controller";
            this.ToolstripMain.ResumeLayout(false);
            this.ToolstripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolstripMain;
        private System.Windows.Forms.ToolStripButton ToolstripButtonAlgorithm;
        private System.Windows.Forms.ToolStripButton ToolstripButtonOperator;
        private System.Windows.Forms.ToolStripButton ToolstripButtonEnvelopes;
        private System.Windows.Forms.Panel PanelContainer;
    }
}

