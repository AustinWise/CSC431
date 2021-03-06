﻿using CSC431.CFG;
using System;
using System.Collections.Generic;

namespace CSC431.IL
{

public partial class AddInstruction : MilocInstruction, IArithmeticInstruction
{
	public AddInstruction
	(
VirtualRegister regSource0,VirtualRegister regSource1,VirtualRegister regDest0	) : base ("add")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}

public override int? ConstantValue(int? x, int? y)
{
	if (!(x.HasValue && y.HasValue))
		return null;
	return x + y;
}

public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class AddiInstruction : MilocInstruction
{
	public AddiInstruction
	(
VirtualRegister regSource0,int immed0,VirtualRegister regDest0	) : base ("addi")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, Immed0, RegDest0);
}
}



public partial class DivInstruction : MilocInstruction, IArithmeticInstruction
{
	public DivInstruction
	(
VirtualRegister regSource0,VirtualRegister regSource1,VirtualRegister regDest0	) : base ("div")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}

public override int? ConstantValue(int? x, int? y)
{
	if (!(x.HasValue && y.HasValue))
		return null;
	return x / y;
}

public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class MultInstruction : MilocInstruction, IArithmeticInstruction
{
	public MultInstruction
	(
VirtualRegister regSource0,VirtualRegister regSource1,VirtualRegister regDest0	) : base ("mult")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}

public override int? ConstantValue(int? x, int? y)
{
	if (!(x.HasValue && y.HasValue))
		return null;
	return x * y;
}

public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class SubInstruction : MilocInstruction, IArithmeticInstruction
{
	public SubInstruction
	(
VirtualRegister regSource0,VirtualRegister regSource1,VirtualRegister regDest0	) : base ("sub")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}

public override int? ConstantValue(int? x, int? y)
{
	if (!(x.HasValue && y.HasValue))
		return null;
	return x - y;
}

public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class RsubiInstruction : MilocInstruction
{
	public RsubiInstruction
	(
VirtualRegister regSource0,int immed0,VirtualRegister regDest0	) : base ("rsubi")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, Immed0, RegDest0);
}
}



public partial class AndInstruction : MilocInstruction, IArithmeticInstruction
{
	public AndInstruction
	(
VirtualRegister regSource0,VirtualRegister regSource1,VirtualRegister regDest0	) : base ("and")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class OrInstruction : MilocInstruction, IArithmeticInstruction
{
	public OrInstruction
	(
VirtualRegister regSource0,VirtualRegister regSource1,VirtualRegister regDest0	) : base ("or")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class XoriInstruction : MilocInstruction
{
	public XoriInstruction
	(
VirtualRegister regSource0,int immed0,VirtualRegister regDest0	) : base ("xori")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, Immed0, RegDest0);
}
}



public partial class LoadiInstruction : MilocInstruction
{
	public LoadiInstruction
	(
int immed0,VirtualRegister regDest0	) : base ("loadi")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, Immed0, RegDest0);
}
}



public partial class PrintInstruction : MilocInstruction
{
	public PrintInstruction
	(
VirtualRegister regSource0	) : base ("print")
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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}", Name, RegSource0);
}
}



public partial class PrintlnInstruction : MilocInstruction
{
	public PrintlnInstruction
	(
VirtualRegister regSource0	) : base ("println")
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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}", Name, RegSource0);
}
}



public partial class ReadInstruction : MilocInstruction
{
	public ReadInstruction
	(
VirtualRegister regSource0	) : base ("read")
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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}", Name, RegSource0);
}
}



public partial class CompInstruction : MilocInstruction
{
	public CompInstruction
	(
VirtualRegister regSource0,VirtualRegister regSource1	) : base ("comp")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;		this.CcSet = true;
	}

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
MilocInstruction.IccReg.Value		};
	}
}

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, RegSource0, RegSource1);
}
}



public partial class MovInstruction : MilocInstruction
{
	public MovInstruction
	(
VirtualRegister regSource0,VirtualRegister regDest0	) : base ("mov")
	{
this.RegSource0 = regSource0;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, RegSource0, RegDest0);
}
}



public partial class MoveqInstruction : MilocInstruction
{
	public MoveqInstruction
	(
int immed0,VirtualRegister regDest0	) : base ("moveq")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
MilocInstruction.IccReg.Value		};
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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, Immed0, RegDest0);
}
}



public partial class MovgeInstruction : MilocInstruction
{
	public MovgeInstruction
	(
int immed0,VirtualRegister regDest0	) : base ("movge")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
MilocInstruction.IccReg.Value		};
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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, Immed0, RegDest0);
}
}



