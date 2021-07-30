using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Dato = 0; 
        int cont = 0; 
        Arbol_Binario mi_Arbol = new Arbol_Binario(null); //Creación del objeto Árbol
        
        Graphics g; //Definición del objeto gráfico
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
        }
        /*Evento que permitirá insertar un nodo al árbol (código de botón “Insertar Nodo” del 
        * formulario mostrado en la figura) */
        private void btn_InsertarNodo_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "") 
            { 
                MessageBox.Show("Debe Ingresar un Valor"); 
            } 
            else 
            { 
                Dato = int.Parse(txtDato.Text); 
                if (Dato <= 0 || Dato >= 100) 
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso"); 
                else 
                { 
                    mi_Arbol.Insertar(Dato); txtDato.Clear(); 
                    txtDato.Focus(); 
                    cont++; 
                    Refresh(); 
                    Refresh(); 
                } 
            }
        }
        /*Evento que permitirá eliminar un nodo del árbol (código de botón “Eliminar Nodo” del formulario 
         * mostrado en la figura) */
        private void btn_EliminarNodo_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text == "") 
            { 
                MessageBox.Show("Debe ingresar el valor a eliminar"); 
            } 
            else 
            { 
                Dato = Convert.ToInt32(txtEliminar.Text); 
                if (Dato <= 0 || Dato >= 100) 
                { 
                    MessageBox.Show("Sólo se adminten valores entre 1 y 99", "Error de Ingreso"); 
                } 
                else 
                { 
                    mi_Arbol.Eliminar(Dato); 
                    txtEliminar.Clear(); 
                    txtEliminar.Focus(); 
                    cont--; 
                    Refresh(); 
                    Refresh(); 
                } 
            }
        }

        private void btn_BuscarNodo_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor a buscar");
            }
            else
            {
                Dato = Convert.ToInt32(txtBuscar.Text);
                if (Dato <= 0 || Dato >= 100) 
                { 
                    MessageBox.Show("Sólo se admiten valores entre 1 y 99", "Error de Ingreso"); 
                }
                else 
                { 
                    mi_Arbol.Buscar(Dato); 
                    txtBuscar.Clear(); 
                    txtBuscar.Focus(); 
                    Refresh(); 
                    Refresh(); 
                }
            }
        }
        private void btn_PreOrden_Click(object sender, EventArgs e)
        {
            pantalla.Text = mi_Arbol.preorden();
        }
    }
}
