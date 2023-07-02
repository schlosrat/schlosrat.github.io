// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.InputHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
