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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new AddInstruction(map[this.RegSource0.IntVal], map[this.RegSource1.IntVal], map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new AddiInstruction(map[this.RegSource0.IntVal], this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new SubInstruction(map[this.RegSource0.IntVal], map[this.RegSource1.IntVal], map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new SdivxInstruction(map[this.RegSource0.IntVal], map[this.RegSource1.IntVal], map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new MulxInstruction(map[this.RegSource0.IntVal], map[this.RegSource1.IntVal], map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new OrInstruction(map[this.RegSource0.IntVal], map[this.RegSource1.IntVal], map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new AndInstruction(map[this.RegSource0.IntVal], map[this.RegSource1.IntVal], map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new XorInstruction(map[this.RegSource0.IntVal], this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new OriInstruction(map[this.RegSource0.IntVal], this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new OrlInstruction(map[this.RegSource0.IntVal], this.LoBits0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new CmpInstruction(map[this.RegSource0.IntVal], map[this.RegSource1.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new BeInstruction(this.Label0);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new BaInstruction(this.Label0);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new MoveqInstruction(this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new MovneInstruction(this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new MovgeInstruction(this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new MovgInstruction(this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new MovleInstruction(this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new MovlInstruction(this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new SethiInstruction(this.HiBits0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new MovInstruction(map[this.RegSource0.IntVal], map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new CallInstruction(this.Str0);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new StwInstruction(map[this.RegSource0.IntVal], map[this.RegSource1.IntVal], this.Immed0);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new LdswInstruction(map[this.RegSource0.IntVal], this.Immed0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new OrlstrInstruction(map[this.RegSource0.IntVal], this.Str0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new SethistrInstruction(this.Str0, map[this.RegDest0.IntVal]);
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new RetInstruction();
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new RestoreInstruction();
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new NopInstruction();
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

	public override SparcInstruction ConvertRegister(SparcRegister[] map)
	{
		return new SaveInstruction();
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
			yield return s.Consume().ConvertRegister(map);
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
