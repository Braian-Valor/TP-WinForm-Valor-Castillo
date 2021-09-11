
namespace WinForm
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tBox_DirImagen = new System.Windows.Forms.TextBox();
            this.lab_Precio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBox_Precio = new System.Windows.Forms.TextBox();
            this.lab_Imagen = new System.Windows.Forms.Label();
            this.tBox_Marca = new System.Windows.Forms.TextBox();
            this.lab_Marca = new System.Windows.Forms.Label();
            this.tBox_Descripcion = new System.Windows.Forms.TextBox();
            this.lab_Descripcion = new System.Windows.Forms.Label();
            this.tBox_Nombre = new System.Windows.Forms.TextBox();
            this.lab_Nombre = new System.Windows.Forms.Label();
            this.tBox_CodigoArticulo = new System.Windows.Forms.TextBox();
            this.lab_CodigoArticulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(255, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Location = new System.Drawing.Point(393, 244);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(221, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Examinar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // tBox_DirImagen
            // 
            this.tBox_DirImagen.Location = new System.Drawing.Point(168, 201);
            this.tBox_DirImagen.MaxLength = 1000;
            this.tBox_DirImagen.Name = "tBox_DirImagen";
            this.tBox_DirImagen.Size = new System.Drawing.Size(194, 20);
            this.tBox_DirImagen.TabIndex = 28;
            this.tBox_DirImagen.Text = "\r\n";
            // 
            // lab_Precio
            // 
            this.lab_Precio.AutoSize = true;
            this.lab_Precio.BackColor = System.Drawing.Color.Transparent;
            this.lab_Precio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Precio.ForeColor = System.Drawing.Color.White;
            this.lab_Precio.Location = new System.Drawing.Point(26, 251);
            this.lab_Precio.Name = "lab_Precio";
            this.lab_Precio.Size = new System.Drawing.Size(57, 16);
            this.lab_Precio.TabIndex = 27;
            this.lab_Precio.Text = "Precio:";
            this.lab_Precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(393, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 153);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // tBox_Precio
            // 
            this.tBox_Precio.Location = new System.Drawing.Point(168, 247);
            this.tBox_Precio.MaxLength = 50;
            this.tBox_Precio.Name = "tBox_Precio";
            this.tBox_Precio.Size = new System.Drawing.Size(194, 20);
            this.tBox_Precio.TabIndex = 25;
            this.tBox_Precio.Text = "$ \r\n\r\n";
            // 
            // lab_Imagen
            // 
            this.lab_Imagen.AutoSize = true;
            this.lab_Imagen.BackColor = System.Drawing.Color.Transparent;
            this.lab_Imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Imagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Imagen.ForeColor = System.Drawing.Color.White;
            this.lab_Imagen.Location = new System.Drawing.Point(26, 205);
            this.lab_Imagen.Name = "lab_Imagen";
            this.lab_Imagen.Size = new System.Drawing.Size(63, 16);
            this.lab_Imagen.TabIndex = 24;
            this.lab_Imagen.Text = "Imagen:";
            this.lab_Imagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_Marca
            // 
            this.tBox_Marca.Location = new System.Drawing.Point(168, 157);
            this.tBox_Marca.MaxLength = 50;
            this.tBox_Marca.Name = "tBox_Marca";
            this.tBox_Marca.Size = new System.Drawing.Size(194, 20);
            this.tBox_Marca.TabIndex = 23;
            this.tBox_Marca.Text = "\r\n";
            // 
            // lab_Marca
            // 
            this.lab_Marca.AutoSize = true;
            this.lab_Marca.BackColor = System.Drawing.Color.Transparent;
            this.lab_Marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Marca.ForeColor = System.Drawing.Color.White;
            this.lab_Marca.Location = new System.Drawing.Point(26, 161);
            this.lab_Marca.Name = "lab_Marca";
            this.lab_Marca.Size = new System.Drawing.Size(55, 16);
            this.lab_Marca.TabIndex = 22;
            this.lab_Marca.Text = "Marca:";
            this.lab_Marca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_Descripcion
            // 
            this.tBox_Descripcion.Location = new System.Drawing.Point(168, 109);
            this.tBox_Descripcion.MaxLength = 150;
            this.tBox_Descripcion.Name = "tBox_Descripcion";
            this.tBox_Descripcion.Size = new System.Drawing.Size(194, 20);
            this.tBox_Descripcion.TabIndex = 21;
            this.tBox_Descripcion.Text = "\r\n";
            // 
            // lab_Descripcion
            // 
            this.lab_Descripcion.AutoSize = true;
            this.lab_Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lab_Descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lab_Descripcion.Location = new System.Drawing.Point(26, 113);
            this.lab_Descripcion.Name = "lab_Descripcion";
            this.lab_Descripcion.Size = new System.Drawing.Size(95, 16);
            this.lab_Descripcion.TabIndex = 20;
            this.lab_Descripcion.Text = "Descripcion:";
            this.lab_Descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_Nombre
            // 
            this.tBox_Nombre.Location = new System.Drawing.Point(168, 69);
            this.tBox_Nombre.MaxLength = 50;
            this.tBox_Nombre.Name = "tBox_Nombre";
            this.tBox_Nombre.Size = new System.Drawing.Size(194, 20);
            this.tBox_Nombre.TabIndex = 19;
            this.tBox_Nombre.Text = "\r\n";
            // 
            // lab_Nombre
            // 
            this.lab_Nombre.AutoSize = true;
            this.lab_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.lab_Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Nombre.ForeColor = System.Drawing.Color.White;
            this.lab_Nombre.Location = new System.Drawing.Point(26, 73);
            this.lab_Nombre.Name = "lab_Nombre";
            this.lab_Nombre.Size = new System.Drawing.Size(67, 16);
            this.lab_Nombre.TabIndex = 18;
            this.lab_Nombre.Text = "Nombre:";
            this.lab_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_CodigoArticulo
            // 
            this.tBox_CodigoArticulo.Location = new System.Drawing.Point(168, 24);
            this.tBox_CodigoArticulo.MaxLength = 50;
            this.tBox_CodigoArticulo.Name = "tBox_CodigoArticulo";
            this.tBox_CodigoArticulo.Size = new System.Drawing.Size(194, 20);
            this.tBox_CodigoArticulo.TabIndex = 17;
            this.tBox_CodigoArticulo.Text = "\r\n";
            // 
            // lab_CodigoArticulo
            // 
            this.lab_CodigoArticulo.AutoSize = true;
            this.lab_CodigoArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lab_CodigoArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_CodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_CodigoArticulo.ForeColor = System.Drawing.Color.White;
            this.lab_CodigoArticulo.Location = new System.Drawing.Point(26, 28);
            this.lab_CodigoArticulo.Name = "lab_CodigoArticulo";
            this.lab_CodigoArticulo.Size = new System.Drawing.Size(140, 16);
            this.lab_CodigoArticulo.TabIndex = 16;
            this.lab_CodigoArticulo.Text = "Codigo de Articulo:";
            this.lab_CodigoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(393, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources._8b6e695fb470ba5939b226d06d55248e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tBox_DirImagen);
            this.Controls.Add(this.lab_Precio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tBox_Precio);
            this.Controls.Add(this.lab_Imagen);
            this.Controls.Add(this.tBox_Marca);
            this.Controls.Add(this.lab_Marca);
            this.Controls.Add(this.tBox_Descripcion);
            this.Controls.Add(this.lab_Descripcion);
            this.Controls.Add(this.tBox_Nombre);
            this.Controls.Add(this.lab_Nombre);
            this.Controls.Add(this.tBox_CodigoArticulo);
            this.Controls.Add(this.lab_CodigoArticulo);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP WinForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tBox_DirImagen;
        private System.Windows.Forms.Label lab_Precio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBox_Precio;
        private System.Windows.Forms.Label lab_Imagen;
        private System.Windows.Forms.TextBox tBox_Marca;
        private System.Windows.Forms.Label lab_Marca;
        private System.Windows.Forms.TextBox tBox_Descripcion;
        private System.Windows.Forms.Label lab_Descripcion;
        private System.Windows.Forms.TextBox tBox_Nombre;
        private System.Windows.Forms.Label lab_Nombre;
        private System.Windows.Forms.TextBox tBox_CodigoArticulo;
        private System.Windows.Forms.Label lab_CodigoArticulo;
        private System.Windows.Forms.Button button2;
    }
}