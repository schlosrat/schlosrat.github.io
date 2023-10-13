// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelBrakes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [HideInInspector]
    [KSPState]
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
