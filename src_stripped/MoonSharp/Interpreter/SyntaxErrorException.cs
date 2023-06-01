// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.SyntaxErrorException
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Tree;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [Serializable]
  public class SyntaxErrorException : InterpreterException
  {
    internal Token Token
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsPrematureStreamTermination
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SyntaxErrorException(Token t, string format, params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SyntaxErrorException(Token t, string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SyntaxErrorException(
      Script script,
      SourceRef sref,
      string format,
      params object[] args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SyntaxErrorException(Script script, SourceRef sref, string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SyntaxErrorException(SyntaxErrorException syntaxErrorException) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DecorateMessage(Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Rethrow() => throw null;
  }
}
