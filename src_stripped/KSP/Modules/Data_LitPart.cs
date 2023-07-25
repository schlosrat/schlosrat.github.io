// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_LitPart
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
  public sealed class Data_LitPart : ModuleData
  {
    [KSPState]
    [PAMDisplayControl(SortIndex = 1)]
    [LocalizedField("PartModules/LitPart/LightEnabled")]
    public ModuleProperty<bool> LightToggle;
    [KSPState]
    [HideInInspector]
    public bool HasEnoughResources;
    [KSPDefinition]
    [Tooltip("Names of the gameObject that should be affected by the light state")]
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
    [Tooltip("Red component colors of the gradient mapping the color transition")]
    [KSPDefinition]
    public FloatCurve RedColorGradient;
    [Tooltip("Blue component colors of the gradient mapping the color transition")]
    [KSPDefinition]
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
    [KSPDefinition]
    [Tooltip("Whether the light starts enabled or not")]
    public bool DefaultEnabledState;
    [Tooltip("The resource for determining if lights are on. If not specificed, no resource is tracked and lights will always stay on")]
    [KSPDefinition]
    public string RequiredResourceName;
    [Tooltip("The minimum amount needed to keep the lights on")]
    [KSPDefinition]
    public float RequiredResourceThreshold;
    [Tooltip("HDR color intensity multiplier for the emissive")]
    [KSPDefinition]
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
