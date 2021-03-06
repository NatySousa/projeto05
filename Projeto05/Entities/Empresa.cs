using Projeto05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto05.Entities
{
   public class Empresa
    {
        //propriedades -> prop + 2x[tab]
        public Guid IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        //Relacionamento de Associação -> Empresa TEM MUITOS Funcionarios 
        public List<Funcionario> Funcionarios { get; set; }
    }
}

