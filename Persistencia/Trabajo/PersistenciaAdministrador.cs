﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    class PersistenciaAdministrador:IPersistenciaAdministrador
    {
        public bool ExisteAdmin(int ci)
        {
            return true;
        }

        public bool AltaAdministrador(EntidadesCompartidas.Administrador administrador)
        {
            return true;
        }

        public bool ComprobarUser(string user)
        {
            return true;
        }

        public List<EntidadesCompartidas.Administrador> ListarAdministradores()
        {
            return new List<EntidadesCompartidas.Administrador>();
        }

        public bool ModificarAdmin(EntidadesCompartidas.Administrador admin)
        {
            return true;
        }

        public EntidadesCompartidas.Administrador Login(string user, string contraseña)
        {
            Administrador administradorResultado = new Administrador();

            EnviosContext dbConexion = new EnviosContext();
            try
            {

                var adminEncontrado = from admin in dbConexion.Administradores
                                       where admin.Empleados.Usuarios.NombreUsuario == user && admin.Empleados.Usuarios.Contraseña == contraseña
                                       select admin;

                foreach (Administradores a in adminEncontrado)
                {
                    administradorResultado.Contraseña = a.Empleados.Usuarios.Contraseña;
                    administradorResultado.Direccion = a.Empleados.Usuarios.Direccion;
                    administradorResultado.Email = a.Empleados.Usuarios.Email;
                    administradorResultado.Id = a.Empleados.Usuarios.Id;
                    administradorResultado.Ci = a.CiEmpleado;
                    administradorResultado.Nombre = a.Empleados.Usuarios.Nombre;
                    administradorResultado.NombreUsuario = a.Empleados.Usuarios.NombreUsuario;
                    administradorResultado.Sueldo = a.Empleados.Sueldo;
                    administradorResultado.Telefono = a.Empleados.Usuarios.Telefono;
                    administradorResultado.Tipo = a.Tipo;
                }

                return administradorResultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar loguear el Cadete" + ex.Message);
            }
        }

        public bool BajaAdministrador(int ci)
        {
            return true;
        }

        public EntidadesCompartidas.Administrador BusxarAdministrador(int ci)
        {
            return new EntidadesCompartidas.Administrador();
        }
    }
}
