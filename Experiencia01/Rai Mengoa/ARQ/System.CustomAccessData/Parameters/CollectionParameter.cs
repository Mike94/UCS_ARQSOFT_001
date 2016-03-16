using System;
using System.Collections;
using System.Collections.Generic;
using System.CustomTypes;
using System.Data;
using System.Data.Common;

namespace System.CustomAccessData
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
        
        public void AddInputParameter(String name, String value)
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

        #endregion

        #region OUT

        public void AddOutputParameter(String name)
        {
            _parameters.Add(new Parameter(name, String.Empty, ParameterDirection.Output));
        }

        //public void AddOutputParameter(String name, CInt32 type)
        //{
        //    _parameters.Add(new Parameter(name, type, ParameterDirection.Output));
        //}

        //public void AddOutputParameter(String name, CDateTime type)
        //{
        //    _parameters.Add(new Parameter(name, type, ParameterDirection.Output));
        //}

        //public void AddOutputParameter(String name, CBoolean type)
        //{
        //    _parameters.Add(new Parameter(name, type, ParameterDirection.Output));
        //}

        #endregion


        #region IN/OUT

        public void AddInputOutputParameter(String name, CString value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, CInt32 value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, CDateTime value)
        {
            _parameters.Add(new Parameter(name, value, ParameterDirection.InputOutput));
        }

        public void AddInputOutputParameter(String name, CBoolean value)
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
