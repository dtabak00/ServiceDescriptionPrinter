namespace ServiceDescriptionForm
{
    partial class EnterServiceDescriptionForm
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.IncludeHttpLbl = new System.Windows.Forms.Label();
            this.IncludeHttpCheckBox = new System.Windows.Forms.CheckBox();
            this.SecondLineLbl = new System.Windows.Forms.Label();
            this.FirstLineLbl = new System.Windows.Forms.Label();
            this.FormExplanationLbl = new System.Windows.Forms.Label();
            this.ServiceDescriptionLbl = new System.Windows.Forms.Label();
            this.ProjectNameLbl = new System.Windows.Forms.Label();
            this.ServiceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(412, 174);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(56, 51);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(479, 174);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(78, 51);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // IncludeHttpLbl
            // 
            this.IncludeHttpLbl.AutoSize = true;
            this.IncludeHttpLbl.Location = new System.Drawing.Point(12, 139);
            this.IncludeHttpLbl.Name = "IncludeHttpLbl";
            this.IncludeHttpLbl.Size = new System.Drawing.Size(145, 17);
            this.IncludeHttpLbl.TabIndex = 19;
            this.IncludeHttpLbl.Text = "Include Http Bindings:";
            // 
            // IncludeHttpCheckBox
            // 
            this.IncludeHttpCheckBox.AutoSize = true;
            this.IncludeHttpCheckBox.Location = new System.Drawing.Point(163, 140);
            this.IncludeHttpCheckBox.Name = "IncludeHttpCheckBox";
            this.IncludeHttpCheckBox.Size = new System.Drawing.Size(18, 17);
            this.IncludeHttpCheckBox.TabIndex = 18;
            this.IncludeHttpCheckBox.UseVisualStyleBackColor = true;
            // 
            // SecondLineLbl
            // 
            this.SecondLineLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondLineLbl.Location = new System.Drawing.Point(12, 169);
            this.SecondLineLbl.Name = "SecondLineLbl";
            this.SecondLineLbl.Size = new System.Drawing.Size(545, 2);
            this.SecondLineLbl.TabIndex = 17;
            // 
            // FirstLineLbl
            // 
            this.FirstLineLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FirstLineLbl.Location = new System.Drawing.Point(15, 39);
            this.FirstLineLbl.Name = "FirstLineLbl";
            this.FirstLineLbl.Size = new System.Drawing.Size(542, 2);
            this.FirstLineLbl.TabIndex = 16;
            // 
            // FormExplanationLbl
            // 
            this.FormExplanationLbl.AutoSize = true;
            this.FormExplanationLbl.Location = new System.Drawing.Point(12, 9);
            this.FormExplanationLbl.Name = "FormExplanationLbl";
            this.FormExplanationLbl.Size = new System.Drawing.Size(236, 17);
            this.FormExplanationLbl.TabIndex = 15;
            this.FormExplanationLbl.Text = "Creates a new WSDL based project.";
            // 
            // ServiceDescriptionLbl
            // 
            this.ServiceDescriptionLbl.AutoSize = true;
            this.ServiceDescriptionLbl.Location = new System.Drawing.Point(12, 105);
            this.ServiceDescriptionLbl.Name = "ServiceDescriptionLbl";
            this.ServiceDescriptionLbl.Size = new System.Drawing.Size(134, 17);
            this.ServiceDescriptionLbl.TabIndex = 14;
            this.ServiceDescriptionLbl.Text = "Service Description:";
            // 
            // ProjectNameLbl
            // 
            this.ProjectNameLbl.AutoSize = true;
            this.ProjectNameLbl.Location = new System.Drawing.Point(12, 57);
            this.ProjectNameLbl.Name = "ProjectNameLbl";
            this.ProjectNameLbl.Size = new System.Drawing.Size(97, 17);
            this.ProjectNameLbl.TabIndex = 13;
            this.ProjectNameLbl.Text = "Project Name:";
            // 
            // ServiceDescriptionTextBox
            // 
            this.ServiceDescriptionTextBox.Location = new System.Drawing.Point(152, 105);
            this.ServiceDescriptionTextBox.Name = "ServiceDescriptionTextBox";
            this.ServiceDescriptionTextBox.Size = new System.Drawing.Size(405, 22);
            this.ServiceDescriptionTextBox.TabIndex = 12;
            this.ServiceDescriptionTextBox.TextChanged += new System.EventHandler(this.ServiceDescriptionTextBox_TextChanged);
            // 
            // ServiceNameTextBox
            // 
            this.ServiceNameTextBox.Location = new System.Drawing.Point(152, 54);
            this.ServiceNameTextBox.Name = "ServiceNameTextBox";
            this.ServiceNameTextBox.Size = new System.Drawing.Size(405, 22);
            this.ServiceNameTextBox.TabIndex = 11;
            // 
            // EnterServiceDescriptionForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(564, 230);
            this.Controls.Add(this.IncludeHttpLbl);
            this.Controls.Add(this.IncludeHttpCheckBox);
            this.Controls.Add(this.SecondLineLbl);
            this.Controls.Add(this.FirstLineLbl);
            this.Controls.Add(this.FormExplanationLbl);
            this.Controls.Add(this.ServiceDescriptionLbl);
            this.Controls.Add(this.ProjectNameLbl);
            this.Controls.Add(this.ServiceDescriptionTextBox);
            this.Controls.Add(this.ServiceNameTextBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterServiceDescriptionForm";
            this.Text = "EnterServiceDescriptionForm";
            this.Shown += new System.EventHandler(this.EnterServiceDescriptionForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label IncludeHttpLbl;
        private System.Windows.Forms.CheckBox IncludeHttpCheckBox;
        private System.Windows.Forms.Label SecondLineLbl;
        private System.Windows.Forms.Label FirstLineLbl;
        private System.Windows.Forms.Label FormExplanationLbl;
        private System.Windows.Forms.Label ServiceDescriptionLbl;
        private System.Windows.Forms.Label ProjectNameLbl;
        private System.Windows.Forms.TextBox ServiceDescriptionTextBox;
        private System.Windows.Forms.TextBox ServiceNameTextBox;
    }
}