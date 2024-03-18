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
            buttonReset = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Location = new Point(40, 27);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(195, 20);
            labelAppName.TabIndex = 0;
            labelAppName.Text = "AstronomicalProcessingApp";
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.Location = new Point(253, 109);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(173, 264);
            listBoxData.TabIndex = 1;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(40, 109);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(193, 27);
            textBoxInput.TabIndex = 2;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(44, 156);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(89, 46);
            buttonSort.TabIndex = 3;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(44, 208);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(89, 46);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(44, 260);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(89, 46);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(44, 312);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(89, 46);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 75);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 7;
            label1.Text = "InputNumber";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(label1);
            Controls.Add(buttonReset);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSort);
            Controls.Add(textBoxInput);
            Controls.Add(listBoxData);
            Controls.Add(labelAppName);
            Name = "MainForm";
            Text = "MainForm";
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
        private Button buttonReset;
        private Label label1;
    }
}
