// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.VM.ExecutionState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.DataStructs;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution.VM
{
  internal sealed class ExecutionState
  {
    public FastStack<DynValue> ValueStack;
    public FastStack<CallStackItem> ExecutionStack;
    public int InstructionPtr;
    public CoroutineState State;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExecutionState() => throw null;
  }
}
