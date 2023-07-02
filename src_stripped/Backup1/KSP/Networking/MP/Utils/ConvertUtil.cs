// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.ConvertUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    public static int ConvertStringToInt32(string str, int defaultVal = 0) => throw null;

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
    public static bool ConvertStringToColor(string str, out Color colorOut) => throw null;

    public enum ColorToStringFlag
    {
      None = 0,
      AddParends = 1,
      Abbrev = 2,
      ExcludeAlpha = 4,
      Pretty = 6,
    }
  }
}