public partial class MovgtInstruction : MilocInstruction
{
	public MovgtInstruction
	(
int immed0,VirtualRegister regDest0	) : base ("movgt")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
MilocInstruction.IccReg.Value		};
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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, Immed0, RegDest0);
}
}



public partial class MovleInstruction : MilocInstruction
{
	public MovleInstruction
	(
int immed0,VirtualRegister regDest0	) : base ("movle")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
MilocInstruction.IccReg.Value		};
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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, Immed0, RegDest0);
}
}



public partial class MovltInstruction : MilocInstruction
{
	public MovltInstruction
	(
int immed0,VirtualRegister regDest0	) : base ("movlt")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
MilocInstruction.IccReg.Value		};
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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, Immed0, RegDest0);
}
}



public partial class MovneInstruction : MilocInstruction
{
	public MovneInstruction
	(
int immed0,VirtualRegister regDest0	) : base ("movne")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
MilocInstruction.IccReg.Value		};
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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, Immed0, RegDest0);
}
}



public partial class JumpiInstruction : MilocInstruction
{
	public JumpiInstruction
	(
Label label0	) : base ("jumpi")
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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} L{1}", Name, Label0);
}
}



public partial class CbreqInstruction : MilocInstruction
{
	public CbreqInstruction
	(
Label label0,Label label1	) : base ("cbreq")
	{
this.Label0 = label0;this.Label1 = label1;	}

public Label Label0{ get; private set; }
public Label Label1{ get; private set; }

public override Register[] SourceRegs
{
	get
	{
		return new Register[] {
MilocInstruction.IccReg.Value		};
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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} L{1}, L{2}", Name, Label0, Label1);
}
}



public partial class LoadinargumentInstruction : MilocInstruction
{
	public LoadinargumentInstruction
	(
string str0,int immed0,VirtualRegister regDest0	) : base ("loadinargument")
	{
this.Str0 = str0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, Str0, Immed0, RegDest0);
}
}



public partial class CallInstruction : MilocInstruction
{
	public CallInstruction
	(
string str0	) : base ("call")
	{
this.Str0 = str0;	}

public string Str0{ get; private set; }

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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}", Name, Str0);
}
}



public partial class RetInstruction : MilocInstruction
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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0}", Name);
}
}



public partial class StoreretInstruction : MilocInstruction
{
	public StoreretInstruction
	(
VirtualRegister regSource0	) : base ("storeret")
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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}", Name, RegSource0);
}
}



public partial class StoreoutargumentInstruction : MilocInstruction
{
	public StoreoutargumentInstruction
	(
VirtualRegister regSource0,int immed0	) : base ("storeoutargument")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;	}

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
		};
	}
}

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, RegSource0, Immed0);
}
}



public partial class LoadretInstruction : MilocInstruction
{
	public LoadretInstruction
	(
VirtualRegister regDest0	) : base ("loadret")
	{
this.RegDest0 = regDest0;	}

public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}", Name, RegDest0);
}
}



public partial class StoreaiFieldInstruction : MilocInstruction
{
	public StoreaiFieldInstruction
	(
VirtualRegister regSource0,VirtualRegister regSource1,string str0	) : base ("storeai")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.Str0 = str0;	}

public VirtualRegister RegSource0{ get; private set; }
public VirtualRegister RegSource1{ get; private set; }
public string Str0{ get; private set; }

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
		};
	}
}

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, RegSource1, Str0);
}
}



public partial class StoreaiVarInstruction : MilocInstruction
{
	public StoreaiVarInstruction
	(
VirtualRegister regSource0,string str0	) : base ("storeai")
	{
this.RegSource0 = regSource0;this.Str0 = str0;	}

public VirtualRegister RegSource0{ get; private set; }
public string Str0{ get; private set; }

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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}, rarp, {3}", Name, RegSource0, null, Str0);
}
}



public partial class LoadaiFieldInstruction : MilocInstruction
{
	public LoadaiFieldInstruction
	(
VirtualRegister regSource0,string str0,VirtualRegister regDest0	) : base ("loadai")
	{
this.RegSource0 = regSource0;this.Str0 = str0;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public string Str0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, Str0, RegDest0);
}
}



public partial class LoadaiVarInstruction : MilocInstruction
{
	public LoadaiVarInstruction
	(
string str0,VirtualRegister regDest0	) : base ("loadai")
	{
this.Str0 = str0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} rarp, {2}, {3}", Name, null, Str0, RegDest0);
}
}



