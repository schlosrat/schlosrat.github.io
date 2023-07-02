// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.VM.Processor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Debugging;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution.VM
{
  internal sealed class Processor
  {
    private ByteCode m_RootChunk;
    private FastStack<DynValue> m_ValueStack;
    private FastStack<CallStackItem> m_ExecutionStack;
    private List<Processor> m_CoroutinesStack;
    private Table m_GlobalTable;
    private Script m_Script;
    private Processor m_Parent;
    private CoroutineState m_State;
    private bool m_CanYield;
    private int m_SavedInstructionPtr;
    private Processor.DebugContext m_Debug;
    private int m_OwningThreadID;
    private int m_ExecutionNesting;
    private const ulong DUMP_CHUNK_MAGIC = 1877195438928383261;
    private const int DUMP_CHUNK_VERSION = 336;
    private const int YIELD_SPECIAL_TRAP = -99;
    internal long AutoYieldCounter;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Processor(Script script, Table globalContext, ByteCode byteCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Processor(Processor parentProcessor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call(DynValue function, DynValue[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int PushClrToScriptStackFrame(
      CallStackItemFlags flags,
      DynValue function,
      DynValue[] args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LeaveProcessor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetThreadId() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnterProcessor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SourceRef GetCoroutineSuspendedLocation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool IsDumpStream(Stream stream) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int Dump(Stream stream, int baseAddress, bool hasUpvalues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddSymbolToMap(Dictionary<SymbolRef, int> symbolMap, SymbolRef s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int Undump(Stream stream, int sourceID, Table envTable, out bool hasUpvalues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Coroutine_Create(MoonSharp.Interpreter.Closure closure) => throw null;

    public CoroutineState State
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Coroutine AssociatedCoroutine
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Coroutine_Resume(DynValue[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Instruction FindMeta(ref int baseAddress) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void AttachDebugger(IDebugger debugger) => throw null;

    internal bool DebuggerEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ListenDebugger(Instruction instr, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetBreakPoints(DebuggerAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ToggleBreakPoint(DebuggerAction action, bool? state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshDebugger(bool hard, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<WatchItem> Debugger_RefreshThreads(ScriptExecutionContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<WatchItem> Debugger_RefreshVStack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<WatchItem> Debugger_RefreshWatches(
      ScriptExecutionContext context,
      List<DynamicExpression> watchList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<WatchItem> Debugger_RefreshLocals(ScriptExecutionContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private WatchItem Debugger_RefreshWatch(
      ScriptExecutionContext context,
      DynamicExpression dynExpr)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal List<WatchItem> Debugger_GetCallStack(SourceRef startingRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SourceRef GetCurrentSourceRef(int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillDebugData(InterpreterException ex, int ip) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Table GetMetatable(DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynValue GetMetamethod(DynValue value, string metamethod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynValue GetMetamethodRaw(DynValue value, string metamethod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Script GetScript() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue Processing_Loop(int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal string PerformMessageDecorationBeforeUnwind(
      DynValue messageHandler,
      string decoratedMessage,
      SourceRef sourceRef)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AssignLocal(SymbolRef symref, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecStoreLcl(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecStoreUpv(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecSwap(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue GetStoreValue(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecClosure(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue GetUpvalueSymbol(SymbolRef s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecMkTuple(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecToNum(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecIterUpd(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecExpTuple(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecIterPrep(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecJFor(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecIncr(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecCNot(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecNot(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecBeginFn(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CallStackItem PopToBasePointer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int PopExecStackAndCheckVStack(int vstackguard) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IList<DynValue> CreateArgsListForFunctionCall(int numargs, int offsFromTop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecArgs(Instruction I) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int Internal_ExecCall(
      int argsCount,
      int instructionPtr,
      CallbackFunction handler = null,
      CallbackFunction continuation = null,
      bool thisCall = false,
      string debugText = null,
      DynValue unwindHandler = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int PerformTCO(int instructionPtr, int argsCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecRet(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int Internal_CheckForTailRequests(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int JumpBool(Instruction i, bool expectedValueForJump, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecShortCircuitingOperator(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecAdd(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecSub(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecMul(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecMod(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecDiv(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecPower(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecNeg(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecEq(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecLess(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecLessEq(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecLen(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecConcat(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecTblInitI(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecTblInitN(Instruction i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecIndexSet(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecIndex(Instruction i, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearBlockData(Instruction I) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetGenericSymbol(SymbolRef symref) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue GetGlobalSymbol(DynValue dynValue, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGlobalSymbol(DynValue dynValue, string name, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssignGenericSymbol(SymbolRef symref, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CallStackItem GetTopNonClrFunction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef FindSymbolByName(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue[] Internal_AdjustTuple(IList<DynValue> values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int Internal_InvokeUnaryMetaMethod(DynValue op1, string eventName, int instructionPtr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int Internal_InvokeBinaryMetaMethod(
      DynValue l,
      DynValue r,
      string eventName,
      int instructionPtr,
      DynValue extraPush = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue[] StackTopToArray(int items, bool pop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue[] StackTopToArrayReverse(int items, bool pop) => throw null;

    private class DebugContext
    {
      public bool DebuggerEnabled;
      public IDebugger DebuggerAttached;
      public DebuggerAction.ActionType DebuggerCurrentAction;
      public int DebuggerCurrentActionTarget;
      public SourceRef LastHlRef;
      public int ExStackDepthAtStep;
      public List<SourceRef> BreakPoints;
      public bool LineBasedBreakPoints;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DebugContext() => throw null;
    }
  }
}
