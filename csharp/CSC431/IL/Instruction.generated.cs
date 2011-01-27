using CSC431.CFG;

namespace CSC431.IL
{

class AddInstruction : MilocInstruction
{
	public AddInstruction
	(
int regSource0,int regSource1,int regDest0	) : base ("add")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }
public int RegDest0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1, 		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



class AddiInstruction : MilocInstruction
{
	public AddiInstruction
	(
int regSource0,int immed0,int regDest0	) : base ("addi")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, {2}, r{3}", Name, RegSource0, Immed0, RegDest0);
}
}



class DivInstruction : MilocInstruction
{
	public DivInstruction
	(
int regSource0,int regSource1,int regDest0	) : base ("div")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }
public int RegDest0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1, 		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



class MultInstruction : MilocInstruction
{
	public MultInstruction
	(
int regSource0,int regSource1,int regDest0	) : base ("mult")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }
public int RegDest0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1, 		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



class SubInstruction : MilocInstruction
{
	public SubInstruction
	(
int regSource0,int regSource1,int regDest0	) : base ("sub")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }
public int RegDest0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1, 		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



class RsubiInstruction : MilocInstruction
{
	public RsubiInstruction
	(
int regSource0,int immed0,int regDest0	) : base ("rsubi")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, {2}, r{3}", Name, RegSource0, Immed0, RegDest0);
}
}



class AndInstruction : MilocInstruction
{
	public AndInstruction
	(
int regSource0,int regSource1,int regDest0	) : base ("and")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }
public int RegDest0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1, 		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



class OrInstruction : MilocInstruction
{
	public OrInstruction
	(
int regSource0,int regSource1,int regDest0	) : base ("or")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }
public int RegDest0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1, 		};
	}
}

public override int[] DestRegs
{
	get
	{
		return new int[] {
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, RegSource0, RegSource1, RegDest0);
}
}



class XoriInstruction : MilocInstruction
{
	public XoriInstruction
	(
int regSource0,int immed0,int regDest0	) : base ("xori")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, {2}, r{3}", Name, RegSource0, Immed0, RegDest0);
}
}



class LoadiInstruction : MilocInstruction
{
	public LoadiInstruction
	(
int immed0,int regDest0	) : base ("loadi")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, RegDest0);
}
}



class PrintInstruction : MilocInstruction
{
	public PrintInstruction
	(
int regSource0	) : base ("print")
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
return string.Format("{0} r{1}", Name, RegSource0);
}
}



class PrintlnInstruction : MilocInstruction
{
	public PrintlnInstruction
	(
int regSource0	) : base ("println")
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
return string.Format("{0} r{1}", Name, RegSource0);
}
}



class ReadInstruction : MilocInstruction
{
	public ReadInstruction
	(
int regSource0	) : base ("read")
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
return string.Format("{0} r{1}", Name, RegSource0);
}
}



class CompInstruction : MilocInstruction
{
	public CompInstruction
	(
int regSource0,int regSource1	) : base ("comp")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;		this.CcSet = true;
	}

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
		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, r{2}", Name, RegSource0, RegSource1);
}
}



class MovInstruction : MilocInstruction
{
	public MovInstruction
	(
int regSource0,int regDest0	) : base ("mov")
	{
this.RegSource0 = regSource0;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, r{2}", Name, RegSource0, RegDest0);
}
}



class MoveqInstruction : MilocInstruction
{
	public MoveqInstruction
	(
int immed0,int regDest0	) : base ("moveq")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, RegDest0);
}
}



class MovgeInstruction : MilocInstruction
{
	public MovgeInstruction
	(
int immed0,int regDest0	) : base ("movge")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, RegDest0);
}
}



class MovgtInstruction : MilocInstruction
{
	public MovgtInstruction
	(
int immed0,int regDest0	) : base ("movgt")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, RegDest0);
}
}



class MovleInstruction : MilocInstruction
{
	public MovleInstruction
	(
int immed0,int regDest0	) : base ("movle")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, RegDest0);
}
}



class MovltInstruction : MilocInstruction
{
	public MovltInstruction
	(
int immed0,int regDest0	) : base ("movlt")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, RegDest0);
}
}



class MovneInstruction : MilocInstruction
{
	public MovneInstruction
	(
int immed0,int regDest0	) : base ("movne")
	{
this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, RegDest0);
}
}



class JumpiInstruction : MilocInstruction
{
	public JumpiInstruction
	(
Label<MilocInstruction> label0	) : base ("jumpi")
	{
this.Label0 = label0;	}

public Label<MilocInstruction> Label0{ get; private set; }

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
return string.Format("{0} L{1}", Name, Label0);
}
}



class CbreqInstruction : MilocInstruction
{
	public CbreqInstruction
	(
Label<MilocInstruction> label0,Label<MilocInstruction> label1	) : base ("cbreq")
	{
this.Label0 = label0;this.Label1 = label1;	}

public Label<MilocInstruction> Label0{ get; private set; }
public Label<MilocInstruction> Label1{ get; private set; }

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
return string.Format("{0} L{1}, L{2}", Name, Label0, Label1);
}
}



