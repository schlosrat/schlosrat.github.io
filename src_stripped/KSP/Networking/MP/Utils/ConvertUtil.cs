// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.ConvertUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Networking.MP.Utils
{
  public static class ConvertUtil
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertInt32ToString(int intVal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryConvertStringToInt32(
      string str,
      out int valueOut,
      int defaultVal = 0,
      bool verbose = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ConvertStringToInt32(string str, int defaultVal = 0, bool verbose = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertFloatToString(float floatVal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryConvertStringToFloat(
      string str,
      out float valueOut,
      float defaultVal = 0.0f,
      bool verbose = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float ConvertStringToFloat(string str, float defaultVal = 0.0f, bool verbose = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertFloatToDouble(double doubleVal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryConvertStringToDouble(
      string str,
      out double valueOut,
      double defaultVal = 0.0,
      bool verbose = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ConvertStringToDouble(string str, double defaultVal = 0.0, bool verbose = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertBooleanToString(
      bool boolValue,
      BoolVarStringFormat boolVarStringFormat = BoolVarStringFormat.ZeroOrOne)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryConvertStringToBoolean(
      string str,
      out bool booleanVal,
      bool defaultVal,
      bool verbose = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ConvertStringToBoolean(string str, bool defaultVal, bool verbose = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ConvertStringToBoolean(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertGuidToString(Guid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Guid ConvertStringToGuid(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertIGGuidToString(IGGuid igguid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IGGuid ConvertStringToIGGuid(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertVector3ToString(Vector3 vector3) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 ConvertStringToVector3(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertColorToString(
      Color color,
      ConvertUtil.ColorToStringFlag colorToStringFlags)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool ExtractHexByte(string str, ref int indexRef, out byte byteOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ConvertStringToColor(string str, out Color colorOut) => throw null;

    public enum ColorToStringFlag
    {
      None = 0,
      AddParends = 1,
      Abbrev = 2,
      ExcludeAlpha = 4,
      Pretty = 6,
      Hex = 8,
    }
  }
}
