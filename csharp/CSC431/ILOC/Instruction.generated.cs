﻿namespace CSC431.ILOC
{

class AddInstruction : TripleRegisterInstruction
{
	public AddInstruction
(int rx, int ry, int rd) : base("add", rx, ry, rd)
	{
	}
}



class AddiInstruction : ImmediateDoubleRegisterInstruction
{
	public AddiInstruction
(int rx, int i, int rd) : base("addi", rx, i, rd)
	{
	}
}



class DivInstruction : TripleRegisterInstruction
{
	public DivInstruction
(int rx, int ry, int rd) : base("div", rx, ry, rd)
	{
	}
}



class MultInstruction : TripleRegisterInstruction
{
	public MultInstruction
(int rx, int ry, int rd) : base("mult", rx, ry, rd)
	{
	}
}



class SubInstruction : TripleRegisterInstruction
{
	public SubInstruction
(int rx, int ry, int rd) : base("sub", rx, ry, rd)
	{
	}
}



class RsubiInstruction : ImmediateDoubleRegisterInstruction
{
	public RsubiInstruction
(int rx, int i, int rd) : base("rsubi", rx, i, rd)
	{
	}
}



class AndInstruction : TripleRegisterInstruction
{
	public AndInstruction
(int rx, int ry, int rd) : base("and", rx, ry, rd)
	{
	}
}



class OrInstruction : TripleRegisterInstruction
{
	public OrInstruction
(int rx, int ry, int rd) : base("or", rx, ry, rd)
	{
	}
}



class XoriInstruction : ImmediateDoubleRegisterInstruction
{
	public XoriInstruction
(int rx, int i, int rd) : base("xori", rx, i, rd)
	{
	}
}



class LoadiInstruction : ImmediateSingleRegisterInstruction
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



class ReadInstruction : SingleRegisterInstruction
{
	public ReadInstruction
(int reg) : base("read", reg)
	{
	}
}



class CompInstruction : DoubleRegisterInstruction
{
	public CompInstruction
(int rx, int ry) : base("comp", rx, ry)
	{
		this.CcSet = true;
	}
}



class MovInstruction : DoubleRegisterInstruction
{
	public MovInstruction
(int rx, int ry) : base("mov", rx, ry)
	{
	}
}



class MoveqInstruction : ImmediateSingleRegisterInstruction
{
	public MoveqInstruction
(int reg, int val) : base("moveq", reg, val)
	{
	}
}



class MovgeInstruction : ImmediateSingleRegisterInstruction
{
	public MovgeInstruction
(int reg, int val) : base("movge", reg, val)
	{
	}
}



class MovgtInstruction : ImmediateSingleRegisterInstruction
{
	public MovgtInstruction
(int reg, int val) : base("movgt", reg, val)
	{
	}
}



class MovleInstruction : ImmediateSingleRegisterInstruction
{
	public MovleInstruction
(int reg, int val) : base("movle", reg, val)
	{
	}
}



class MovltInstruction : ImmediateSingleRegisterInstruction
{
	public MovltInstruction
(int reg, int val) : base("movlt", reg, val)
	{
	}
}



class MovneInstruction : ImmediateSingleRegisterInstruction
{
	public MovneInstruction
(int reg, int val) : base("movne", reg, val)
	{
	}
}




}
