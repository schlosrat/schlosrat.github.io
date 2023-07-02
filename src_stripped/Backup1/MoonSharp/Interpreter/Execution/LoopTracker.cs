// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.LoopTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.DataStructs;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution
{
  internal class LoopTracker
  {
    public FastStack<ILoop> Loops;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoopTracker() => throw null;
  }
}
