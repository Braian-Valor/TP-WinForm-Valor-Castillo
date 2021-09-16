
namespace WinForm
{
    partial class Frm_NuevoArticulo
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tBox_DirImagen = new System.Windows.Forms.TextBox();
            this.lab_Precio = new System.Windows.Forms.Label();
            this.pBoxAlta = new System.Windows.Forms.PictureBox();
            this.tBox_Precio = new System.Windows.Forms.TextBox();
            this.lab_Imagen = new System.Windows.Forms.Label();
            this.lab_Marca = new System.Windows.Forms.Label();
            this.tBox_Descripcion = new System.Windows.Forms.TextBox();
            this.lab_Descripcion = new System.Windows.Forms.Label();
            this.tBox_Nombre = new System.Windows.Forms.TextBox();
            this.lab_Nombre = new System.Windows.Forms.Label();
            this.tBox_CodigoArticulo = new System.Windows.Forms.TextBox();
            this.lab_CodigoArticulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cBox_Marca = new System.Windows.Forms.ComboBox();
            this.cBox_Categoria = new System.Windows.Forms.ComboBox();
            this.lab_Categoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(204, 341);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 31);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tBox_DirImagen
            // 
            this.tBox_DirImagen.Location = new System.Drawing.Point(168, 235);
            this.tBox_DirImagen.MaxLength = 1000;
            this.tBox_DirImagen.Name = "tBox_DirImagen";
            this.tBox_DirImagen.Size = new System.Drawing.Size(194, 20);
            this.tBox_DirImagen.TabIndex = 5;
            this.tBox_DirImagen.Text = "\r\n";
            this.tBox_DirImagen.Leave += new System.EventHandler(this.tBox_DirImagen_Leave);
            // 
            // lab_Precio
            // 
            this.lab_Precio.AutoSize = true;
            this.lab_Precio.BackColor = System.Drawing.Color.Transparent;
            this.lab_Precio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Precio.ForeColor = System.Drawing.Color.White;
            this.lab_Precio.Location = new System.Drawing.Point(26, 285);
            this.lab_Precio.Name = "lab_Precio";
            this.lab_Precio.Size = new System.Drawing.Size(57, 16);
            this.lab_Precio.TabIndex = 27;
            this.lab_Precio.Text = "Precio:";
            this.lab_Precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxAlta
            // 
            this.pBoxAlta.Location = new System.Drawing.Point(393, 24);
            this.pBoxAlta.Name = "pBoxAlta";
            this.pBoxAlta.Size = new System.Drawing.Size(274, 277);
            this.pBoxAlta.TabIndex = 26;
            this.pBoxAlta.TabStop = false;
            // 
            // tBox_Precio
            // 
            this.tBox_Precio.Location = new System.Drawing.Point(168, 281);
            this.tBox_Precio.MaxLength = 50;
            this.tBox_Precio.Name = "tBox_Precio";
            this.tBox_Precio.Size = new System.Drawing.Size(194, 20);
            this.tBox_Precio.TabIndex = 6;
            this.tBox_Precio.Text = "\r\n\r\n";
            // 
            // lab_Imagen
            // 
            this.lab_Imagen.AutoSize = true;
            this.lab_Imagen.BackColor = System.Drawing.Color.Transparent;
            this.lab_Imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Imagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Imagen.ForeColor = System.Drawing.Color.White;
            this.lab_Imagen.Location = new System.Drawing.Point(26, 239);
            this.lab_Imagen.Name = "lab_Imagen";
            this.lab_Imagen.Size = new System.Drawing.Size(87, 16);
            this.lab_Imagen.TabIndex = 24;
            this.lab_Imagen.Text = "Url Imagen:";
            this.lab_Imagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Marca
            // 
            this.lab_Marca.AutoSize = true;
            this.lab_Marca.BackColor = System.Drawing.Color.Transparent;
            this.lab_Marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Marca.ForeColor = System.Drawing.Color.White;
            this.lab_Marca.Location = new System.Drawing.Point(26, 157);
            this.lab_Marca.Name = "lab_Marca";
            this.lab_Marca.Size = new System.Drawing.Size(55, 16);
            this.lab_Marca.TabIndex = 22;
            this.lab_Marca.Text = "Marca:";
            this.lab_Marca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_Descripcion
            // 
            this.tBox_Descripcion.Location = new System.Drawing.Point(168, 109);
            this.tBox_Descripcion.MaxLength = 1000;
            this.tBox_Descripcion.Name = "tBox_Descripcion";
            this.tBox_Descripcion.Size = new System.Drawing.Size(194, 20);
            this.tBox_Descripcion.TabIndex = 2;
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
            this.tBox_Nombre.TabIndex = 1;
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
            this.tBox_CodigoArticulo.TabIndex = 0;
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(393, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cBox_Marca
            // 
            this.cBox_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Marca.FormattingEnabled = true;
            this.cBox_Marca.Location = new System.Drawing.Point(168, 152);
            this.cBox_Marca.Name = "cBox_Marca";
            this.cBox_Marca.Size = new System.Drawing.Size(194, 21);
            this.cBox_Marca.TabIndex = 3;
            // 
            // cBox_Categoria
            // 
            this.cBox_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Categoria.FormattingEnabled = true;
            this.cBox_Categoria.Location = new System.Drawing.Point(168, 194);
            this.cBox_Categoria.Name = "cBox_Categoria";
            this.cBox_Categoria.Size = new System.Drawing.Size(194, 21);
            this.cBox_Categoria.TabIndex = 4;
            // 
            // lab_Categoria
            // 
            this.lab_Categoria.AutoSize = true;
            this.lab_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.lab_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Categoria.ForeColor = System.Drawing.Color.White;
            this.lab_Categoria.Location = new System.Drawing.Point(26, 199);
            this.lab_Categoria.Name = "lab_Categoria";
            this.lab_Categoria.Size = new System.Drawing.Size(80, 16);
            this.lab_Categoria.TabIndex = 34;
            this.lab_Categoria.Text = "Categoria:";
            this.lab_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_NuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinForm.Properties.Resources._8b6e695fb470ba5939b226d06d55248e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 405);
            this.Controls.Add(this.cBox_Categoria);
            this.Controls.Add(this.lab_Categoria);
            this.Controls.Add(this.cBox_Marca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tBox_DirImagen);
            this.Controls.Add(this.lab_Precio);
            this.Controls.Add(this.pBoxAlta);
            this.Controls.Add(this.tBox_Precio);
            this.Controls.Add(this.lab_Imagen);
            this.Controls.Add(this.lab_Marca);
            this.Controls.Add(this.tBox_Descripcion);
            this.Controls.Add(this.lab_Descripcion);
            this.Controls.Add(this.tBox_Nombre);
            this.Controls.Add(this.lab_Nombre);
            this.Controls.Add(this.tBox_CodigoArticulo);
            this.Controls.Add(this.lab_CodigoArticulo);
            this.Name = "Frm_NuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.Frm_NuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tBox_DirImagen;
        private System.Windows.Forms.Label lab_Precio;
        private System.Windows.Forms.PictureBox pBoxAlta;
        private System.Windows.Forms.TextBox tBox_Precio;
        private System.Windows.Forms.Label lab_Imagen;
        private System.Windows.Forms.Label lab_Marca;
        private System.Windows.Forms.TextBox tBox_Descripcion;
        private System.Windows.Forms.Label lab_Descripcion;
        private System.Windows.Forms.TextBox tBox_Nombre;
        private System.Windows.Forms.Label lab_Nombre;
        private System.Windows.Forms.TextBox tBox_CodigoArticulo;
        private System.Windows.Forms.Label lab_CodigoArticulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cBox_Marca;
        private System.Windows.Forms.ComboBox cBox_Categoria;
        private System.Windows.Forms.Label lab_Categoria;
    }
}