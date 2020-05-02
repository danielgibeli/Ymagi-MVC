using System.Collections.Generic;

namespace YmagiWebMvc.Models.ViewModels
{
    public class OscFormViewModel
    {
        public Voluntario Voluntario { get; set; }
        public ICollection<Osc> Oscs { get; set; } 
    }
}
