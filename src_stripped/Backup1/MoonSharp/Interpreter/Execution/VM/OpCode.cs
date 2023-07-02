// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.VM.OpCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace MoonSharp.Interpreter.Execution.VM
{
  internal enum OpCode
  {
    Nop,
    Debug,
    Pop,
    Copy,
    Swap,
    Literal,
    Closure,
    NewTable,
    TblInitN,
    TblInitI,
    StoreLcl,
    Local,
    StoreUpv,
    Upvalue,
    IndexSet,
    Index,
    IndexSetN,
    IndexN,
    IndexSetL,
    IndexL,
    Clean,
    Meta,
    BeginFn,
    Args,
    Call,
    ThisCall,
    Ret,
    Jump,
    Jf,
    JNil,
    JFor,
    JtOrPop,
    JfOrPop,
    Concat,
    LessEq,
    Less,
    Eq,
    Add,
    Sub,
    Mul,
    Div,
    Mod,
    Not,
    Len,
    Neg,
    Power,
    CNot,
    MkTuple,
    Scalar,
    Incr,
    ToNum,
    ToBool,
    ExpTuple,
    IterPrep,
    IterUpd,
    Invalid,
  }
}
