// Decompiled with JetBrains decompiler
// Type: AeroUtilities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class AeroUtilities
{
  public const double CONVERT_KPA_TO_PA = 1000.0;
  public const double MIN_ATM_DENSITY = 1E-07;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static double GetSoundSpeed(
    double atmosphereAdiabaticIndex,
    double staticPressurekPa,
    double atmDensity)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float GetDynamicPressure(Vector3 velocity, double density) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AeroUtilities() => throw null;
}
