// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Gimbal
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
  public sealed class Data_Gimbal : ModuleData
  {
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Gimbal/IsEnabled")]
    [PAMDisplayControl(SortIndex = 2)]
    public ModuleProperty<bool> isEnabled;
    [LocalizedField("PartModules/Gimbal/Limiter")]
    [PAMDisplayControl(SortIndex = 4)]
    [SteppedRange(0.0f, 100f, 1f)]
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<float> gimbalLimiter;
    [PAMDisplayControl(SortIndex = 5)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [LocalizedField("PartModules/Gimbal/PitchEnabled")]
    public ModuleProperty<bool> enablePitch;
    [PAMDisplayControl(SortIndex = 6)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [LocalizedField("PartModules/Gimbal/YawEnabled")]
    public ModuleProperty<bool> enableYaw;
    [LocalizedField("PartModules/Gimbal/RollEnabled")]
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 7)]
    public ModuleProperty<bool> enableRoll;
    [HideInInspector]
    [LocalizedField("PartModules/Gimbal/AdvancedSettings")]
    [PAMDisplayControl(SortIndex = 3)]
    public ModuleProperty<bool> IsAdvancedSettingsShown;
    [KSPDefinition]
    public string gimbalTransformName;
    [KSPDefinition]
    public bool forceProceduralGimbaling;
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
