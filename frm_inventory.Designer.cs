namespace MyFirstProject
{
    partial class frm_inventory
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_searchBy = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(140, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(283, 26);
            this.txt_id.TabIndex = 0;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(140, 80);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(283, 26);
            this.txt_barcode.TabIndex = 1;
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(140, 129);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(283, 26);
            this.txt_product.TabIndex = 2;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(140, 172);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(283, 26);
            this.txt_price.TabIndex = 3;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(140, 218);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(283, 26);
            this.txt_quantity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(448, 35);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(98, 36);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(448, 77);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(98, 39);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(448, 122);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 33);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // cbo_searchBy
            // 
            this.cbo_searchBy.FormattingEnabled = true;
            this.cbo_searchBy.Location = new System.Drawing.Point(827, 38);
            this.cbo_searchBy.Name = "cbo_searchBy";
            this.cbo_searchBy.Size = new System.Drawing.Size(219, 28);
            this.cbo_searchBy.TabIndex = 14;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(1077, 40);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(277, 26);
            this.txt_search.TabIndex = 15;
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.AllowUserToAddRows = false;
            this.dgv_inventory.AllowUserToDeleteRows = false;
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory.Location = new System.Drawing.Point(30, 294);
            this.dgv_inventory.Name = "dgv_inventory";
            this.dgv_inventory.ReadOnly = true;
            this.dgv_inventory.RowHeadersWidth = 62;
            this.dgv_inventory.RowTemplate.Height = 28;
            this.dgv_inventory.Size = new System.Drawing.Size(1504, 450);
            this.dgv_inventory.TabIndex = 16;
            this.dgv_inventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_inventory_CellClick);
            // 
            // frm_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 773);
            this.Controls.Add(this.dgv_inventory);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cbo_searchBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.txt_id);
            this.Name = "frm_inventory";
            this.Text = "frm_inventory";
            this.Load += new System.EventHandler(this.frm_inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_searchBy;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.TextBox txt_barcode;
    }
}