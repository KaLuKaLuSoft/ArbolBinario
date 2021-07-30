
namespace ArbolBinario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_InsertarNodo = new System.Windows.Forms.Button();
            this.btn_EliminarNodo = new System.Windows.Forms.Button();
            this.btn_BuscarNodo = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btn_PreOrden = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arbol Binario";
            // 
            // btn_InsertarNodo
            // 
            this.btn_InsertarNodo.Location = new System.Drawing.Point(20, 78);
            this.btn_InsertarNodo.Name = "btn_InsertarNodo";
            this.btn_InsertarNodo.Size = new System.Drawing.Size(92, 59);
            this.btn_InsertarNodo.TabIndex = 1;
            this.btn_InsertarNodo.Text = "Insertar Nodo";
            this.btn_InsertarNodo.UseVisualStyleBackColor = true;
            this.btn_InsertarNodo.Click += new System.EventHandler(this.btn_InsertarNodo_Click);
            // 
            // btn_EliminarNodo
            // 
            this.btn_EliminarNodo.Location = new System.Drawing.Point(20, 143);
            this.btn_EliminarNodo.Name = "btn_EliminarNodo";
            this.btn_EliminarNodo.Size = new System.Drawing.Size(92, 59);
            this.btn_EliminarNodo.TabIndex = 2;
            this.btn_EliminarNodo.Text = "Eliminar Nodo";
            this.btn_EliminarNodo.UseVisualStyleBackColor = true;
            this.btn_EliminarNodo.Click += new System.EventHandler(this.btn_EliminarNodo_Click);
            // 
            // btn_BuscarNodo
            // 
            this.btn_BuscarNodo.Location = new System.Drawing.Point(20, 208);
            this.btn_BuscarNodo.Name = "btn_BuscarNodo";
            this.btn_BuscarNodo.Size = new System.Drawing.Size(92, 59);
            this.btn_BuscarNodo.TabIndex = 3;
            this.btn_BuscarNodo.Text = "Buscar Nodo";
            this.btn_BuscarNodo.UseVisualStyleBackColor = true;
            this.btn_BuscarNodo.Click += new System.EventHandler(this.btn_BuscarNodo_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(128, 96);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(103, 22);
            this.txtDato.TabIndex = 4;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(128, 161);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(103, 22);
            this.txtEliminar.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(128, 234);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(103, 22);
            this.txtBuscar.TabIndex = 6;
            // 
            // btn_PreOrden
            // 
            this.btn_PreOrden.Location = new System.Drawing.Point(20, 273);
            this.btn_PreOrden.Name = "btn_PreOrden";
            this.btn_PreOrden.Size = new System.Drawing.Size(92, 59);
            this.btn_PreOrden.TabIndex = 7;
            this.btn_PreOrden.Text = "Pre-Orden";
            this.btn_PreOrden.UseVisualStyleBackColor = true;
            this.btn_PreOrden.Click += new System.EventHandler(this.btn_PreOrden_Click);
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(20, 612);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(426, 95);
            this.pantalla.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 719);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.btn_PreOrden);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btn_BuscarNodo);
            this.Controls.Add(this.btn_EliminarNodo);
            this.Controls.Add(this.btn_InsertarNodo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_InsertarNodo;
        private System.Windows.Forms.Button btn_EliminarNodo;
        private System.Windows.Forms.Button btn_BuscarNodo;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btn_PreOrden;
        private System.Windows.Forms.TextBox pantalla;
    }
}

