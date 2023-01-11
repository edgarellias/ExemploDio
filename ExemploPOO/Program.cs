using ExemploPOO.Models;

Pessoa p1 = new Pessoa("Edgar", 27);
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.Sacar(500);
c1.ExibirSaldo();