// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_LitPart
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
  public sealed class Data_LitPart : ModuleData
  {
    [KSPState]
    [LocalizedField("PartModules/LitPart/LightEnabled")]
    [PAMDisplayControl(SortIndex = 1)]
    public ModuleProperty<bool> LightToggle;
    [HideInInspector]
    [KSPState]
    public bool HasEnoughResources;
    [Tooltip("Names of the gameObject that should be affected by the light state")]
    [KSPDefinition]
    public List<string> LightObjectNames;
    [KSPDefinition]
    [Tooltip("Names of the materials that should be affected by the light state")]
    public List<string> LightMaterialNames;
    [KSPDefinition]
    [Tooltip("The duration of the on/off transition in seconds. The gradient in colorGradient will be applied over this duration.")]
    public float Duration;
    [HideInInspector]
    public List<Vector4> ColorGradientColors;
    [HideInInspector]
    public List<float> ColorGradientTimes;
    [KSPDefinition]
    [Tooltip("Red component colors of the gradient mapping the color transition")]
    public FloatCurve RedColorGradient;
    [KSPDefinition]
    [Tooltip("Blue component colors of the gradient mapping the color transition")]
    public FloatCurve GreenColorGradient;
    [Tooltip("Green component colors of the gradient mapping the color transition")]
    [KSPDefinition]
    public FloatCurve BlueColorGradient;
    [Tooltip("Alpha component colors of the gradient mapping the color transition")]
    [KSPDefinition]
    public FloatCurve AlphaColorGradient;
    [Tooltip("Action group set by default")]
    [KSPDefinition]
    public KSPActionGroup DefaultActionGroup;
    [Tooltip("Whether the light starts enabled or not")]
    [KSPDefinition]
    public bool DefaultEnabledState;
    [Tooltip("The resource for determining if lights are on. If not specificed, no resource is tracked and lights will always stay on")]
    [KSPDefinition]
    public string RequiredResourceName;
    [KSPDefinition]
    [Tooltip("The minimum amount needed to keep the lights on")]
    public float RequiredResourceThreshold;
    [KSPDefinition]
    [Tooltip("HDR color intensity multiplier for the emissive")]
    public float LightIntensityMultiplier;
    [HideInInspector]
    public float CurrentLightIntensity;
    [HideInInspector]
    public float TargetLightIntensity;
    [HideInInspector]
    public float DurationMultiplier;
    [HideInInspector]
    public bool IsTransitioning;
    [HideInInspector]
    public float Interpolation;
    [HideInInspector]
    [KSPState]
    public bool LightStateOnBlackout;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_LitPart() => throw null;
  }
}
