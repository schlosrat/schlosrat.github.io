// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Light
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Light/LightSwitch")]
    [HideInInspector]
    public ModuleProperty<bool> isLightEnabled;
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 2)]
    [SteppedRange(0.0f, 1f, 0.01f)]
    [HideInInspector]
    [LocalizedField("PartModules/Light/ColorR")]
    public ModuleProperty<float> lightColorR;
    [LocalizedField("PartModules/Light/ColorG")]
    [KSPState(CopyToSymmetrySet = true)]
    [SteppedRange(0.0f, 1f, 0.01f)]
    [PAMDisplayControl(SortIndex = 3)]
    [HideInInspector]
    public ModuleProperty<float> lightColorG;
    [LocalizedField("PartModules/Light/ColorB")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 4)]
    [SteppedRange(0.0f, 1f, 0.01f)]
    [HideInInspector]
    public ModuleProperty<float> lightColorB;
    [LocalizedField("PartModules/Light/LightEmission")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 8)]
    [HideInInspector]
    public ModuleProperty<bool> castLight;
    [LocalizedField("PartModules/Light/BlinkOn")]
    [PAMDisplayControl(SortIndex = 9)]
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> isBlinkEnabled;
    [LocalizedField("PartModules/Light/BlinkRate")]
    [SteppedRange(0.2f, 2f, 0.1f)]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 10)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<float> blinkRate;
    [SteppedRange(0.0f, 360f, 5f)]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 5)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Light/RotationAngle")]
    public ModuleProperty<float> rotationAngle;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Light/PitchAngle")]
    [PAMDisplayControl(SortIndex = 6)]
    [HideInInspector]
    [SteppedRange(0.0f, 360f, 5f)]
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
    [KSPDefinition]
    [Header("Default PAM values")]
    [Tooltip("Default of whether the light is on when pulled out of the editor")]
    public bool IsOn;
    [KSPDefinition]
    [Tooltip("Default red component of the light color")]
    public float LightR;
    [Tooltip("Default green component of the light color")]
    [KSPDefinition]
    public float LightG;
    [Tooltip("Default blue component of the light color")]
    [KSPDefinition]
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
