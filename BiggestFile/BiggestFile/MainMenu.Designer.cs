namespace BiggestFile
{
    partial class MainMenu
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
            this.pathLabel = new System.Windows.Forms.Label();
            this.fileNumberLabel = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.fileNumber = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resultsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelMessageLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.progressList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(70, 50);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(32, 13);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Path:";
            // 
            // fileNumberLabel
            // 
            this.fileNumberLabel.AutoSize = true;
            this.fileNumberLabel.Location = new System.Drawing.Point(36, 86);
            this.fileNumberLabel.Name = "fileNumberLabel";
            this.fileNumberLabel.Size = new System.Drawing.Size(66, 13);
            this.fileNumberLabel.TabIndex = 1;
            this.fileNumberLabel.Text = "File Number:";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(109, 50);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(100, 20);
            this.path.TabIndex = 2;
            // 
            // fileNumber
            // 
            this.fileNumber.Location = new System.Drawing.Point(109, 78);
            this.fileNumber.Name = "fileNumber";
            this.fileNumber.Size = new System.Drawing.Size(100, 20);
            this.fileNumber.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(109, 125);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(109, 154);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resultsList
            // 
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.resultsList.Location = new System.Drawing.Point(215, 12);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(573, 426);
            this.resultsList.TabIndex = 7;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.Details;
            this.resultsList.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 231;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size(Bytes)";
            this.columnHeader2.Width = 350;
            // 
            // cancelMessageLabel
            // 
            this.cancelMessageLabel.Location = new System.Drawing.Point(0, 0);
            this.cancelMessageLabel.Name = "cancelMessageLabel";
            this.cancelMessageLabel.Size = new System.Drawing.Size(100, 23);
            this.cancelMessageLabel.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 219);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Visible = false;
            // 
            // progressList
            // 
            this.progressList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.progressList.Location = new System.Drawing.Point(215, 12);
            this.progressList.Name = "progressList";
            this.progressList.Size = new System.Drawing.Size(573, 426);
            this.progressList.TabIndex = 9;
            this.progressList.UseCompatibleStateImageBehavior = false;
            this.progressList.View = System.Windows.Forms.View.Details;
            this.progressList.Visible = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 285;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 246;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressList);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.cancelMessageLabel);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fileNumber);
            this.Controls.Add(this.path);
            this.Controls.Add(this.fileNumberLabel);
            this.Controls.Add(this.pathLabel);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label fileNumberLabel;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox fileNumber;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label cancelMessageLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ListView progressList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

