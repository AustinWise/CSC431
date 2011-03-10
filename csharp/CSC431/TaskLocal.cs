using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC431
{
    public sealed class TaskLocal<T>
    {
        private Dictionary<int, T> data = new Dictionary<int, T>();
        private Func<T> defaultValue;

        public TaskLocal()
            : this(default(T))
        {
        }

        public TaskLocal(T defaultValue)
        {
            this.defaultValue = () => defaultValue;
        }

        public TaskLocal(Func<T> defaultValue)
        {
            this.defaultValue = defaultValue;
        }

        private int getCurId()
        {
            var curId = Task.CurrentId;
            if (!curId.HasValue)
                throw new Exception("Steps need to be run on a task.");
            return curId.Value;
        }

        public T Value
        {
            get
            {
                var curId = getCurId();
                lock (this)
                {
                    if (!data.ContainsKey(curId))
                    {
                        //avoid calling this while holding a lock to allow for task local
                        //initalizers to call other task locals
                        var newVal = defaultValue();
                        lock (data)
                        {
                            if (!data.ContainsKey(curId))
                                data[curId] = newVal;
                        }
                    }
                    return data[curId];
                }
            }
            set
            {
                var curId = getCurId();
                lock (this)
                {
                    data[curId] = value;
                }
            }
        }
    }
}
