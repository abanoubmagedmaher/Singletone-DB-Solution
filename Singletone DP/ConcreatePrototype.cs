using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone_DP
{
    public class ConcreatePrototype : ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICloneable Clone()
        {
            return new ConcreatePrototype { Id = this.Id, Name =this.Name};
        }

        public override string ToString()
        {
            return $"Id {Id}, Name : {Name}";
        }
    }
}
