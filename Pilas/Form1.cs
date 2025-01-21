using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas {
    public partial class Form1: Form {
        Pila p = new Pila();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e) {

        }

        private void btn_Apilar_Click(object sender,EventArgs e) {
            p.push(txt_Nombre.Text);
            listBoxNombre.Items.Clear();
            p.mostrar(listBoxNombre);
        }

        private void btn_Desapilar_Click(object sender,EventArgs e) {

            if (p.pop()!=null) {

                MessageBox.Show("Desapilado: "+p.pop());
                listBoxNombre.Items.Clear();
                p.mostrar(listBoxNombre);
            }
        }

        private void btn_Vistazo_Click(object sender,EventArgs e) {
            MessageBox.Show("Cima: "+p.peek());
        }

        private void btn_Elementos_Click(object sender,EventArgs e) {
            MessageBox.Show("# Elementos "+p.contar());
        }

        private void btn_Limpiar_Click(object sender,EventArgs e) {
            p.Clear();
            listBoxNombre.Items.Clear();
        }
    }
}
