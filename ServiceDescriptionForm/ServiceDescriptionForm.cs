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
    public partial class ServiceDescriptionForm : Form
    {
        //Form Variables
        private DisplayServiceDescription _displayService { get; set; }
        public int _rootTreeNodeCounter { get; set; }



        //Form costructor
        public ServiceDescriptionForm()
        {
            InitializeComponent();
        }

        
        //Methods for handling Events of the Form and it's child elements
        private void GetServiceDescriptionBtn_Click(object sender, EventArgs e)
        {
            EnterServiceDescriptionForm enterProjectForm = new EnterServiceDescriptionForm();

            enterProjectForm.ShowDialog();

            if (enterProjectForm.DialogResult == DialogResult.OK)
            {
                _displayService.GetServiceDescription(enterProjectForm.ServiceDescriptionUriString, enterProjectForm.InlucdeHttpBindings);
                _displayService.DisplayProject(ServiceTreeView, enterProjectForm.ServiceNameString);
            }
        }

        private void RemoveServiceBtn_Click(object sender, EventArgs e)
        {
            if (ServiceTreeView.SelectedNode != null)
            {
                if (ServiceTreeView.SelectedNode.Level == 0)
                {
                    ServiceTreeView.SelectedNode.Remove();
                    _displayService._rootTreeNodeCounter--;
                }
                else
                {
                    MessageBox.Show("Project node not selected!");
                }
            }
            else
            {
                MessageBox.Show("No Project Node Selected!");
            }
        }

        private void ServiceTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (ServiceTreeView.SelectedNode.Text.Contains("Request"))
            {
                MessageBox.Show("No request template generator found!");
            }
        }
    }
}
