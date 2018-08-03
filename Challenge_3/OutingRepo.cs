using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepo
    {
        private List<Outing> _outingRepo = new List<Outing>();

        public void AddToList(Outing outing)
        {
            _outingRepo.Add(outing);
        }

        public List<Outing> GetList()
        {
            return _outingRepo;
        }









    }
}
