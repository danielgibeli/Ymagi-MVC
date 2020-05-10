using System;
using System.Linq;
using YmagiWebMvc.Models;
using YmagiWebMvc.Models.Enums;

namespace YmagiWebMvc.Data
{
    public class SeendingService
    {
        private YmagiWebMvcContext _context;

        public SeendingService(YmagiWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
           

        }
    }
}