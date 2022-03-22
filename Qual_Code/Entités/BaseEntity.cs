using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_Code.Entités
{
    internal class BaseEntity
    {
        public int Id { get; set; }

        public DateTime LastModified { get; set; } = DateTime.Now;
    }
}
