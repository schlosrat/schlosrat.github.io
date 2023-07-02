// Decompiled with JetBrains decompiler
// Type: KSP.VFX.ContextualFxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Assets;
using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class ContextualFxSystem : KerbalMonoBehaviour
  {
    private bool _initialized;
    public FXContextData ContextData;
    private AssetProvider _assets;
    [SerializeField]
    private VFXSurfaceMapping _biomeToSurfaceLUT;
    private LRUCache<GameObject> _loadedVFXCache;
    private List<FXContextualEvent> _contextualEvents;
    public static List<string> CONTRAILS_MIXTURES;
    private readonly string VFXGlobalSettingsAssetTag;
    public static VFXGlobalSettings VFXGlobalSettings;
    public FXInstanceAggregator InstanceAggregator;
    private VFXQuality _currentVFXQuality;
    private bool _previsScene;
    public FXContextualEvent LastEvent;
    private ResourceDefinitionDatabase resourceDefinitionDatabase;

    public List<FXContextualEvent> ContextualEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadVFXGlobalSettingsAsset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Tick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateContextData(FXContextData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXSurfaceType GetVFXSurfaceTypeForBiome(PQSData.KSP2BiomeType biome) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXSurfaceType GetSurfaceType(
      Collider hitCollider,
      PartBehavior part,
      Vector3 contactPoint)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool EventEnabled(FXContextualEvent contextualEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsFXTypeEnabled(VFXEventType evtype) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVFXTypeEnabled(VFXEventType evtype, bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<float> GetAggregatorCellSizes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetAggregatorLimit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerEvent(FXContextualEvent contextualEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetOwnerPartName(FXContextualEventParams eventParams) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadFXPrefabFromAssetDatabase(
      string prefabAssetName,
      FXContextualEvent contextualEvent,
      bool isDefault = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPrefabLoaded(GameObject prefab, FXContextualEvent contextualEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryRemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ExplosionType GetExplosionType(bool isInAtmosphere, bool isOnGround) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXPartContextData GetPartContextData(
      PartBehavior part,
      PQS pqs,
      AttachNodeData attachNode = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VFXSituation GetSituationForContext(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsResourceAvailableInEnvironment(PartBehavior part, ResourceDefinitionID ingredient) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AllIngredientsPresentForRecipe(
      PartBehavior part,
      ResourceDefinitionID recipe,
      ResourceContainer resContainer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetFuelRecipeForPart(PartBehavior part, ref FXPartContextData partContextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetFuelDataForPart(PartBehavior part, ref FXPartContextData partContextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LogCollision(Vector3 relativeVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextualFxSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ContextualFxSystem() => throw null;
  }
}
