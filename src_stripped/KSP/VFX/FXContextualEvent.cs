// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXContextualEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public abstract class FXContextualEvent : ISpatialDatabaseNode
  {
    public readonly string VFX_SOCKET_NAME;
    public ContextualFxSystem FXSystem;
    public FXPartContextData PartData;
    public FXContextualEventParams EventParams;
    public FXContextData ContextData;
    protected bool _active;
    protected bool _vfxSpawned;
    private List<GameObject> _socketedFX;
    protected GameObject _spawnedPrefab;
    protected ParticleSystem[] _particleSystems;
    protected bool _overridePrefab;
    protected string _overridePrefabName;
    protected VFXParameterizer[] parameterizers;
    private string _prefabName;

    public virtual string DefaultVFXAssetName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ContextualFxSystem CFXSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool GetUseSocketLocations() => throw null;

    public List<GameObject> SocketedFX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObject SpawnedPrefab
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public virtual VFXEventType EventType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXContextualEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion GetOrientation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Aggregate(ISpatialDatabaseNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetAggregationAmount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXContextualEvent(
      FXContextualEventParams eventParams,
      ContextualFxSystem system,
      FXPartContextData partData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string SelectPrefab(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetOverridePrefabName(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ClearOverridePrefabName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateLocation(Vector3d position, Quaternion orientation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetSocketChildNodes(Transform parent, ref List<GameObject> childNodes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Instantiate(GameObject prefab, FXContextData contextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayParticleSystems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopParticleSystems(bool withChildren, ParticleSystemStopBehavior behavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AnyParticleSystemPlaying() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void CleanUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DelayedDeletion(GameObject objectToDestroy) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Tick(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateParameterizers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop() => throw null;
  }
}
