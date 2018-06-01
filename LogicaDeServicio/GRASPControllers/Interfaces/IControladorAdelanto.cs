﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace LogicaDeServicio
{
    public interface IControladorAdelanto
    {
        List<Empleado> ListarEmpleados();

        Empleado BuscarEmpleado(int cedula);

        bool RealizarAdelanto(Adelanto pAdelanto);
    }
}
