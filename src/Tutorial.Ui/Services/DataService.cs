using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorial.Ui.Services
{
    public class DataService
    {
        public IEnumerable<string> GetRandomData(int count)
        {
            return Enumerable.Range(0, count).Select(x => $"Item - {Guid.NewGuid()}");
        }
    }
}
