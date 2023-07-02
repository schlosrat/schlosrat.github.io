// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.VM.ByteCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution.VM
{
  internal class ByteCode : RefIdObject
  {
    public List<Instruction> Code;
    private List<SourceRef> m_SourceRefStack;
    private SourceRef m_CurrentSourceRef;
    internal LoopTracker LoopTracker;

    public Script Script
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ByteCode(Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDisposable EnterSource(SourceRef sref) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushSourceRef(SourceRef sref) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PopSourceRef() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dump(string file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetJumpPointForNextInstruction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetJumpPointForLastInstruction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction GetLastInstruction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Instruction AppendInstruction(Instruction c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Nop(string comment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Invalid(string type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Pop(int num = 1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Emit_Call(int argCount, string debugName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Emit_ThisCall(int argCount, string debugName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Literal(DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Jump(OpCode jumpOpCode, int idx, int optPar = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_MkTuple(int cnt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Operator(OpCode opcode) => throw null;

    [Conditional("EMIT_DEBUG_OPS")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Emit_Debug(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Enter(RuntimeScopeBlock runtimeScopeBlock) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Leave(RuntimeScopeBlock runtimeScopeBlock) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Exit(RuntimeScopeBlock runtimeScopeBlock) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Clean(RuntimeScopeBlock runtimeScopeBlock) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Closure(SymbolRef[] symbols, int jmpnum) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Args(params SymbolRef[] symbols) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Ret(int retvals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_ToNum(int stage = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Incr(int i) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_NewTable(bool shared) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_IterPrep() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_ExpTuple(int stackOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_IterUpd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Meta(string funcName, OpCodeMetadataType metaType, DynValue value = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_BeginFn(RuntimeScopeFrame stackFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Scalar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Emit_Load(SymbolRef sym) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Emit_Store(SymbolRef sym, int stackofs, int tupleidx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_TblInitN() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_TblInitI(bool lastpos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Index(DynValue index = null, bool isNameIndex = false, bool isExpList = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_IndexSet(
      int stackofs,
      int tupleidx,
      DynValue index = null,
      bool isNameIndex = false,
      bool isExpList = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Copy(int numval) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Instruction Emit_Swap(int p1, int p2) => throw null;

    private class SourceCodeStackGuard : IDisposable
    {
      private ByteCode m_Bc;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SourceCodeStackGuard(SourceRef sref, ByteCode bc) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Dispose() => throw null;
    }
  }
}
