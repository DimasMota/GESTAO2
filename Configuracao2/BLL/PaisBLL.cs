using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PaisBLL
    {
        public void Inserir(string _nomepais)
        {
           
            
            if (new PaisDAL().NomePais_Existe(_nomepais))
            {
                throw new Exception("Usuário já existente");

            }


            PaisDAL paisDAL = new   PaisDAL();
            paisDAL.Inserir(_nomepais);
        }
        public List<Pais> BuscarTodos_Pais()
        {
            PaisDAL paisDAL = new PaisDAL();
            return paisDAL.BuscarTodos_Pais();
        }

        public List<Pais> BuscarPorNome_Pais(string _nomepais)
        {
            PaisDAL paisDAL = new PaisDAL();
            return paisDAL.BuscarPorNome_Pais(_nomepais);
        }

        public Pais BuscarPorId_Pais(int _idpais)
        {
            PaisDAL paisDAL = new PaisDAL();
            return paisDAL.BuscarPorId_Pais(_idpais);
        }
    }
}
