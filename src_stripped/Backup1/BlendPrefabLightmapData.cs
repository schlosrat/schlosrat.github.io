// Decompiled with JetBrains decompiler
// Type: BlendPrefabLightmapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
