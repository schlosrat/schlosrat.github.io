﻿// Decompiled with JetBrains decompiler
// Type: LingoonaGrammarExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
