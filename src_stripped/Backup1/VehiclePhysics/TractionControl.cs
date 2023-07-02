// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.TractionControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
