using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.BunisessLogic.Services
{
    public class AccesoService
    {

        public AccesoService()
        {

        }

        #region Pantallas
        public ServicesResult ListaPantallas()
        {
            var result = new ServicesResult();
            try
            {

                return result.Ok();

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        #endregion

        #region Roles

        #endregion

        #region PantallasPorRoles

        #endregion
    }
}