class LoadinargumentInstruction : MilocInstruction
{
	public LoadinargumentInstruction
	(
string str0,int immed0,int regDest0	) : base ("loadinargument")
	{
this.Str0 = str0;this.Immed0 = immed0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public int Immed0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, {2}, r{3}", Name, Str0, Immed0, RegDest0);
}
}



class CallInstruction : MilocInstruction
{
	public CallInstruction
	(
string str0	) : base ("call")
	{
this.Str0 = str0;	}

public string Str0{ get; private set; }

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
return string.Format("{0} {1}", Name, Str0);
}
}



class RetInstruction : MilocInstruction
{
	public RetInstruction
	(
	) : base ("ret")
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
return string.Format("{0}", Name);
}
}



class StoreretInstruction : MilocInstruction
{
	public StoreretInstruction
	(
int regSource0	) : base ("storeret")
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
return string.Format("{0} r{1}", Name, RegSource0);
}
}



class StoreoutargumentInstruction : MilocInstruction
{
	public StoreoutargumentInstruction
	(
int regSource0,int immed0	) : base ("storeoutargument")
	{
this.RegSource0 = regSource0;this.Immed0 = immed0;	}

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
		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, {2}", Name, RegSource0, Immed0);
}
}



class LoadretInstruction : MilocInstruction
{
	public LoadretInstruction
	(
int regDest0	) : base ("loadret")
	{
this.RegDest0 = regDest0;	}

public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}", Name, RegDest0);
}
}



class StoreaiFieldInstruction : MilocInstruction
{
	public StoreaiFieldInstruction
	(
int regSource0,int regSource1,string str0	) : base ("storeai")
	{
this.RegSource0 = regSource0;this.RegSource1 = regSource1;this.Str0 = str0;	}

public int RegSource0{ get; private set; }
public int RegSource1{ get; private set; }
public string Str0{ get; private set; }

public override int[] SourceRegs
{
	get
	{
		return new int[] {
RegSource0, RegSource1, 		};
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
return string.Format("{0} r{1}, r{2}, {3}", Name, RegSource0, RegSource1, Str0);
}
}



class StoreaiVarInstruction : MilocInstruction
{
	public StoreaiVarInstruction
	(
int regSource0,string str0	) : base ("storeai")
	{
this.RegSource0 = regSource0;this.Str0 = str0;	}

public int RegSource0{ get; private set; }
public string Str0{ get; private set; }

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
		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, rarp, {3}", Name, RegSource0, null, Str0);
}
}



class LoadaiFieldInstruction : MilocInstruction
{
	public LoadaiFieldInstruction
	(
int regSource0,string str0,int regDest0	) : base ("loadai")
	{
this.RegSource0 = regSource0;this.Str0 = str0;this.RegDest0 = regDest0;	}

public int RegSource0{ get; private set; }
public string Str0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, {2}, r{3}", Name, RegSource0, Str0, RegDest0);
}
}



class LoadaiVarInstruction : MilocInstruction
{
	public LoadaiVarInstruction
	(
string str0,int regDest0	) : base ("loadai")
	{
this.Str0 = str0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} rarp, {2}, r{3}", Name, null, Str0, RegDest0);
}
}



class LoadglobalInstruction : MilocInstruction
{
	public LoadglobalInstruction
	(
string str0,int regDest0	) : base ("loadglobal")
	{
this.Str0 = str0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Str0, RegDest0);
}
}



class StoreglobalInstruction : MilocInstruction
{
	public StoreglobalInstruction
	(
int regSource0,string str0	) : base ("storeglobal")
	{
this.RegSource0 = regSource0;this.Str0 = str0;	}

public int RegSource0{ get; private set; }
public string Str0{ get; private set; }

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
		};
	}
}

public override string ToString()
{
return string.Format("{0} r{1}, {2}", Name, RegSource0, Str0);
}
}



class ComputeglobaladdressInstruction : MilocInstruction
{
	public ComputeglobaladdressInstruction
	(
string str0,int regDest0	) : base ("computeglobaladdress")
	{
this.Str0 = str0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Str0, RegDest0);
}
}



class NewInstruction : MilocInstruction
{
	public NewInstruction
	(
string str0,string[] arr0,int regDest0	) : base ("new")
	{
this.Str0 = str0;this.Arr0 = arr0;this.RegDest0 = regDest0;	}

public string Str0{ get; private set; }
public string[] Arr0{ get; private set; }
public int RegDest0{ get; private set; }

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
RegDest0		};
	}
}

public override string ToString()
{
return string.Format("{0} {1}, [{2}], r{3}", Name, Str0, string.Join(", ", Arr0), RegDest0);
}
}



class DelInstruction : MilocInstruction
{
	public DelInstruction
	(
int regSource0	) : base ("del")
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
return string.Format("{0} r{1}", Name, RegSource0);
}
}




}
