namespace LayeredCRUD
{
    partial class Form2
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
            this.TXTManufacturer = new System.Windows.Forms.TextBox();
            this.TXTLine = new System.Windows.Forms.TextBox();
            this.TXTModel = new System.Windows.Forms.TextBox();
            this.TXTClass = new System.Windows.Forms.TextBox();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.Manufacturer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTManufacturer
            // 
            this.TXTManufacturer.Location = new System.Drawing.Point(80, 31);
            this.TXTManufacturer.Name = "TXTManufacturer";
            this.TXTManufacturer.Size = new System.Drawing.Size(100, 20);
            this.TXTManufacturer.TabIndex = 0;
            // 
            // TXTLine
            // 
            this.TXTLine.Location = new System.Drawing.Point(80, 57);
            this.TXTLine.Name = "TXTLine";
            this.TXTLine.Size = new System.Drawing.Size(100, 20);
            this.TXTLine.TabIndex = 1;
            // 
            // TXTModel
            // 
            this.TXTModel.Location = new System.Drawing.Point(80, 83);
            this.TXTModel.Name = "TXTModel";
            this.TXTModel.Size = new System.Drawing.Size(100, 20);
            this.TXTModel.TabIndex = 2;
            // 
            // TXTClass
            // 
            this.TXTClass.Location = new System.Drawing.Point(80, 109);
            this.TXTClass.Name = "TXTClass";
            this.TXTClass.Size = new System.Drawing.Size(100, 20);
            this.TXTClass.TabIndex = 3;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(93, 144);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(75, 23);
            this.BTNUpdate.TabIndex = 4;
            this.BTNUpdate.Text = "Update";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.Location = new System.Drawing.Point(174, 144);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(75, 23);
            this.BTNCancel.TabIndex = 5;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(12, 144);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(75, 23);
            this.BTNAdd.TabIndex = 6;
            this.BTNAdd.Text = "Add";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Location = new System.Drawing.Point(4, 34);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(70, 13);
            this.Manufacturer.TabIndex = 7;
            this.Manufacturer.Text = "Manufacturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Class";
            // 
            // TXTId
            // 
            this.TXTId.AutoSize = true;
            this.TXTId.Location = new System.Drawing.Point(231, 9);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(0, 13);
            this.TXTId.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 177);
            this.Controls.Add(this.TXTId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.TXTClass);
            this.Controls.Add(this.TXTModel);
            this.Controls.Add(this.TXTLine);
            this.Controls.Add(this.TXTManufacturer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Label Manufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TXTManufacturer;
        public System.Windows.Forms.TextBox TXTLine;
        public System.Windows.Forms.TextBox TXTModel;
        public System.Windows.Forms.TextBox TXTClass;
        public System.Windows.Forms.Label TXTId;
    }
}