// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.ILoop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
