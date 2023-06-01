// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelBrakes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_WheelBrakes : ModuleData
  {
    [Tooltip("The maximum brake torque that the brakes can apply.")]
    [KSPDefinition]
    public float MaxBrakeTorque;
    [Tooltip("The brake response time to full brake force being applied in seconds.")]
    [KSPDefinition]
    public float BrakeResponse;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Wheels/Brakes")]
    [PAMDisplayControl(SortIndex = 11)]
    [SteppedRange(0.0f, 200f, 1f)]
    public ModuleProperty<float> BrakeTweakable;
    [KSPState]
    [HideInInspector]
    public float BrakeInput;
    [PAMDisplayControl(ExcludeFromContext = true)]
    public ModuleProperty<bool> IsBraking;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetBrakeString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetTorqueStrings(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelBrakes() => throw null;
  }
}
