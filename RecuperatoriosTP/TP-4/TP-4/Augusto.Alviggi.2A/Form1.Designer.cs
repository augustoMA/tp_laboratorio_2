namespace Augusto.Alviggi._2A
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.gbEstados = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEntregado = new System.Windows.Forms.ListBox();
            this.lbEnViaje = new System.Windows.Forms.ListBox();
            this.lbIngresado = new System.Windows.Forms.ListBox();
            this.gbPaquete = new System.Windows.Forms.GroupBox();
            this.mtxtAgregar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rtxtLista = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbEstados.SuspendLayout();
            this.gbPaquete.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(30, 114);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(172, 20);
            this.txtMostrar.TabIndex = 0;
            // 
            // gbEstados
            // 
            this.gbEstados.Controls.Add(this.label5);
            this.gbEstados.Controls.Add(this.label4);
            this.gbEstados.Controls.Add(this.label3);
            this.gbEstados.Controls.Add(this.lbEntregado);
            this.gbEstados.Controls.Add(this.lbEnViaje);
            this.gbEstados.Controls.Add(this.lbIngresado);
            this.gbEstados.Location = new System.Drawing.Point(12, 12);
            this.gbEstados.Name = "gbEstados";
            this.gbEstados.Size = new System.Drawing.Size(776, 260);
            this.gbEstados.TabIndex = 1;
            this.gbEstados.TabStop = false;
            this.gbEstados.Text = "Estados Paquetes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Entregado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "En viaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresado";
            // 
            // lbEntregado
            // 
            this.lbEntregado.FormattingEnabled = true;
            this.lbEntregado.Location = new System.Drawing.Point(530, 49);
            this.lbEntregado.Name = "lbEntregado";
            this.lbEntregado.Size = new System.Drawing.Size(225, 199);
            this.lbEntregado.TabIndex = 2;
            this.lbEntregado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbEntregado_MouseDown);
            // 
            // lbEnViaje
            // 
            this.lbEnViaje.FormattingEnabled = true;
            this.lbEnViaje.Location = new System.Drawing.Point(281, 49);
            this.lbEnViaje.Name = "lbEnViaje";
            this.lbEnViaje.Size = new System.Drawing.Size(217, 199);
            this.lbEnViaje.TabIndex = 1;
            // 
            // lbIngresado
            // 
            this.lbIngresado.FormattingEnabled = true;
            this.lbIngresado.Location = new System.Drawing.Point(25, 49);
            this.lbIngresado.Name = "lbIngresado";
            this.lbIngresado.Size = new System.Drawing.Size(222, 199);
            this.lbIngresado.TabIndex = 0;
            // 
            // gbPaquete
            // 
            this.gbPaquete.Controls.Add(this.mtxtAgregar);
            this.gbPaquete.Controls.Add(this.label2);
            this.gbPaquete.Controls.Add(this.label1);
            this.gbPaquete.Controls.Add(this.btnMostrar);
            this.gbPaquete.Controls.Add(this.btnAgregar);
            this.gbPaquete.Controls.Add(this.txtMostrar);
            this.gbPaquete.Location = new System.Drawing.Point(418, 292);
            this.gbPaquete.Name = "gbPaquete";
            this.gbPaquete.Size = new System.Drawing.Size(370, 140);
            this.gbPaquete.TabIndex = 2;
            this.gbPaquete.TabStop = false;
            this.gbPaquete.Text = "Paquete";
            // 
            // mtxtAgregar
            // 
            this.mtxtAgregar.Location = new System.Drawing.Point(30, 59);
            this.mtxtAgregar.Name = "mtxtAgregar";
            this.mtxtAgregar.Size = new System.Drawing.Size(172, 20);
            this.mtxtAgregar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tacking ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Direccion";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(258, 89);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(106, 45);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(258, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 45);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rtxtLista
            // 
            this.rtxtLista.Location = new System.Drawing.Point(12, 292);
            this.rtxtLista.Name = "rtxtLista";
            this.rtxtLista.Size = new System.Drawing.Size(383, 140);
            this.rtxtLista.TabIndex = 3;
            this.rtxtLista.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            this.mostrarToolStripMenuItem1.Click += new System.EventHandler(this.mostrarToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtLista);
            this.Controls.Add(this.gbPaquete);
            this.Controls.Add(this.gbEstados);
            this.Name = "Form1";
            this.Text = "Augusto.Alviggi.2A";
            this.gbEstados.ResumeLayout(false);
            this.gbEstados.PerformLayout();
            this.gbPaquete.ResumeLayout(false);
            this.gbPaquete.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.GroupBox gbEstados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbEntregado;
        private System.Windows.Forms.ListBox lbEnViaje;
        private System.Windows.Forms.ListBox lbIngresado;
        private System.Windows.Forms.GroupBox gbPaquete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MaskedTextBox mtxtAgregar;
        private System.Windows.Forms.RichTextBox rtxtLista;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
    }
}

