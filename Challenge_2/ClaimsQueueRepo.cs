using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimsQueueRepo
    {
        Queue<Claims> _claimsQueueRepo = new Queue<Claims>();

        public void ViewItemsInQueue(Claims claim)
        {
            _claimsQueueRepo.Enqueue(claim);
        }

        public Queue<Claims> GetQueue()
        {
            return _claimsQueueRepo;
        }

        public void RemoveItemFromQueue()
        {
            _claimsQueueRepo.Dequeue();
        }

        public void PrintList (Queue<Claims> list)
        {
            foreach (Claims claim in list)
            {
                Console.WriteLine(claim);
            }
        }

        //public Queue<Claims>
    }
}
