// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PostProcessVolumeOverride
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Rendering
{
  [DisallowMultipleComponent]
  public class PostProcessVolumeOverride : MonoBehaviour
  {
    [SerializeField]
    private PostProcessData data;
    [SerializeField]
    public PostProcessVolume postProcessVolume;
    private PostProcessProfile postProcessProfile;
    private AutoExposure _autoExposure;

    public PostProcessData Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryToggleVolume(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVolumeWeight(float weight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePropertyWeights(float blendValue, CelestialBodyLightingData lightingData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAutoExposure(float blendValue, CelestialBodyLightingData lightingData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessVolumeOverride() => throw null;
  }
}
