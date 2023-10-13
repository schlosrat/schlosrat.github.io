// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.InputHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
