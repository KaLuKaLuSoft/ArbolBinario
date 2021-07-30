using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; //librería para dibujar figuras geométricas
using System.Linq;
using System.Text;
using System.Threading; //librería para manejo de hilos
using System.Windows.Forms;


namespace ArbolBinario
{
    class Nodo_Arbol
    {
        public int info; //dato a almacenar en el nodo
        public Nodo_Arbol Izquierdo; //nodo izquierdo del árbol
        public Nodo_Arbol Derecho; //nodo derecho del árbol
        public Nodo_Arbol Padre; //nodo raíz del árbol
        public int altura;
        public int nivel;
        public Rectangle nodo; //para dibujar el nodo del árbol

        //Variable que definen el tamaño de los círculos que representan los nodos del árbol
        private const int Radio = 30;
        //Variable para el manejo de distancia horizontal
        private const int DistanciaH = 80;
        //variable para el manejo de distancia vertical
        private const int DistanciaV = 10;
        //variable para manejar posición eje X 
        private int CoordenadaX;
        //variable para manejar posición eje Y 
        private int CoordenadaY;
        Graphics col;
        private Arbol_Binario arbol; //declarando un objeto de tipo árbol
        public Nodo_Arbol() //constructor por defecto
        {
        }
        //constructor por defecto para el objeto de tipo árbol
        public Arbol_Binario Arbol
        {
            get
            { 
                return arbol; 
            }
            set
            {
                arbol = value;
            }
        }
        //constructor con parámetros
        public Nodo_Arbol(int nueva_info, Nodo_Arbol izquierdo, Nodo_Arbol derecho, Nodo_Arbol padre)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
        }
        //función para insertar un nodo en el árbol
        public Nodo_Arbol Insertar(int x, Nodo_Arbol t, int Level)
        {
            if (t == null)
            {
                t = new Nodo_Arbol(x, null, null, null);
                t.nivel = Level;
            }
            else if (x < t.info) //si el valor a insertar es menor que la raíz
            {
                Level++;
                t.Izquierdo = Insertar(x, t.Izquierdo, Level);
            }
            else if (x > t.info) //si el valor a insertar es mayor que la raíz
            {
                Level++;
                t.Derecho = Insertar(x, t.Derecho, Level);
            }
            else
            {
                MessageBox.Show("Dato existente en el Arbol", "Error de Ingreso");
            }
            return t;
        }
        //Función para eliminar un nodo de un árbol binario
        public void Eliminar(int x, ref Nodo_Arbol t)
        {
            if (t != null) //si la raíz es distinta de null
            {
                if (x < t.info) //si el valor a eliminar es menor que la raíz
                {
                    Eliminar(x, ref t.Izquierdo);
                }
                else
                {
                    if (x > t.info) //si el valor a eliminar es mayor que la raíz
                    {
                        Eliminar(x, ref t.Derecho);
                    }
                    else
                    {
                        Nodo_Arbol NodoEliminar = t; //se ubica el nodo a eliminar                                         
                        if (NodoEliminar.Derecho == null)//se verifica si tiene hijo derecho
                        {
                            t = NodoEliminar.Izquierdo;
                        }
                        else
                        {
                            //se verifica si tiene hijo izq
                            if (NodoEliminar.Izquierdo == null)
                            {
                                t = NodoEliminar.Derecho;
                            }
                            else
                            {
                                if (Alturas(t.Izquierdo) - Alturas(t.Derecho) > 0)
                                //Para verificar que hijo pasa a ser nueva raíz del subárbol
                                {
                                    Nodo_Arbol AuxiliarNodo = null;
                                    Nodo_Arbol Auxiliar = t.Izquierdo;
                                    bool bandera = false;
                                    while (Auxiliar.Derecho != null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.Derecho;
                                        bandera = true;
                                    }
                                    // se crea nodo temporal
                                    t.info = Auxiliar.info;
                                    NodoEliminar = Auxiliar;
                                    if (bandera == true)
                                    {
                                        AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                    }
                                    else
                                    {
                                        t.Izquierdo = Auxiliar.Izquierdo;
                                    }
                                }
                                else
                                {
                                    if (Alturas(t.Derecho) - Alturas(t.Izquierdo) > 0)
                                    {
                                        Nodo_Arbol AuxiliarNodo = null;
                                        Nodo_Arbol Auxiliar = t.Derecho;
                                        bool bandera = false;
                                        while (Auxiliar.Izquierdo != null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.Izquierdo;
                                            bandera = true;
                                        }
                                        t.info = Auxiliar.info;
                                        NodoEliminar = Auxiliar;
                                        if (bandera == true)
                                        {
                                            AuxiliarNodo.Izquierdo = Auxiliar.Derecho;
                                        }
                                        else
                                        {
                                            t.Derecho = Auxiliar.Derecho;
                                        }
                                    }
                                    else
                                    {
                                        if (Alturas(t.Derecho) - Alturas(t.Izquierdo) == 0)
                                        {
                                            Nodo_Arbol AuxiliarNodo = null;
                                            Nodo_Arbol Auxiliar = t.Izquierdo;
                                            bool bandera = false;
                                            while (Auxiliar.Derecho != null)
                                            {
                                                AuxiliarNodo = Auxiliar;
                                                Auxiliar = Auxiliar.Derecho;
                                                bandera = true;
                                            }
                                            t.info = Auxiliar.info;
                                            NodoEliminar = Auxiliar;
                                            if (bandera == true)
                                            {
                                                AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                            }
                                            else
                                            {
                                                t.Izquierdo = Auxiliar.Izquierdo;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo NO existente el Arbol", "Error de eliminación");
            }
        } //Final de la función eliminar
          //Función buscar un nodo
        public void buscar(int x, Nodo_Arbol t)
        {
            if (t != null)
            {
                if (x == t.info)
                {
                    MessageBox.Show("Nodo encontrado!!!");
                    encontrado(t);
                }
                else
                {
                    if (x < t.info) //búsqueda en el subárbol izquierdo
                    {
                        buscar(x, t.Izquierdo);
                    }
                    else
                    {
                        if (x > t.info) //búsqueda en el subárbol derecho
                        {
                            buscar(x, t.Derecho);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo NO encontrado", "Error de búsqueda");
            }
        }
        //Función posición nodo (donde se ha creado dibujo del nodo)
        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2; CoordenadaY = (int)(ymin + Radio / 2);
            //obtiene la posición del sub-árbol izquierdo
            if (Izquierdo != null) 
            { 
                Izquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV); 
            }
            if ((Izquierdo != null) && (Derecho != null)) 
            { 
                xmin += DistanciaH; 
            }
            //si existe nodo derecho y el nodo izquierdo deja un espacio entre ellos
            if (Derecho != null) 
            { 
                Derecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV); 
            }
            if (Izquierdo != null && Derecho != null) 
                CoordenadaX = (int)((Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2); 
            else if 
                (Izquierdo != null) 
            { 
                aux1 = Izquierdo.CoordenadaX; 
                Izquierdo.CoordenadaX = CoordenadaX - 80; 
                CoordenadaX = aux1; 
            }
            else
            {
                if (Derecho != null)
                {
                    aux2 = Derecho.CoordenadaX; 
                    //no hay nodo izquierdo, centrar en nodo derecho
                    Derecho.CoordenadaX = CoordenadaX + 80; 
                    CoordenadaX = aux2; 
                }
                else 
                { 
                    CoordenadaX = (int)(xmin + Radio / 2); xmin += Radio; 
                }
            }
        }
        //Función para dibujar las ramas de los nodos izquierdo y derecho
        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if (Izquierdo != null) 
                // Dibujará rama izquierda
            { 
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX,Izquierdo.CoordenadaY); 
                Izquierdo.DibujarRamas(grafo, Lapiz); 
            }
            if (Derecho != null) 
                // Dibujará rama derecha
            { 
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX,Derecho.CoordenadaY); 
                Derecho.DibujarRamas(grafo, Lapiz); 
            }
        }
        //Función para dibujar el nodo en la posición especificada
        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            col = grafo;
            // Dibuja el contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio); 
            Rectangle prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(encuentro, rect); 
            grafo.FillEllipse(Relleno, rect); 
            grafo.DrawEllipse(Lapiz, rect);
            // Para dibujar el nombre del nodo, es decir el contenido
            StringFormat formato = new StringFormat(); formato.Alignment = StringAlignment.Center; 
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, formato);
            //Dibuja los nodos hijos derecho e izquierdo.
            if (Izquierdo != null) 
            { 
                Izquierdo.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro); 
            }
            if (Derecho != null) 
            { 
                Derecho.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro); 
            }
        }
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz)
        { //Dibuja el contorno del nodo.
          Rectangle rect = new Rectangle (( int)(CoordenadaX - Radio / 2), ( int)(CoordenadaY- Radio / 2), Radio, Radio); 
            Rectangle prueba =new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio/ 2), Radio, Radio); 
            grafo.FillEllipse(Relleno, rect); grafo.DrawEllipse(Lapiz, rect); 
            //Dibuja el nombre
            StringFormat formato = new StringFormat(); 
            formato.Alignment =StringAlignment.Center; 
            formato.LineAlignment = StringAlignment.Center; 
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX,CoordenadaY, formato); 
        }
        //Verificar altura del árbol
        private static int Alturas(Nodo_Arbol t) 
        { 
            return t == null ? -1 : t.altura; 
        }
        public void encontrado(Nodo_Arbol t) 
        {
            Rectangle rec = new Rectangle(t.CoordenadaX, t.CoordenadaY, 40, 40);
        }
    }
}


