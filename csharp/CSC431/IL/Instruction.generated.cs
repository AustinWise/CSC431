using CSC431.CFG;
using System;
using System.Collections.Generic;

namespace CSC431.IL
{

public class AddInstruction : MilocInstruction
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



public class AddiInstruction : MilocInstruction
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



public class DivInstruction : MilocInstruction
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



public class MultInstruction : MilocInstruction
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



public class SubInstruction : MilocInstruction
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



public class RsubiInstruction : MilocInstruction
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



public class AndInstruction : MilocInstruction
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



public class OrInstruction : MilocInstruction
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



public class XoriInstruction : MilocInstruction
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



public class LoadiInstruction : MilocInstruction
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



public class PrintInstruction : MilocInstruction
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



public class PrintlnInstruction : MilocInstruction
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



public class ReadInstruction : MilocInstruction
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



public class CompInstruction : MilocInstruction
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



public class MovInstruction : MilocInstruction
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



public class MoveqInstruction : MilocInstruction
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



public class MovgeInstruction : MilocInstruction
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



public class MovgtInstruction : MilocInstruction
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



public class MovleInstruction : MilocInstruction
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



public class MovltInstruction : MilocInstruction
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



public class MovneInstruction : MilocInstruction
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



public class JumpiInstruction : MilocInstruction
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



public class CbreqInstruction : MilocInstruction
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



public class LoadinargumentInstruction : MilocInstruction
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



public class CallInstruction : MilocInstruction
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



public class RetInstruction : MilocInstruction
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



public class StoreretInstruction : MilocInstruction
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



public class StoreoutargumentInstruction : MilocInstruction
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



public class LoadretInstruction : MilocInstruction
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



public class StoreaiFieldInstruction : MilocInstruction
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



public class StoreaiVarInstruction : MilocInstruction
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



public class LoadaiFieldInstruction : MilocInstruction
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



public class LoadaiVarInstruction : MilocInstruction
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



public class LoadglobalInstruction : MilocInstruction
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



public class StoreglobalInstruction : MilocInstruction
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



public class ComputeglobaladdressInstruction : MilocInstruction
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



public class NewInstruction : MilocInstruction
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



public class DelInstruction : MilocInstruction
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



public interface IMilocTranslator<T> where T : Instruction
{

	IEnumerable<T> Add(AddInstruction s);
	IEnumerable<T> Addi(AddiInstruction s);
	IEnumerable<T> Div(DivInstruction s);
	IEnumerable<T> Mult(MultInstruction s);
	IEnumerable<T> Sub(SubInstruction s);
	IEnumerable<T> Rsubi(RsubiInstruction s);
	IEnumerable<T> And(AndInstruction s);
	IEnumerable<T> Or(OrInstruction s);
	IEnumerable<T> Xori(XoriInstruction s);
	IEnumerable<T> Loadi(LoadiInstruction s);
	IEnumerable<T> Print(PrintInstruction s);
	IEnumerable<T> Println(PrintlnInstruction s);
	IEnumerable<T> Read(ReadInstruction s);
	IEnumerable<T> Comp(CompInstruction s);
	IEnumerable<T> Mov(MovInstruction s);
	IEnumerable<T> Moveq(MoveqInstruction s);
	IEnumerable<T> Movge(MovgeInstruction s);
	IEnumerable<T> Movgt(MovgtInstruction s);
	IEnumerable<T> Movle(MovleInstruction s);
	IEnumerable<T> Movlt(MovltInstruction s);
	IEnumerable<T> Movne(MovneInstruction s);
	IEnumerable<T> Jumpi(JumpiInstruction s);
	IEnumerable<T> Cbreq(CbreqInstruction s);
	IEnumerable<T> Loadinargument(LoadinargumentInstruction s);
	IEnumerable<T> Call(CallInstruction s);
	IEnumerable<T> Ret(RetInstruction s);
	IEnumerable<T> Storeret(StoreretInstruction s);
	IEnumerable<T> Storeoutargument(StoreoutargumentInstruction s);
	IEnumerable<T> Loadret(LoadretInstruction s);
	IEnumerable<T> StoreaiField(StoreaiFieldInstruction s);
	IEnumerable<T> StoreaiVar(StoreaiVarInstruction s);
	IEnumerable<T> LoadaiField(LoadaiFieldInstruction s);
	IEnumerable<T> LoadaiVar(LoadaiVarInstruction s);
	IEnumerable<T> Loadglobal(LoadglobalInstruction s);
	IEnumerable<T> Storeglobal(StoreglobalInstruction s);
	IEnumerable<T> Computeglobaladdress(ComputeglobaladdressInstruction s);
	IEnumerable<T> New(NewInstruction s);
	IEnumerable<T> Del(DelInstruction s);
}

public class MilocIdentityTranslator : IMilocTranslator<MilocInstruction>
{

