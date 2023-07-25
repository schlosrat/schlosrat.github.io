// Decompiled with JetBrains decompiler
// Type: I2.Loc.GoogleTranslation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine.Networking;

namespace I2.Loc
{
  public static class GoogleTranslation
  {
    private static List<UnityWebRequest> mCurrentTranslations;
    private static List<TranslationJob> mTranslationJobs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanTranslate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Translate(
      string text,
      string LanguageCodeFrom,
      string LanguageCodeTo,
      GoogleTranslation.fnOnTranslated OnTranslationReady)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ForceTranslate(
      string text,
      string LanguageCodeFrom,
      string LanguageCodeTo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Translate(
      Dictionary<string, TranslationQuery> requests,
      GoogleTranslation.fnOnTranslationReady OnTranslationReady,
      bool usePOST = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> ConvertTranslationRequest(
      Dictionary<string, TranslationQuery> requests,
      bool encodeGET)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AddTranslationJob(TranslationJob job) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerator WaitForTranslations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ParseTranslationResult(
      string html,
      Dictionary<string, TranslationQuery> requests)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsTranslating() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CancelCurrentGoogleTranslations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateQueries(
      string text,
      string LanguageCodeFrom,
      string LanguageCodeTo,
      Dictionary<string, TranslationQuery> dict)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateQueries_Plurals(
      string text,
      string LanguageCodeFrom,
      string LanguageCodeTo,
      Dictionary<string, TranslationQuery> dict)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddQuery(
      string text,
      string LanguageCodeFrom,
      string LanguageCodeTo,
      Dictionary<string, TranslationQuery> dict)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetTranslation(
      string text,
      string LanguageCodeTo,
      Dictionary<string, TranslationQuery> dict)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static TranslationQuery FindQueryFromOrigText(
      string origText,
      Dictionary<string, TranslationQuery> dict)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HasParameters(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPluralParameter(string text, bool forceTag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPluralText(string text, string pluralType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int FindClosingTag(string tag, MatchCollection matches, int startIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetGoogleNoTranslateTag(int tagNumber) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ParseNonTranslatableElements(ref TranslationQuery query) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetQueryResult(
      string text,
      string LanguageCodeTo,
      Dictionary<string, TranslationQuery> dict)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string RebuildTranslation(
      string text,
      Dictionary<string, TranslationQuery> dict,
      string LanguageCodeTo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string RebuildTranslation_Plural(
      string text,
      Dictionary<string, TranslationQuery> dict,
      string LanguageCodeTo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string UppercaseFirst(string s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string TitleCase(string s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GoogleTranslation() => throw null;

    public delegate void fnOnTranslated(string Translation, string Error);

    public delegate void fnOnTranslationReady(
      Dictionary<string, TranslationQuery> dict,
      string error);
  }
}
