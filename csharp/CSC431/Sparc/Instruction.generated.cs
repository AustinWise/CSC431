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
int loBits0,Register regDest0	) : base ("or")
	{
this.LoBits0 = loBits0;this.RegDest0 = regDest0;	}

public int LoBits0{ get; private set; }
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
return string.Format("{0} lo(%r{1}), %{2}", Name, LoBits0, RegDest0);
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
return string.Format("{0} hi(%r{1}), %{2}", Name, HiBits0, RegDest0);
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
