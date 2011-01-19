using CSC431.CFG;

namespace CSC431.IL
{

class AddInstruction : MilocInstruction
{
	public AddInstruction
	(
int reg0,int reg1,int reg2	) : base ("add")
	{
this.Reg0 = reg0;this.Reg1 = reg1;this.Reg2 = reg2;	}

public int Reg0{ get; private set; }public int Reg1{ get; private set; }public int Reg2{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, Reg0, Reg1, Reg2);
}
}



class AddiInstruction : MilocInstruction
{
	public AddiInstruction
	(
int reg0,int immed0,int reg1	) : base ("addi")
	{
this.Reg0 = reg0;this.Immed0 = immed0;this.Reg1 = reg1;	}

public int Reg0{ get; private set; }public int Immed0{ get; private set; }public int Reg1{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, {2}, r{3}", Name, Reg0, Immed0, Reg1);
}
}



class DivInstruction : MilocInstruction
{
	public DivInstruction
	(
int reg0,int reg1,int reg2	) : base ("div")
	{
this.Reg0 = reg0;this.Reg1 = reg1;this.Reg2 = reg2;	}

public int Reg0{ get; private set; }public int Reg1{ get; private set; }public int Reg2{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, Reg0, Reg1, Reg2);
}
}



class MultInstruction : MilocInstruction
{
	public MultInstruction
	(
int reg0,int reg1,int reg2	) : base ("mult")
	{
this.Reg0 = reg0;this.Reg1 = reg1;this.Reg2 = reg2;	}

public int Reg0{ get; private set; }public int Reg1{ get; private set; }public int Reg2{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, Reg0, Reg1, Reg2);
}
}



class SubInstruction : MilocInstruction
{
	public SubInstruction
	(
int reg0,int reg1,int reg2	) : base ("sub")
	{
this.Reg0 = reg0;this.Reg1 = reg1;this.Reg2 = reg2;	}

public int Reg0{ get; private set; }public int Reg1{ get; private set; }public int Reg2{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, Reg0, Reg1, Reg2);
}
}



class RsubiInstruction : MilocInstruction
{
	public RsubiInstruction
	(
int reg0,int immed0,int reg1	) : base ("rsubi")
	{
this.Reg0 = reg0;this.Immed0 = immed0;this.Reg1 = reg1;	}

public int Reg0{ get; private set; }public int Immed0{ get; private set; }public int Reg1{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, {2}, r{3}", Name, Reg0, Immed0, Reg1);
}
}



class AndInstruction : MilocInstruction
{
	public AndInstruction
	(
int reg0,int reg1,int reg2	) : base ("and")
	{
this.Reg0 = reg0;this.Reg1 = reg1;this.Reg2 = reg2;	}

public int Reg0{ get; private set; }public int Reg1{ get; private set; }public int Reg2{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, Reg0, Reg1, Reg2);
}
}



class OrInstruction : MilocInstruction
{
	public OrInstruction
	(
int reg0,int reg1,int reg2	) : base ("or")
	{
this.Reg0 = reg0;this.Reg1 = reg1;this.Reg2 = reg2;	}

public int Reg0{ get; private set; }public int Reg1{ get; private set; }public int Reg2{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, r{2}, r{3}", Name, Reg0, Reg1, Reg2);
}
}



class XoriInstruction : MilocInstruction
{
	public XoriInstruction
	(
int reg0,int immed0,int reg1	) : base ("xori")
	{
this.Reg0 = reg0;this.Immed0 = immed0;this.Reg1 = reg1;	}

public int Reg0{ get; private set; }public int Immed0{ get; private set; }public int Reg1{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, {2}, r{3}", Name, Reg0, Immed0, Reg1);
}
}



class LoadiInstruction : MilocInstruction
{
	public LoadiInstruction
	(
int immed0,int reg0	) : base ("loadi")
	{
this.Immed0 = immed0;this.Reg0 = reg0;	}

public int Immed0{ get; private set; }public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, Reg0);
}
}



class PrintInstruction : MilocInstruction
{
	public PrintInstruction
	(
int reg0	) : base ("print")
	{
this.Reg0 = reg0;	}

public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}", Name, Reg0);
}
}



class PrintlnInstruction : MilocInstruction
{
	public PrintlnInstruction
	(
int reg0	) : base ("println")
	{
this.Reg0 = reg0;	}

public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}", Name, Reg0);
}
}



class ReadInstruction : MilocInstruction
{
	public ReadInstruction
	(
int reg0	) : base ("read")
	{
this.Reg0 = reg0;	}

public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}", Name, Reg0);
}
}



class CompInstruction : MilocInstruction
{
	public CompInstruction
	(
int reg0,int reg1	) : base ("comp")
	{
this.Reg0 = reg0;this.Reg1 = reg1;		this.CcSet = true;
	}

public int Reg0{ get; private set; }public int Reg1{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, r{2}", Name, Reg0, Reg1);
}
}



class MovInstruction : MilocInstruction
{
	public MovInstruction
	(
int reg0,int reg1	) : base ("mov")
	{
this.Reg0 = reg0;this.Reg1 = reg1;	}

public int Reg0{ get; private set; }public int Reg1{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, r{2}", Name, Reg0, Reg1);
}
}



