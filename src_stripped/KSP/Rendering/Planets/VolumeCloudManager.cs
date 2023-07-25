// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.VolumeCloudManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Map;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class VolumeCloudManager : MonoBehaviour
  {
    private GameInstance Game;
    private PrevisGameInstance PrevisGame;
    private bool previsScene;
    public GraphicsManager GraphicsManager;
    public LightingSystem LightingSystem;
    private MapProvider _mapProvider;
    private MapCore _mapCore;
    [SerializeField]
    private Shader _scaledCloudShader;
    [SerializeField]
    private bool _postEnabled;
    private bool _initialized;
    private Dictionary<string, VolumeCloudManager.VolumeCloudModelReference> _loadedModels;
    private Mesh _fullScreenQuad;
    private VolumeCloudManager.ActivePostEffectData _postData;
    private PQS _currentPqs;
    private bool _inFlightView;
    private bool _inMapView;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(LightingSystem lightingSystem, bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Shader GetScaledCloudShader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMapEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapCamera GetMapCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCelestialBodyLoaded(
      string bodyName,
      ScaledCloudDataModelComponent scaledCloudComp)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCelestialBodyRemoved(
      string bodyName,
      ScaledCloudDataModelComponent scaledCloudComp)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCameraPQSChanged(string bodyName, PQS pqsRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapCelestialBodyLoaded(
      string bodyName,
      ScaledCloudDataModelComponent scaledCloudComp)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapCelestialBodyRemoved(
      string bodyName,
      ScaledCloudDataModelComponent scaledCloudComp)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapInitialized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFlightViewEntered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFlightViewExited() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShouldRenderScaledClouds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryAddScaledCloudModelReference(
      string key,
      ScaledCloudDataModelComponent scaledCloudComp,
      bool inMap = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryUnloadCloudModelReference(
      string key,
      VolumeCloudManager.VolumeCloudModelReference modelRef)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMaterials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateScaledClouds(string bodyName, ScaledCloudDataModelComponent scaledCloudComp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnScaledCloudModelLoaded(string bodyName, ScaledCloudConfiguration model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaledCloudDataModelComponent GetScaledCloudDataModel(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumeCloudManager() => throw null;

    [Serializable]
    private class VolumeCloudModelReference
    {
      public ScaledCloudConfiguration Model;
      public List<ScaledCloudDataModelComponent> ComponentRefs;
      public int ReferenceCount;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public VolumeCloudModelReference() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool IsModelLoaded() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool HasComponentReferences() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddComponentReference(ScaledCloudDataModelComponent comp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveComponentReference(ScaledCloudDataModelComponent comp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateComponentModelReferences() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Clear() => throw null;
    }

    [Serializable]
    private struct ActivePostEffectData
    {
      public string Key;
      public ScaledCloudConfiguration DataModel;
      public Material Material;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Clear() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Cleanup() => throw null;
    }
  }
}
