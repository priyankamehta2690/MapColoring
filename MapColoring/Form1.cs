using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapColoring
{
    public partial class Form1 : Form
    {
        int noOfStates = 0;
        int count = 0;
        string[] states = new string[10];
        List<Node> nodes = new List<Node>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNeighbor_Click(object sender, EventArgs e)
        {
            try
            {
                noOfStates = Convert.ToInt32(txtNoOfStates.Text);

                string allStates = txtStates.Text;
                states = allStates.Split(',');

                if (noOfStates == 0)
                {
                    MessageBox.Show("Please enter the number of states");
                }
                else if (states.Length == 0)
                {
                    MessageBox.Show("Please enter state names");
                }
                else if (noOfStates != states.Length)
                {
                    MessageBox.Show("The count of state names does not match with the number of states entered");
                }
                else
                {
                    lblNeighbor.Visible = true;
                    lblNeighbor.Text = "Select the neighbor for state: " + states[0];

                    lbNeighbor.Visible = true;
                    lbNeighbor.DataSource = states;
                    lbNeighbor.SelectionMode = SelectionMode.MultiExtended;

                    btnDone.Visible = true;
                    btnDone.Click += new EventHandler(this.btnDone_Click);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            count++;

            if (count >= states.Length)
            {
                lblNeighbor.Enabled = false;
                lbNeighbor.Enabled = false;
                btnDone.Enabled = false;
                btnAddNeighbor.Enabled = false;
            }

            if (count <= states.Length - 1)
                lblNeighbor.Text = "Select the neighbor for state: " + states[count];

            List<Node> neighbor = new List<Node>();
            foreach (var item in lbNeighbor.SelectedItems)
            {
                Node node = new Node(item.ToString());
                neighbor.Add(node);
            }

            if (count != 0 && count <= states.Length)
            {
                Node node = new Node(states[count - 1]);
                node.neighbor = neighbor;
                for (int i = 0; i < neighbor.Count; i++)
                {
                    if (node.neighbor[i].name.Equals(node.name))
                    {
                        node.neighbor.RemoveAt(i);
                    }
                }
                nodes.Add(node);
            }

            if (count == states.Length)
            {
                rbForwardChecking.Visible = true;
                rbMinConflict.Visible = true;
                btnColorMap.Visible = true;
            }
            lbNeighbor.ClearSelected();
        }

        private void btnColorMap_Click(object sender, EventArgs e)
        {
            List<Node> coloredNodes = new List<Node>();
            string minConflictTime;
            string forwardCheckingTime;
            rtbOutput.Clear();

            if (rbMinConflict.Checked)
            {
                MinConflict minConflict = new MinConflict();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                coloredNodes = minConflict.Color(nodes);
                watch.Stop();
                minConflictTime = watch.ElapsedMilliseconds.ToString();
                rtbOutput.AppendText("Time elapsed by Min-Conflict algorithm is: " + minConflictTime + " ms");
                rtbOutput.AppendText(Environment.NewLine);
                rtbOutput.AppendText(Environment.NewLine);
            }
            if (rbForwardChecking.Checked)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                ForwardChecking forwardChecking = new ForwardChecking();
                coloredNodes = forwardChecking.Color(nodes);
                for (int i = 0; i < coloredNodes.Count; i++)
                {
                    for (int j = 0; j < coloredNodes[i].neighbor.Count; j++)
                    {
                        for (int k = 0; k < coloredNodes.Count; k++)
                        {
                            if (i != k)
                            {
                                if (coloredNodes[i].neighbor[j].name.Equals(coloredNodes[k].name))
                                    coloredNodes[i].neighbor[j].color = coloredNodes[k].color;
                            }
                        }
                    }
                }
                watch.Stop();
                forwardCheckingTime = watch.ElapsedMilliseconds.ToString();
                rtbOutput.AppendText("Time elapsed by Forward checking algorithm is: " + forwardCheckingTime + " ms");
                rtbOutput.AppendText(Environment.NewLine);
                rtbOutput.AppendText(Environment.NewLine);
            }
            if (coloredNodes.Count != 0)
            {
                rtbOutput.Visible = true;


                for (int i = 0; i < coloredNodes.Count; i++)
                {
                    rtbOutput.AppendText(coloredNodes[i].name + " - " + coloredNodes[i].color);
                    rtbOutput.AppendText("-->");
                    for (int j = 0; j < coloredNodes[i].neighbor.Count; j++)
                    {
                        rtbOutput.AppendText(coloredNodes[i].neighbor[j].name + " - " + coloredNodes[i].neighbor[j].color);
                        rtbOutput.AppendText(" | ");
                    }
                    rtbOutput.AppendText(Environment.NewLine);
                    rtbOutput.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
