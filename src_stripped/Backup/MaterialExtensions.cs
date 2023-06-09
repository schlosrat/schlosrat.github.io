﻿// Decompiled with JetBrains decompiler
// Type: MaterialExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public static class MaterialExtensions
{
  private const string _convertToPBRSafeColorSampler = "Material Extensions - Convert Color to PBR Safe Color";
  private static float _fallbackPbrValueMin;
  private static float _fallbackPbrValueMax;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetPBRSafeColor(this Material material, string name, Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetPBRSafeColor(this Material material, int nameID, Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Color ConvertToPBRSafeColor(Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static MaterialExtensions() => throw null;
}
