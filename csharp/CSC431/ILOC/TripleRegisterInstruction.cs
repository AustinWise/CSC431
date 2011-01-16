namespace CSC431.ILOC
{
    public class TripleRegisterInstruction : Instruction
    {
        public TripleRegisterInstruction(string name, int rx, int ry, int rd)
            : base(name)
        {
            this.Rx = rx;
            this.Ry = ry;
            this.Rd = rd;
        }

        public int Rx { get; private set; }
        public int Ry { get; private set; }
        public int Rd { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} r{1}, r{2}, r{3}", Name, Rx, Ry, Rd);
        }
    }
}
