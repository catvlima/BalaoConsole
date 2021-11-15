
namespace BalaoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_balao = new System.Windows.Forms.PictureBox();
            this.bt_up = new System.Windows.Forms.Button();
            this.bt_left = new System.Windows.Forms.Button();
            this.bt_down = new System.Windows.Forms.Button();
            this.bt_right = new System.Windows.Forms.Button();
            this.cb_cor = new System.Windows.Forms.ComboBox();
            this.bt_MudarCor = new System.Windows.Forms.Button();
            this.lbl_InfoCor = new System.Windows.Forms.Label();
            this.lbl_InfoDirecao = new System.Windows.Forms.Label();
            this.lbl_InfoAltura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_balao)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_balao
            // 
            this.pb_balao.BackColor = System.Drawing.Color.Transparent;
            this.pb_balao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_balao.Image = ((System.Drawing.Image)(resources.GetObject("pb_balao.Image")));
            this.pb_balao.Location = new System.Drawing.Point(216, 273);
            this.pb_balao.Name = "pb_balao";
            this.pb_balao.Size = new System.Drawing.Size(79, 83);
            this.pb_balao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_balao.TabIndex = 0;
            this.pb_balao.TabStop = false;
            // 
            // bt_up
            // 
            this.bt_up.BackColor = System.Drawing.Color.Transparent;
            this.bt_up.FlatAppearance.BorderSize = 0;
            this.bt_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_up.Location = new System.Drawing.Point(96, 516);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(26, 26);
            this.bt_up.TabIndex = 1;
            this.bt_up.UseVisualStyleBackColor = false;
            this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
            // 
            // bt_left
            // 
            this.bt_left.BackColor = System.Drawing.Color.Transparent;
            this.bt_left.FlatAppearance.BorderSize = 0;
            this.bt_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_left.Location = new System.Drawing.Point(58, 553);
            this.bt_left.Name = "bt_left";
            this.bt_left.Size = new System.Drawing.Size(26, 26);
            this.bt_left.TabIndex = 2;
            this.bt_left.UseVisualStyleBackColor = false;
            this.bt_left.Click += new System.EventHandler(this.bt_left_Click);
            // 
            // bt_down
            // 
            this.bt_down.BackColor = System.Drawing.Color.Transparent;
            this.bt_down.FlatAppearance.BorderSize = 0;
            this.bt_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_down.Location = new System.Drawing.Point(96, 593);
            this.bt_down.Name = "bt_down";
            this.bt_down.Size = new System.Drawing.Size(26, 26);
            this.bt_down.TabIndex = 3;
            this.bt_down.UseVisualStyleBackColor = false;
            this.bt_down.Click += new System.EventHandler(this.bt_down_Click);
            // 
            // bt_right
            // 
            this.bt_right.BackColor = System.Drawing.Color.Transparent;
            this.bt_right.FlatAppearance.BorderSize = 0;
            this.bt_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_right.Location = new System.Drawing.Point(134, 553);
            this.bt_right.Name = "bt_right";
            this.bt_right.Size = new System.Drawing.Size(26, 26);
            this.bt_right.TabIndex = 4;
            this.bt_right.UseVisualStyleBackColor = false;
            this.bt_right.Click += new System.EventHandler(this.bt_right_Click);
            // 
            // cb_cor
            // 
            this.cb_cor.FormattingEnabled = true;
            this.cb_cor.Items.AddRange(new object[] {
            "Rosa",
            "Amarelo",
            "Azul",
            "Lilás"});
            this.cb_cor.Location = new System.Drawing.Point(323, 616);
            this.cb_cor.Name = "cb_cor";
            this.cb_cor.Size = new System.Drawing.Size(121, 23);
            this.cb_cor.TabIndex = 5;
            this.cb_cor.Text = "Escolha uma cor";
            this.cb_cor.Visible = false;
            this.cb_cor.SelectedIndexChanged += new System.EventHandler(this.cb_cor_SelectedIndexChanged);
            // 
            // bt_MudarCor
            // 
            this.bt_MudarCor.BackColor = System.Drawing.Color.Transparent;
            this.bt_MudarCor.FlatAppearance.BorderSize = 0;
            this.bt_MudarCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_MudarCor.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_MudarCor.ForeColor = System.Drawing.Color.White;
            this.bt_MudarCor.Location = new System.Drawing.Point(323, 538);
            this.bt_MudarCor.Name = "bt_MudarCor";
            this.bt_MudarCor.Size = new System.Drawing.Size(73, 81);
            this.bt_MudarCor.TabIndex = 6;
            this.bt_MudarCor.Text = "Clique para mudar a cor";
            this.bt_MudarCor.UseVisualStyleBackColor = false;
            this.bt_MudarCor.Click += new System.EventHandler(this.bt_MudarCor_Click);
            // 
            // lbl_InfoCor
            // 
            this.lbl_InfoCor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InfoCor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_InfoCor.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_InfoCor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_InfoCor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_InfoCor.Location = new System.Drawing.Point(178, 448);
            this.lbl_InfoCor.Name = "lbl_InfoCor";
            this.lbl_InfoCor.Size = new System.Drawing.Size(190, 17);
            this.lbl_InfoCor.TabIndex = 8;
            // 
            // lbl_InfoDirecao
            // 
            this.lbl_InfoDirecao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InfoDirecao.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_InfoDirecao.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_InfoDirecao.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_InfoDirecao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_InfoDirecao.Location = new System.Drawing.Point(178, 482);
            this.lbl_InfoDirecao.Name = "lbl_InfoDirecao";
            this.lbl_InfoDirecao.Size = new System.Drawing.Size(218, 17);
            this.lbl_InfoDirecao.TabIndex = 9;
            // 
            // lbl_InfoAltura
            // 
            this.lbl_InfoAltura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_InfoAltura.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_InfoAltura.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_InfoAltura.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_InfoAltura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_InfoAltura.Location = new System.Drawing.Point(178, 465);
            this.lbl_InfoAltura.Name = "lbl_InfoAltura";
            this.lbl_InfoAltura.Size = new System.Drawing.Size(190, 17);
            this.lbl_InfoAltura.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(516, 833);
            this.Controls.Add(this.lbl_InfoAltura);
            this.Controls.Add(this.lbl_InfoDirecao);
            this.Controls.Add(this.lbl_InfoCor);
            this.Controls.Add(this.bt_MudarCor);
            this.Controls.Add(this.cb_cor);
            this.Controls.Add(this.bt_right);
            this.Controls.Add(this.bt_down);
            this.Controls.Add(this.bt_left);
            this.Controls.Add(this.bt_up);
            this.Controls.Add(this.pb_balao);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balãozito";
            ((System.ComponentModel.ISupportInitialize)(this.pb_balao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_balao;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.Button bt_left;
        private System.Windows.Forms.Button bt_down;
        private System.Windows.Forms.Button bt_right;
        private System.Windows.Forms.ComboBox cb_cor;
        private System.Windows.Forms.Button bt_MudarCor;
        private System.Windows.Forms.Label lbl_InfoCor;
        private System.Windows.Forms.Label lbl_InfoDirecao;
        private System.Windows.Forms.Label lbl_InfoAltura;
    }
}

