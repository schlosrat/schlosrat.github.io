// Decompiled with JetBrains decompiler
// Type: BlendPrefabLightmapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class BlendPrefabLightmapData : MonoBehaviour
{
  public PrefabLightmapDataObject dayData;
  public PrefabLightmapDataObject eveningData;
  public PrefabLightmapDataObject nightData;
  private RendererInfo[] _rendererInfo;
  private SphericalHarmonicsL2 _probeA;
  private SphericalHarmonicsL2 _probeB;
  [Range(-1f, 1f)]
  public float _debugTimeOfDay;
  private bool _dayDataSet;
  private bool _nightDataSet;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ChangeActiveLightmapData(
    PrefabLightmapDataObject dataA,
    PrefabLightmapDataObject dataB)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public BlendPrefabLightmapData() => throw null;
}
