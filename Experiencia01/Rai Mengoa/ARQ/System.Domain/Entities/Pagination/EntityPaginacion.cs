using System;
using System.Runtime.Serialization;

namespace SGISystem.Domain.Entities
{
    [DataContract]
    public class EntityPaginacion
    {
        private int pageIndex;
        private int rowsPerPage;
        private int rowCount;
        private string sortType;
        private string sortDir;

        [DataMember]
        public int PageIndex
        {
            get { return pageIndex; }
            set { pageIndex = value; }
        }

        [DataMember]
        public int RowsPerPage
        {
            get { return rowsPerPage; }
            set { rowsPerPage = value; }
        }

        [DataMember]
        public int RowCount
        {
            get { return rowCount; }
            set { rowCount = value; }
        }

        [DataMember]
        public string SortType
        {
            get { return sortType; }
            set { sortType = value; }
        }

        [DataMember]
        public string SortDir
        {
            get { return sortDir; }
            set { sortDir = value; }
        }
    }
}
