using CSC431.CFG;
using System;
using System.Collections.Generic;

namespace CSC431.Sparc
{

public partial class AddInstruction : SparcInstruction
{
	public AddInstruction
	(
Register regSource0,Register regSource1,Register regDest0	) : base ("add")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public Register RegSource0{ get; private set; }
public Register RegSource1{ get; private set; }
public Register RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0, RegSource1, 		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class AddiInstruction : SparcInstruction
{
	public AddiInstruction
	(
Register regSource0,int immed0,Register regDest0	) : base ("add")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public Register RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public Register RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0, 		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} %{1}, {2}, %{3}", Name, RegSource0, Immed0, RegDest0);
}
}



public partial class SubInstruction : SparcInstruction
{
	public SubInstruction
	(
Register regSource0,Register regSource1,Register regDest0	) : base ("sub")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public Register RegSource0{ get; private set; }
public Register RegSource1{ get; private set; }
public Register RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0, RegSource1, 		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class OrInstruction : SparcInstruction
{
	public OrInstruction
	(
Register regSource0,Register regSource1,Register regDest0	) : base ("or")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public Register RegSource0{ get; private set; }
public Register RegSource1{ get; private set; }
public Register RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0, RegSource1, 		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class OriInstruction : SparcInstruction
{
	public OriInstruction
	(
Register regSource0,int immed0,Register regDest0	) : base ("or")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public Register RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public Register RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0, 		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} %{1}, {2}, %{3}", Name, RegSource0, Immed0, RegDest0);
}
}



public partial class OrlInstruction : SparcInstruction
{
	public OrlInstruction
	(
Register regSource0,int loBits0,Register regDest0	) : base ("or")
	{
this.RegSource0 = regSource0;this.LoBits0 = loBits0;this.RegDest0 = regDest0;	}

public Register RegSource0{ get; private set; }
public int LoBits0{ get; private set; }
public Register RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0, 		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} %{1}, lo({2}), %{3}", Name, RegSource0, LoBits0, RegDest0);
}
}



public partial class CmpInstruction : SparcInstruction
{
	public CmpInstruction
	(
Register regSource0,Register regSource1	) : base ("cmp")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public Register RegSource0{ get; private set; }
public Register RegSource1{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0, RegSource1		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override string ToString()
{
return string.Format("{0} %{1}, %{2}", Name, RegSource0, RegSource1);
}
}



public partial class BeInstruction : SparcInstruction
{
	public BeInstruction
	(
Label label0	) : base ("be")
	{
this.Label0 = label0;	}

public Label Label0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override string ToString()
{
return string.Format("{0} %icc, L{2}", Name, null, Label0);
}
}



public partial class BaInstruction : SparcInstruction
{
	public BaInstruction
	(
Label label0	) : base ("ba")
	{
this.Label0 = label0;	}

public Label Label0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override string ToString()
{
return string.Format("{0} %icc, L{2}", Name, null, Label0);
}
}



public partial class JmpInstruction : SparcInstruction
{
	public JmpInstruction
	(
Label label0	) : base ("jmp")
	{
this.Label0 = label0;	}

public Label Label0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override string ToString()
{
return string.Format("{0} L{1}", Name, Label0);
}
}



public partial class SethiInstruction : SparcInstruction
{
	public SethiInstruction
	(
int hiBits0,Register regDest0	) : base ("sethi")
	{
this.HiBits0 = hiBits0;this.RegDest0 = regDest0;	}

public int HiBits0{ get; private set; }
public Register RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} hi({1}), %{2}", Name, HiBits0, RegDest0);
}
}



public partial class MovaInstruction : SparcInstruction
{
	public MovaInstruction
	(
Register regSource0,Register regDest0	) : base ("mova")
	{
this.RegSource0 = regSource0;this.RegDest0 = regDest0;	}

public Register RegSource0{ get; private set; }
public Register RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0, 		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} %{1}, %{2}", Name, RegSource0, RegDest0);
}
}



public partial class CallInstruction : SparcInstruction
{
	public CallInstruction
	(
Label label0	) : base ("call")
	{
this.Label0 = label0;	}

public Label Label0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override string ToString()
{
return string.Format("{0} L{1}", Name, Label0);
}
}



public partial class RetInstruction : SparcInstruction
{
	public RetInstruction
	(
	) : base ("ret")
	{
	}


public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override string ToString()
{
return string.Format("{0}", Name);
}
}



public partial class RestoreInstruction : SparcInstruction
{
	public RestoreInstruction
	(
	) : base ("restore")
	{
	}


public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override string ToString()
{
return string.Format("{0}", Name);
}
}



public partial class NopInstruction : SparcInstruction
{
	public NopInstruction
	(
	) : base ("nop")
	{
	}


public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
		};
	}
}

public override string ToString()
{
return string.Format("{0}", Name);
}
}



public partial class SaveInstruction : SparcInstruction
{
	public SaveInstruction
	(
Register regSource0,int immed0,Register regDest0	) : base ("save")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public Register RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public Register RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0, 		};
	}
}

public override Register[] DestRegs
{
	get
	{
		return new Register[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} %{1}, {2}, %{3}", Name, RegSource0, Immed0, RegDest0);
}
}




}
