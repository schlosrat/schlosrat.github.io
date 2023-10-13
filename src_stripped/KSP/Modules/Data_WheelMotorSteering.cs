// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelMotorSteering
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
