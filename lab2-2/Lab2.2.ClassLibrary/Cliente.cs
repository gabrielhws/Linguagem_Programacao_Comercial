using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2.ClassLibrary
{
    public class Cliente
    {
        string _nome;
        int _idade;

        public Cliente() { }
        public Cliente(string nome, int idade) {
            _nome = nome;
            _idade = idade;
        }

        public void Salvar(out string message) {
            message = "Cliente salvo com sucesso";
        }
        
    }
}
