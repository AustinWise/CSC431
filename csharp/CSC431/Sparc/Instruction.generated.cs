using CSC431.CFG;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }
				if (regToSpill[this.RegSource1.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource1.IntVal), this.RegSource1); }

				var copy = new AddInstruction(
this.RegSource0, this.RegSource1, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END AddInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }

				var copy = new AddiInstruction(
this.RegSource0, this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END AddiInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }
				if (regToSpill[this.RegSource1.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource1.IntVal), this.RegSource1); }

				var copy = new SubInstruction(
this.RegSource0, this.RegSource1, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END SubInstruction



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

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }
				if (regToSpill[this.RegSource1.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource1.IntVal), this.RegSource1); }

				var copy = new SdivxInstruction(
this.RegSource0, this.RegSource1, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END SdivxInstruction



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

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }
				if (regToSpill[this.RegSource1.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource1.IntVal), this.RegSource1); }

				var copy = new MulxInstruction(
this.RegSource0, this.RegSource1, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END MulxInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }
				if (regToSpill[this.RegSource1.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource1.IntVal), this.RegSource1); }

				var copy = new OrInstruction(
this.RegSource0, this.RegSource1, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END OrInstruction



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

public override string ToString()
{
return string.Format("{0} %{1}, %{2}, %{3}", Name, RegSource0, RegSource1, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }
				if (regToSpill[this.RegSource1.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource1.IntVal), this.RegSource1); }

				var copy = new AndInstruction(
this.RegSource0, this.RegSource1, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END AndInstruction



public partial class XorInstruction : SparcInstruction
{
	public XorInstruction
	(
Register regSource0,int immed0,Register regDest0	) : base ("xor")
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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }

				var copy = new XorInstruction(
this.RegSource0, this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END XorInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }

				var copy = new OriInstruction(
this.RegSource0, this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END OriInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }

				var copy = new OrlInstruction(
this.RegSource0, this.LoBits0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END OrlInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }
				if (regToSpill[this.RegSource1.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource1.IntVal), this.RegSource1); }

				var copy = new CmpInstruction(
this.RegSource0, this.RegSource1				);
				yield return copy;
	}

} //END CmpInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new BeInstruction(
this.Label0				);
				yield return copy;
	}

} //END BeInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new BaInstruction(
this.Label0				);
				yield return copy;
	}

} //END BaInstruction



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

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new MoveqInstruction(
this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END MoveqInstruction



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

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new MovneInstruction(
this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END MovneInstruction



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

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new MovgeInstruction(
this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END MovgeInstruction



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

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new MovgInstruction(
this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END MovgInstruction



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

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new MovleInstruction(
this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END MovleInstruction



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

public override string ToString()
{
return string.Format("{0} %icc, {2}, %{3}", Name, null, Immed0, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new MovlInstruction(
this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END MovlInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new SethiInstruction(
this.HiBits0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END SethiInstruction



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

public override string ToString()
{
return string.Format("{0} %{1}, %{2}", Name, RegSource0, RegDest0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }

				var copy = new MovInstruction(
this.RegSource0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END MovInstruction



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

public override string ToString()
{
return string.Format("{0} {1}", Name, Str0);
}

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new CallInstruction(
this.Str0				);
				yield return copy;
	}

} //END CallInstruction



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

	public override string ToString()
	{
		string ret = string.Empty;
		ToStringCore(ref ret);
		if (string.IsNullOrEmpty(ret))
			throw new NotImplementedException();
		return ret;
	}

	partial void ToStringCore(ref string ret);

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }
				if (regToSpill[this.RegSource1.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource1.IntVal), this.RegSource1); }

				var copy = new StwInstruction(
this.RegSource0, this.RegSource1, this.Immed0				);
				yield return copy;
	}

} //END StwInstruction



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

	public override string ToString()
	{
		string ret = string.Empty;
		ToStringCore(ref ret);
		if (string.IsNullOrEmpty(ret))
			throw new NotImplementedException();
		return ret;
	}

	partial void ToStringCore(ref string ret);

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }

				var copy = new LdswInstruction(
this.RegSource0, this.Immed0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END LdswInstruction



public partial class OrlstrInstruction : SparcInstruction
{
	public OrlstrInstruction
	(
Register regSource0,string str0,Register regDest0	) : base ("or")
	{
this.RegSource0 = regSource0;this.Str0 = str0;this.RegDest0 = regDest0;	}

public Register RegSource0{ get; private set; }
public string Str0{ get; private set; }
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
		string ret = string.Empty;
		ToStringCore(ref ret);
		if (string.IsNullOrEmpty(ret))
			throw new NotImplementedException();
		return ret;
	}

	partial void ToStringCore(ref string ret);

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{
				if (regToSpill[this.RegSource0.IntVal]){ yield return new LdswInstruction(SparcRegister.SP, getLocalOffset("reg_" + this.RegSource0.IntVal), this.RegSource0); }

				var copy = new OrlstrInstruction(
this.RegSource0, this.Str0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END OrlstrInstruction



public partial class SethistrInstruction : SparcInstruction
{
	public SethistrInstruction
	(
string str0,Register regDest0	) : base ("sethi")
	{
this.Str0 = str0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
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
		string ret = string.Empty;
		ToStringCore(ref ret);
		if (string.IsNullOrEmpty(ret))
			throw new NotImplementedException();
		return ret;
	}

	partial void ToStringCore(ref string ret);

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new SethistrInstruction(
this.Str0, this.RegDest0				);
				yield return copy;
				if (regToSpill[this.RegDest0.IntVal]){ yield return new StwInstruction(this.RegDest0, SparcRegister.SP, getLocalOffset("reg_" + this.RegDest0.IntVal)); }
	}

} //END SethistrInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new RetInstruction(
				);
				yield return copy;
	}

} //END RetInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new RestoreInstruction(
				);
				yield return copy;
	}

} //END RestoreInstruction



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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new NopInstruction(
				);
				yield return copy;
	}

} //END NopInstruction



