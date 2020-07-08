using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class IPagedResponse<T>
    {
        public IPagedResponse(IEnumerable<T> Data)
        {
           this.Data = Data;
        }
        public IEnumerable<T> Data { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }

        public int? TotalCount { get; set; }
    }
}
