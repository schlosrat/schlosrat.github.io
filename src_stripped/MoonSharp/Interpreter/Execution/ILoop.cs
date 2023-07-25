// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.ILoop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Execution
{
  internal interface ILoop
  {
    void CompileBreak(ByteCode bc);

    bool IsBoundary();
  }
}