public partial class LoadglobalInstruction : MilocInstruction
{
	public LoadglobalInstruction
	(
string str0,VirtualRegister regDest0	) : base ("loadglobal")
	{
this.Str0 = str0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, Str0, RegDest0);
}
}



public partial class StoreglobalInstruction : MilocInstruction
{
	public StoreglobalInstruction
	(
VirtualRegister regSource0,string str0	) : base ("storeglobal")
	{
this.RegSource0 = regSource0;this.Str0 = str0;	}

public VirtualRegister RegSource0{ get; private set; }
public string Str0{ get; private set; }

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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, RegSource0, Str0);
}
}



public partial class ComputeglobaladdressInstruction : MilocInstruction
{
	public ComputeglobaladdressInstruction
	(
string str0,VirtualRegister regDest0	) : base ("computeglobaladdress")
	{
this.Str0 = str0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}", Name, Str0, RegDest0);
}
}



public partial class NewInstruction : MilocInstruction
{
	public NewInstruction
	(
string str0,string[] arr0,VirtualRegister regDest0	) : base ("new")
	{
this.Str0 = str0;this.Arr0 = arr0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public string[] Arr0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, [{2}], {3}", Name, Str0, string.Join(", ", Arr0), RegDest0);
}
}



public partial class DelInstruction : MilocInstruction
{
	public DelInstruction
	(
VirtualRegister regSource0	) : base ("del")
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

public override bool IsCritical
{
    get { return true; }
}


public override string ToString()
{
return string.Format("{0} {1}", Name, RegSource0);
}
}



public partial class SllInstruction : MilocInstruction
{
	public SllInstruction
	(
VirtualRegister regSource0,int immed0,VirtualRegister regDest0	) : base ("sll")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, Immed0, RegDest0);
}
}



public partial class SraInstruction : MilocInstruction
{
	public SraInstruction
	(
VirtualRegister regSource0,int immed0,VirtualRegister regDest0	) : base ("sra")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public VirtualRegister RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public VirtualRegister RegDest0{ get; private set; }

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

public override bool IsCritical
{
    get { return false; }
}


public override string ToString()
{
return string.Format("{0} {1}, {2}, {3}", Name, RegSource0, Immed0, RegDest0);
}
}



