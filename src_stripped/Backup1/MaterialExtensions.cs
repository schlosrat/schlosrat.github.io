// Decompiled with JetBrains decompiler
// Type: MaterialExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
