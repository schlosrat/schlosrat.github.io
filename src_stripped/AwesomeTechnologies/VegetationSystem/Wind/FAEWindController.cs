// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Wind.FAEWindController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem.Wind
{
  public class FAEWindController : IWindController
  {
    private WindControllerSettings _windControllerSettings;
    public Texture2D WindVectors;
    public float WindSpeed;
    public float WindStrength;
    public float WindAmplitude;
    public float TrunkWindSpeed;
    public float TrunkWindWeight;
    public float TrunkWindSwinging;
    private readonly int _windVectors;
    private readonly int _windSpeed;
    private readonly int _windStrength;
    private readonly int _windAmplitude;
    private readonly int _windDirection;
    private readonly int _trunkWindSpeed;
    private readonly int _trunkWindWeight;
    private readonly int _trunkWindSwinging;

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
    public FAEWindController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WindControllerSettings CreateDefaultSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateWind(WindZone windZone, float windSpeedFactor) => throw null;
  }
}
