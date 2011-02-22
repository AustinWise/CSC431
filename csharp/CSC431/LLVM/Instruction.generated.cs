using CSC431.CFG;
using System;
using System.Collections.Generic;

namespace CSC431.LLVM
{

public partial class AddInstruction : LlvmInstruction
{
	public AddInstruction
	(
Register regDest0,Register regSource0,Register regSource1	) : base ("add")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public Register RegDest0{ get; private set; }
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
Register regDest0,Register regSource0,int immed0	) : base ("add")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.Immed0 = immed0;	}

public Register RegDest0{ get; private set; }
public Register RegSource0{ get; private set; }
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
Register regDest0,Register regSource0,Register regSource1	) : base ("sub")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public Register RegDest0{ get; private set; }
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
Register regDest0,Register regSource0,Register regSource1	) : base ("mul")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public Register RegDest0{ get; private set; }
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
Register regDest0,Register regSource0,Register regSource1	) : base ("sdiv")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public Register RegDest0{ get; private set; }
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
Register regDest0,Register regSource0,Register regSource1	) : base ("and")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public Register RegDest0{ get; private set; }
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
Register regDest0,Register regSource0,Register regSource1	) : base ("or")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public Register RegDest0{ get; private set; }
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
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%{1} = {0} i32 %{2}, %{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class XoriInstruction : LlvmInstruction
{
	public XoriInstruction
	(
Register regDest0,Register regSource0,int immed0	) : base ("xor")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.Immed0 = immed0;	}

public Register RegDest0{ get; private set; }
public Register RegSource0{ get; private set; }
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



public partial class LoadiInstruction : LlvmInstruction
{
	public LoadiInstruction
	(
Register regDest0,int immed0	) : base ("loadi")
	{
this.RegDest0 = regDest0;this.Immed0 = immed0;	}

public Register RegDest0{ get; private set; }
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



public partial class BrcondInstruction : LlvmInstruction
{
	public BrcondInstruction
	(
Register regSource0,Label label0,Label label1	) : base ("br")
	{
this.RegSource0 = regSource0;this.Label0 = label0;this.Label1 = label1;	}

public Register RegSource0{ get; private set; }
public Label Label0{ get; private set; }
public Label Label1{ get; private set; }

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



public partial class BrInstruction : LlvmInstruction
{
	public BrInstruction
	(
Label label0	) : base ("br")
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
Register regSource0	) : base ("retvalue")
	{
this.RegSource0 = regSource0;	}

public Register RegSource0{ get; private set; }

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



public partial class CallInstruction : LlvmInstruction
{
	public CallInstruction
	(
	) : base ("call")
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
return string.Format("", Name);
}
}



public partial class AllocaInstruction : LlvmInstruction
{
	public AllocaInstruction
	(
Register regDest0	) : base ("alloca")
	{
this.RegDest0 = regDest0;	}

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
return string.Format("%{1} = {0} i32", Name, RegDest0);
}
}



public partial class LoadInstruction : LlvmInstruction
{
	public LoadInstruction
	(
Register regDest0,Register regSource0	) : base ("load")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;	}

public Register RegDest0{ get; private set; }
public Register RegSource0{ get; private set; }

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



public partial class StoreInstruction : LlvmInstruction
{
	public StoreInstruction
	(
Register regSource0,Register regSource1	) : base ("store")
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
		string ret = string.Empty;
		ToStringCore(ref ret);
		if (string.IsNullOrEmpty(ret))
			throw new NotImplementedException();
		return ret;
	}

	partial void ToStringCore(ref string ret);
}




}
