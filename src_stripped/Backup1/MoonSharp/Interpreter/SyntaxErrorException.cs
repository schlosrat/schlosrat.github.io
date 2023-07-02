// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.SyntaxErrorException
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