public partial class SaveInstruction : SparcInstruction
{
	public SaveInstruction
	(
	) : base ("save")
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

	public override IEnumerable<SparcInstruction> Spill(BitArray regToSpill, Func<string, int> getLocalOffset)
	{

				var copy = new SaveInstruction(
				);
				yield return copy;
	}

} //END SaveInstruction




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
			if (cur is SdivxInstruction)
			{
				var conv = cur as SdivxInstruction;
				var copy = new SdivxInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is MulxInstruction)
			{
				var conv = cur as MulxInstruction;
				var copy = new MulxInstruction(
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
			if (cur is AndInstruction)
			{
				var conv = cur as AndInstruction;
				var copy = new AndInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is XorInstruction)
			{
				var conv = cur as XorInstruction;
				var copy = new XorInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
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
			if (cur is MoveqInstruction)
			{
				var conv = cur as MoveqInstruction;
				var copy = new MoveqInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is MovneInstruction)
			{
				var conv = cur as MovneInstruction;
				var copy = new MovneInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is MovgeInstruction)
			{
				var conv = cur as MovgeInstruction;
				var copy = new MovgeInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is MovgInstruction)
			{
				var conv = cur as MovgInstruction;
				var copy = new MovgInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is MovleInstruction)
			{
				var conv = cur as MovleInstruction;
				var copy = new MovleInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is MovlInstruction)
			{
				var conv = cur as MovlInstruction;
				var copy = new MovlInstruction(
conv.Immed0, map[conv.RegDest0.IntVal]				);
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
			if (cur is MovInstruction)
			{
				var conv = cur as MovInstruction;
				var copy = new MovInstruction(
map[conv.RegSource0.IntVal], map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is CallInstruction)
			{
				var conv = cur as CallInstruction;
				var copy = new CallInstruction(
conv.Str0				);
				yield return copy;
				continue;
			}
			if (cur is StwInstruction)
			{
				var conv = cur as StwInstruction;
				var copy = new StwInstruction(
map[conv.RegSource0.IntVal], map[conv.RegSource1.IntVal], conv.Immed0				);
				yield return copy;
				continue;
			}
			if (cur is LdswInstruction)
			{
				var conv = cur as LdswInstruction;
				var copy = new LdswInstruction(
map[conv.RegSource0.IntVal], conv.Immed0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is OrlstrInstruction)
			{
				var conv = cur as OrlstrInstruction;
				var copy = new OrlstrInstruction(
map[conv.RegSource0.IntVal], conv.Str0, map[conv.RegDest0.IntVal]				);
				yield return copy;
				continue;
			}
			if (cur is SethistrInstruction)
			{
				var conv = cur as SethistrInstruction;
				var copy = new SethistrInstruction(
conv.Str0, map[conv.RegDest0.IntVal]				);
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
				);
				yield return copy;
				continue;
			}
			throw new NotSupportedException();
		}
	}
}

public class SpillConverter : IInstructionConverter<SparcInstruction, SparcInstruction>
{
	private BitArray regToSpill;
	private int spOffset;
    CFG.FunctionBlock<SparcInstruction> curFunc;

	public SpillConverter(BitArray regToSpill)
	{
		this.regToSpill = regToSpill;
	}

    private int getLocalOffset(string name)
    {
        return spOffset + curFunc.GetLocalIndex(name) * 4;
    }

	public IEnumerable<SparcInstruction> FunctionStart(FunctionBlock<SparcInstruction> copy)
	{
		curFunc = copy;

        spOffset = 92;
        if (copy.MaxOutArgs > 6)
        {
            spOffset += (copy.MaxOutArgs - 6) * 4;
        }

		return Enumerable.Empty<SparcInstruction>();
	}

	public IEnumerable<SparcInstruction> Convert(InstructionStream<SparcInstruction> s)
	{
		while (s.More)
		{
			var cur = s.Consume();
			foreach (var newInstr in cur.Spill(regToSpill, getLocalOffset))
			{
				yield return newInstr;
			}
		}
	}
}

}
