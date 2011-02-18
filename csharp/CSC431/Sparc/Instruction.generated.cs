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

partial void MyCopyExtraDataToNewInstance(AddInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as AddInstruction);
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

partial void MyCopyExtraDataToNewInstance(AddiInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as AddiInstruction);
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

partial void MyCopyExtraDataToNewInstance(SubInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as SubInstruction);
}

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class SdivxInstruction : SparcInstruction
{
	public SdivxInstruction
	(
Register regSource0,Register regSource1,Register regDest0	) : base ("sdivx")
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

partial void MyCopyExtraDataToNewInstance(SdivxInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as SdivxInstruction);
}

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class MulxInstruction : SparcInstruction
{
	public MulxInstruction
	(
Register regSource0,Register regSource1,Register regDest0	) : base ("mulx")
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

partial void MyCopyExtraDataToNewInstance(MulxInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as MulxInstruction);
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

partial void MyCopyExtraDataToNewInstance(OrInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as OrInstruction);
}

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class AndInstruction : SparcInstruction
{
	public AndInstruction
	(
Register regSource0,Register regSource1,Register regDest0	) : base ("and")
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

partial void MyCopyExtraDataToNewInstance(AndInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as AndInstruction);
}

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



public partial class XoriInstruction : SparcInstruction
{
	public XoriInstruction
	(
Register regSource0,int immed0,Register regDest0	) : base ("xori")
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

partial void MyCopyExtraDataToNewInstance(XoriInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as XoriInstruction);
}

public override string ToString()
{
return string.Format("{0} %{1}, {2}, %{3}", Name, RegSource0, Immed0, RegDest0);
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

partial void MyCopyExtraDataToNewInstance(OriInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as OriInstruction);
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

partial void MyCopyExtraDataToNewInstance(OrlInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as OrlInstruction);
}

public override string ToString()
{
return string.Format("{0} %{1}, %lo({2}), %{3}", Name, RegSource0, IsConstantData ? ".ConstantString" + LoBits0 : LoBits0.ToString(), RegDest0);
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

partial void MyCopyExtraDataToNewInstance(CmpInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as CmpInstruction);
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

partial void MyCopyExtraDataToNewInstance(BeInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as BeInstruction);
}

public override string ToString()
{
return string.Format("{0} %icc, .L{2}", Name, null, Label0);
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

partial void MyCopyExtraDataToNewInstance(BaInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as BaInstruction);
}

public override string ToString()
{
return string.Format("{0} %icc, .L{2}", Name, null, Label0);
}
}



public partial class MoveqInstruction : SparcInstruction
{
	public MoveqInstruction
	(
int immed0,Register regDest0	) : base ("move")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
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

partial void MyCopyExtraDataToNewInstance(MoveqInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as MoveqInstruction);
}

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}
}



public partial class MovneInstruction : SparcInstruction
{
	public MovneInstruction
	(
int immed0,Register regDest0	) : base ("movne")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
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

partial void MyCopyExtraDataToNewInstance(MovneInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as MovneInstruction);
}

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}
}



public partial class MovgeInstruction : SparcInstruction
{
	public MovgeInstruction
	(
int immed0,Register regDest0	) : base ("movge")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
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

partial void MyCopyExtraDataToNewInstance(MovgeInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as MovgeInstruction);
}

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}
}



public partial class MovgInstruction : SparcInstruction
{
	public MovgInstruction
	(
int immed0,Register regDest0	) : base ("movg")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
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

partial void MyCopyExtraDataToNewInstance(MovgInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as MovgInstruction);
}

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}
}



public partial class MovleInstruction : SparcInstruction
{
	public MovleInstruction
	(
int immed0,Register regDest0	) : base ("movle")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
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

partial void MyCopyExtraDataToNewInstance(MovleInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as MovleInstruction);
}

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}
}



public partial class MovlInstruction : SparcInstruction
{
	public MovlInstruction
	(
int immed0,Register regDest0	) : base ("movl")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
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

partial void MyCopyExtraDataToNewInstance(MovlInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as MovlInstruction);
}

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
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

partial void MyCopyExtraDataToNewInstance(SethiInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as SethiInstruction);
}

public override string ToString()
{
return string.Format("{0} %hi({1}), %{2}", Name, IsConstantData ? ".ConstantString" + HiBits0 : HiBits0.ToString(), RegDest0);
}
}



public partial class MovInstruction : SparcInstruction
{
	public MovInstruction
	(
Register regSource0,Register regDest0	) : base ("mov")
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

partial void MyCopyExtraDataToNewInstance(MovInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as MovInstruction);
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

partial void MyCopyExtraDataToNewInstance(CallInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as CallInstruction);
}

public override string ToString()
{
return string.Format("{0} {1}", Name, Str0);
}
}



public partial class StwInstruction : SparcInstruction
{
	public StwInstruction
	(
Register regSource0,Register regSource1,int immed0	) : base ("stw")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.Immed0 = immed0;	}

public Register RegSource0{ get; private set; }
public Register RegSource1{ get; private set; }
public int Immed0{ get; private set; }

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

