using CSC431.CFG;
using System;
using System.Collections.Generic;

namespace CSC431.LLVM
{

public partial class AddInstruction : LlvmInstruction
{
	public AddInstruction
	(
VirtualRegister regDest0,VirtualRegister regSource0,VirtualRegister regSource1	) : base ("add")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public VirtualRegister RegDest0{ get; private set; }
public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }

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
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%{1} = {0} i32 %{2}, %{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class AddiInstruction : LlvmInstruction
{
	public AddiInstruction
	(
VirtualRegister regDest0,VirtualRegister regSource0,int immed0	) : base ("add")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.Immed0 = immed0;	}

public VirtualRegister RegDest0{ get; private set; }
public VirtualRegister RegSource0{ get; private set; }
public int Immed0{ get; private set; }

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
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%{1} = {0} i32 %{2}, {3}", Name, RegDest0, RegSource0, Immed0);
}
}



public partial class SubInstruction : LlvmInstruction
{
	public SubInstruction
	(
VirtualRegister regDest0,VirtualRegister regSource0,VirtualRegister regSource1	) : base ("sub")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public VirtualRegister RegDest0{ get; private set; }
public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }

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
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%{1} = {0} i32 %{2}, %{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class MulInstruction : LlvmInstruction
{
	public MulInstruction
	(
VirtualRegister regDest0,VirtualRegister regSource0,VirtualRegister regSource1	) : base ("mul")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public VirtualRegister RegDest0{ get; private set; }
public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }

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
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%{1} = {0} i32 %{2}, %{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class SdivInstruction : LlvmInstruction
{
	public SdivInstruction
	(
VirtualRegister regDest0,VirtualRegister regSource0,VirtualRegister regSource1	) : base ("sdiv")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public VirtualRegister RegDest0{ get; private set; }
public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }

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
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%{1} = {0} i32 %{2}, %{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class AndInstruction : LlvmInstruction
{
	public AndInstruction
	(
VirtualRegister regDest0,VirtualRegister regSource0,VirtualRegister regSource1	) : base ("and")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public VirtualRegister RegDest0{ get; private set; }
public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }

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
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%{1} = {0} i32 %{2}, %{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class OrInstruction : LlvmInstruction
{
	public OrInstruction
	(
VirtualRegister regDest0,VirtualRegister regSource0,VirtualRegister regSource1	) : base ("or")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public VirtualRegister RegDest0{ get; private set; }
public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }

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
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%{1} = {0} i32 %{2}, %{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class LoadiInstruction : LlvmInstruction
{
	public LoadiInstruction
	(
VirtualRegister regDest0,int immed0	) : base ("loadi")
	{
this.RegDest0 = regDest0;this.Immed0 = immed0;	}

public VirtualRegister RegDest0{ get; private set; }
public int Immed0{ get; private set; }

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
RegDest0, 		};
	}
}

	public override string ToString()
	{
		string ret = string.Empty;
		ToStringCore(ref ret);
		if (string.IsNullOrEmpty(ret))
			throw new NotImplementedException();
		return ret;
	}

	partial void ToStringCore(ref string ret);
}



public partial class RetvalueInstruction : LlvmInstruction
{
	public RetvalueInstruction
	(
VirtualRegister regSource0	) : base ("retvalue")
	{
this.RegSource0 = regSource0;	}

public VirtualRegister RegSource0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
RegSource0		};
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
		string ret = string.Empty;
		ToStringCore(ref ret);
		if (string.IsNullOrEmpty(ret))
			throw new NotImplementedException();
		return ret;
	}

	partial void ToStringCore(ref string ret);
}



public partial class RetvoidInstruction : LlvmInstruction
{
	public RetvoidInstruction
	(
	) : base ("retvoid")
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
		string ret = string.Empty;
		ToStringCore(ref ret);
		if (string.IsNullOrEmpty(ret))
			throw new NotImplementedException();
		return ret;
	}

	partial void ToStringCore(ref string ret);
}




}
