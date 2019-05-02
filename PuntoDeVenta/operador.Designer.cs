namespace PuntoDeVenta
{
    partial class operador
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.pagar = new System.Windows.Forms.Button();
            this.recarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "20/03/2015 4:8:33 AM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(277, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(274, 33);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Abarrotes doña Chu";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Nombre,
            this.PrecioUnitario,
            this.Total_});
            this.grid.Location = new System.Drawing.Point(12, 91);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(865, 150);
            this.grid.TabIndex = 3;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Total_
            // 
            this.Total_.HeaderText = "Total_";
            this.Total_.Name = "Total_";
            this.Total_.ReadOnly = true;
            // 
            // box
            // 
            this.box.Location = new System.Drawing.Point(12, 329);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(100, 20);
            this.box.TabIndex = 4;
            this.box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_KeyPress);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.Teal;
            this.total.Location = new System.Drawing.Point(707, 354);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(74, 29);
            this.total.TabIndex = 5;
            this.total.Text = "Total:";
            // 
            // pagar
            // 
            this.pagar.Image = global::PuntoDeVenta.Properties.Resources.iconfinder_Travel_Filled_16_3671992;
            this.pagar.Location = new System.Drawing.Point(574, 265);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(75, 65);
            this.pagar.TabIndex = 7;
            this.pagar.UseVisualStyleBackColor = true;
            this.pagar.Click += new System.EventHandler(this.pagar_Click);
            // 
            // recarga
            // 
            this.recarga.Image = global::PuntoDeVenta.Properties.Resources.iconfinder_04_171508;
            this.recarga.Location = new System.Drawing.Point(476, 265);
            this.recarga.Name = "recarga";
            this.recarga.Size = new System.Drawing.Size(75, 65);
            this.recarga.TabIndex = 6;
            this.recarga.UseVisualStyleBackColor = true;
            this.recarga.Click += new System.EventHandler(this.button1_Click);
            // 
            // operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 413);
            this.Controls.Add(this.pagar);
            this.Controls.Add(this.recarga);
            this.Controls.Add(this.total);
            this.Controls.Add(this.box);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "operador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "operador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.operador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox box;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_;
        private System.Windows.Forms.Button recarga;
        private System.Windows.Forms.Button pagar;
    }
}