using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    public class PageResponse<T>:ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public PageResponse(T value):base(value) 
        {
            
        }
        public PageResponse()
        {
            PageNumber = 1;
            PageSize=10; 
        }
        public PageResponse(int pageNumber, int pageSize)
        {
            PageNumber=pageNumber; PageSize=pageSize;
        }

    }
}
