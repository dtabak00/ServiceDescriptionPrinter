namespace ServiceDescriptionForm
{
    partial class ServiceDescriptionForm
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
            this.GetServiceDescriptionBtn = new System.Windows.Forms.Button();
            this.ServiceTreeView = new System.Windows.Forms.TreeView();
            this.RemoveServiceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetServiceDescriptionBtn
            // 
            this.GetServiceDescriptionBtn.Location = new System.Drawing.Point(12, 12);
            this.GetServiceDescriptionBtn.Name = "GetServiceDescriptionBtn";
            this.GetServiceDescriptionBtn.Size = new System.Drawing.Size(239, 65);
            this.GetServiceDescriptionBtn.TabIndex = 0;
            this.GetServiceDescriptionBtn.Text = "Get Service Description";
            this.GetServiceDescriptionBtn.UseVisualStyleBackColor = true;
            this.GetServiceDescriptionBtn.Click += new System.EventHandler(this.GetServiceDescriptionBtn_Click);
            // 
            // ServiceTreeView
            // 
            this.ServiceTreeView.Location = new System.Drawing.Point(12, 83);
            this.ServiceTreeView.Name = "ServiceTreeView";
            this.ServiceTreeView.Size = new System.Drawing.Size(496, 500);
            this.ServiceTreeView.TabIndex = 1;
            this.ServiceTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ServiceTreeView_NodeMouseDoubleClick);
            // 
            // RemoveServiceBtn
            // 
            this.RemoveServiceBtn.Location = new System.Drawing.Point(257, 12);
            this.RemoveServiceBtn.Name = "RemoveServiceBtn";
            this.RemoveServiceBtn.Size = new System.Drawing.Size(251, 65);
            this.RemoveServiceBtn.TabIndex = 2;
            this.RemoveServiceBtn.Text = "Remove Service";
            this.RemoveServiceBtn.UseVisualStyleBackColor = true;
            this.RemoveServiceBtn.Click += new System.EventHandler(this.RemoveServiceBtn_Click);
            // 
            // ServiceDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 595);
            this.Controls.Add(this.RemoveServiceBtn);
            this.Controls.Add(this.ServiceTreeView);
            this.Controls.Add(this.GetServiceDescriptionBtn);
            this.Name = "ServiceDescriptionForm";
            this.Text = "Service Description Printer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetServiceDescriptionBtn;
        private System.Windows.Forms.Button RemoveServiceBtn;
        public System.Windows.Forms.TreeView ServiceTreeView;
    }
}

