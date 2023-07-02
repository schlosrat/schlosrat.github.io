// Decompiled with JetBrains decompiler
// Type: KSP.OAB.SearchQueryRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class SearchQueryRunner
  {
    private int tokenIndex;
    private string query;
    private SearchQueryRunner.QueryTokenizer tokenizer;
    private List<SearchQueryRunner.Token> tokens;
    private Func<string, bool> evaluator;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static List<SearchQueryRunner.Token> SanitizeTokens(
      IEnumerable<SearchQueryRunner.Token> inputs)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ParseQuery(string query) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SearchQueryRunner.SearchResult Evaluate(Func<string, bool> evaluator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Expression() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Statement1() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Statement2() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Accept(SearchQueryRunner.TokenType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Expect(SearchQueryRunner.TokenType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SearchQueryRunner() => throw null;

    private class ExampleSearchQueryProgram
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Main() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ExampleSearchQueryProgram() => throw null;

      private class Test
      {
        public string name;
        public string description;
        public string category;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Test(string name, string description, string category) => throw null;
      }
    }

    public enum SearchResult
    {
      ResultTrue,
      ResultFalse,
      Exception,
    }

    protected enum TokenType
    {
      OpenParen,
      CloseParen,
      BooleanAnd,
      BooleanOr,
      UnaryNot,
      Literal,
      WhiteSpace,
      None,
    }

    protected class Token
    {
      public SearchQueryRunner.TokenType type;
      public int startIndex;
      public int length;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Token(SearchQueryRunner.TokenType type) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Token(SearchQueryRunner.TokenType type, int startIndex, int endIndex) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string GetValue(string query) => throw null;
    }

    protected class QueryTokenizer
    {
      private static Dictionary<string, SearchQueryRunner.QueryTokenizer.TokenMapInfo> tokenMap;
      private string query;
      private int index;
      private int lastIndex;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public List<SearchQueryRunner.Token> Tokenize(string query) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool GetMappedToken(
        int curIndex,
        out SearchQueryRunner.TokenType token,
        out int nextIndex)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void SkipWhiteSpace() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool IsWhitespace(int curIndex) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private SearchQueryRunner.QueryTokenizer.TokenMapInfo GetTokenInfo(int curIndex) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public QueryTokenizer() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static QueryTokenizer() => throw null;

      private class TokenMapInfo
      {
        public SearchQueryRunner.TokenType type;
        public bool needWhitespaceLeft;
        public bool needWhitespaceRight;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public TokenMapInfo(SearchQueryRunner.TokenType type, bool needWhitespace = true) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public TokenMapInfo(
          SearchQueryRunner.TokenType type,
          bool needWhitespaceLeft,
          bool needWhitespaceRight)
        {
          throw null;
        }
      }
    }
  }
}
