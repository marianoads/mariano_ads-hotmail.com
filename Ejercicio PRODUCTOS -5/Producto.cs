using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public Producto(string marca,string codigo,float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        
        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Codigo de barra:" + p.codigoDeBarra);
            sb.Append("Marca:" + p.marca);
            sb.Append("Precio:" + p.precio);

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {                  
             return p.codigoDeBarra;                 
        }

        public static bool operator !=(Producto p,string marca)
        {

            return !(p.marca==marca);

        }

        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;
            if(p.GetMarca() == marca)
            {
                retorno = true;
            }

            return retorno;

        }
        
       
         public static bool operator ==(Producto p1,Producto p2)
        {
            if((string)p1 == (string)p2 && p1.GetMarca() == p2.GetMarca())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator !=(Producto p1, Producto p2)
        {

            p2.GetPrecio();
            return true;
        }
        


    }

    
}
