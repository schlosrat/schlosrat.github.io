// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.InterpreterException
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [Serializable]
  public class InterpreterException : Exception
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected InterpreterException(Exception ex, string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected InterpreterException(Exception ex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected InterpreterException(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected InterpreterException(string format, params object[] args) => throw null;

    public int InstructionPtr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] internal set => throw null;
    }

    public IList<WatchItem> CallStack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] internal set => throw null;
    }

    public string DecoratedMessage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] internal set => throw null;
    }

    public bool DoNotDecorateMessage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DecorateMessage(Script script, SourceRef sref, int ip = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Rethrow() => throw null;
  }
}
