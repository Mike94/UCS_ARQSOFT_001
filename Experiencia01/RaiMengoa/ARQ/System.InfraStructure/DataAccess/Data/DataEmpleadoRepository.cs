using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using SGISystem.Helpers.DataAccess;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Collections.Generic;
using System.Data;

namespace SGISystem.InfraStructure.DataAccess.Data
{
    public class DataEmpleadoRepository : BaseDataRepository<EntityEmpleado>
    {
        public DataEmpleadoRepository(EntityEmpleado entity, String nameSP)
            : base(nameSP)
        {
            this.Entity = entity;
        }

        #region Sobreescritos para el data access

        public override EntityEmpleado Create(IDataReader datareader)
        {
            return EntityEmpleado.Create(datareader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IDEmpleado", Entity.Key.IDEmpleado);
            this.CollectionParams.AddInputParameter("Nombres", Entity.Nombres);
        }

           
        protected override void OnInsert()
        {
            this.CollectionParams.AddInputParameter("CodTienda", Entity.CodTienda);
            this.CollectionParams.AddInputParameter("Nombres", Entity.Nombres);
            this.CollectionParams.AddInputParameter("Apellidos", Entity.Apellidos);
            this.CollectionParams.AddInputParameter("FechaNacimiento", Entity.FechaNacimiento);
            this.CollectionParams.AddInputParameter("IdCargo", Entity.IdCargo);
            this.CollectionParams.AddInputParameter("DNI", Entity.DNI);
            this.CollectionParams.AddInputParameter("Sexo", Entity.Sexo);
            this.CollectionParams.AddInputParameter("EstadoCivil", Entity.EstadoCivil);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);

            this.CollectionParams.AddOutputParameter("IDEmpleado");
        }


        protected override void OnUpdate()
        {
            this.CollectionParams.AddInputParameter("IDEmpleado", Entity.Key.IDEmpleado);

            this.CollectionParams.AddInputParameter("CodTienda", Entity.CodTienda);
            this.CollectionParams.AddInputParameter("Nombres", Entity.Nombres);
            this.CollectionParams.AddInputParameter("Apellidos", Entity.Apellidos);
            this.CollectionParams.AddInputParameter("FechaNacimiento", Entity.FechaNacimiento);
            this.CollectionParams.AddInputParameter("IdCargo", Entity.IdCargo);
            this.CollectionParams.AddInputParameter("DNI", Entity.DNI);
            this.CollectionParams.AddInputParameter("Sexo", Entity.Sexo);
            this.CollectionParams.AddInputParameter("EstadoCivil", Entity.EstadoCivil);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnDelete()
        {
            this.CollectionParams.AddInputParameter("IDEmpleado", Entity.Key.IDEmpleado);
        }

        #endregion

        public EntityEmpleado SelectByKey(KeyEmpleado oKeyEmpleado, CTransaction oCTransaction)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("IDEmpleado", oKeyEmpleado.IDEmpleado);

            using (IDataReader reader = run.ExecuteReader(oCTransaction, Procedimientos.Empleado_Select))
            {
                if (reader.Read())
                {
                    return EntityEmpleado.Create(reader);
                }
            }

            return EntityEmpleado.Empty;
        }

        public IList<EntityEmpleadoPaginacion> SelectPagging(ref EntityEmpleadoPaginacion oEntityEmployeePaginacion)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("Nombres", oEntityEmployeePaginacion.Nombres);
            run.CollectionParams.AddInputParameter("Estado", oEntityEmployeePaginacion.Estado);
            run.CollectionParams.AddInputParameter("PageIndex", oEntityEmployeePaginacion.EntityPaginacion.PageIndex);
            run.CollectionParams.AddInputParameter("PageSize", oEntityEmployeePaginacion.EntityPaginacion.RowsPerPage);

            run.CollectionParams.AddOutputParameter("TotalRows");


            IList<EntityEmpleadoPaginacion> oListEmployee = new List<EntityEmpleadoPaginacion>();
            using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.Empleado_Select_Paginado))
            {
                
                while (reader.Read())
                {
                    oListEmployee.Add(EntityEmpleadoPaginacion.CreatePag(reader));
                }
            }
            run.AssignReturnParameters();

            oEntityEmployeePaginacion.EntityPaginacion.RowCount = DataCreator.CreateInt32(run.CollectionParams.GetParameter("TotalRows").Value);

            return oListEmployee;
        }
    }
}
