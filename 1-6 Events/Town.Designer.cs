namespace _1_6_Events
{
    partial class Town
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
            this.btnHouse1 = new System.Windows.Forms.Button();
            this.btnHouse2 = new System.Windows.Forms.Button();
            this.btnHouse3 = new System.Windows.Forms.Button();
            this.btnHouse4 = new System.Windows.Forms.Button();
            this.btnDeliverBaskets = new System.Windows.Forms.Button();
            this.lblQueueList = new System.Windows.Forms.Label();
            this.lblStackList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHouse1
            // 
            this.btnHouse1.Location = new System.Drawing.Point(86, 103);
            this.btnHouse1.Name = "btnHouse1";
            this.btnHouse1.Size = new System.Drawing.Size(136, 83);
            this.btnHouse1.TabIndex = 0;
            this.btnHouse1.Text = "House 1";
            this.btnHouse1.UseVisualStyleBackColor = true;
            // 
            // btnHouse2
            // 
            this.btnHouse2.Location = new System.Drawing.Point(86, 251);
            this.btnHouse2.Name = "btnHouse2";
            this.btnHouse2.Size = new System.Drawing.Size(136, 83);
            this.btnHouse2.TabIndex = 1;
            this.btnHouse2.Text = "House 2";
            this.btnHouse2.UseVisualStyleBackColor = true;
            // 
            // btnHouse3
            // 
            this.btnHouse3.Location = new System.Drawing.Point(310, 251);
            this.btnHouse3.Name = "btnHouse3";
            this.btnHouse3.Size = new System.Drawing.Size(136, 83);
            this.btnHouse3.TabIndex = 2;
            this.btnHouse3.Text = "House 3";
            this.btnHouse3.UseVisualStyleBackColor = true;
            // 
            // btnHouse4
            // 
            this.btnHouse4.Location = new System.Drawing.Point(600, 301);
            this.btnHouse4.Name = "btnHouse4";
            this.btnHouse4.Size = new System.Drawing.Size(136, 83);
            this.btnHouse4.TabIndex = 3;
            this.btnHouse4.Text = "House 4";
            this.btnHouse4.UseVisualStyleBackColor = true;
            // 
            // btnDeliverBaskets
            // 
            this.btnDeliverBaskets.Location = new System.Drawing.Point(86, 35);
            this.btnDeliverBaskets.Name = "btnDeliverBaskets";
            this.btnDeliverBaskets.Size = new System.Drawing.Size(136, 23);
            this.btnDeliverBaskets.TabIndex = 4;
            this.btnDeliverBaskets.Text = "Deliver Baskets";
            this.btnDeliverBaskets.UseVisualStyleBackColor = true;
            this.btnDeliverBaskets.Click += new System.EventHandler(this.btnDeliverBaskets_Click);
            // 
            // lblQueueList
            // 
            this.lblQueueList.AutoSize = true;
            this.lblQueueList.Location = new System.Drawing.Point(520, 74);
            this.lblQueueList.Name = "lblQueueList";
            this.lblQueueList.Size = new System.Drawing.Size(65, 13);
            this.lblQueueList.TabIndex = 5;
            this.lblQueueList.Text = "lblQueueList";
            // 
            // lblStackList
            // 
            this.lblStackList.AutoSize = true;
            this.lblStackList.Location = new System.Drawing.Point(638, 74);
            this.lblStackList.Name = "lblStackList";
            this.lblStackList.Size = new System.Drawing.Size(61, 13);
            this.lblStackList.TabIndex = 6;
            this.lblStackList.Text = "lblStackList";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Queue List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stack List";
            // 
            // Town
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStackList);
            this.Controls.Add(this.lblQueueList);
            this.Controls.Add(this.btnDeliverBaskets);
            this.Controls.Add(this.btnHouse4);
            this.Controls.Add(this.btnHouse3);
            this.Controls.Add(this.btnHouse2);
            this.Controls.Add(this.btnHouse1);
            this.Name = "Town";
            this.Text = "Basket Delivery Application";
            this.Load += new System.EventHandler(this.Town_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHouse1;
        private System.Windows.Forms.Button btnHouse2;
        private System.Windows.Forms.Button btnHouse3;
        private System.Windows.Forms.Button btnHouse4;
        private System.Windows.Forms.Button btnDeliverBaskets;
        private System.Windows.Forms.Label lblQueueList;
        private System.Windows.Forms.Label lblStackList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

