// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Wind.HDWindController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem.Wind
{
  public class HDWindController : IWindController
  {
    private WindControllerSettings _windControllerSettings;
    public float WindSpeed;
    public float Turbulence;
    public Texture2D NoiseTexture;
    public float FlexNoiseWorldSize;
    public float ShiverNoiseWorldSize;
    public Texture2D GustMaskTexture;
    public float GustWorldSize;
    public float GustSpeed;
    public float GustScale;
    private readonly int _windSettingsTexNoise;
    private readonly int _windSettingsTexGust;
    private readonly int _windSettingsWorldDirectionAndSpeed;
    private readonly int _windSettingsFlexNoiseScale;
    private readonly int _windSettingsShiverNoiseScale;
    private readonly int _windSettingsTurbulence;
    private readonly int _windSettingsGustSpeed;
    private readonly int _windSettingsGustScale;
    private readonly int _windSettingsGustWorldScale;

    public string WindControlerID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public WindControllerSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HDWindController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WindControllerSettings CreateDefaultSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateWind(WindZone windZone, float windSpeedFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector4 GetDirectionAndSpeed(WindZone windZone, float windSpeedFactor) => throw null;
  }
}
