using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentQueue
{
    public class ConcurentQueue<T>
    {
        public ConcurentQueue()
        {
            _data = new Queue<T>();
        }

        public void Push(T item)
        {
            lock (_data)
            {
                _data.Enqueue(item);
            }
        }

        public async Task<T> Pop()
        {
            while (_data.Count == 0)
            {
                await Task.Delay(200);
            }
            lock (_data)
            {
                return _data.Dequeue();
            }
        }

        private Queue<T> _data;
    }
}
