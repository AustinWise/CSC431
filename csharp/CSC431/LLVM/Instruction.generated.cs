using CSC431.CFG;
using System;
using System.Collections.Generic;

namespace CSC431.LLVM
{

public partial class AddInstruction : LlvmInstruction
{
	public AddInstruction
	(
int regDest0,int regSource0,int regSource1	) : base ("add")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public int RegDest0{ get; private set; }
public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%r{1} = {0} i32 %r{2}, %r{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class AddiInstruction : LlvmInstruction
{
	public AddiInstruction
	(
int regDest0,int regSource0,int immed0	) : base ("add")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.Immed0 = immed0;	}

public int RegDest0{ get; private set; }
public int RegSource0{ get; private set; }
public int Immed0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, 		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%r{1} = {0} i32 %r{2}, {3}", Name, RegDest0, RegSource0, Immed0);
}
}



public partial class SubInstruction : LlvmInstruction
{
	public SubInstruction
	(
int regDest0,int regSource0,int regSource1	) : base ("sub")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public int RegDest0{ get; private set; }
public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%r{1} = {0} i32 %r{2}, %r{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class MulInstruction : LlvmInstruction
{
	public MulInstruction
	(
int regDest0,int regSource0,int regSource1	) : base ("mul")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public int RegDest0{ get; private set; }
public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%r{1} = {0} i32 %r{2}, %r{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class SdivInstruction : LlvmInstruction
{
	public SdivInstruction
	(
int regDest0,int regSource0,int regSource1	) : base ("sdiv")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public int RegDest0{ get; private set; }
public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%r{1} = {0} i32 %r{2}, %r{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class AndInstruction : LlvmInstruction
{
	public AndInstruction
	(
int regDest0,int regSource0,int regSource1	) : base ("and")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public int RegDest0{ get; private set; }
public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%r{1} = {0} i32 %r{2}, %r{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class OrInstruction : LlvmInstruction
{
	public OrInstruction
	(
int regDest0,int regSource0,int regSource1	) : base ("or")
	{
this.RegDest0 = regDest0;this.RegSource0 = regSource0;this.RegSource1 = regSource1;	}

public int RegDest0{ get; private set; }
public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0, 		};
	}
}

public override string ToString()
{
return string.Format("%r{1} = {0} i32 %r{2}, %r{3}", Name, RegDest0, RegSource0, RegSource1);
}
}



public partial class LoadiInstruction : LlvmInstruction
{
	public LoadiInstruction
	(
int regDest0,int immed0	) : base ("loadi")
	{
this.RegDest0 = regDest0;this.Immed0 = immed0;	}

public int RegDest0{ get; private set; }
public int Immed0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
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
int regSource0	) : base ("retvalue")
	{
this.RegSource0 = regSource0;	}

public int RegSource0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
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


public override int[] SourceRegs
{
	get
	{
		return new int[] {
		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
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
