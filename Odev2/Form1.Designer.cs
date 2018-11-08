namespace Odev2
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
            this.btnCircularQueue = new System.Windows.Forms.Button();
            this.btnPriorityQueue = new System.Windows.Forms.Button();
            this.txtCircular = new System.Windows.Forms.TextBox();
            this.txtCircularOrtalama = new System.Windows.Forms.TextBox();
            this.txtPriorityOrtalama = new System.Windows.Forms.TextBox();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.txtBekleme = new System.Windows.Forms.TextBox();
            this.txtPriorityTers = new System.Windows.Forms.TextBox();
            this.txtTersSirali = new System.Windows.Forms.TextBox();
            this.lblTers = new System.Windows.Forms.Label();
            this.lblTersAzBekleyen = new System.Windows.Forms.Label();
            this.lblAzBekleyen = new System.Windows.Forms.Label();
            this.lblCircularOrtalama = new System.Windows.Forms.Label();
            this.lblPriorityOrtalama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCircularQueue
            // 
            this.btnCircularQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCircularQueue.Location = new System.Drawing.Point(65, 30);
            this.btnCircularQueue.Name = "btnCircularQueue";
            this.btnCircularQueue.Size = new System.Drawing.Size(98, 23);
            this.btnCircularQueue.TabIndex = 0;
            this.btnCircularQueue.Text = "CircularQueue";
            this.btnCircularQueue.UseVisualStyleBackColor = true;
            this.btnCircularQueue.Click += new System.EventHandler(this.btnCircularQueue_Click);
            // 
            // btnPriorityQueue
            // 
            this.btnPriorityQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPriorityQueue.Location = new System.Drawing.Point(341, 30);
            this.btnPriorityQueue.Name = "btnPriorityQueue";
            this.btnPriorityQueue.Size = new System.Drawing.Size(98, 23);
            this.btnPriorityQueue.TabIndex = 5;
            this.btnPriorityQueue.Text = "PriorityQueue";
            this.btnPriorityQueue.UseVisualStyleBackColor = true;
            this.btnPriorityQueue.Click += new System.EventHandler(this.btnPriorityQueue_Click);
            // 
            // txtCircular
            // 
            this.txtCircular.Location = new System.Drawing.Point(12, 70);
            this.txtCircular.Multiline = true;
            this.txtCircular.Name = "txtCircular";
            this.txtCircular.Size = new System.Drawing.Size(236, 196);
            this.txtCircular.TabIndex = 6;
            // 
            // txtCircularOrtalama
            // 
            this.txtCircularOrtalama.Location = new System.Drawing.Point(21, 347);
            this.txtCircularOrtalama.Multiline = true;
            this.txtCircularOrtalama.Name = "txtCircularOrtalama";
            this.txtCircularOrtalama.Size = new System.Drawing.Size(227, 60);
            this.txtCircularOrtalama.TabIndex = 7;
            // 
            // txtPriorityOrtalama
            // 
            this.txtPriorityOrtalama.Location = new System.Drawing.Point(265, 347);
            this.txtPriorityOrtalama.Multiline = true;
            this.txtPriorityOrtalama.Name = "txtPriorityOrtalama";
            this.txtPriorityOrtalama.Size = new System.Drawing.Size(227, 60);
            this.txtPriorityOrtalama.TabIndex = 9;
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(256, 70);
            this.txtPriority.Multiline = true;
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(236, 196);
            this.txtPriority.TabIndex = 8;
            this.txtPriority.TextChanged += new System.EventHandler(this.txtPriority_TextChanged);
            // 
            // txtBekleme
            // 
            this.txtBekleme.Location = new System.Drawing.Point(507, 70);
            this.txtBekleme.Multiline = true;
            this.txtBekleme.Name = "txtBekleme";
            this.txtBekleme.Size = new System.Drawing.Size(201, 346);
            this.txtBekleme.TabIndex = 10;
            // 
            // txtPriorityTers
            // 
            this.txtPriorityTers.Location = new System.Drawing.Point(980, 70);
            this.txtPriorityTers.Multiline = true;
            this.txtPriorityTers.Name = "txtPriorityTers";
            this.txtPriorityTers.Size = new System.Drawing.Size(201, 346);
            this.txtPriorityTers.TabIndex = 11;
            // 
            // txtTersSirali
            // 
            this.txtTersSirali.Location = new System.Drawing.Point(743, 70);
            this.txtTersSirali.Multiline = true;
            this.txtTersSirali.Name = "txtTersSirali";
            this.txtTersSirali.Size = new System.Drawing.Size(201, 346);
            this.txtTersSirali.TabIndex = 12;
            // 
            // lblTers
            // 
            this.lblTers.AutoSize = true;
            this.lblTers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTers.Location = new System.Drawing.Point(740, 40);
            this.lblTers.Name = "lblTers";
            this.lblTers.Size = new System.Drawing.Size(209, 13);
            this.lblTers.TabIndex = 13;
            this.lblTers.Text = "Bütükten Küçüğe Sıralanmış Kuyruk";
            // 
            // lblTersAzBekleyen
            // 
            this.lblTersAzBekleyen.AutoSize = true;
            this.lblTersAzBekleyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTersAzBekleyen.Location = new System.Drawing.Point(965, 40);
            this.lblTersAzBekleyen.Name = "lblTersAzBekleyen";
            this.lblTersAzBekleyen.Size = new System.Drawing.Size(239, 13);
            this.lblTersAzBekleyen.TabIndex = 14;
            this.lblTersAzBekleyen.Text = "Ters Kuyrukta Daha Az Bekleyen Müşteri";
            // 
            // lblAzBekleyen
            // 
            this.lblAzBekleyen.AutoSize = true;
            this.lblAzBekleyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAzBekleyen.Location = new System.Drawing.Point(531, 40);
            this.lblAzBekleyen.Name = "lblAzBekleyen";
            this.lblAzBekleyen.Size = new System.Drawing.Size(156, 13);
            this.lblAzBekleyen.TabIndex = 15;
            this.lblAzBekleyen.Text = "Daha Az Bekleyen Müşteri";
            // 
            // lblCircularOrtalama
            // 
            this.lblCircularOrtalama.AutoSize = true;
            this.lblCircularOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCircularOrtalama.Location = new System.Drawing.Point(62, 311);
            this.lblCircularOrtalama.Name = "lblCircularOrtalama";
            this.lblCircularOrtalama.Size = new System.Drawing.Size(87, 13);
            this.lblCircularOrtalama.TabIndex = 16;
            this.lblCircularOrtalama.Text = "Ortalama Süre";
            // 
            // lblPriorityOrtalama
            // 
            this.lblPriorityOrtalama.AutoSize = true;
            this.lblPriorityOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriorityOrtalama.Location = new System.Drawing.Point(338, 311);
            this.lblPriorityOrtalama.Name = "lblPriorityOrtalama";
            this.lblPriorityOrtalama.Size = new System.Drawing.Size(87, 13);
            this.lblPriorityOrtalama.TabIndex = 17;
            this.lblPriorityOrtalama.Text = "Ortalama Süre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1206, 439);
            this.Controls.Add(this.lblPriorityOrtalama);
            this.Controls.Add(this.lblCircularOrtalama);
            this.Controls.Add(this.lblAzBekleyen);
            this.Controls.Add(this.lblTersAzBekleyen);
            this.Controls.Add(this.lblTers);
            this.Controls.Add(this.txtTersSirali);
            this.Controls.Add(this.txtPriorityTers);
            this.Controls.Add(this.txtBekleme);
            this.Controls.Add(this.txtPriorityOrtalama);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.txtCircularOrtalama);
            this.Controls.Add(this.txtCircular);
            this.Controls.Add(this.btnPriorityQueue);
            this.Controls.Add(this.btnCircularQueue);
            this.Name = "Form1";
            this.Text = "Kuruk İmplementasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCircularQueue;
        private System.Windows.Forms.Button btnPriorityQueue;
        private System.Windows.Forms.TextBox txtCircular;
        private System.Windows.Forms.TextBox txtCircularOrtalama;
        private System.Windows.Forms.TextBox txtPriorityOrtalama;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.TextBox txtBekleme;
        private System.Windows.Forms.TextBox txtPriorityTers;
        private System.Windows.Forms.TextBox txtTersSirali;
        private System.Windows.Forms.Label lblTers;
        private System.Windows.Forms.Label lblTersAzBekleyen;
        private System.Windows.Forms.Label lblAzBekleyen;
        private System.Windows.Forms.Label lblCircularOrtalama;
        private System.Windows.Forms.Label lblPriorityOrtalama;
    }
}

