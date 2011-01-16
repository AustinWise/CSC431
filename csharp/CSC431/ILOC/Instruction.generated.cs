namespace CSC431.ILOC
{

class AddInstruction : ArithmeticInstruction
{
	public AddInstruction
(int rx, int ry, int rd) : base("add", rx, ry, rd)
	{
	}
}



class AddiInstruction : ArithmeticImmediateInstruction
{
	public AddiInstruction
(int rx, int i, int rd) : base("addi", rx, i, rd)
	{
	}
}



class DivInstruction : ArithmeticInstruction
{
	public DivInstruction
(int rx, int ry, int rd) : base("div", rx, ry, rd)
	{
	}
}



class MultInstruction : ArithmeticInstruction
{
	public MultInstruction
(int rx, int ry, int rd) : base("mult", rx, ry, rd)
	{
	}
}



class SubInstruction : ArithmeticInstruction
{
	public SubInstruction
(int rx, int ry, int rd) : base("sub", rx, ry, rd)
	{
	}
}



class RsubiInstruction : ArithmeticImmediateInstruction
{
	public RsubiInstruction
(int rx, int i, int rd) : base("rsubi", rx, i, rd)
	{
	}
}



class AndInstruction : ArithmeticInstruction
{
	public AndInstruction
(int rx, int ry, int rd) : base("and", rx, ry, rd)
	{
	}
}



class OrInstruction : ArithmeticInstruction
{
	public OrInstruction
(int rx, int ry, int rd) : base("or", rx, ry, rd)
	{
	}
}



class XoriInstruction : ArithmeticImmediateInstruction
{
	public XoriInstruction
(int rx, int i, int rd) : base("xori", rx, i, rd)
	{
	}
}



class LoadiInstruction : ImmediateInstruction
{
	public LoadiInstruction
(int reg, int val) : base("loadi", reg, val)
	{
	}
}



class PrintInstruction : SingleRegisterInstruction
{
	public PrintInstruction
(int reg) : base("print", reg)
	{
	}
}




}
