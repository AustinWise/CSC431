namespace CSC431.ILOC
{
    public class ImmediateDoubleRegisterInstruction : Instruction
    {
        public ImmediateDoubleRegisterInstruction(string name, int rx, int i, int rd)
            : base(name)
        {
            this.Rx = rx;
            this.I = i;
            this.Rd = rd;
        }

        public int Rx { get; private set; }
        public int I { get; private set; }
        public int Rd { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} r{1}, {2}, r{3}", Name, Rx, I, Rd);
        }
    }
}
