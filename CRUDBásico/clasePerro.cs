using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUDBásico
{
    class clasePerro
    {
        //propiedades

        public int _perroId { get; set; }
        public string _nombre { get; set; }
        public string _raza { get; set; }
        public string _edad { get; set; }
        public string _vaccine { get; set; }
        public string _ownerName { get; set; }
        public string _telephone { get; set; }

        //instancias a la clase Crud
        private Crud crud = new Crud();

        //metodo para retornar los registros de la tabla Book
        public MySqlDataReader getAllPerro()
        {
            string query = "SELECT perroId, nombre, raza, edad, vaccine, ownerName, telephone FROM perro";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditclasePerro(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO perro(nombre, raza, edad, vaccine, ownerName, telephone)" + 
                    "VALUES('"+_nombre + "', '" + _raza + "', '" + _edad + "', '" + _vaccine + "', '" + _ownerName + "', '" + _telephone +"')";
                crud.executeQuery(query); //llamado al metodo executeQuery de la clase Crud
            }
            else if (action == "edit")
            {
                string query = "UPDATE book SET "
                    + "nombre='" + _nombre + "', "
                    + "raza='" + _raza + "', "
                    + "edad='" + _edad + "', "
                    + "vaccine='" + _vaccine + "', "
                    + "ownerName='" + _ownerName + "', "
                    + "telephone='" + _telephone + "', ";
                crud.executeQuery(query);
                return true;
            }

            return false;
        }

        //metodo para eliminar
        public Boolean deletePerro()
        {
            string query = "DELETE FROM perro WHERE perroId='" + _perroId + "'";
            crud.executeQuery(query);   
            return true;
        }
    }
}
