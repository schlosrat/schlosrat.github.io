// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelMotorSteering
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_WheelMotorSteering : ModuleData
  {
    [KSPDefinition]
    [Tooltip("This is the steering torque")]
    public float SteeringTorque;
    [LocalizedField("PartModules/Wheels/SteeringEnabled")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> SteeringEnabled;
    [LocalizedField("PartModules/Wheels/SteeringDirection")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> SteeringInverted;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSteeringEnabledString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSteeringInvertedString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelMotorSteering() => throw null;
  }
}
