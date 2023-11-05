using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UnidadMedida : Entity<int>
    {
        public string UnidadDeMedida { get; set; }
        public string Diminutivo { get; set; }
        public virtual ICollection<Cantidad> Cantidades { get; set; }
    }
}
