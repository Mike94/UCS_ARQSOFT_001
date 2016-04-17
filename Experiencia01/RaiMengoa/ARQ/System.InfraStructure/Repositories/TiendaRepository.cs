using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Repository;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.InfraStructure.Repositories
{
    public class TiendaRepository : ITiendaRepository
    {
        public EntityTienda SelectByKey(KeyTienda okey, CTransaction oCTransaction)
        {
            try
            {
                DataTiendaRepository data = new DataTiendaRepository(EntityTienda.Empty, "tienda");
                return data.SelectByKey(okey, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityTienda> Select(EntityTienda oEntityTienda, CTransaction oCTransaction)
        {
            try
            {
                DataTiendaRepository data = new DataTiendaRepository(oEntityTienda, "tienda");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityTiendaPaginacion> SelectPagging(ref EntityTiendaPaginacion oEntityTiendaPaginacion)
        {
            try
            {
                DataTiendaRepository data = new DataTiendaRepository(EntityTiendaPaginacion.Empty, "tienda");
                return data.SelectPagging(ref oEntityTiendaPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTienda Insert(EntityTienda oEntityTienda, CTransaction oCTransaction)
        {
            try
            {
                DataTiendaRepository data = new DataTiendaRepository(oEntityTienda, "tienda");
                return data.Insert(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTienda Update(EntityTienda oEntityTienda, CTransaction oCTransaction)
        {
            try
            {
                DataTiendaRepository data = new DataTiendaRepository(oEntityTienda, "tienda");
                return data.Update(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTienda Delete(EntityTienda oEntityTienda, CTransaction oCTransaction)
        {
            try
            {
                DataTiendaRepository data = new DataTiendaRepository(oEntityTienda, "tienda");
                return data.Delete(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
