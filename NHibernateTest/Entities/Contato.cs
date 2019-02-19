using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTest.Entities
{
    public class Contato
    {
        public virtual int ID { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Telefone { get; set; }

    }
}
