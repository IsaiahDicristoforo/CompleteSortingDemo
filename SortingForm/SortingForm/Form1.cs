using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace SortingForm
{
    public partial class UtimateSortingDemo : Form
    {
        List<NumberDataSet> dataSets = new List<NumberDataSet>();

        public UtimateSortingDemo()
        {
            dataSets = new List<NumberDataSet>();
            InitializeComponent();
        }

        private void button_AddNewTestCase_Click(object sender, EventArgs e)
        {
            NumberDataSet set = new NumberDataSet();
            flowLayoutPanel1.Controls.Add(set);
            flowLayoutPanel1.ScrollControlIntoView(flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1]);
            dataSets.Add(set);
            UnselectAllTestCases(sender,e);
            set.HighlightEvent += new EventHandler(UnselectAllTestCases);
            set.UnsortedDataUpdated += new EventHandler(UserControl_ButtonClick);

        }
        protected void UserControl_ButtonClick(object sender, EventArgs e)
        {

            UpdateUnsortedViews();

        }

        private void UpdateUnsortedViews()
        {
            listView_Unsorted.Clear();
            treeView1.Nodes.Clear();
            if (dataSets.Count > 0)
            {
              //  NumberDataSet set = dataSets.Where(x => x.IsHighlighted).ToArray()[0];

              NumberDataSet set = null;
              foreach (NumberDataSet numberDataSet in dataSets)
              {
                  if (numberDataSet.IsHighlighted)
                  {
                      set = numberDataSet;
                      break;
                  }
              }

           

                if (set.testCase.UnsortedTestCase.Count > 500)
                {
                    listView_Unsorted.Hide();
                    treeView1.Show();

                    TreeNode node = new TreeNode("700-800");

                    Random r = new Random();
                    treeView1.Nodes.Add(r.Next().ToString());

                    for (int i = 0; i < set.testCase.UnsortedTestCase.Count; i++)
                    {
                        if (i == set.testCase.UnsortedTestCase.Count - 100)
                        {
                            treeView1.Nodes.Add(i.ToString() + "-g" + (set.testCase.UnsortedTestCase.Count - 1).ToString());
                            break;
                        }
                        else if (i % 100 == 0 && i < set.testCase.UnsortedTestCase.Count - 200)
                        {
                            treeView1.Nodes.Add(i.ToString() + "-" + (i + 99).ToString());
                        }
                    }


                }
                else
                {
                    listView_Unsorted.Show();
                    set.testCase.UnsortedTestCase.ForEach(UpdateUnsortedListView);

                }
            }
        }

        private void UpdateUnsortedListView(int i)
        {
            listView_Unsorted.Clear();
            listView_Unsorted.Items.Add(i.ToString());
        }

        public void UnselectAllTestCases(object sender, EventArgs e)
        {

            for (int i = 0; i < dataSets.Count; i++)
            {
                if (dataSets[i].IsHighlighted)
                {
                    dataSets[i].IsHighlighted = false;
                }
                else
                {
                    dataSets[i].IsHighlighted = true;
                }
            }

           



        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void UtimateSortingDemo_Load(object sender, EventArgs e)
        {
            listView_Unsorted.Hide();
            treeView1.Hide();

            
        }
    }
}
