namespace SortingForm
{
    partial class NumberDataSet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Test = new System.Windows.Forms.Button();
            this.Button_DeleteTestCase = new System.Windows.Forms.Button();
            this.panel_TestDetails = new System.Windows.Forms.Panel();
            this.radioButton_CompletlyRandom = new System.Windows.Forms.RadioButton();
            this.Button_ImportTextFile = new System.Windows.Forms.Button();
            this.label_NumbersToGenerate = new System.Windows.Forms.Label();
            this.comboBox_TotalToGenerate = new System.Windows.Forms.ComboBox();
            this.labelSortInputType = new System.Windows.Forms.Label();
            this.upDown_MaxValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upDown_MinValue = new System.Windows.Forms.NumericUpDown();
            this.radioButton_FileInput = new System.Windows.Forms.RadioButton();
            this.radioButton_RandomRange = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel_TestDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_MaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_MinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Test
            // 
            this.Button_Test.BackColor = System.Drawing.Color.Orange;
            this.Button_Test.Font = new System.Drawing.Font("Modak", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Test.Location = new System.Drawing.Point(924, 231);
            this.Button_Test.Margin = new System.Windows.Forms.Padding(7);
            this.Button_Test.Name = "Button_Test";
            this.Button_Test.Size = new System.Drawing.Size(292, 151);
            this.Button_Test.TabIndex = 0;
            this.Button_Test.Text = "Test";
            this.Button_Test.UseVisualStyleBackColor = false;
            this.Button_Test.Click += new System.EventHandler(this.Button_Test_Click);
            // 
            // Button_DeleteTestCase
            // 
            this.Button_DeleteTestCase.Font = new System.Drawing.Font("Modak", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DeleteTestCase.Location = new System.Drawing.Point(1220, 305);
            this.Button_DeleteTestCase.Margin = new System.Windows.Forms.Padding(7);
            this.Button_DeleteTestCase.Name = "Button_DeleteTestCase";
            this.Button_DeleteTestCase.Size = new System.Drawing.Size(262, 57);
            this.Button_DeleteTestCase.TabIndex = 1;
            this.Button_DeleteTestCase.Text = "Delete Test Case";
            this.Button_DeleteTestCase.UseVisualStyleBackColor = true;
            this.Button_DeleteTestCase.Click += new System.EventHandler(this.Button_DeleteTestCase_Click);
            // 
            // panel_TestDetails
            // 
            this.panel_TestDetails.Controls.Add(this.radioButton_CompletlyRandom);
            this.panel_TestDetails.Controls.Add(this.Button_DeleteTestCase);
            this.panel_TestDetails.Controls.Add(this.Button_ImportTextFile);
            this.panel_TestDetails.Controls.Add(this.Button_Test);
            this.panel_TestDetails.Controls.Add(this.label_NumbersToGenerate);
            this.panel_TestDetails.Controls.Add(this.comboBox_TotalToGenerate);
            this.panel_TestDetails.Controls.Add(this.labelSortInputType);
            this.panel_TestDetails.Controls.Add(this.upDown_MaxValue);
            this.panel_TestDetails.Controls.Add(this.label2);
            this.panel_TestDetails.Controls.Add(this.label1);
            this.panel_TestDetails.Controls.Add(this.upDown_MinValue);
            this.panel_TestDetails.Controls.Add(this.radioButton_FileInput);
            this.panel_TestDetails.Controls.Add(this.radioButton_RandomRange);
            this.panel_TestDetails.Location = new System.Drawing.Point(0, 43);
            this.panel_TestDetails.Margin = new System.Windows.Forms.Padding(7);
            this.panel_TestDetails.Name = "panel_TestDetails";
            this.panel_TestDetails.Size = new System.Drawing.Size(1489, 516);
            this.panel_TestDetails.TabIndex = 2;
            this.panel_TestDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_TestDetails_Paint);
            this.panel_TestDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_TestDetails_MouseDown);
            // 
            // radioButton_CompletlyRandom
            // 
            this.radioButton_CompletlyRandom.AutoSize = true;
            this.radioButton_CompletlyRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CompletlyRandom.Location = new System.Drawing.Point(1065, 19);
            this.radioButton_CompletlyRandom.Name = "radioButton_CompletlyRandom";
            this.radioButton_CompletlyRandom.Size = new System.Drawing.Size(354, 44);
            this.radioButton_CompletlyRandom.TabIndex = 10;
            this.radioButton_CompletlyRandom.TabStop = true;
            this.radioButton_CompletlyRandom.Text = "Completly Random";
            this.radioButton_CompletlyRandom.UseVisualStyleBackColor = true;
            this.radioButton_CompletlyRandom.CheckedChanged += new System.EventHandler(this.RadioButton_CompletlyRandom_CheckedChanged);
            // 
            // Button_ImportTextFile
            // 
            this.Button_ImportTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_ImportTextFile.Location = new System.Drawing.Point(763, 85);
            this.Button_ImportTextFile.Margin = new System.Windows.Forms.Padding(7);
            this.Button_ImportTextFile.Name = "Button_ImportTextFile";
            this.Button_ImportTextFile.Size = new System.Drawing.Size(240, 94);
            this.Button_ImportTextFile.TabIndex = 9;
            this.Button_ImportTextFile.Text = "Import Text File";
            this.Button_ImportTextFile.UseVisualStyleBackColor = false;
            // 
            // label_NumbersToGenerate
            // 
            this.label_NumbersToGenerate.AutoSize = true;
            this.label_NumbersToGenerate.Location = new System.Drawing.Point(257, 96);
            this.label_NumbersToGenerate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_NumbersToGenerate.Name = "label_NumbersToGenerate";
            this.label_NumbersToGenerate.Size = new System.Drawing.Size(279, 29);
            this.label_NumbersToGenerate.TabIndex = 8;
            this.label_NumbersToGenerate.Text = "Total Nums To Generate";
            // 
            // comboBox_TotalToGenerate
            // 
            this.comboBox_TotalToGenerate.FormattingEnabled = true;
            this.comboBox_TotalToGenerate.Location = new System.Drawing.Point(259, 132);
            this.comboBox_TotalToGenerate.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox_TotalToGenerate.Name = "comboBox_TotalToGenerate";
            this.comboBox_TotalToGenerate.Size = new System.Drawing.Size(277, 37);
            this.comboBox_TotalToGenerate.TabIndex = 7;
            // 
            // labelSortInputType
            // 
            this.labelSortInputType.AutoSize = true;
            this.labelSortInputType.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortInputType.Location = new System.Drawing.Point(37, 19);
            this.labelSortInputType.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelSortInputType.Name = "labelSortInputType";
            this.labelSortInputType.Size = new System.Drawing.Size(173, 76);
            this.labelSortInputType.TabIndex = 6;
            this.labelSortInputType.Text = "Input";
            // 
            // upDown_MaxValue
            // 
            this.upDown_MaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDown_MaxValue.Location = new System.Drawing.Point(427, 245);
            this.upDown_MaxValue.Margin = new System.Windows.Forms.Padding(7);
            this.upDown_MaxValue.Name = "upDown_MaxValue";
            this.upDown_MaxValue.Size = new System.Drawing.Size(280, 62);
            this.upDown_MaxValue.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min Value";
            // 
            // upDown_MinValue
            // 
            this.upDown_MinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDown_MinValue.Location = new System.Drawing.Point(40, 245);
            this.upDown_MinValue.Margin = new System.Windows.Forms.Padding(7);
            this.upDown_MinValue.Name = "upDown_MinValue";
            this.upDown_MinValue.Size = new System.Drawing.Size(280, 62);
            this.upDown_MinValue.TabIndex = 2;
            // 
            // radioButton_FileInput
            // 
            this.radioButton_FileInput.AutoSize = true;
            this.radioButton_FileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_FileInput.Location = new System.Drawing.Point(763, 19);
            this.radioButton_FileInput.Margin = new System.Windows.Forms.Padding(7);
            this.radioButton_FileInput.Name = "radioButton_FileInput";
            this.radioButton_FileInput.Size = new System.Drawing.Size(224, 52);
            this.radioButton_FileInput.TabIndex = 1;
            this.radioButton_FileInput.TabStop = true;
            this.radioButton_FileInput.Text = "File Input";
            this.radioButton_FileInput.UseVisualStyleBackColor = true;
            this.radioButton_FileInput.CheckedChanged += new System.EventHandler(this.RadioButton_FileInput_CheckedChanged);
            // 
            // radioButton_RandomRange
            // 
            this.radioButton_RandomRange.AutoSize = true;
            this.radioButton_RandomRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_RandomRange.Location = new System.Drawing.Point(237, 19);
            this.radioButton_RandomRange.Margin = new System.Windows.Forms.Padding(7);
            this.radioButton_RandomRange.Name = "radioButton_RandomRange";
            this.radioButton_RandomRange.Size = new System.Drawing.Size(341, 52);
            this.radioButton_RandomRange.TabIndex = 0;
            this.radioButton_RandomRange.TabStop = true;
            this.radioButton_RandomRange.Text = "Random Range";
            this.radioButton_RandomRange.UseVisualStyleBackColor = true;
            this.radioButton_RandomRange.CheckedChanged += new System.EventHandler(this.RadioButton_RandomRange_CheckedChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // NumberDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SortingForm.Properties.Resources.green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panel_TestDetails);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "NumberDataSet";
            this.Size = new System.Drawing.Size(1496, 605);
            this.Load += new System.EventHandler(this.NumberDataSet_Load);
            this.panel_TestDetails.ResumeLayout(false);
            this.panel_TestDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_MaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_MinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Test;
        private System.Windows.Forms.Button Button_DeleteTestCase;
        private System.Windows.Forms.Panel panel_TestDetails;
        private System.Windows.Forms.NumericUpDown upDown_MinValue;
        private System.Windows.Forms.RadioButton radioButton_FileInput;
        private System.Windows.Forms.RadioButton radioButton_RandomRange;
        private System.Windows.Forms.Label label_NumbersToGenerate;
        private System.Windows.Forms.ComboBox comboBox_TotalToGenerate;
        private System.Windows.Forms.Label labelSortInputType;
        private System.Windows.Forms.NumericUpDown upDown_MaxValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_ImportTextFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RadioButton radioButton_CompletlyRandom;
    }
}
