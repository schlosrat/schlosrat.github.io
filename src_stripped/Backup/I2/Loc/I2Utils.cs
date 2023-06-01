// Decompiled with JetBrains decompiler
// Type: I2.Loc.I2Utils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
  public static class I2Utils
  {
    public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
    public const string NumberChars = "0123456789";
    public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ReverseText(string source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string RemoveNonASCII(string text, bool allowCategory = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetValidTermName(string text, bool allowCategory = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string SplitLine(string line, int maxCharacters) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string RemoveTags(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RemoveResourcesPath(ref string sPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPlaying() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPath(this Transform tr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Transform FindObject(string objectPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Transform FindObject(Scene scene, string objectPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Transform FindObject(Transform root, string objectPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static H FindInParents<H>(Transform tr) where H : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetCaptureMatch(Match match) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SendWebRequest(UnityWebRequest www) => throw null;
  }
}
