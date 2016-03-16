using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityGrupo
    {
        private KeyGrupo key;
        private Int32 idPadre;
        private String descripcionCorta;
        private String descripcionLarga;
        private Int32 estado;

        public EntityGrupo()
        {

        }

        public EntityGrupo(
           Keys.KeyGrupo okey,
           Int32 okeyPadre,
           String oDescripcionCorta,
           String oDescripcionLarga,
           Int32 oEstado)
        {
            this.key = okey;
            this.idPadre = okeyPadre;
            this.descripcionCorta = oDescripcionCorta;
            this.descripcionLarga = oDescripcionLarga;
            this.estado= oEstado;
        }

        [DataMember]
        public KeyGrupo Key
        {
            get { return key; }
            set { key = value; }
        }

        [DataMember]
        public Int32 IDGrupoPadre
        {
            get { return idPadre; }
            set { idPadre = value; }
        }

        [DataMember]
        public String DescripcionCorta
        {
            get { return descripcionCorta; }
            set { descripcionCorta = value; }
        }

        [DataMember]
        public String DescripcionLarga
        {
            get { return descripcionLarga; }
            set { descripcionLarga = value; }
        }

        [DataMember]
        public Int32 Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public static EntityGrupo Create(IDataReader fila)
        {
            return new EntityGrupo(
                Keys.KeyGrupo.Create(fila),
                DataCreator.CreateInt32(fila, "IDGrupoPadre"),
                DataCreator.CreateString(fila, "DescripcionCorta"),
                DataCreator.CreateString(fila, "DescripcionLarga"),
                DataCreator.CreateInt32(fila, "Estado"));
        }
 
        public static EntityGrupo Empty
        {
            get
            {
                return new EntityGrupo(
                Keys.KeyGrupo.Empty,
                Parameters.UnoNegativo,
                Parameters.Vacio,
                Parameters.Vacio,
                Parameters.UnoNegativo);
            }
        }
    }
}
