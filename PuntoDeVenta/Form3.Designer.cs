namespace PuntoDeVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Excel = new System.Windows.Forms.Button();
            this.PDF = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtApellidoUno = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Excel
            // 
            this.Excel.BackgroundImage = global::PuntoDeVenta.Properties.Resources.iconfinder_09_2064824;
            this.Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Excel.Location = new System.Drawing.Point(543, 3);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(35, 35);
            this.Excel.TabIndex = 41;
            this.Excel.UseVisualStyleBackColor = true;
            // 
            // PDF
            // 
            this.PDF.BackgroundImage = global::PuntoDeVenta.Properties.Resources.iconfinder_icon_70_document_file_pdf_315672;
            this.PDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PDF.Location = new System.Drawing.Point(584, 3);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(35, 35);
            this.PDF.TabIndex = 40;
            this.PDF.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.Editar.BackgroundImage = global::PuntoDeVenta.Properties.Resources.iconfinder_write_126582;
            this.Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Editar.Location = new System.Drawing.Point(470, 9);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(25, 25);
            this.Editar.TabIndex = 39;
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.BackgroundImage = global::PuntoDeVenta.Properties.Resources.iconfinder_remove_01_186389;
            this.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminar.Location = new System.Drawing.Point(439, 9);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(25, 25);
            this.Eliminar.TabIndex = 38;
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            this.Agregar.BackgroundImage = global::PuntoDeVenta.Properties.Resources.iconfinder_plus_24_103172;
            this.Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Agregar.Location = new System.Drawing.Point(408, 9);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(25, 25);
            this.Agregar.TabIndex = 37;
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.URL,
            this.Imagen});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(641, 161);
            this.dataGridView1.TabIndex = 36;
            // 
            // txtApellidoUno
            // 
            this.txtApellidoUno.Location = new System.Drawing.Point(190, 377);
            this.txtApellidoUno.Name = "txtApellidoUno";
            this.txtApellidoUno.Size = new System.Drawing.Size(135, 20);
            this.txtApellidoUno.TabIndex = 32;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(190, 339);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 31;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(190, 289);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(135, 20);
            this.txtUsuario.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(190, 240);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 20);
            this.txtId.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "Administracion de productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo de Barras";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtApellidoUno);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtApellidoUno;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
    }
}