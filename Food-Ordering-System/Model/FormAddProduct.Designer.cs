namespace Food_Ordering_System.Model
{
    partial class FormAddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_btn = new Guna.UI.WinForms.GunaButton();
            this.save_btn = new Guna.UI.WinForms.GunaButton();
            this.browse_btn = new Guna.UI.WinForms.GunaButton();
            this.picbox_browse = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.combo_category = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.text_price = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.text_name = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_browse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 100);
            this.panel1.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(117, 41);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(169, 31);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Food Products";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Food_Ordering_System.Properties.Resources.food;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(86, 73);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 2;
            this.gunaPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.close_btn);
            this.panel2.Controls.Add(this.save_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 100);
            this.panel2.TabIndex = 2;
            // 
            // close_btn
            // 
            this.close_btn.AnimationHoverSpeed = 0.07F;
            this.close_btn.AnimationSpeed = 0.03F;
            this.close_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.close_btn.BorderColor = System.Drawing.Color.Black;
            this.close_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.close_btn.FocusedColor = System.Drawing.Color.Empty;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = global::Food_Ordering_System.Properties.Resources.close_button1;
            this.close_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.close_btn.Location = new System.Drawing.Point(212, 32);
            this.close_btn.Name = "close_btn";
            this.close_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.close_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.close_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.close_btn.OnHoverImage = null;
            this.close_btn.OnPressedColor = System.Drawing.Color.Black;
            this.close_btn.Size = new System.Drawing.Size(132, 42);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "CLOSE";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.AnimationHoverSpeed = 0.07F;
            this.save_btn.AnimationSpeed = 0.03F;
            this.save_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.save_btn.BorderColor = System.Drawing.Color.Black;
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save_btn.FocusedColor = System.Drawing.Color.Empty;
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Image = global::Food_Ordering_System.Properties.Resources.Save_Button_PNG_Transparent_File;
            this.save_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.save_btn.Location = new System.Drawing.Point(54, 32);
            this.save_btn.Name = "save_btn";
            this.save_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.save_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.save_btn.OnHoverImage = null;
            this.save_btn.OnPressedColor = System.Drawing.Color.Black;
            this.save_btn.Size = new System.Drawing.Size(128, 42);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "SAVE";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // browse_btn
            // 
            this.browse_btn.AnimationHoverSpeed = 0.07F;
            this.browse_btn.AnimationSpeed = 0.03F;
            this.browse_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.browse_btn.BorderColor = System.Drawing.Color.Black;
            this.browse_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.browse_btn.FocusedColor = System.Drawing.Color.Empty;
            this.browse_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_btn.ForeColor = System.Drawing.Color.White;
            this.browse_btn.Image = global::Food_Ordering_System.Properties.Resources.browse_icon_16;
            this.browse_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.browse_btn.Location = new System.Drawing.Point(598, 279);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.browse_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.browse_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.browse_btn.OnHoverImage = null;
            this.browse_btn.OnPressedColor = System.Drawing.Color.Black;
            this.browse_btn.Size = new System.Drawing.Size(156, 42);
            this.browse_btn.TabIndex = 23;
            this.browse_btn.Text = "Browse";
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // picbox_browse
            // 
            this.picbox_browse.BaseColor = System.Drawing.Color.White;
            this.picbox_browse.Image = global::Food_Ordering_System.Properties.Resources.img_47703;
            this.picbox_browse.Location = new System.Drawing.Point(598, 130);
            this.picbox_browse.Name = "picbox_browse";
            this.picbox_browse.Size = new System.Drawing.Size(156, 143);
            this.picbox_browse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_browse.TabIndex = 22;
            this.picbox_browse.TabStop = false;
            this.picbox_browse.UseTransfarantBackground = false;
            // 
            // combo_category
            // 
            this.combo_category.BackColor = System.Drawing.Color.Transparent;
            this.combo_category.BaseColor = System.Drawing.Color.White;
            this.combo_category.BorderColor = System.Drawing.Color.Silver;
            this.combo_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category.FocusedColor = System.Drawing.Color.Empty;
            this.combo_category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_category.ForeColor = System.Drawing.Color.Black;
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(60, 265);
            this.combo_category.Name = "combo_category";
            this.combo_category.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_category.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_category.Size = new System.Drawing.Size(246, 31);
            this.combo_category.TabIndex = 18;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(57, 224);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(98, 28);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Category";
            // 
            // text_price
            // 
            this.text_price.BaseColor = System.Drawing.Color.White;
            this.text_price.BorderColor = System.Drawing.Color.Silver;
            this.text_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_price.FocusedBaseColor = System.Drawing.Color.White;
            this.text_price.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_price.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_price.Location = new System.Drawing.Point(328, 170);
            this.text_price.Name = "text_price";
            this.text_price.PasswordChar = '\0';
            this.text_price.SelectedText = "";
            this.text_price.Size = new System.Drawing.Size(246, 32);
            this.text_price.TabIndex = 17;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(324, 130);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(59, 28);
            this.gunaLabel3.TabIndex = 20;
            this.gunaLabel3.Text = "Price";
            // 
            // text_name
            // 
            this.text_name.BaseColor = System.Drawing.Color.White;
            this.text_name.BorderColor = System.Drawing.Color.Silver;
            this.text_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_name.FocusedBaseColor = System.Drawing.Color.White;
            this.text_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_name.Location = new System.Drawing.Point(60, 170);
            this.text_name.Name = "text_name";
            this.text_name.PasswordChar = '\0';
            this.text_name.SelectedText = "";
            this.text_name.Size = new System.Drawing.Size(246, 32);
            this.text_name.TabIndex = 16;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(57, 130);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 28);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Name";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.picbox_browse);
            this.Controls.Add(this.combo_category);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddProduct";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_browse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public System.Windows.Forms.Panel panel2;
        public Guna.UI.WinForms.GunaButton close_btn;
        public Guna.UI.WinForms.GunaButton save_btn;
        private Guna.UI.WinForms.GunaButton browse_btn;
        private Guna.UI.WinForms.GunaCirclePictureBox picbox_browse;
        public Guna.UI.WinForms.GunaComboBox combo_category;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        public Guna.UI.WinForms.GunaTextBox text_price;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaTextBox text_name;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}