// Decompiled with JetBrains decompiler
// Type: I2.Loc.LocalizationReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace I2.Loc
{
  public class LocalizationReader
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Dictionary<string, string> ReadTextAsset(TextAsset asset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TextAsset_ReadLine(
      string line,
      out string key,
      out string value,
      out string category,
      out string comment,
      out string termType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ReadCSVfile(string Path, Encoding encoding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string[]> ReadCSV(string Text, char Separator = ',') => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string[] ParseCSVline(string Line, ref int iStart, char Separator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AddCSVtoken(
      ref List<string> list,
      ref string Line,
      int iEnd,
      ref int iWordStart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string[]> ReadI2CSV(string Text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ValidateFullTerm(ref string Term) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string EncodeString(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string DecodeString(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizationReader() => throw null;
  }
}
