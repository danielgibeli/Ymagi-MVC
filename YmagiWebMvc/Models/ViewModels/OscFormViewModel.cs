using System.Collections.Generic;

namespace YmagiWebMvc.Models.ViewModels
{
    public class OscFormViewModel
    {
        public Membro Membro { get; set; }
        public ICollection<Osc> Oscs { get; set; } 
    }
}