public interface IMilocTranslator<T> where T : Instruction
{
	IEnumerable<T> FunctionStart(FunctionBlock<T> copy);
	IEnumerable<T> Add(AddInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Addi(AddiInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Div(DivInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Mult(MultInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Sub(SubInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Rsubi(RsubiInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> And(AndInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Or(OrInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Xori(XoriInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Loadi(LoadiInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Print(PrintInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Println(PrintlnInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Read(ReadInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Comp(CompInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Mov(MovInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Moveq(MoveqInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Movge(MovgeInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Movgt(MovgtInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Movle(MovleInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Movlt(MovltInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Movne(MovneInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Jumpi(JumpiInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Cbreq(CbreqInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Loadinargument(LoadinargumentInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Call(CallInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Ret(RetInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Storeret(StoreretInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Storeoutargument(StoreoutargumentInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Loadret(LoadretInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> StoreaiField(StoreaiFieldInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> StoreaiVar(StoreaiVarInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> LoadaiField(LoadaiFieldInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> LoadaiVar(LoadaiVarInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Loadglobal(LoadglobalInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Storeglobal(StoreglobalInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Computeglobaladdress(ComputeglobaladdressInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> New(NewInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Del(DelInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Sll(SllInstruction s, InstructionStream<MilocInstruction> stream);
	IEnumerable<T> Sra(SraInstruction s, InstructionStream<MilocInstruction> stream);
}

public class MilocIdentityTranslator : IMilocTranslator<MilocInstruction>
{
	private bool copyOnlyMarked = false;

	public MilocIdentityTranslator(bool copyOnlyMarked)
	{
		this.copyOnlyMarked = copyOnlyMarked;
	}

	public IEnumerable<MilocInstruction> FunctionStart(FunctionBlock<MilocInstruction> copy)
	{
		yield break;
	}
	public virtual IEnumerable<MilocInstruction> Add(AddInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new AddInstruction(
s.RegSource0, s.RegSource1, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Addi(AddiInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new AddiInstruction(
s.RegSource0, s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Div(DivInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new DivInstruction(
s.RegSource0, s.RegSource1, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Mult(MultInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new MultInstruction(
s.RegSource0, s.RegSource1, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Sub(SubInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new SubInstruction(
s.RegSource0, s.RegSource1, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Rsubi(RsubiInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new RsubiInstruction(
s.RegSource0, s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> And(AndInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new AndInstruction(
s.RegSource0, s.RegSource1, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Or(OrInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new OrInstruction(
s.RegSource0, s.RegSource1, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Xori(XoriInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new XoriInstruction(
s.RegSource0, s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Loadi(LoadiInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new LoadiInstruction(
s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Print(PrintInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new PrintInstruction(
s.RegSource0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Println(PrintlnInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new PrintlnInstruction(
s.RegSource0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Read(ReadInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new ReadInstruction(
s.RegSource0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Comp(CompInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new CompInstruction(
s.RegSource0, s.RegSource1			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Mov(MovInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new MovInstruction(
s.RegSource0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Moveq(MoveqInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new MoveqInstruction(
s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Movge(MovgeInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new MovgeInstruction(
s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Movgt(MovgtInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new MovgtInstruction(
s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Movle(MovleInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new MovleInstruction(
s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Movlt(MovltInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new MovltInstruction(
s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Movne(MovneInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new MovneInstruction(
s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Jumpi(JumpiInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new JumpiInstruction(
s.Label0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Cbreq(CbreqInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new CbreqInstruction(
s.Label0, s.Label1			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Loadinargument(LoadinargumentInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new LoadinargumentInstruction(
s.Str0, s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Call(CallInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new CallInstruction(
s.Str0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Ret(RetInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new RetInstruction(
			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Storeret(StoreretInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new StoreretInstruction(
s.RegSource0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Storeoutargument(StoreoutargumentInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new StoreoutargumentInstruction(
s.RegSource0, s.Immed0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Loadret(LoadretInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new LoadretInstruction(
s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> StoreaiField(StoreaiFieldInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new StoreaiFieldInstruction(
s.RegSource0, s.RegSource1, s.Str0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> StoreaiVar(StoreaiVarInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new StoreaiVarInstruction(
s.RegSource0, s.Str0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> LoadaiField(LoadaiFieldInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new LoadaiFieldInstruction(
s.RegSource0, s.Str0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> LoadaiVar(LoadaiVarInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new LoadaiVarInstruction(
s.Str0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Loadglobal(LoadglobalInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new LoadglobalInstruction(
s.Str0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Storeglobal(StoreglobalInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new StoreglobalInstruction(
s.RegSource0, s.Str0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Computeglobaladdress(ComputeglobaladdressInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new ComputeglobaladdressInstruction(
s.Str0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> New(NewInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new NewInstruction(
s.Str0, s.Arr0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Del(DelInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new DelInstruction(
s.RegSource0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Sll(SllInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new SllInstruction(
s.RegSource0, s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
	public virtual IEnumerable<MilocInstruction> Sra(SraInstruction s, InstructionStream<MilocInstruction> stream)
	{
		if (!copyOnlyMarked || s.Mark)
		{

			var copy = new SraInstruction(
s.RegSource0, s.Immed0, s.RegDest0			);
			s.CopyExtraData(copy);
			yield return copy;
		}
	}
}

public class MilocConverter<T> : IInstructionConverter<MilocInstruction, T>
	where T : Instruction
{
	private IMilocTranslator<T> translator;
	public MilocConverter(IMilocTranslator<T> translator)
	{
		this.translator = translator;
	}

	public IEnumerable<T> FunctionStart(FunctionBlock<T> copy)
	{
		return translator.FunctionStart(copy);
	}

	public IEnumerable<T> Convert(InstructionStream<MilocInstruction> s)
	{
		while (s.More)
		{
			var cur = s.Consume();
			if (cur is AddInstruction)
			{
				var conv = cur as AddInstruction;
				foreach (var newInstr in translator.Add(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is AddiInstruction)
			{
				var conv = cur as AddiInstruction;
				foreach (var newInstr in translator.Addi(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is DivInstruction)
			{
				var conv = cur as DivInstruction;
				foreach (var newInstr in translator.Div(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is MultInstruction)
			{
				var conv = cur as MultInstruction;
				foreach (var newInstr in translator.Mult(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is SubInstruction)
			{
				var conv = cur as SubInstruction;
				foreach (var newInstr in translator.Sub(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is RsubiInstruction)
			{
				var conv = cur as RsubiInstruction;
				foreach (var newInstr in translator.Rsubi(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is AndInstruction)
			{
				var conv = cur as AndInstruction;
				foreach (var newInstr in translator.And(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is OrInstruction)
			{
				var conv = cur as OrInstruction;
				foreach (var newInstr in translator.Or(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is XoriInstruction)
			{
				var conv = cur as XoriInstruction;
				foreach (var newInstr in translator.Xori(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is LoadiInstruction)
			{
				var conv = cur as LoadiInstruction;
				foreach (var newInstr in translator.Loadi(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is PrintInstruction)
			{
				var conv = cur as PrintInstruction;
				foreach (var newInstr in translator.Print(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is PrintlnInstruction)
			{
				var conv = cur as PrintlnInstruction;
				foreach (var newInstr in translator.Println(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is ReadInstruction)
			{
				var conv = cur as ReadInstruction;
				foreach (var newInstr in translator.Read(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is CompInstruction)
			{
				var conv = cur as CompInstruction;
				foreach (var newInstr in translator.Comp(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is MovInstruction)
			{
				var conv = cur as MovInstruction;
				foreach (var newInstr in translator.Mov(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is MoveqInstruction)
			{
				var conv = cur as MoveqInstruction;
				foreach (var newInstr in translator.Moveq(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is MovgeInstruction)
			{
				var conv = cur as MovgeInstruction;
				foreach (var newInstr in translator.Movge(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is MovgtInstruction)
			{
				var conv = cur as MovgtInstruction;
				foreach (var newInstr in translator.Movgt(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is MovleInstruction)
			{
				var conv = cur as MovleInstruction;
				foreach (var newInstr in translator.Movle(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is MovltInstruction)
			{
				var conv = cur as MovltInstruction;
				foreach (var newInstr in translator.Movlt(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is MovneInstruction)
			{
				var conv = cur as MovneInstruction;
				foreach (var newInstr in translator.Movne(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is JumpiInstruction)
			{
				var conv = cur as JumpiInstruction;
				foreach (var newInstr in translator.Jumpi(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is CbreqInstruction)
			{
				var conv = cur as CbreqInstruction;
				foreach (var newInstr in translator.Cbreq(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is LoadinargumentInstruction)
			{
				var conv = cur as LoadinargumentInstruction;
				foreach (var newInstr in translator.Loadinargument(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is CallInstruction)
			{
				var conv = cur as CallInstruction;
				foreach (var newInstr in translator.Call(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is RetInstruction)
			{
				var conv = cur as RetInstruction;
				foreach (var newInstr in translator.Ret(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is StoreretInstruction)
			{
				var conv = cur as StoreretInstruction;
				foreach (var newInstr in translator.Storeret(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is StoreoutargumentInstruction)
			{
				var conv = cur as StoreoutargumentInstruction;
				foreach (var newInstr in translator.Storeoutargument(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is LoadretInstruction)
			{
				var conv = cur as LoadretInstruction;
				foreach (var newInstr in translator.Loadret(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is StoreaiFieldInstruction)
			{
				var conv = cur as StoreaiFieldInstruction;
				foreach (var newInstr in translator.StoreaiField(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is StoreaiVarInstruction)
			{
				var conv = cur as StoreaiVarInstruction;
				foreach (var newInstr in translator.StoreaiVar(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is LoadaiFieldInstruction)
			{
				var conv = cur as LoadaiFieldInstruction;
				foreach (var newInstr in translator.LoadaiField(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is LoadaiVarInstruction)
			{
				var conv = cur as LoadaiVarInstruction;
				foreach (var newInstr in translator.LoadaiVar(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is LoadglobalInstruction)
			{
				var conv = cur as LoadglobalInstruction;
				foreach (var newInstr in translator.Loadglobal(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is StoreglobalInstruction)
			{
				var conv = cur as StoreglobalInstruction;
				foreach (var newInstr in translator.Storeglobal(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is ComputeglobaladdressInstruction)
			{
				var conv = cur as ComputeglobaladdressInstruction;
				foreach (var newInstr in translator.Computeglobaladdress(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is NewInstruction)
			{
				var conv = cur as NewInstruction;
				foreach (var newInstr in translator.New(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is DelInstruction)
			{
				var conv = cur as DelInstruction;
				foreach (var newInstr in translator.Del(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is SllInstruction)
			{
				var conv = cur as SllInstruction;
				foreach (var newInstr in translator.Sll(conv, s))
					yield return newInstr;
				continue;
			}
			if (cur is SraInstruction)
			{
				var conv = cur as SraInstruction;
				foreach (var newInstr in translator.Sra(conv, s))
					yield return newInstr;
				continue;
			}
			throw new NotSupportedException();
		}
	}
}

}
