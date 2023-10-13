// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_LitPart
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
  public sealed class Data_LitPart : ModuleData
  {
    [KSPState]
    [LocalizedField("PartModules/LitPart/LightEnabled")]
    [PAMDisplayControl(SortIndex = 1)]
    public ModuleProperty<bool> LightToggle;
    [KSPState]
    [HideInInspector]
    public bool HasEnoughResources;
    [Tooltip("Names of the gameObject that should be affected by the light state")]
    [KSPDefinition]
    public List<string> LightObjectNames;
    [Tooltip("Names of the materials that should be affected by the light state")]
    [KSPDefinition]
    public List<string> LightMaterialNames;
    [Tooltip("The duration of the on/off transition in seconds. The gradient in colorGradient will be applied over this duration.")]
    [KSPDefinition]
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
    [KSPDefinition]
    [Tooltip("Green component colors of the gradient mapping the color transition")]
    public FloatCurve BlueColorGradient;
    [KSPDefinition]
    [Tooltip("Alpha component colors of the gradient mapping the color transition")]
    public FloatCurve AlphaColorGradient;
    [KSPDefinition]
    [Tooltip("Action group set by default")]
    public KSPActionGroup DefaultActionGroup;
    [KSPDefinition]
    [Tooltip("Whether the light starts enabled or not")]
    public bool DefaultEnabledState;
    [KSPDefinition]
    [Tooltip("The resource for determining if lights are on. If not specificed, no resource is tracked and lights will always stay on")]
    public string RequiredResourceName;
    [Tooltip("The minimum amount needed to keep the lights on")]
    [KSPDefinition]
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
