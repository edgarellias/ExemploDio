﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta

    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo() 
        {
            Console.WriteLine($"O seu Saldo é : {saldo}"); 
        }
    }
}
