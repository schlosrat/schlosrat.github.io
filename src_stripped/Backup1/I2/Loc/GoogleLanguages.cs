// Decompiled with JetBrains decompiler
// Type: I2.Loc.GoogleLanguages
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public static class GoogleLanguages
  {
    public static Dictionary<string, GoogleLanguages.LanguageCodeDef> mLanguageDef;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetLanguageCode(string Filter, bool ShowWarnings = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool LanguageMatchesFilter(string Language, string[] Filters) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetFormatedLanguageName(string Language) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetCodedLanguage(string Language, string code) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnPackCodeFromLanguageName(
      string CodedLanguage,
      out string Language,
      out string code)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetGoogleLanguageCode(string InternationalCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetLanguageName(
      string code,
      bool useParenthesesForRegion = false,
      bool allowDiscardRegion = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> GetAllInternationalCodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LanguageCode_HasJoinedWord(string languageCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GetPluralRule(string langCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LanguageHasPluralType(string langCode, string pluralType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ePluralType GetPluralType(string langCode, int n) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetPluralTestNumber(string langCode, ePluralType pluralType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool inRange(int amount, int min, int max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GoogleLanguages() => throw null;

    public struct LanguageCodeDef
    {
      public string Code;
      public string GoogleCode;
      public bool HasJoinedWords;
      public int PluralRule;
    }
  }
}
