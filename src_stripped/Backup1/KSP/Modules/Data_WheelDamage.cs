// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_WheelDamage : ModuleData
  {
    [KSPDefinition]
    public float stressTolerance;
    [KSPDefinition]
    public float impactTolerance;
    [KSPDefinition]
    public float deflectionMagnitude;
    [KSPDefinition]
    public float slipMagnitude;
    [KSPDefinition]
    public float deflectionSharpness;
    [KSPDefinition]
    public float slipSharpness;
    [KSPDefinition]
    public string damagedTransformName;
    [KSPDefinition]
    public string undamagedTransformName;
    [KSPDefinition]
    public bool isRepairable;
    [KSPDefinition]
    public float explodeMultiplier;
    [HideInInspector]
    [KSPState]
    public bool isDamaged;
    [KSPDefinition]
    public float impactDamageVelocity;
    [KSPDefinition]
    public string impactDamageColliderName;
    [LocalizedField("PartModules/Wheels/WheelStress")]
    [KSPState]
    [HideInInspector]
    [Range(0.0f, 100f)]
    public ModuleProperty<float> stressPercent;
    [LocalizedField("PartModules/Wheels/Broken")]
    [Range(0.0f, 100f)]
    [KSPState]
    public ModuleProperty<string> brokenStatusWarning;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetWheelStressString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetBrokenStatusString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelDamage() => throw null;
  }
}
