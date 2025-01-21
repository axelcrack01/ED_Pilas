namespace Pilas {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Apilar = new System.Windows.Forms.Button();
            this.btn_Desapilar = new System.Windows.Forms.Button();
            this.btn_Vistazo = new System.Windows.Forms.Button();
            this.btn_Elementos = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.listBoxNombre = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILA - STACK (LIFO)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Nombre:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(262, 179);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // btn_Apilar
            // 
            this.btn_Apilar.Location = new System.Drawing.Point(171, 225);
            this.btn_Apilar.Name = "btn_Apilar";
            this.btn_Apilar.Size = new System.Drawing.Size(75, 23);
            this.btn_Apilar.TabIndex = 3;
            this.btn_Apilar.Text = "Apilar";
            this.btn_Apilar.UseVisualStyleBackColor = true;
            // 
            // btn_Desapilar
            // 
            this.btn_Desapilar.Location = new System.Drawing.Point(171, 255);
            this.btn_Desapilar.Name = "btn_Desapilar";
            this.btn_Desapilar.Size = new System.Drawing.Size(75, 23);
            this.btn_Desapilar.TabIndex = 4;
            this.btn_Desapilar.Text = "Desapilar";
            this.btn_Desapilar.UseVisualStyleBackColor = true;
            // 
            // btn_Vistazo
            // 
            this.btn_Vistazo.Location = new System.Drawing.Point(171, 285);
            this.btn_Vistazo.Name = "btn_Vistazo";
            this.btn_Vistazo.Size = new System.Drawing.Size(75, 23);
            this.btn_Vistazo.TabIndex = 5;
            this.btn_Vistazo.Text = "Vistazo";
            this.btn_Vistazo.UseVisualStyleBackColor = true;
            // 
            // btn_Elementos
            // 
            this.btn_Elementos.Location = new System.Drawing.Point(171, 315);
            this.btn_Elementos.Name = "btn_Elementos";
            this.btn_Elementos.Size = new System.Drawing.Size(75, 36);
            this.btn_Elementos.TabIndex = 6;
            this.btn_Elementos.Text = "Cantidad de elementos";
            this.btn_Elementos.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(171, 357);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 7;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // listBoxNombre
            // 
            this.listBoxNombre.FormattingEnabled = true;
            this.listBoxNombre.Location = new System.Drawing.Point(262, 225);
            this.listBoxNombre.Name = "listBoxNombre";
            this.listBoxNombre.Size = new System.Drawing.Size(157, 160);
            this.listBoxNombre.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 638);
            this.Controls.Add(this.listBoxNombre);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Elementos);
            this.Controls.Add(this.btn_Vistazo);
            this.Controls.Add(this.btn_Desapilar);
            this.Controls.Add(this.btn_Apilar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Apilar;
        private System.Windows.Forms.Button btn_Desapilar;
        private System.Windows.Forms.Button btn_Vistazo;
        private System.Windows.Forms.Button btn_Elementos;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.ListBox listBoxNombre;
    }
}

