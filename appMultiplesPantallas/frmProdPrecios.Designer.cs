namespace appMultiplesPantallas
{
    partial class frmProdPrecios
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
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnCincoCaros = new System.Windows.Forms.Button();
            this.btnDiezCaros = new System.Windows.Forms.Button();
            this.btnCincoBaratos = new System.Windows.Forms.Button();
            this.btnDiezBaratos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 20;
            this.lstProductos.Location = new System.Drawing.Point(39, 24);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(378, 384);
            this.lstProductos.TabIndex = 0;
            // 
            // btnCincoCaros
            // 
            this.btnCincoCaros.Location = new System.Drawing.Point(525, 117);
            this.btnCincoCaros.Name = "btnCincoCaros";
            this.btnCincoCaros.Size = new System.Drawing.Size(163, 32);
            this.btnCincoCaros.TabIndex = 1;
            this.btnCincoCaros.Text = "5 productos más caros";
            this.btnCincoCaros.UseVisualStyleBackColor = true;
            this.btnCincoCaros.Click += new System.EventHandler(this.btnCincoCaros_Click);
            // 
            // btnDiezCaros
            // 
            this.btnDiezCaros.Location = new System.Drawing.Point(525, 174);
            this.btnDiezCaros.Name = "btnDiezCaros";
            this.btnDiezCaros.Size = new System.Drawing.Size(163, 32);
            this.btnDiezCaros.TabIndex = 2;
            this.btnDiezCaros.Text = "10 productos más caros";
            this.btnDiezCaros.UseVisualStyleBackColor = true;
            this.btnDiezCaros.Click += new System.EventHandler(this.btnDiezCaros_Click);
            // 
            // btnCincoBaratos
            // 
            this.btnCincoBaratos.Location = new System.Drawing.Point(525, 237);
            this.btnCincoBaratos.Name = "btnCincoBaratos";
            this.btnCincoBaratos.Size = new System.Drawing.Size(163, 32);
            this.btnCincoBaratos.TabIndex = 3;
            this.btnCincoBaratos.Text = "5 productos más baratos";
            this.btnCincoBaratos.UseVisualStyleBackColor = true;
            this.btnCincoBaratos.Click += new System.EventHandler(this.btnCincoBaratos_Click);
            // 
            // btnDiezBaratos
            // 
            this.btnDiezBaratos.Location = new System.Drawing.Point(525, 301);
            this.btnDiezBaratos.Name = "btnDiezBaratos";
            this.btnDiezBaratos.Size = new System.Drawing.Size(163, 32);
            this.btnDiezBaratos.TabIndex = 4;
            this.btnDiezBaratos.Text = "10 productos más baratos";
            this.btnDiezBaratos.UseVisualStyleBackColor = true;
            this.btnDiezBaratos.Click += new System.EventHandler(this.btnDiezBaratos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(702, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProdPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDiezBaratos);
            this.Controls.Add(this.btnCincoBaratos);
            this.Controls.Add(this.btnDiezCaros);
            this.Controls.Add(this.btnCincoCaros);
            this.Controls.Add(this.lstProductos);
            this.Name = "frmProdPrecios";
            this.Text = "Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnCincoCaros;
        private System.Windows.Forms.Button btnDiezCaros;
        private System.Windows.Forms.Button btnCincoBaratos;
        private System.Windows.Forms.Button btnDiezBaratos;
        private System.Windows.Forms.Button btnSalir;
    }
}