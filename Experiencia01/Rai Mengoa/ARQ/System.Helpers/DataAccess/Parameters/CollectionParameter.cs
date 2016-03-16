using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace SGISystem.Helpers.DataAccess
{
    public class CollectionParameter
    {
        public CollectionParameter()
        {
            _parameters = new List<Parameter>();
        }

        private IList<Parameter> _parameters;

        public Int32 Count
        {
            get { return _parameters.Count; }
        }

        #region IN

        public void AddInputParameter(String name, Object oValue, DbType oDbType)
        {
            _parameters.Add(new Parameter(name, oValue, oDbType, ParameterDirection.Input));
        }
        
        public void AddInputParameter(String name, String value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.Input));
        }

        public void AddInputParameter(String name, Char value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.Input));
        }

        public void AddInputParameter(String name, Int32 value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.Input));
        }

        public void AddInputParameter(String name, DateTime value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.Input));
        }

        public void AddInputParameter(String name, Boolean value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.Input));
        }

        public void AddInputParameter(String name, Decimal value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.Input));
        }

        public void AddInputParameter(String name, Byte value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.Input));
        }


        #endregion

        #region OUT

        public void AddOutputParameter(String name)
        {
            _parameters.Add(new Parameter(name, String.Empty, ParameterDirection.Output));
        }

        #endregion


        #region IN/OUT

        public void AddInputOutputParameter(String name, Object value, DbType oDbType)
        {
            _parameters.Add(new Parameter(name, value, oDbType, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, String value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, Char value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, Int32 value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, DateTime value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, Boolean value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, Decimal value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, Byte value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }


        #endregion

        public Parameter GetParameter(String name)
        {
            foreach (Parameter item in _parameters)
	        {
                if (item.ParameterName == name)
                {
                    return item;
                }
	        }
            return null;
        }

        public IList<Parameter> Values
        {
            get { return _parameters; }
        }

    }
}
