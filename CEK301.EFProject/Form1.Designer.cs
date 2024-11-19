namespace CEK301.EFProject
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
            this.txtRehberAdi = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRehberId = new System.Windows.Forms.Label();
            this.txtRehberId = new System.Windows.Forms.TextBox();
            this.txtRehberSoyadi = new System.Windows.Forms.TextBox();
            this.lblRehberAdi = new System.Windows.Forms.Label();
            this.lblRehberSoyadi = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetListById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRehberAdi
            // 
            this.txtRehberAdi.Location = new System.Drawing.Point(95, 56);
            this.txtRehberAdi.Name = "txtRehberAdi";
            this.txtRehberAdi.Size = new System.Drawing.Size(150, 20);
            this.txtRehberAdi.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(95, 126);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(72, 31);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 286);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblRehberId
            // 
            this.lblRehberId.AutoSize = true;
            this.lblRehberId.Location = new System.Drawing.Point(38, 22);
            this.lblRehberId.Name = "lblRehberId";
            this.lblRehberId.Size = new System.Drawing.Size(54, 13);
            this.lblRehberId.TabIndex = 0;
            this.lblRehberId.Text = "RehberId:";
            // 
            // txtRehberId
            // 
            this.txtRehberId.Location = new System.Drawing.Point(95, 19);
            this.txtRehberId.Name = "txtRehberId";
            this.txtRehberId.Size = new System.Drawing.Size(150, 20);
            this.txtRehberId.TabIndex = 1;
            // 
            // txtRehberSoyadi
            // 
            this.txtRehberSoyadi.Location = new System.Drawing.Point(95, 89);
            this.txtRehberSoyadi.Name = "txtRehberSoyadi";
            this.txtRehberSoyadi.Size = new System.Drawing.Size(150, 20);
            this.txtRehberSoyadi.TabIndex = 1;
            // 
            // lblRehberAdi
            // 
            this.lblRehberAdi.AutoSize = true;
            this.lblRehberAdi.Location = new System.Drawing.Point(29, 59);
            this.lblRehberAdi.Name = "lblRehberAdi";
            this.lblRehberAdi.Size = new System.Drawing.Size(63, 13);
            this.lblRehberAdi.TabIndex = 0;
            this.lblRehberAdi.Text = "Rehber Adi:";
            // 
            // lblRehberSoyadi
            // 
            this.lblRehberSoyadi.AutoSize = true;
            this.lblRehberSoyadi.Location = new System.Drawing.Point(12, 92);
            this.lblRehberSoyadi.Name = "lblRehberSoyadi";
            this.lblRehberSoyadi.Size = new System.Drawing.Size(80, 13);
            this.lblRehberSoyadi.TabIndex = 0;
            this.lblRehberSoyadi.Text = "Rehber Soyadi:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(173, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(95, 163);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetListById
            // 
            this.btnGetListById.Location = new System.Drawing.Point(95, 200);
            this.btnGetListById.Name = "btnGetListById";
            this.btnGetListById.Size = new System.Drawing.Size(150, 34);
            this.btnGetListById.TabIndex = 2;
            this.btnGetListById.Text = "Id\'ye Göre Getir";
            this.btnGetListById.UseVisualStyleBackColor = true;
            this.btnGetListById.Click += new System.EventHandler(this.btnGetListById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 326);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetListById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtRehberId);
            this.Controls.Add(this.lblRehberSoyadi);
            this.Controls.Add(this.lblRehberAdi);
            this.Controls.Add(this.lblRehberId);
            this.Controls.Add(this.txtRehberSoyadi);
            this.Controls.Add(this.txtRehberAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRehberAdi;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRehberId;
        private System.Windows.Forms.TextBox txtRehberId;
        private System.Windows.Forms.TextBox txtRehberSoyadi;
        private System.Windows.Forms.Label lblRehberAdi;
        private System.Windows.Forms.Label lblRehberSoyadi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetListById;
    }
}

