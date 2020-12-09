using System;
using Database;

namespace Bussines
{
    public class Promocion
    {

        static public bool Nueva(PromocionBase acrear, DBContext contexto) {
            // el contexto tien que haber sido inicializado
            if (contexto != null)
            {
                string sql = $"Insert into promocion (nombre) values ('{acrear.nombre}')";

                contexto.ExecuteInsertQuery(sql);

                return true;
            }
            else {
                throw new Exception("El DBcontext debe estar inicializado");
            }
        }

        static public bool Todas(DBContext contexto)
        {
            // el contexto tien que haber sido inicializado
            if (contexto != null)
            {
                string sql = $"select * from promocion";

                contexto.ExecuteInsertQuery(sql);

                return true;
            }
            else
            {
                throw new Exception("El DBcontext debe estar inicializado");
            }
        }
    }

}
