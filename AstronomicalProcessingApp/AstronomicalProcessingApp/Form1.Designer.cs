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
            labelAppName = new Label();
            listBoxData = new ListBox();
            textBoxInput = new TextBox();
            buttonSort = new Button();
            buttonSearch = new Button();
            buttonEdit = new Button();
            buttonRefresh = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Location = new Point(35, 20);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(157, 15);
            labelAppName.TabIndex = 0;
            labelAppName.Text = "AstronomicalProcessingApp";
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.ItemHeight = 15;
            listBoxData.Location = new Point(221, 82);
            listBoxData.Margin = new Padding(3, 2, 3, 2);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(152, 199);
            listBoxData.TabIndex = 1;
            listBoxData.SelectedIndexChanged += listBoxData_SelectedIndexChanged;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(35, 82);
            textBoxInput.Margin = new Padding(3, 2, 3, 2);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(169, 23);
            textBoxInput.TabIndex = 2;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(38, 117);
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
            buttonSearch.Location = new Point(38, 156);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(78, 34);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(38, 195);
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
            buttonRefresh.Location = new Point(38, 234);
            buttonRefresh.Margin = new Padding(3, 2, 3, 2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(78, 34);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 56);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 7;
            label1.Text = "InputNumber";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 338);
            Controls.Add(label1);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSort);
            Controls.Add(textBoxInput);
            Controls.Add(listBoxData);
            Controls.Add(labelAppName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAppName;
        private ListBox listBoxData;
        private TextBox textBoxInput;
        private Button buttonSort;
        private Button buttonSearch;
        private Button buttonEdit;
        private Button buttonRefresh;
        private Label label1;
    }
}
