namespace ad
{
    partial class customer
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
            this.back_to_menu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.open_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.viev_orders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_to_menu
            // 
            this.back_to_menu.Location = new System.Drawing.Point(739, 526);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(167, 34);
            this.back_to_menu.TabIndex = 0;
            this.back_to_menu.Text = "Назад в меню";
            this.back_to_menu.UseVisualStyleBackColor = true;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(894, 458);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список доступных билбордов:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(391, 526);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(167, 34);
            this.open_btn.TabIndex = 4;
            this.open_btn.Text = "Открыть";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ваш id:";
            // 
            // viev_orders
            // 
            this.viev_orders.Location = new System.Drawing.Point(35, 526);
            this.viev_orders.Name = "viev_orders";
            this.viev_orders.Size = new System.Drawing.Size(232, 34);
            this.viev_orders.TabIndex = 6;
            this.viev_orders.Text = "Посмотреть мои заказы";
            this.viev_orders.UseVisualStyleBackColor = true;
            this.viev_orders.Click += new System.EventHandler(this.viev_orders_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 572);
            this.Controls.Add(this.viev_orders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_to_menu);
            this.Name = "customer";
            this.Text = "customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.customer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button back_to_menu;
        private DataGridView dataGridView1;
        private Label label2;
        private Button open_btn;
        private Label label3;
        private Button viev_orders;
    }
}