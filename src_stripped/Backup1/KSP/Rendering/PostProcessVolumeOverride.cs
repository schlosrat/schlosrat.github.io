// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PostProcessVolumeOverride
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
