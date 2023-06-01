// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Gimbal
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
  public sealed class Data_Gimbal : ModuleData
  {
    [LocalizedField("PartModules/Gimbal/IsEnabled")]
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<bool> isEnabled;
    [LocalizedField("PartModules/Gimbal/Limiter")]
    [PAMDisplayControl(SortIndex = 4)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [SteppedRange(0.0f, 100f, 1f)]
    public ModuleProperty<float> gimbalLimiter;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Gimbal/PitchEnabled")]
    [PAMDisplayControl(SortIndex = 5)]
    public ModuleProperty<bool> enablePitch;
    [LocalizedField("PartModules/Gimbal/YawEnabled")]
    [PAMDisplayControl(SortIndex = 6)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<bool> enableYaw;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Gimbal/RollEnabled")]
    [PAMDisplayControl(SortIndex = 7)]
    public ModuleProperty<bool> enableRoll;
    [LocalizedField("PartModules/Gimbal/AdvancedSettings")]
    [PAMDisplayControl(SortIndex = 3)]
    [HideInInspector]
    public ModuleProperty<bool> IsAdvancedSettingsShown;
    [KSPDefinition]
    public string gimbalTransformName;
    [KSPDefinition]
    public float gimbalRange;
    [KSPDefinition]
    public float gimbalResponseSpeed;
    [KSPDefinition]
    public bool useGimbalResponseSpeed;
    [KSPDefinition]
    public float gimbalRangeXP;
    [KSPDefinition]
    public float gimbalRangeXN;
    [KSPDefinition]
    public float gimbalRangeYP;
    [KSPDefinition]
    public float gimbalRangeYN;
    [KSPDefinition]
    public float minRollOffset;
    [KSPDefinition]
    public float xMult;
    [KSPDefinition]
    public float yMult;
    [KSPDefinition]
    public string pitchValueName;
    [KSPDefinition]
    public bool flipAnimatedPitchAxis;
    [KSPDefinition]
    public string yawValueName;
    [KSPDefinition]
    public bool flipAnimatedYawAxis;
    [KSPDefinition]
    public float movementAudioThreshold;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetLimiterString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetVectorRangeString(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Gimbal() => throw null;
  }
}
