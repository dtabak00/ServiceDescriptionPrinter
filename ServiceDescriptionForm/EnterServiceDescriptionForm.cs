using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceDescriptionForm
{
    public partial class EnterServiceDescriptionForm : Form
    {
        //Form Variables
        public string ServiceNameString { get; set; }
        public string ServiceDescriptionUriString { get; set; }
        public bool InlucdeHttpBindings { get; set; }


        //Form Constructor
        public EnterServiceDescriptionForm()
        {
            InitializeComponent();
        }


        //Methods for handling Events of the Form and it's child elements
        private void EnterServiceDescriptionForm_Shown(object sender, EventArgs e)
        {
            ServiceDescriptionTextBox.Focus();
        }

        private void ServiceDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ServiceDescriptionTextBox.Text.Contains("?WSDL") || ServiceDescriptionTextBox.Text.Contains("?wsdl"))
            {
                string serviceName = ServiceDescriptionTextBox.Text.Substring(ServiceDescriptionTextBox.Text.LastIndexOf('/') + 1);

                if (serviceName.Contains("?WSDL"))
                {
                    serviceName = serviceName.Remove(serviceName.LastIndexOf("?WSDL"));
                }
                else
                {
                    serviceName = serviceName.Remove(serviceName.LastIndexOf("?wsdl"));
                }

                if (serviceName.Contains(".asmx"))
                {
                    serviceName = serviceName.Remove(serviceName.IndexOf(".asmx"));
                    ServiceNameTextBox.Text = serviceName;
                }
                else
                {
                    ServiceNameTextBox.Text = serviceName;
                }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (ServiceDescriptionTextBox.Text != "" && ServiceNameTextBox.Text != "")
            {
                ServiceDescriptionUriString = ServiceDescriptionTextBox.Text;
                ServiceNameString = ServiceNameTextBox.Text;
                InlucdeHttpBindings = IncludeHttpCheckBox.Checked;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (ServiceDescriptionTextBox.Text == "" && ServiceNameTextBox.Text == "")
                {
                    MessageBox.Show("Both Service Description and Name were not entered!");
                }
                else if (ServiceDescriptionTextBox.Text == "")
                {
                    MessageBox.Show("No Service Description URI was entered!");
                }
                else if (ServiceNameTextBox.Text == "")
                {
                    MessageBox.Show("No Service Name was entered!");
                }
            }
        }
    }
}
