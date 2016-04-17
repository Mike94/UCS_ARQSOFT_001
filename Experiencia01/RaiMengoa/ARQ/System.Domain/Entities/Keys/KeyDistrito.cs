using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyDistrito
    {
        private String idDepartamento;
        private String idProvincia;
        private String idDistrito;

        [DataMember]
        public String IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }

        [DataMember]
        public String IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }

        [DataMember]
        public String IdDistrito
        {
            get { return idDistrito; }
            set { idDistrito = value; }
        }

        public KeyDistrito()
        {

        }

        public KeyDistrito(
            String oIdDepartamento,
            String oIdProvincia,
            String oIdDistrito)
        {
            this.idDepartamento = oIdDepartamento;
            this.idProvincia = oIdProvincia;
            this.idDistrito = oIdDistrito;
        }

        public static KeyDistrito Create(IDataReader row)
        {
            return new KeyDistrito(
                DataCreator.CreateString(row, "IdDepartamento"),
                DataCreator.CreateString(row, "IdProvincia"),
                DataCreator.CreateString(row, "IdDistrito")
            );
        }


        public static KeyDistrito Empty
        {
            get
            {
                return new KeyDistrito(
                    Parameters.Vacio,
                    Parameters.Vacio,
                    Parameters.Vacio);
            }
        }
    }
}
