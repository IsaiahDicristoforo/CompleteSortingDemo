namespace SortingForm
{
    partial class UtimateSortingDemo
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
            this.components = new System.ComponentModel.Container();
            this.button_AddNewTestCase = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ResultsControl = new System.Windows.Forms.TabControl();
            this.tabPage_Unsorted = new System.Windows.Forms.TabPage();
            this.listView_Unsorted = new System.Windows.Forms.ListView();
            this.tabPage_Sorted = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ResultsControl.SuspendLayout();
            this.tabPage_Unsorted.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AddNewTestCase
            // 
            this.button_AddNewTestCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_AddNewTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewTestCase.ForeColor = System.Drawing.Color.Black;
            this.button_AddNewTestCase.Location = new System.Drawing.Point(545, 26);
            this.button_AddNewTestCase.Margin = new System.Windows.Forms.Padding(7);
            this.button_AddNewTestCase.Name = "button_AddNewTestCase";
            this.button_AddNewTestCase.Size = new System.Drawing.Size(581, 183);
            this.button_AddNewTestCase.TabIndex = 1;
            this.button_AddNewTestCase.Text = "Add New Test Case";
            this.button_AddNewTestCase.UseVisualStyleBackColor = false;
            this.button_AddNewTestCase.Click += new System.EventHandler(this.button_AddNewTestCase_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 223);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1559, 1532);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ResultsControl
            // 
            this.ResultsControl.Controls.Add(this.tabPage_Unsorted);
            this.ResultsControl.Controls.Add(this.tabPage_Sorted);
            this.ResultsControl.Location = new System.Drawing.Point(1607, 218);
            this.ResultsControl.Name = "ResultsControl";
            this.ResultsControl.SelectedIndex = 0;
            this.ResultsControl.Size = new System.Drawing.Size(580, 1537);
            this.ResultsControl.TabIndex = 4;
            // 
            // tabPage_Unsorted
            // 
            this.tabPage_Unsorted.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage_Unsorted.Controls.Add(this.treeView1);
            this.tabPage_Unsorted.Controls.Add(this.listView_Unsorted);
            this.tabPage_Unsorted.Location = new System.Drawing.Point(10, 47);
            this.tabPage_Unsorted.Name = "tabPage_Unsorted";
            this.tabPage_Unsorted.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Unsorted.Size = new System.Drawing.Size(560, 1480);
            this.tabPage_Unsorted.TabIndex = 0;
            this.tabPage_Unsorted.Text = "tabPage1";
            // 
            // listView_Unsorted
            // 
            this.listView_Unsorted.BackColor = System.Drawing.Color.RoyalBlue;
            this.listView_Unsorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Unsorted.HideSelection = false;
            this.listView_Unsorted.Location = new System.Drawing.Point(22, 31);
            this.listView_Unsorted.Name = "listView_Unsorted";
            this.listView_Unsorted.Size = new System.Drawing.Size(512, 1394);
            this.listView_Unsorted.TabIndex = 0;
            this.listView_Unsorted.UseCompatibleStateImageBehavior = false;
            this.listView_Unsorted.View = System.Windows.Forms.View.List;
            // 
            // tabPage_Sorted
            // 
            this.tabPage_Sorted.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage_Sorted.Location = new System.Drawing.Point(10, 47);
            this.tabPage_Sorted.Name = "tabPage_Sorted";
            this.tabPage_Sorted.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Sorted.Size = new System.Drawing.Size(560, 1480);
            this.tabPage_Sorted.TabIndex = 1;
            this.tabPage_Sorted.Text = "tabPage2";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(22, 31);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(512, 1443);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // UtimateSortingDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(3166, 1702);
            this.Controls.Add(this.ResultsControl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button_AddNewTestCase);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UtimateSortingDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate Sorting Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UtimateSortingDemo_Load);
            this.ResultsControl.ResumeLayout(false);
            this.tabPage_Unsorted.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_AddNewTestCase;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl ResultsControl;
        private System.Windows.Forms.TabPage tabPage_Unsorted;
        private System.Windows.Forms.TabPage tabPage_Sorted;
        private System.Windows.Forms.ListView listView_Unsorted;
        private System.Windows.Forms.TreeView treeView1;
    }
}

