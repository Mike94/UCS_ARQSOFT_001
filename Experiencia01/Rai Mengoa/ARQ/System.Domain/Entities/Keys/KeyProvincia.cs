using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyProvincia
    {
        private String idDepartamento;
        private String idProvincia;

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

        public KeyProvincia()
        {

        }

        public KeyProvincia(
            String oIDDepartamento,
            String oIDProvincia)
        {
            this.idDepartamento = oIDDepartamento;
            this.idProvincia = oIDProvincia;
        }

        public static KeyProvincia Create(IDataReader row)
        {
            return new KeyProvincia(
                DataCreator.CreateString(row, "IdDepartamento"),
                DataCreator.CreateString(row, "IdProvincia")
            );
        }


        public static KeyProvincia Empty
        {
            get
            {
                return new KeyProvincia(
                    Parameters.Vacio,
                    Parameters.Vacio);
            }
        }
    }
}
