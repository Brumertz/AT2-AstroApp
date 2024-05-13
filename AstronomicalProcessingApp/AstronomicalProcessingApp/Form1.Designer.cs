namespace AstronomicalProcessingApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxData = new ListBox();
            buttonSort = new Button();
            buttonSearch = new Button();
            buttonEdit = new Button();
            buttonRefresh = new Button();
            label1 = new Label();
            buttonMidExtreme = new Button();
            buttonMode = new Button();
            buttonAverage = new Button();
            buttonRange = new Button();
            buttonSequentialsearch = new Button();
            textBoxInput = new TextBox();
            textBoxMidExtreme = new TextBox();
            textBoxAverage = new TextBox();
            textBoxMode = new TextBox();
            textBoxRange = new TextBox();
            textBoxSequencialSearch = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.ItemHeight = 15;
            listBoxData.Location = new Point(236, 70);
            listBoxData.Margin = new Padding(3, 2, 3, 2);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(227, 349);
            listBoxData.TabIndex = 1;
            listBoxData.SelectedIndexChanged += listBoxData_SelectedIndexChanged;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(7, 88);
            buttonSort.Margin = new Padding(3, 2, 3, 2);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(78, 34);
            buttonSort.TabIndex = 3;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(7, 219);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(78, 34);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Visible = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(7, 138);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(78, 34);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(7, 176);
            buttonRefresh.Margin = new Padding(3, 2, 3, 2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(78, 39);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 7;
            label1.Text = "InputNumber";
            // 
            // buttonMidExtreme
            // 
            buttonMidExtreme.Location = new Point(13, 87);
            buttonMidExtreme.Name = "buttonMidExtreme";
            buttonMidExtreme.Size = new Size(85, 44);
            buttonMidExtreme.TabIndex = 8;
            buttonMidExtreme.Text = "Mid-Extreme";
            buttonMidExtreme.UseMnemonic = false;
            buttonMidExtreme.UseVisualStyleBackColor = true;
            buttonMidExtreme.Click += buttonMidExtreme_Click;
            // 
            // buttonMode
            // 
            buttonMode.Location = new Point(13, 207);
            buttonMode.Name = "buttonMode";
            buttonMode.Size = new Size(85, 46);
            buttonMode.TabIndex = 9;
            buttonMode.Text = "Mode";
            buttonMode.UseVisualStyleBackColor = true;
            buttonMode.Click += buttonMode_Click;
            // 
            // buttonAverage
            // 
            buttonAverage.Location = new Point(13, 147);
            buttonAverage.Name = "buttonAverage";
            buttonAverage.Size = new Size(85, 47);
            buttonAverage.TabIndex = 10;
            buttonAverage.Text = "Average";
            buttonAverage.UseVisualStyleBackColor = true;
            buttonAverage.Click += buttonAverage_Click;
            // 
            // buttonRange
            // 
            buttonRange.Location = new Point(13, 267);
            buttonRange.Name = "buttonRange";
            buttonRange.Size = new Size(85, 46);
            buttonRange.TabIndex = 11;
            buttonRange.Text = "Range";
            buttonRange.UseVisualStyleBackColor = true;
            buttonRange.Click += buttonRange_Click;
            // 
            // buttonSequentialsearch
            // 
            buttonSequentialsearch.Location = new Point(13, 26);
            buttonSequentialsearch.Name = "buttonSequentialsearch";
            buttonSequentialsearch.Size = new Size(85, 46);
            buttonSequentialsearch.TabIndex = 12;
            buttonSequentialsearch.Text = "Sequential Search";
            buttonSequentialsearch.UseVisualStyleBackColor = true;
            buttonSequentialsearch.Click += buttonSequentialsearch_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(7, 52);
            textBoxInput.Margin = new Padding(3, 2, 3, 2);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(78, 23);
            textBoxInput.TabIndex = 2;
            // 
            // textBoxMidExtreme
            // 
            textBoxMidExtreme.Location = new Point(133, 99);
            textBoxMidExtreme.Name = "textBoxMidExtreme";
            textBoxMidExtreme.Size = new Size(55, 23);
            textBoxMidExtreme.TabIndex = 13;
            // 
            // textBoxAverage
            // 
            textBoxAverage.Location = new Point(133, 160);
            textBoxAverage.Name = "textBoxAverage";
            textBoxAverage.Size = new Size(55, 23);
            textBoxAverage.TabIndex = 14;
            // 
            // textBoxMode
            // 
            textBoxMode.Location = new Point(133, 220);
            textBoxMode.Name = "textBoxMode";
            textBoxMode.Size = new Size(55, 23);
            textBoxMode.TabIndex = 15;
            // 
            // textBoxRange
            // 
            textBoxRange.Location = new Point(133, 277);
            textBoxRange.Name = "textBoxRange";
            textBoxRange.Size = new Size(55, 23);
            textBoxRange.TabIndex = 16;
            // 
            // textBoxSequencialSearch
            // 
            textBoxSequencialSearch.Location = new Point(133, 39);
            textBoxSequencialSearch.Name = "textBoxSequencialSearch";
            textBoxSequencialSearch.Size = new Size(55, 23);
            textBoxSequencialSearch.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxSequencialSearch);
            groupBox1.Controls.Add(textBoxRange);
            groupBox1.Controls.Add(textBoxMode);
            groupBox1.Controls.Add(textBoxAverage);
            groupBox1.Controls.Add(textBoxMidExtreme);
            groupBox1.Controls.Add(buttonSequentialsearch);
            groupBox1.Controls.Add(buttonRange);
            groupBox1.Controls.Add(buttonAverage);
            groupBox1.Controls.Add(buttonMode);
            groupBox1.Controls.Add(buttonMidExtreme);
            groupBox1.Location = new Point(9, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 349);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "MethodsTools ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonRefresh);
            groupBox2.Controls.Add(buttonEdit);
            groupBox2.Controls.Add(buttonSearch);
            groupBox2.Controls.Add(buttonSort);
            groupBox2.Controls.Add(textBoxInput);
            groupBox2.Location = new Point(501, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(104, 267);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(listBoxData);
            groupBox3.Location = new Point(21, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(652, 461);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "AstronomicalProcessingApp";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 567);
            Controls.Add(groupBox3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBoxData;
        private Button buttonSort;
        private Button buttonSearch;
        private Button buttonEdit;
        private Button buttonRefresh;
        private Label label1;
        private Button buttonMidExtreme;
        private Button buttonMode;
        private Button buttonAverage;
        private Button buttonRange;
        private Button buttonSequentialsearch;
        private TextBox textBoxInput;
        private TextBox textBoxMidExtreme;
        private TextBox textBoxAverage;
        private TextBox textBoxMode;
        private TextBox textBoxRange;
        private TextBox textBoxSequencialSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
