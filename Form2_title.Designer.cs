namespace Solo_project
{
    partial class Form2_title
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
            store = new System.Windows.Forms.Button();
            pack = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // store
            // 
            store.BackColor = System.Drawing.Color.FromArgb(215, 210, 203);
            store.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            store.Location = new System.Drawing.Point(12, 729);
            store.Name = "store";
            store.Size = new System.Drawing.Size(485, 120);
            store.TabIndex = 0;
            store.Text = "매장";
            store.UseVisualStyleBackColor = false;
            store.Click += button1_Click;
            // 
            // pack
            // 
            pack.BackColor = System.Drawing.Color.FromArgb(215, 210, 203);
            pack.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pack.Location = new System.Drawing.Point(617, 729);
            pack.Name = "pack";
            pack.Size = new System.Drawing.Size(485, 120);
            pack.TabIndex = 1;
            pack.Text = "포장";
            pack.UseVisualStyleBackColor = false;
            pack.Click += pack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.new_logo_brand_1;
            pictureBox1.Location = new System.Drawing.Point(230, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(653, 156);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.이미지2;
            pictureBox2.Location = new System.Drawing.Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(1090, 699);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form2_title
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1114, 861);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pack);
            Controls.Add(store);
            Location = new System.Drawing.Point(300, 50);
            Name = "Form2_title";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Form2_title";
            Load += Form2_title_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button store;
        private System.Windows.Forms.Button pack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}