class MoveqInstruction : MilocInstruction
{
	public MoveqInstruction
	(
int immed0,int reg0	) : base ("moveq")
	{
this.Immed0 = immed0;this.Reg0 = reg0;	}

public int Immed0{ get; private set; }public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, Reg0);
}
}



class MovgeInstruction : MilocInstruction
{
	public MovgeInstruction
	(
int immed0,int reg0	) : base ("movge")
	{
this.Immed0 = immed0;this.Reg0 = reg0;	}

public int Immed0{ get; private set; }public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, Reg0);
}
}



class MovgtInstruction : MilocInstruction
{
	public MovgtInstruction
	(
int immed0,int reg0	) : base ("movgt")
	{
this.Immed0 = immed0;this.Reg0 = reg0;	}

public int Immed0{ get; private set; }public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, Reg0);
}
}



class MovleInstruction : MilocInstruction
{
	public MovleInstruction
	(
int immed0,int reg0	) : base ("movle")
	{
this.Immed0 = immed0;this.Reg0 = reg0;	}

public int Immed0{ get; private set; }public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, Reg0);
}
}



class MovltInstruction : MilocInstruction
{
	public MovltInstruction
	(
int immed0,int reg0	) : base ("movlt")
	{
this.Immed0 = immed0;this.Reg0 = reg0;	}

public int Immed0{ get; private set; }public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, Reg0);
}
}



class MovneInstruction : MilocInstruction
{
	public MovneInstruction
	(
int immed0,int reg0	) : base ("movne")
	{
this.Immed0 = immed0;this.Reg0 = reg0;	}

public int Immed0{ get; private set; }public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} {1}, r{2}", Name, Immed0, Reg0);
}
}



class JumpiInstruction : MilocInstruction
{
	public JumpiInstruction
	(
Label<MilocInstruction> label0	) : base ("jumpi")
	{
this.Label0 = label0;	}

public Label<MilocInstruction> Label0{ get; private set; }public override string ToString()
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

public Label<MilocInstruction> Label0{ get; private set; }public Label<MilocInstruction> Label1{ get; private set; }public override string ToString()
{
return string.Format("{0} L{1}, L{2}", Name, Label0, Label1);
}
}



class LoadinargumentInstruction : MilocInstruction
{
	public LoadinargumentInstruction
	(
string str0,int immed0,int reg0	) : base ("loadinargument")
	{
this.Str0 = str0;this.Immed0 = immed0;this.Reg0 = reg0;	}

public string Str0{ get; private set; }public int Immed0{ get; private set; }public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} {1}, {2}, r{3}", Name, Str0, Immed0, Reg0);
}
}



class CallInstruction : MilocInstruction
{
	public CallInstruction
	(
string str0	) : base ("call")
	{
this.Str0 = str0;	}

public string Str0{ get; private set; }public override string ToString()
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

public override string ToString()
{
return string.Format("{0}", Name);
}
}



class StoreretInstruction : MilocInstruction
{
	public StoreretInstruction
	(
int reg0	) : base ("storeret")
	{
this.Reg0 = reg0;	}

public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}", Name, Reg0);
}
}



class StoreoutargumentInstruction : MilocInstruction
{
	public StoreoutargumentInstruction
	(
int reg0,int immed0	) : base ("storeoutargument")
	{
this.Reg0 = reg0;this.Immed0 = immed0;	}

public int Reg0{ get; private set; }public int Immed0{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, {2}", Name, Reg0, Immed0);
}
}



class LoadretInstruction : MilocInstruction
{
	public LoadretInstruction
	(
int reg0	) : base ("loadret")
	{
this.Reg0 = reg0;	}

public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}", Name, Reg0);
}
}



class StoreaiInstruction : MilocInstruction
{
	public StoreaiInstruction
	(
int reg0,int reg1,string str0	) : base ("storeai")
	{
this.Reg0 = reg0;this.Reg1 = reg1;this.Str0 = str0;	}

public int Reg0{ get; private set; }public int Reg1{ get; private set; }public string Str0{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, r{2}, {3}", Name, Reg0, Reg1, Str0);
}
}



class LoadaiInstruction : MilocInstruction
{
	public LoadaiInstruction
	(
int reg0,string str0,int reg1	) : base ("loadai")
	{
this.Reg0 = reg0;this.Str0 = str0;this.Reg1 = reg1;	}

public int Reg0{ get; private set; }public string Str0{ get; private set; }public int Reg1{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}, {2}, r{3}", Name, Reg0, Str0, Reg1);
}
}



class NewInstruction : MilocInstruction
{
	public NewInstruction
	(
string str0,string[] arr0,int reg0	) : base ("new")
	{
this.Str0 = str0;this.Arr0 = arr0;this.Reg0 = reg0;	}

public string Str0{ get; private set; }public string[] Arr0{ get; private set; }public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} {1}, [{2}], r{3}", Name, Str0, string.Join(", ", Arr0), Reg0);
}
}



class DelInstruction : MilocInstruction
{
	public DelInstruction
	(
int reg0	) : base ("del")
	{
this.Reg0 = reg0;	}

public int Reg0{ get; private set; }public override string ToString()
{
return string.Format("{0} r{1}", Name, Reg0);
}
}




}
