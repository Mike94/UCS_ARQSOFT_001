using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using System;
using System.Data;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities.Keys
{
    [DataContract]
    public class KeyDepartamento
    {
        private String idDepartamento;

        [DataMember]
        public String IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }

        public KeyDepartamento()
        {

        }

        public KeyDepartamento(String oIDDepartamento)
        {
            this.idDepartamento = oIDDepartamento;
        }

        public static KeyDepartamento Create(IDataReader row)
        {
            return new KeyDepartamento(
                DataCreator.CreateString(row, "IdDepartamento")
            );
        }


        public static KeyDepartamento Empty
        {
            get
            {
                return new KeyDepartamento(
                    Parameters.Vacio);
            }
        }
    }
}
