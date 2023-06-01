// Decompiled with JetBrains decompiler
// Type: LingoonaGrammarExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

public static class LingoonaGrammarExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeNoun(
    this string input,
    LingoonaGrammarExtensions.Gender gender,
    bool isProperNoun)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeRemoveGender(this string input) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeName(this string input, LingoonaGrammarExtensions.Gender gender) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeNameMale(this string input) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeNameFemale(this string input) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeNameNeutral(this string input) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeCommonNoun(
    this string input,
    LingoonaGrammarExtensions.Gender gender)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeCommonNounMale(this string input) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeCommonNounFemale(this string input) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string LocalizeCommonNounNeutral(this string input) => throw null;

  public enum Gender
  {
    Male,
    Female,
    Neutral,
  }
}
