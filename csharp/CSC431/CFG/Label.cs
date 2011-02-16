using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC431.CFG
{
    public class Label
    {
        private bool _marked;
        private int _loc;

        public Label()
        {
            this._marked = false;
        }

        public Label(int loc)
        {
            this._loc = loc;
            this._marked = true;
        }

        public void Mark<T>(Node<T> loc) where T : Instruction
        {
            if (_marked)
                throw new Exception("this label has already been marked");
            _loc = loc.Label;
            _marked = true;
        }

        public int Loc
        {
            get
            {
                if (!_marked)
                    throw new Exception("label has not been marked");
                return _loc;
            }
        }

        public override string ToString()
        {
            return Loc.ToString();
        }

        public static implicit operator Label(int loc)
        {
            return new Label(loc);
        }

    }
}
