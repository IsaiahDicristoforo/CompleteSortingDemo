using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortingForm.Sorting;

namespace SortingForm
{
    public partial class NumberDataSet : UserControl
    {
        public TestCase testCase { get;}
        public bool _IsHighlighted;
        public event EventHandler ClickToChangeData;
        public event EventHandler UnsortedDataUpdated;
        public event EventHandler HighlightEvent;


        public bool IsHighlighted
        {
            get { return _IsHighlighted; }
            set
            {
                if (value == true)
                {
                    this.BackgroundImage = SortingForm.Properties.Resources.orange;
                    _IsHighlighted = true;

                }
                else
                {
                    this.BackgroundImage = SortingForm.Properties.Resources.green;
                    _IsHighlighted = false;

                }
            }
        }

        public NumberDataSet()
        {
            testCase = new TestCase();
            InitializeComponent();

        }

        private void RadioButton_FileInput_CheckedChanged(object sender, EventArgs e)
        {
            ChangeInputTypes(false);

        }

        public void ChangeInputTypes(bool enable)
        {
            upDown_MinValue.Enabled = enable;
            upDown_MaxValue.Enabled = enable;
            comboBox_TotalToGenerate.Enabled = enable;
        }

        private void RadioButton_RandomRange_CheckedChanged(object sender, EventArgs e)
        {
            ChangeInputTypes(true);
        }

        private void RadioButton_CompletlyRandom_CheckedChanged(object sender, EventArgs e)
        {
            ChangeInputTypes(false);
        }

        private void Button_Test_Click(object sender, EventArgs e)
        {

            if (radioButton_CompletlyRandom.Checked)
            {
                for (int i = 0; i < 10004; i++)
                {
                    testCase.AddToTestCase(i);
                }
            }

            this.UnsortedDataUpdated(this, e);
        }

        private void NumberDataSet_Load(object sender, EventArgs e)
        {
            IsHighlighted = true;

        }

      

        private void Panel_TestDetails_MouseDown(object sender, MouseEventArgs e)
        {

            this.HighlightEvent(this, e);

            IsHighlighted = true;

            this.BackgroundImage = SortingForm.Properties.Resources.orange;

            this.ClickToChangeData(this, e);



        }

        private void Panel_TestDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_DeleteTestCase_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
