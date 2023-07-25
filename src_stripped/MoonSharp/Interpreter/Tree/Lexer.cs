// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Lexer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree
{
  internal class Lexer
  {
    private Token m_Current;
    private string m_Code;
    private int m_PrevLineTo;
    private int m_PrevColTo;
    private int m_Cursor;
    private int m_Line;
    private int m_Col;
    private int m_SourceId;
    private bool m_AutoSkipComments;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Lexer(int sourceID, string scriptContent, bool autoSkipComments) => throw null;

    public Token Current
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token FetchNewToken() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Next() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Token PeekNext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CursorNext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private char CursorChar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private char CursorCharNext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CursorMatches(string pattern) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CursorNotEof() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsWhiteSpace(char c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SkipWhiteSpace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token ReadToken() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ReadLongString(
      int fromLine,
      int fromCol,
      string startpattern,
      string subtypeforerrors)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token ReadNumberToken(int fromLine, int fromCol, bool leadingDot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token CreateSingleCharToken(TokenType tokenType, int fromLine, int fromCol) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token ReadHashBang(int fromLine, int fromCol) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token ReadComment(int fromLine, int fromCol) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token ReadSimpleStringToken(int fromLine, int fromCol) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token PotentiallyDoubleCharOperator(
      char expectedSecondChar,
      TokenType singleCharToken,
      TokenType doubleCharToken,
      int fromLine,
      int fromCol)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token CreateNameToken(string name, int fromLine, int fromCol) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Token CreateToken(TokenType tokenType, int fromLine, int fromCol, string text = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ReadNameToken() => throw null;
  }
}
