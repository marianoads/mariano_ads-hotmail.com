using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad,int ubicacion): this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto GetProductos()
        {
            return this.productos[ubicacionEstante];
        }

        public static bool operator +(Estante e,Producto p)
        {
            bool retorno = false;
            int flag = 0;
            for(int i = 0; i < e.productos.Count(); i++)
            {
                if(e.productos[i] == p)
                {
                    flag = 1;
                    break;
                }                
            }
            

            for(int i = 0; i < e.productos.Count(); i++)
            {
                if(flag == 0)
                {
                    e.productos[i] = p;
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static Estante operator -(Estante e, Producto p)
        {            
            
            for (int i = 0; i < e.productos.Count(); i++)
            {
                if (e.productos[i] == p)
                {                    
                    e.productos[i] = null;
                    break;
                    
                }                

            }
            return e;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            foreach (Producto item in e.productos)
            {
                if(item.GetMarca() == p.GetMarca())
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e==p);
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Capacidad de estante :" + e.productos.Count());
            sb.Append("\nUbicacion de estante :" + e.ubicacionEstante);

            foreach (Producto item in e.productos)
            {
                if (!(item is null))
                {
                    sb.AppendLine($"\n**************************");
                    sb.AppendLine($" {item.GetMarca()}");
                    sb.AppendLine($" {item.GetPrecio()}");                    
                    sb.AppendLine($"****************************");
                }
            }


            return sb.ToString();

        }



    }
}
