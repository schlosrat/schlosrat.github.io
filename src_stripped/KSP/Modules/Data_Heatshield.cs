// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Heatshield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Heatshield : ModuleData
  {
    [LocalizedField("PartModules/HeatShield/Status")]
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState]
    public ModuleProperty<string> StatusDisplay;
    [LocalizedField("Ablator")]
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState]
    public ModuleProperty<string> ResourceDisplay;
    [KSPState]
    public bool IsDeployed;
    [KSPState]
    public bool IsAblating;
    public bool HasEnoughResources;
    public float AblatorRatio;
    public double AblatorTonnesPerSecond;
    public double FluxRemoved;
    [HideInInspector]
    [KSPState]
    public HeatshieldStatus CurrentStatus;
    [KSPState]
    public bool IsAblatorExhausted;
    [KSPDefinition]
    public List<PartModuleResourceSetting> requiredResources;
    [KSPDefinition]
    public double AblationTempThreshold;
    [KSPDefinition]
    public double PyrolysisLossFactor;
    [KSPDefinition]
    public float ShieldingScale;
    [KSPDefinition]
    public Vector3 ShieldingDirection;
    [KSPDefinition]
    public float ShieldingDirectionScale;
    [KSPDefinition]
    public bool DisabledWhenRetracted;
    [KSPDefinition]
    public bool UseChar;
    [KSPDefinition]
    public string CharMaterialName;
    [KSPDefinition]
    public float CharMin;
    [KSPDefinition]
    public float CharMax;
    public double AblatorMaxValue;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetResourceStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Heatshield() => throw null;
  }
}
