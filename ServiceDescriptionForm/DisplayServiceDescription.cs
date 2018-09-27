using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ServiceDescriptionForm
{
    class DisplayServiceDescription
    {
        //Class Variables
        public ServiceDescription _serviceDescription { get; set; }
        public ServiceDescriptionForm _mainForm { get; set; }
        public int _rootTreeNodeCounter { get; set; }
        public bool _includeHttpBindings { get; set; }


        //Class Constructor
        public DisplayServiceDescription(ServiceDescriptionForm mainForm)
        {
            _mainForm = mainForm;
            _rootTreeNodeCounter = _mainForm._rootTreeNodeCounter;
        }


        //Class Methods
        public void GetServiceDescription(string serviceDescriptionUri, bool includeHttpBindings)
        {
            try
            {
                _serviceDescription = ServiceDescription.Read(XmlReader.Create(serviceDescriptionUri));
                TreeView treeView = _mainForm.ServiceTreeView;
                _includeHttpBindings = includeHttpBindings;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.TrimEnd(e.Message.Substring(e.Message.IndexOf('\r')).ToCharArray()));
            }
        }

        public void DisplayProject(TreeView treeView, string projectName)
        {
            treeView.Nodes.Add(projectName).Tag = _serviceDescription;
            DisplayServices(treeView.Nodes[_rootTreeNodeCounter]);
            _rootTreeNodeCounter++;
        }

        private void DisplayServices(TreeNode treeNode)
        {
            int treeNodeCounter = 0;
            if (this._serviceDescription.Services.Count != 1 && _serviceDescription.Services.Count != 0)
            {
                foreach (Service service in _serviceDescription.Services)
                {
                    TreeNode tempTreeNode = treeNode.Nodes.Add(service.Name + " (Service)");
                    tempTreeNode.Tag = service;
                    DisplayBindings(treeNode.Nodes[treeNodeCounter], service);
                    treeNodeCounter++;
                }
            }
            else
            {
                DisplayBindings(treeNode, _serviceDescription.Services[0]);
            }
        }

        private void DisplayBindings(TreeNode treeNode, Service service)
        {
            int treeNodeCounter = 0;
            foreach (System.Web.Services.Description.Binding binding in _serviceDescription.Bindings)
            {
                if (_includeHttpBindings == false)
                {
                    if (binding.Name.Contains("Http") == false && binding.Name.Contains("http") == false)
                    {
                        treeNode.Nodes.Add(binding.Name).Tag = binding;
                        DisplayOperations(treeNode.Nodes[treeNodeCounter], binding);
                        treeNodeCounter++;
                    }
                }
                else
                {
                    treeNode.Nodes.Add(binding.Name).Tag = binding;
                    DisplayOperations(treeNode.Nodes[treeNodeCounter], binding);
                    treeNodeCounter++;
                }
            }
        }

        private void DisplayOperations(TreeNode treeNode, System.Web.Services.Description.Binding binding)
        {
            int treeNodeCounter = 0;

            foreach (PortType portType in _serviceDescription.PortTypes)
            {
                if (portType.Name == binding.Type.Name)
                {
                    foreach (Operation operation in portType.Operations)
                    {
                        treeNode.Nodes.Add(operation.Name).Tag = operation;
                        DisplayRequests(treeNode.Nodes[treeNodeCounter], operation);
                        treeNodeCounter++;
                    }
                }
            }
        }

        private void DisplayRequests(TreeNode treeNode, Operation operation)
        {
            int treeNodeCounter = 0;

            foreach (System.Web.Services.Description.OperationMessage message in operation.Messages)
            {
                if (message.GetType() == typeof(OperationInput))
                {
                    treeNode.Nodes.Add($"Request {treeNodeCounter + 1}").Tag = message;
                    treeNodeCounter++;
                }
            }
        }
    }
}
