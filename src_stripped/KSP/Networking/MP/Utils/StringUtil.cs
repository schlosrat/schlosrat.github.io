// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.StringUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Networking.MP.Utils
{
  public static class StringUtil
  {
    public static string DEFAULT_UBER_STRING_SEPERATOR_CHARACTER_STRING;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void StringBuilderAppendAbbrevNameValuePair(
      StringBuilder stringBuilder,
      bool abbrev,
      string nameNormal,
      string nameAbbrev,
      string val)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDebugPlayerIdString(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string JustifyAndPadString(StringUtil.Justify justify, int size, string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetLevelString(int level, string str = " ") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Matches(string s1, string s2, bool matchIfTwoNulls = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string BuildTabString(string tab, int level) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDoubleQuotedStringValueOrNull(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDebugPlayerIdNameAndGuidString(
      StringUtil.PlayerNameFlag playerNameFlags,
      byte playerId,
      string playerNameString,
      string playerGuidString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string RemoveSurroundingParends(string src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ContainsMultilineCharacters(string line) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string RemoveMultilineCharacters(string line) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string RemoveHTMLTags(string sourceString, out int numTagsRemovedOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string RemoveHTMLTags(string sourceString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConcatString(string str1, string str2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConcatString(string str1, string str2, string str3) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConcatString(string str1, string str2, string str3, string str4) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConcatString(
      string str1,
      string str2,
      string str3,
      string str4,
      string str5)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConcatString(
      string str1,
      string str2,
      string str3,
      string str4,
      string str5,
      string str6,
      params string[] stringParams)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> UberStringToStringList(string uberString, string seperatorString = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string StringListToUberString(List<string> stringList, string seperatorString = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string RemoveUberStringMatches(string src, string matches) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StringBuilderRemoveEnding(
      StringBuilder stringBuilder,
      string endingString,
      bool caseSensitive = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsCharSpaceTabNewLine(char ch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> TruncateStringListForReadability(
      List<string> srcList,
      int numCharsPerLineMax)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SaveStringToPasswordString(
      string saveString,
      out string passwordStringOut,
      string scrambleKeyString,
      string machineNameString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PasswordStringToSaveString(
      string passwordString,
      out string saveStringOut,
      string scrambleKeyString,
      string machineNameString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToLowerCamelCase(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static StringUtil() => throw null;

    [Flags]
    public enum PlayerNameFlag
    {
      None = 0,
      IncludePlayerId = 1,
      IncludePlayerNameString = 2,
      IncludePlayerGuidString = 4,
      ExcludePlayerIdIfNone = 8,
      Default = ExcludePlayerIdIfNone | IncludePlayerGuidString | IncludePlayerNameString | IncludePlayerId, // 0x0000000F
    }

    public enum Justify
    {
      Left,
      Right,
      Center,
    }
  }
}
