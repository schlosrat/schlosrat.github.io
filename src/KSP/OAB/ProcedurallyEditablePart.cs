// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProcedurallyEditablePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Game;
using KSP.Rendering;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.OAB
{
  public class ProcedurallyEditablePart : KerbalMonoBehaviour
  {
    protected static readonly string ControlSurfaceAttributeName;
    private const float FLOAT_COMPARISON_TOLERANCE = 1E-05f;
    private static readonly Quaternion DEFAULT_PART_VISUAL_ROTATION;
    public ProcedurallyEditablePart.ProceduralMeshBakerDelegate OnPostDynamicMeshInstantiated;
    public ProcedurallyEditablePart.ProceduralMeshBakerDelegate OnPostDynamicMeshDataChange;
    public ProcedurallyEditablePart.ProceduralMeshBakerDelegate OnPostMeshVisibilityChange;
    public ProcedurallyEditablePart.ProceduralMeshBakerDelegate OnBakedMeshChanged;
    public ProcedurallyEditablePart.ProceduralMeshBakerDelegate OnPostFinalize;
    public ProcedurallyEditablePart.AttachNodeUpdateDelegate OnToggleAttachNodeVisibility;
    private ProcedurallyEditablePart.DirtyFlag _meshDirtyState;
    private bool _isMeshFinalized;
    private ProcedurallyEditablePart.VisibilityMode _meshVisibility;
    private bool _isBeingMirrored;
    private ProcedurallyEditablePart _driverPart;
    private OffsetSliderSystem _driverSliderSystem;
    [SerializeField]
    private List<ProceduralMeshOption> _meshOptionPrefabs;
    private int _selectedMeshOptionIndex;
    private GameObject _selectedMeshOptionPrefab;
    private int _loadedMeshOptionIndex;
    private GameObject _pendingMeshOptionPrefab;
    private Transform _meshContainer;
    [SerializeField]
    [FormerlySerializedAs("BakedInstance")]
    private GameObject _bakedMeshObject;
    private GameObject _targetDynamicMesh;
    private SkinMeshToStaticGenerator _targetMeshGenerator;
    private OffsetSliderSystem _targetMeshSliderSystem;
    private ProceduralShaderData _targetMeshShaderData;
    private readonly Dictionary<string, float> _sliderValueDataStorage;
    private readonly Dictionary<string, bool> _toggleValueDataStorage;
    private readonly Dictionary<string, bool> _visibleSubMeshStorage;
    private readonly Dictionary<string, SkinMeshToStaticGenerator.StaticSetData> _targetNamedSubMeshesCache;
    private bool _waitInitialFrame;
    private int _framesWaited;
    private const int INITIAL_WAIT_FRAMES = 2;

    private string LOG_PREFIX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ProcedurallyEditablePart.DirtyFlag MeshDirtyState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasDirtyFlag(ProcedurallyEditablePart.DirtyFlag flag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddDirtyFlag(ProcedurallyEditablePart.DirtyFlag flag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveDirtyFlag(ProcedurallyEditablePart.DirtyFlag flag) => throw null;

    public bool IsMeshClean
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMeshFinalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool MeshFinalizeIsQueued
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ProcedurallyEditablePart.VisibilityMode MeshVisibility
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsBeingMirrored
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IReadOnlyList<ProceduralMeshOption> MeshOptionPrefabs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyList<ProceduralPartAttribute> SelectedOptionAttributes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int SelectedMeshOptionIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int LoadedMeshOptionIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Transform MeshContainer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObject BakedMeshObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObject DynamicMeshObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HaveDynamicMesh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OffsetSliderSystem TargetMeshSliderSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<string, float> SliderValueDataStorage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<string, bool> ToggleValueDataStorage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<string, bool> VisibleSubMeshDataStorage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ProcedurallyEditablePart DriverPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OffsetSliderSystem DriverSliderSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsEditable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetMeshOptionName(int meshOptionIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDefaultMeshOption() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetMeshSliderValue(string key, float newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetMeshToggleValue(string key, bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetSubMeshVisibility(string key, bool newVisibility) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Collider[] GetBakedMeshColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMeshVisibility(
      ProcedurallyEditablePart.VisibilityMode visibilityMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void QueueMeshFinalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDriverPart(ProcedurallyEditablePart newDriver) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleMirror() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDirtyDynamicMeshPrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDirtyDynamicMeshInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDirtyDynamicMeshUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDirtyStaticMeshRebuilding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDirtyVisibilityMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleQueuedMeshFinalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Transform LocateOrCreateMeshContainer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnloadSelectedMeshOptionPrefab() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyBakedMesh(bool skipEvent = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetTargetDynamicMesh(GameObject newDynamicMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConnectTargetSliderSystem(bool connect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReadValuesFromTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int FindMatchingAttributePrefab(string key, bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteValuesToTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReadVisibleMeshValuesFromTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteVisibleMeshValuesToTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncDynamicValuesFromDriver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConnectDriverSliderSystem(bool connect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncSliderValuesFromDriver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetWithDirty<T>(
      ref T toSet,
      T value,
      ProcedurallyEditablePart.DirtyFlag dirtyFlag)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetWithDirty(
      ref float toSet,
      float value,
      ProcedurallyEditablePart.DirtyFlag dirtyFlag)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetWithDirty(
      ref double toSet,
      double value,
      ProcedurallyEditablePart.DirtyFlag dirtyFlag)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetWithDirty<TKey, TVal>(
      IDictionary<TKey, TVal> dictionary,
      TKey key,
      TVal value,
      ProcedurallyEditablePart.DirtyFlag dirtyFlag,
      bool doInsert = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetDictionaryValueWithDirty<TKey, TVal>(
      IDictionary<TKey, TVal> dictionary,
      TKey key,
      TVal value,
      ProcedurallyEditablePart.DirtyFlag dirtyFlag,
      bool doInsert = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetDictionaryValueWithDirty<TKey>(
      IDictionary<TKey, float> dictionary,
      TKey key,
      float value,
      ProcedurallyEditablePart.DirtyFlag dirtyFlag,
      bool doInsert = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProcedurallyEditablePart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ProcedurallyEditablePart() => throw null;

    [Flags]
    public enum DirtyFlag
    {
      Clean = 0,
      DynamicMeshLoadQueued = 1,
      DynamicMeshLoading = 2,
      DynamicMeshInstantiate = 4,
      DynamicMeshUpdate = 8,
      StaticMeshRebuild = 16, // 0x00000010
      AllVisibilityModeUpdate = 32, // 0x00000020
      FinalizeQueued = 64, // 0x00000040
    }

    public enum VisibilityMode
    {
      DynamicMesh,
      StaticMesh,
    }

    public delegate void ProceduralMeshBakerDelegate();

    public delegate void AttachNodeUpdateDelegate(
      SkinMeshToStaticGenerator.AttachNodeData nodeData,
      bool shouldAttachNodeBeOn);
  }
}
