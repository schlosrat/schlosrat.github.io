// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Light
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Light : ModuleData
  {
    [LocalizedField("PartModules/Light/LightSwitch")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 1)]
    [HideInInspector]
    public ModuleProperty<bool> isLightEnabled;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 2)]
    [SteppedRange(0.0f, 1f, 0.01f)]
    [LocalizedField("PartModules/Light/ColorR")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<float> lightColorR;
    [LocalizedField("PartModules/Light/ColorG")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 3)]
    [SteppedRange(0.0f, 1f, 0.01f)]
    [HideInInspector]
    public ModuleProperty<float> lightColorG;
    [LocalizedField("PartModules/Light/ColorB")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 4)]
    [HideInInspector]
    [SteppedRange(0.0f, 1f, 0.01f)]
    public ModuleProperty<float> lightColorB;
    [LocalizedField("PartModules/Light/LightEmission")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 8)]
    [HideInInspector]
    public ModuleProperty<bool> castLight;
    [HideInInspector]
    [LocalizedField("PartModules/Light/BlinkOn")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 9)]
    public ModuleProperty<bool> isBlinkEnabled;
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 10)]
    [HideInInspector]
    [SteppedRange(0.2f, 2f, 0.1f)]
    [LocalizedField("PartModules/Light/BlinkRate")]
    public ModuleProperty<float> blinkRate;
    [LocalizedField("PartModules/Light/RotationAngle")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 5)]
    [HideInInspector]
    [SteppedRange(0.0f, 360f, 5f)]
    public ModuleProperty<float> rotationAngle;
    [LocalizedField("PartModules/Light/PitchAngle")]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [SteppedRange(0.0f, 360f, 5f)]
    [PAMDisplayControl(SortIndex = 6)]
    public ModuleProperty<float> pitchAngle;
    [LocalizedField("PartModules/Gimbal/AdvancedSettings")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 7)]
    [HideInInspector]
    public ModuleProperty<bool> IsAdvancedControlsShown;
    [HideInInspector]
    [KSPDefinition]
    public bool isSmoothTransitionEnabled;
    [Header("GameObject Config")]
    [KSPDefinition]
    [Tooltip("Name of the mesh renderer for emissive")]
    public string LightMeshRendererName;
    [KSPDefinition]
    [Tooltip("Whether the light consumes resources")]
    public bool useResources;
    [Tooltip("Resource required to operate this module if consumes resources")]
    [KSPDefinition]
    public PartModuleResourceSetting requiredResource;
    [KSPDefinition]
    public float lightBrightenDuration;
    [KSPDefinition]
    public float lightDimDuration;
    [KSPDefinition]
    public bool simpleLightControls;
    [KSPDefinition]
    public bool canRotate;
    [KSPDefinition]
    public bool canPitch;
    [KSPDefinition]
    public Vector3 rotationAxis;
    [KSPDefinition]
    public Vector3 pitchAxis;
    [KSPDefinition]
    public float rotateMin;
    [KSPDefinition]
    public float rotateMax;
    [KSPDefinition]
    public float pitchMin;
    [KSPDefinition]
    public float pitchMax;
    [KSPDefinition]
    public bool canBlink;
    [KSPDefinition]
    public float blinkRateMin;
    [KSPDefinition]
    public float blinkRateMax;
    [Tooltip("Default of whether the light is on when pulled out of the editor")]
    [KSPDefinition]
    [Header("Default PAM values")]
    public bool IsOn;
    [Tooltip("Default red component of the light color")]
    [KSPDefinition]
    public float LightR;
    [KSPDefinition]
    [Tooltip("Default green component of the light color")]
    public float LightG;
    [KSPDefinition]
    [Tooltip("Default blue component of the light color")]
    public float LightB;
    [HideInInspector]
    public bool HasResourcesToOperate;
    public ResourceFlowRequestCommandConfig RequestConfig;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetColorComponentString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAngleString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetBlinkString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

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
    public Data_Light() => throw null;
  }
}