	public IEnumerable<MilocInstruction> Add(AddInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Addi(AddiInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Div(DivInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Mult(MultInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Sub(SubInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Rsubi(RsubiInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> And(AndInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Or(OrInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Xori(XoriInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Loadi(LoadiInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Print(PrintInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Println(PrintlnInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Read(ReadInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Comp(CompInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Mov(MovInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Moveq(MoveqInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Movge(MovgeInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Movgt(MovgtInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Movle(MovleInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Movlt(MovltInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Movne(MovneInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Jumpi(JumpiInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Cbreq(CbreqInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Loadinargument(LoadinargumentInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Call(CallInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Ret(RetInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Storeret(StoreretInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Storeoutargument(StoreoutargumentInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Loadret(LoadretInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> StoreaiField(StoreaiFieldInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> StoreaiVar(StoreaiVarInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> LoadaiField(LoadaiFieldInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> LoadaiVar(LoadaiVarInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Loadglobal(LoadglobalInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Storeglobal(StoreglobalInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Computeglobaladdress(ComputeglobaladdressInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> New(NewInstruction s) { yield return s; }
	public IEnumerable<MilocInstruction> Del(DelInstruction s) { yield return s; }
}

public class MilocConverter<T> : IInstructionConverter<MilocInstruction, T>
	where T : Instruction
{
	private IMilocTranslator<T> translator;
	public MilocConverter(IMilocTranslator<T> translator)
	{
		this.translator = translator;
	}

	public IEnumerable<T> Convert(MilocInstruction s)
	{

		if (s is AddInstruction)
			return translator.Add(s as AddInstruction);
		if (s is AddiInstruction)
			return translator.Addi(s as AddiInstruction);
		if (s is DivInstruction)
			return translator.Div(s as DivInstruction);
		if (s is MultInstruction)
			return translator.Mult(s as MultInstruction);
		if (s is SubInstruction)
			return translator.Sub(s as SubInstruction);
		if (s is RsubiInstruction)
			return translator.Rsubi(s as RsubiInstruction);
		if (s is AndInstruction)
			return translator.And(s as AndInstruction);
		if (s is OrInstruction)
			return translator.Or(s as OrInstruction);
		if (s is XoriInstruction)
			return translator.Xori(s as XoriInstruction);
		if (s is LoadiInstruction)
			return translator.Loadi(s as LoadiInstruction);
		if (s is PrintInstruction)
			return translator.Print(s as PrintInstruction);
		if (s is PrintlnInstruction)
			return translator.Println(s as PrintlnInstruction);
		if (s is ReadInstruction)
			return translator.Read(s as ReadInstruction);
		if (s is CompInstruction)
			return translator.Comp(s as CompInstruction);
		if (s is MovInstruction)
			return translator.Mov(s as MovInstruction);
		if (s is MoveqInstruction)
			return translator.Moveq(s as MoveqInstruction);
		if (s is MovgeInstruction)
			return translator.Movge(s as MovgeInstruction);
		if (s is MovgtInstruction)
			return translator.Movgt(s as MovgtInstruction);
		if (s is MovleInstruction)
			return translator.Movle(s as MovleInstruction);
		if (s is MovltInstruction)
			return translator.Movlt(s as MovltInstruction);
		if (s is MovneInstruction)
			return translator.Movne(s as MovneInstruction);
		if (s is JumpiInstruction)
			return translator.Jumpi(s as JumpiInstruction);
		if (s is CbreqInstruction)
			return translator.Cbreq(s as CbreqInstruction);
		if (s is LoadinargumentInstruction)
			return translator.Loadinargument(s as LoadinargumentInstruction);
		if (s is CallInstruction)
			return translator.Call(s as CallInstruction);
		if (s is RetInstruction)
			return translator.Ret(s as RetInstruction);
		if (s is StoreretInstruction)
			return translator.Storeret(s as StoreretInstruction);
		if (s is StoreoutargumentInstruction)
			return translator.Storeoutargument(s as StoreoutargumentInstruction);
		if (s is LoadretInstruction)
			return translator.Loadret(s as LoadretInstruction);
		if (s is StoreaiFieldInstruction)
			return translator.StoreaiField(s as StoreaiFieldInstruction);
		if (s is StoreaiVarInstruction)
			return translator.StoreaiVar(s as StoreaiVarInstruction);
		if (s is LoadaiFieldInstruction)
			return translator.LoadaiField(s as LoadaiFieldInstruction);
		if (s is LoadaiVarInstruction)
			return translator.LoadaiVar(s as LoadaiVarInstruction);
		if (s is LoadglobalInstruction)
			return translator.Loadglobal(s as LoadglobalInstruction);
		if (s is StoreglobalInstruction)
			return translator.Storeglobal(s as StoreglobalInstruction);
		if (s is ComputeglobaladdressInstruction)
			return translator.Computeglobaladdress(s as ComputeglobaladdressInstruction);
		if (s is NewInstruction)
			return translator.New(s as NewInstruction);
		if (s is DelInstruction)
			return translator.Del(s as DelInstruction);
		throw new NotSupportedException();
	}
}

}
