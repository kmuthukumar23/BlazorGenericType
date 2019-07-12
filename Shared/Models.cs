using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericTypeBlazor.Shared.Models
{
    public class EventArgsData<T>
    {
        public bool IsRendered { get; set; }

        public T Data { get; set; }
    }

    public class EventArguments
    {
        public bool IsRendered { get; set; }

        public object Data { get; set; }
    }
}
