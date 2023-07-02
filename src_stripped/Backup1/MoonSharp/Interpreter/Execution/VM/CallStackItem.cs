// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.VM.CallStackItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution.VM
{
  internal class CallStackItem
  {
    public int Debug_EntryPoint;
    public SymbolRef[] Debug_Symbols;
    public SourceRef CallingSourceRef;
    public CallbackFunction ClrFunction;
    public CallbackFunction Continuation;
    public CallbackFunction ErrorHandler;
    public DynValue ErrorHandlerBeforeUnwind;
    public int BasePointer;
    public int ReturnAddress;
    public DynValue[] LocalScope;
    public ClosureContext ClosureScope;
    public CallStackItemFlags Flags;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CallStackItem() => throw null;
  }
}
