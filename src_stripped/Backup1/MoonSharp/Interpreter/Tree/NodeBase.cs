// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.NodeBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree
{
  internal abstract class NodeBase
  {
    public Script Script
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    protected ScriptLoadingContext LoadingContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NodeBase(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static Token UnexpectedTokenType(Token t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static Token CheckTokenType(
      ScriptLoadingContext lcontext,
      TokenType tokenType1,
      TokenType tokenType2)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static Token CheckTokenType(
      ScriptLoadingContext lcontext,
      TokenType tokenType1,
      TokenType tokenType2,
      TokenType tokenType3)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static void CheckTokenTypeNotNext(ScriptLoadingContext lcontext, TokenType tokenType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static Token CheckMatch(
      ScriptLoadingContext lcontext,
      Token originalToken,
      TokenType expectedTokenType,
      string expectedTokenText)
    {
      throw null;
    }
  }
}
