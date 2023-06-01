// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.MPConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public static class MPConverter
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IntToString(int intVal, out string stringValOut, string defaultStringVal = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StringToInt(string stringVal, out int intValOut, int defaultIntVal = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool DoubleToString(
      double doubleVal,
      out string stringValOut,
      string defaultStringVal = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StringToDouble(
      string stringVal,
      out double doubleValOut,
      double defaultDoubleVal = 0.0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool BoolToString(bool boolVal, out string stringValOut, string defaultStringVal = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool BoolToStringTF(
      bool boolVal,
      out string stringValOut,
      string defaultStringVal = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool BoolToString01(
      bool boolVal,
      out string stringValOut,
      string defaultStringVal = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StringToBool(string stringVal, out bool boolValOut, bool defaultBoolVal = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool EnumToStringViaValue<T>(
      T enumVal,
      out string stringValOut,
      string defaultStringVal = "")
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool EnumToStringViaLabel<T>(
      T enumVal,
      out string stringValOut,
      string defaultStringVal = "")
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StringToEnum<T>(string stringVal, out T enumValOut, T defaultEnumVal = null) where T : Enum => throw null;
  }
}
