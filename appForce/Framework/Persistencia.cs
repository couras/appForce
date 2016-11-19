using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;


namespace appForce.Framework
{
    class Persistencia
    {
        public bool Salvar(object obj)
        {
            foreach(PropertyInfo info in obj.GetType().GetProperties())
            {

            }

            return true;
        }
    }
}
