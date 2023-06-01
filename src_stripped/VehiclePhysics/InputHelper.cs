// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.InputHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class InputHelper
  {
    public InputHelper.Settings settings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetThrottleInput(float throttlePosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetBrakePressure(float brakePosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetClutchInput(float clutchPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputHelper() => throw null;

    [Serializable]
    public class Settings
    {
      [Range(0.1f, 3f)]
      public float throttleShape;
      [Range(0.1f, 3f)]
      public float brakeShape;
      public float brakeToPressureGain;
      [Range(0.0f, 2f)]
      public float clutchShape;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
