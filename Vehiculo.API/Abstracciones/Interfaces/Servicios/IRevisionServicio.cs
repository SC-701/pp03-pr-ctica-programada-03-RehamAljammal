using Abstracciones.Modelos.Revision;
using Abstracciones.Modelos.Servicios.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.Servicios
{
    public interface IRevisionServicio
    {
        Task<Revision> Obtener(string placa);
    }
}
