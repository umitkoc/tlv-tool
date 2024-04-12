using System.Configuration.Internal;
using System.Drawing;
using System.Reflection;
using System.Text.Json;

namespace TLV
{
    public partial class Form1 : Form
    {
        private readonly Parser parser;
        public Form1()
        {
            InitializeComponent();
             dataText.Text = "6F50840E325041592E5359532E4444463031A53EBF0C3B6119500B54524F59204352454449544F07A0000006723010870101611E501054524F5920494C20446F6D65737469634F07A00000067230108701029000";
            parser = new Parser();
        }

        public void start_Click(object sender, EventArgs e)
        {
            if (dataText.Text != "")
            {
                GetTlv();
            }
            else
            {
                MessageBox.Show("Input Error");
            }
        }



        void GetTlv()
        {
            bool ok=false;
                List<TLV> model = parser.getTlv(dataText.Text);
                foreach (TLV item in model)
                {
                    TreeNode node = new(item.Tag + ":" + item.Description);
                    node.Nodes.Add(new TreeNode(item.Length));
                    if (item.Value != "")node.Nodes.Add(new TreeNode(item.Value));
                    if (treeView1.SelectedNode == null)treeView1.Nodes.Add(node);
                    else treeView1.SelectedNode.Parent.Nodes.Add(node);
                        ok= true;
                }
                if(ok) { treeView1.SelectedNode?.Remove(); }
                dataText.Text = string.Empty;
                dataText.ReadOnly = true;
        }



        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            dataText.Text = treeView1.SelectedNode.Text;
        }



        private void clearBtn_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            dataText.Text = "";
            treeView1.Refresh();
            dataText.ReadOnly = false;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (dataText.Text != "")
                dataText.Text = (Convert.ToUInt32(dataText.Text, 16)).ToString();


        }

        private void lengthBtn_Click(object sender, EventArgs e)
        {
            if (dataText.Text != "")
                dataText.Text = dataText.TextLength.ToString();
        }

        private void asciiBtn_Click(object sender, EventArgs e)
        {
            var model = "";
            if (dataText.Text != "")
                for (int i = 0; i < dataText.Text.Length; i += 2)
                {
                    string hs = dataText.Text.Substring(i, 2);
                    model += Convert.ToChar(Convert.ToUInt32(hs, 16));
                }
            dataText.Text = model;
        }

        private  void aidBtn_Click(object sender, EventArgs e)
        {
            if (dataText.Text != "")
            {
                AID aidModel = parser.getAid(dataText.Text);
                if (aidModel != null)
                {
                    dataText.Text = $"Application Identifier:\r\n{aidModel.ApplicationIdentifier}\r\n" +
                    $"Country:\r\n{aidModel.Country}\r\n" +
                    $"Name:\r\n{aidModel.Name}\r\n" +
                    $"Description:\r\n{aidModel.Description}\r\n" +
                    $"Type:\r\n{aidModel.Type}\r\n" +
                    $"Vendor:\r\n{aidModel.Vendor}\r\n";
                }
                else
                {
                    MessageBox.Show("UNKNOWN APPLICATION IDENTIFIER");
                }
            }
            else
            {
                MessageBox.Show("INPUT ERROR");
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            dataText.Text = "";
            exportNode(treeView1.Nodes);
        }

        void exportNode(TreeNodeCollection currentNode)
        {

            foreach (TreeNode node in currentNode)
            {
                dataText.Text += node.Text.Split(":")[0];
                if (node.Nodes != null)
                {
                    exportNode(node.Nodes);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Nodes.Count>0)
                {
                    long step = (Convert.ToUInt32(treeView1.SelectedNode.FirstNode.Text, 16) + 1) * 2 + treeView1.SelectedNode.Text.Split(':')[0].Length;
                    removeNode(treeView1.SelectedNode, false, step);
                    treeView1.SelectedNode.Remove();
                }
                else
                {
                    MessageBox.Show("TAG NOT SELECTED");
                }
               
            }
            else
            {
                MessageBox.Show("TAG NOT SELECTED");
            }
        }

        private void removeNode(TreeNode currentNode,bool ok,long step)
        {

            if (ok)
            {
                var first = Convert.ToUInt32(currentNode.FirstNode.Text, 16)*2;
                currentNode.FirstNode.Text= ((first - step)/2).ToString("X2");
            }
            if (currentNode.Parent != null)
            {

                removeNode(currentNode.Parent,true,step);
            }
           
        }

        private void positiveBtn_Click(object sender, EventArgs e)
        {
            if (dataText.Text != "")
                treeView1.SelectedNode.Text = ((Convert.ToUInt32(dataText.Text, 16)) + 1).ToString("X2");
                dataText.Text = treeView1.SelectedNode.Text;
        }

        private void negativeBtn_Click(object sender, EventArgs e)
        {
            if (dataText.Text != "")
                treeView1.SelectedNode.Text = ((Convert.ToUInt32(dataText.Text, 16)) - 1).ToString("X2");
                dataText.Text = treeView1.SelectedNode.Text;
        }
    }


}