partial void MyCopyExtraDataToNewInstance(StwInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as StwInstruction);
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



public partial class LdswInstruction : SparcInstruction
{
	public LdswInstruction
	(
Register regSource0,int immed0,Register regDest0	) : base ("ldsw")
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

partial void MyCopyExtraDataToNewInstance(LdswInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as LdswInstruction);
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

partial void MyCopyExtraDataToNewInstance(RetInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as RetInstruction);
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

partial void MyCopyExtraDataToNewInstance(RestoreInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as RestoreInstruction);
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

partial void MyCopyExtraDataToNewInstance(NopInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as NopInstruction);
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

partial void MyCopyExtraDataToNewInstance(SaveInstruction newObj);

public override void CopyExtraDataToNewInstance(SparcInstruction newObj)
{
	MyCopyExtraDataToNewInstance(newObj as SaveInstruction);
}

public override string ToString()
{
return string.Format("{0} %{1}, {2}, %{3}", Name, RegSource0, Immed0, RegDest0);
}
}




public class SparcRegisterConverter : IInstructionConverter<SparcInstruction, SparcInstruction>
{
	private Dictionary<string, SparcRegister[]> colorMapping;
	private SparcRegister[] map;

    public SparcRegisterConverter(Dictionary<string, SparcRegister[]> colorMapping)
	{
		this.colorMapping = colorMapping;
	}

	public IEnumerable<SparcInstruction> FunctionStart(FunctionBlock<SparcInstruction> copy)
	{
		this.map = colorMapping[copy.Name];
		yield break;
	}

	public IEnumerable<SparcInstruction> Convert(InstructionStream<SparcInstruction> s)
	{
		while (s.More)
		{
			var cur = s.Consume();
			if (cur is AddInstruction)
			{
				var conv = cur as AddInstruction;
				var copy = new AddInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is AddiInstruction)
			{
				var conv = cur as AddiInstruction;
				var copy = new AddiInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is SubInstruction)
			{
				var conv = cur as SubInstruction;
				var copy = new SubInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is SdivxInstruction)
			{
				var conv = cur as SdivxInstruction;
				var copy = new SdivxInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is MulxInstruction)
			{
				var conv = cur as MulxInstruction;
				var copy = new MulxInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is OrInstruction)
			{
				var conv = cur as OrInstruction;
				var copy = new OrInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is AndInstruction)
			{
				var conv = cur as AndInstruction;
				var copy = new AndInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is XoriInstruction)
			{
				var conv = cur as XoriInstruction;
				var copy = new XoriInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is OriInstruction)
			{
				var conv = cur as OriInstruction;
				var copy = new OriInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is OrlInstruction)
			{
				var conv = cur as OrlInstruction;
				var copy = new OrlInstruction(
map[conv.RegSource0.IntVal], conv.LoBits0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is CmpInstruction)
			{
				var conv = cur as CmpInstruction;
				var copy = new CmpInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is BeInstruction)
			{
				var conv = cur as BeInstruction;
				var copy = new BeInstruction(
conv.Label0				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is BaInstruction)
			{
				var conv = cur as BaInstruction;
				var copy = new BaInstruction(
conv.Label0				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is MoveqInstruction)
			{
				var conv = cur as MoveqInstruction;
				var copy = new MoveqInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is MovneInstruction)
			{
				var conv = cur as MovneInstruction;
				var copy = new MovneInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is MovgeInstruction)
			{
				var conv = cur as MovgeInstruction;
				var copy = new MovgeInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is MovgInstruction)
			{
				var conv = cur as MovgInstruction;
				var copy = new MovgInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is MovleInstruction)
			{
				var conv = cur as MovleInstruction;
				var copy = new MovleInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is MovlInstruction)
			{
				var conv = cur as MovlInstruction;
				var copy = new MovlInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is SethiInstruction)
			{
				var conv = cur as SethiInstruction;
				var copy = new SethiInstruction(
conv.HiBits0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is MovInstruction)
			{
				var conv = cur as MovInstruction;
				var copy = new MovInstruction(
map[conv.RegSource0.IntVal], map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is CallInstruction)
			{
				var conv = cur as CallInstruction;
				var copy = new CallInstruction(
conv.Str0				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is StwInstruction)
			{
				var conv = cur as StwInstruction;
				var copy = new StwInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], conv.Immed0				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is LdswInstruction)
			{
				var conv = cur as LdswInstruction;
				var copy = new LdswInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is RetInstruction)
			{
				var conv = cur as RetInstruction;
				var copy = new RetInstruction(
				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is RestoreInstruction)
			{
				var conv = cur as RestoreInstruction;
				var copy = new RestoreInstruction(
				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is NopInstruction)
			{
				var conv = cur as NopInstruction;
				var copy = new NopInstruction(
				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			if (cur is SaveInstruction)
			{
				var conv = cur as SaveInstruction;
				var copy = new SaveInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
				conv.CopyExtraDataToNewInstance(copy);
				yield return copy;
				continue;
			}
			throw new NotSupportedException();
		}
	}
}

}
