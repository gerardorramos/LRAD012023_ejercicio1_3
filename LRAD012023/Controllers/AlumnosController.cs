using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using LRAD012023.Models;
using System.Threading.Tasks;

namespace LRAD012023.Controllers
{
    public class AlumnosController
    {
        readonly SQLiteAsyncConnection connection;


        // Constructor de clase
        public AlumnosController(String dbpath)
        {
            // Crear una nueva conexion hacia la base de datos
            connection = new SQLiteAsyncConnection(dbpath);

            // Crear los objetos de base de datos que vamos a ocupar
            connection.CreateTableAsync<personas>().Wait();
        }


        // Creacion de las operaciones CRUD - DB
        // Create 

        public Task<int> SaveAlum(personas alumno)
        {
            if (alumno.id != 0)
                return connection.UpdateAsync(alumno);
            else
                return connection.InsertAsync(alumno);
        }

        // Read
        public Task<List<personas>> GetListAlumn()
        {
            return connection.Table<personas>().ToListAsync();
        }

        public Task<personas> GetAlumno(int pid)
        {
            return connection.Table<personas>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        // Delete
        public Task<int> DeleteAlumn(personas alumno)
        {
            return connection.DeleteAsync(alumno);
        }

    }
}
