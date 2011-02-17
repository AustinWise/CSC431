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
return string.Format("{0} %{1}, %lo({2}), %{3}", Name, RegSource0, LoBits0, RegDest0);
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

public override string ToString()
{
return string.Format("{0} %icc, .L{2}", Name, null, Label0);
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
return string.Format("{0} %hi({1}), %{2}", Name, HiBits0, RegDest0);
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
return string.Format("{0} .L{1}", Name, Label0);
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




public class SparcRegisterConverter : IInstructionConverter<SparcInstruction, SparcInstruction>
{
	private Dictionary<FunctionBlock<SparcInstruction>, SparcRegister[]> colorMapping;
	private SparcRegister[] map;

	public SparcRegisterConverter(Dictionary<FunctionBlock<SparcInstruction>, SparcRegister[]> colorMapping)
	{
		this.colorMapping = colorMapping;
	}

	public IEnumerable<SparcInstruction> FunctionStart(FunctionBlock<SparcInstruction> block)
	{
		this.map = colorMapping[block];
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
				yield return copy;
				continue;
			}
			if (cur is AddiInstruction)
			{
				var conv = cur as AddiInstruction;
				var copy = new AddiInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is SubInstruction)
			{
				var conv = cur as SubInstruction;
				var copy = new SubInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is OrInstruction)
			{
				var conv = cur as OrInstruction;
				var copy = new OrInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is OriInstruction)
			{
				var conv = cur as OriInstruction;
				var copy = new OriInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is OrlInstruction)
			{
				var conv = cur as OrlInstruction;
				var copy = new OrlInstruction(
map[conv.RegSource0.IntVal], conv.LoBits0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is CmpInstruction)
			{
				var conv = cur as CmpInstruction;
				var copy = new CmpInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is BeInstruction)
			{
				var conv = cur as BeInstruction;
				var copy = new BeInstruction(
conv.Label0				);
				yield return copy;
				continue;
			}
			if (cur is BaInstruction)
			{
				var conv = cur as BaInstruction;
				var copy = new BaInstruction(
conv.Label0				);
				yield return copy;
				continue;
			}
			if (cur is SethiInstruction)
			{
				var conv = cur as SethiInstruction;
				var copy = new SethiInstruction(
conv.HiBits0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is CallInstruction)
			{
				var conv = cur as CallInstruction;
				var copy = new CallInstruction(
conv.Label0				);
				yield return copy;
				continue;
			}
			if (cur is RetInstruction)
			{
				var conv = cur as RetInstruction;
				var copy = new RetInstruction(
				);
				yield return copy;
				continue;
			}
			if (cur is RestoreInstruction)
			{
				var conv = cur as RestoreInstruction;
				var copy = new RestoreInstruction(
				);
				yield return copy;
				continue;
			}
			if (cur is NopInstruction)
			{
				var conv = cur as NopInstruction;
				var copy = new NopInstruction(
				);
				yield return copy;
				continue;
			}
			if (cur is SaveInstruction)
			{
				var conv = cur as SaveInstruction;
				var copy = new SaveInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			throw new NotSupportedException();
		}
	}
}

}
