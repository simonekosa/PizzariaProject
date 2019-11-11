﻿using Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Pessoas
{
    public class Usuario
    {
        public Usuario()
        {
            this.TipoUsuario = new TipoUsuario();
        }

        public int Codigo { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Status Status { get; set; }
        public DateTime DtInsercao { get; set; }
        public int CodigoUsrInsercao { get; set; }

    }

}