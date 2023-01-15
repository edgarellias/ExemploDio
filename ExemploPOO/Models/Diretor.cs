using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome) : base(nome) { }
      
    }
}
