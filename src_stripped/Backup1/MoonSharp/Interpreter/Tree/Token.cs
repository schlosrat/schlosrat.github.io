// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Token
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree
{
  internal class Token
  {
    public readonly int SourceId;
    public readonly int FromCol;
    public readonly int ToCol;
    public readonly int FromLine;
    public readonly int ToLine;
    public readonly int PrevCol;
    public readonly int PrevLine;
    public readonly TokenType Type;

    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Token(
      TokenType type,
      int sourceId,
      int fromLine,
      int fromCol,
      int toLine,
      int toCol,
      int prevLine,
      int prevCol)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TokenType? GetReservedTokenType(string reservedWord) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNumberValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEndOfBlock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsUnaryOperator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsBinaryOperator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SourceRef GetSourceRef(bool isStepStop = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SourceRef GetSourceRef(Token to, bool isStepStop = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SourceRef GetSourceRefUpTo(Token to, bool isStepStop = true) => throw null;
  }
}
