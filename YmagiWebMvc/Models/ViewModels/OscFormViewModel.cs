﻿using System.Collections.Generic;

namespace YmagiWebMvc.Models.ViewModels
{
    public class OscFormViewModel
    {
        public Membro Membro { get; set; }
        public Usuario Usuario { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Osc Osc { get; set; }

        public ICollection<Osc> Oscs { get; set; }
        public ICollection<Membro> Membros { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Entrega> Entregas { get; set; }
        public ICollection<Recebimento> Recebimentos { get; set; }
    }
}
