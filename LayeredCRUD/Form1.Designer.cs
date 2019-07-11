namespace LayeredCRUD
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNEdit = new System.Windows.Forms.Button();
            this.BTNRemove = new System.Windows.Forms.Button();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(13, 347);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(75, 23);
            this.BTNAdd.TabIndex = 1;
            this.BTNAdd.Text = "Add";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // BTNEdit
            // 
            this.BTNEdit.Location = new System.Drawing.Point(94, 347);
            this.BTNEdit.Name = "BTNEdit";
            this.BTNEdit.Size = new System.Drawing.Size(75, 23);
            this.BTNEdit.TabIndex = 2;
            this.BTNEdit.Text = "Edit";
            this.BTNEdit.UseVisualStyleBackColor = true;
            this.BTNEdit.Click += new System.EventHandler(this.BTNEdit_Click);
            // 
            // BTNRemove
            // 
            this.BTNRemove.Location = new System.Drawing.Point(176, 346);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(75, 23);
            this.BTNRemove.TabIndex = 3;
            this.BTNRemove.Text = "Remove";
            this.BTNRemove.UseVisualStyleBackColor = true;
            this.BTNRemove.Click += new System.EventHandler(this.BTNRemove_Click);
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(516, 20);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(100, 20);
            this.filterBox.TabIndex = 4;
            this.filterBox.TextChanged += new System.EventHandler(this.FilterBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.BTNRemove);
            this.Controls.Add(this.BTNEdit);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNEdit;
        private System.Windows.Forms.Button BTNRemove;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Button button1;
    }
}

