// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.IVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
  internal interface IVariable
  {
    void CompileAssignment(ByteCode bc, int stackofs, int tupleidx);
  }
}
