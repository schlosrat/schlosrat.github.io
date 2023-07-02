// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.AtmosphereScatterManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
  public class AtmosphereScatterManager : MonoBehaviour
  {
    private GameInstance Game;
    private PrevisGameInstance PrevisGame;
    private bool previsScene;
    public GraphicsManager GraphicsManager;
    public LightingSystem LightingSystem;
    private MapProvider _mapProvider;
    private MapCore _mapCore;
    [SerializeField]
    private Shader _scaledAtmosphereShader;
    [SerializeField]
    private Shader _postAtmosphereShader;
    [SerializeField]
    private bool _postEnabled;
    private bool _initialized;
    private Dictionary<string, AtmosphereScatterManager.AtmosphereModelReference> _loadedModels;
    private Mesh _fullScreenQuad;
    private AtmosphereScatterManager.ActivePostEffectData _postData;
    private PQS _currentPqs;
    private bool _inFlightView;
    private bool _inMapView;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(LightingSystem lightingSystem, bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Shader GetScaledAtmosphereShader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMapEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapCamera GetMapCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindLocalAtmosphereDataToMaterial(Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCelestialBodyLoaded(string bodyName, AtmosphereDataModelComponent atmoComp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCelestialBodyRemoved(string bodyName, AtmosphereDataModelComponent atmoComp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCameraPQSChanged(string bodyName, PQS pqsRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapCelestialBodyLoaded(string bodyName, AtmosphereDataModelComponent atmoComp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapCelestialBodyRemoved(string bodyName, AtmosphereDataModelComponent atmoComp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapInitialized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFlightViewEntered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFlightViewExited() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShouldRenderAtmosphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateFullscreenQuad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryAddAtmosphereModelReference(
      string key,
      AtmosphereDataModelComponent comp,
      bool inMap = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryUnloadAtmosphereModelReference(
      string key,
      AtmosphereScatterManager.AtmosphereModelReference modelRef)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadAtmosphereModelAsset(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseAtmosphereModelAsset(AtmosphereModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAndRenderPostEffect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAtmosphereModelLoaded(AtmosphereModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AtmosphereScatterManager() => throw null;

    [Serializable]
    private class AtmosphereModelReference
    {
      public string ModelKey;
      public AtmosphereModel Model;
      public HashSet<AtmosphereDataModelComponent> ComponentRefs;
      public int ReferenceCount;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AtmosphereModelReference() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool IsModelLoaded() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool HasComponentReferences() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddComponentReference(AtmosphereDataModelComponent comp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveComponentReference(AtmosphereDataModelComponent comp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateComponentModelReferences() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Clear() => throw null;
    }

    [Serializable]
    private struct ActivePostEffectData
    {
      public string Key;
      public AtmosphereModel DataModel;
      public Material Material;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Clear() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Cleanup() => throw null;
    }
  }
}
