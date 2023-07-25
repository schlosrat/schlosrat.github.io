﻿// Decompiled with JetBrains decompiler
// Type: PrefabLightmapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrefabLightmapData : MonoBehaviour
{
  [SerializeField]
  public RendererInfo[] rendererInfo;
  [SerializeField]
  public LightInfo[] lightInfo;
  [SerializeField]
  public PrefabLightmapDataObject data;
  public bool addToUnityLightmaps;
  public bool bakeLightingOnPrefabUpdate;
  public Transform ambientProbe;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnSceneLoaded(Scene scene, LoadSceneMode mode) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void ApplyRendererInfo(
    RendererInfo[] infos,
    int[] lightmapOffsetIndex,
    LightInfo[] lightsInfo)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PrefabLightmapData() => throw null;
}
