namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_mostrar2 = new System.Windows.Forms.Button();
            this.btn_apagar2 = new System.Windows.Forms.Button();
            this.pictureBoxmostrar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxmostrar = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmostrar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(111, 312);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(498, 42);
            this.btn_mostrar.TabIndex = 1;
            this.btn_mostrar.Text = "Clique para mostrar image ";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(111, 360);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(498, 44);
            this.btn_apagar.TabIndex = 2;
            this.btn_apagar.Text = "Clique para apagar a image";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_mostrar2
            // 
            this.btn_mostrar2.Location = new System.Drawing.Point(663, 312);
            this.btn_mostrar2.Name = "btn_mostrar2";
            this.btn_mostrar2.Size = new System.Drawing.Size(539, 42);
            this.btn_mostrar2.TabIndex = 4;
            this.btn_mostrar2.Text = "Mostrar a imagem 2!";
            this.btn_mostrar2.UseVisualStyleBackColor = true;
            this.btn_mostrar2.Click += new System.EventHandler(this.btn_mostrar2_Click);
            // 
            // btn_apagar2
            // 
            this.btn_apagar2.Location = new System.Drawing.Point(663, 360);
            this.btn_apagar2.Name = "btn_apagar2";
            this.btn_apagar2.Size = new System.Drawing.Size(539, 44);
            this.btn_apagar2.TabIndex = 5;
            this.btn_apagar2.Text = "Não Mostrar a imagem 2!";
            this.btn_apagar2.UseVisualStyleBackColor = true;
            this.btn_apagar2.Click += new System.EventHandler(this.btn_apagar2_Click);
            // 
            // pictureBoxmostrar2
            // 
            this.pictureBoxmostrar2.Image = global::WindowsFormsApp1.Properties.Resources.omega;
            this.pictureBoxmostrar2.Location = new System.Drawing.Point(663, 33);
            this.pictureBoxmostrar2.Name = "pictureBoxmostrar2";
            this.pictureBoxmostrar2.Size = new System.Drawing.Size(522, 273);
            this.pictureBoxmostrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxmostrar2.TabIndex = 3;
            this.pictureBoxmostrar2.TabStop = false;
            // 
            // pictureBoxmostrar
            // 
            this.pictureBoxmostrar.Image = global::WindowsFormsApp1.Properties.Resources.cj;
            this.pictureBoxmostrar.Location = new System.Drawing.Point(124, 33);
            this.pictureBoxmostrar.Name = "pictureBoxmostrar";
            this.pictureBoxmostrar.Size = new System.Drawing.Size(498, 273);
            this.pictureBoxmostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxmostrar.TabIndex = 0;
            this.pictureBoxmostrar.TabStop = false;
            this.pictureBoxmostrar.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(412, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "Fechar Tudo !";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 519);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_apagar2);
            this.Controls.Add(this.btn_mostrar2);
            this.Controls.Add(this.pictureBoxmostrar2);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.pictureBoxmostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmostrar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxmostrar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.PictureBox pictureBoxmostrar2;
        private System.Windows.Forms.Button btn_mostrar2;
        private System.Windows.Forms.Button btn_apagar2;
        private System.Windows.Forms.Button button3;
    }
}

