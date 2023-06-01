// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.IVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
  internal interface IVariable
  {
    void CompileAssignment(ByteCode bc, int stackofs, int tupleidx);
  }
}
