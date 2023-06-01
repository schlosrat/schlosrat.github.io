// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.TractionControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class TractionControl
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetMaxEngineRpm(
      VehicleBase vehicle,
      TractionControl.Settings settings,
      int wheelIndexL,
      int wheelIndexR,
      float finalRatio)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetMaxEngineRpm(
      VehicleBase vehicle,
      TractionControl.Settings settings,
      int wheelIndexL,
      int wheelIndexR,
      float finalRatio,
      float maxEngineRpm)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TractionControl() => throw null;

    public enum Mode
    {
      Street,
      Sport,
      CustomSlip,
    }

    [Serializable]
    public class Settings
    {
      public bool enabled;
      public TractionControl.Mode mode;
      [Range(0.0f, 1f)]
      public float ratio;
      public float customSlip;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
