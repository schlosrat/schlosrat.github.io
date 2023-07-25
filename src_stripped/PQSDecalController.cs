// Decompiled with JetBrains decompiler
// Type: PQSDecalController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using KSP;
using KSP.Rendering.Planets;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

[ExecuteInEditMode]
[AwesomeTechnologiesScriptOrder(10)]
public class PQSDecalController : MonoBehaviour
{
  public PQSDecalData PqsDecalData;
  public PQS Pqs;
  public CoreCelestialBodyData CoreCelestialBodyData;
  public int CurrentTabIndex;
  public List<PQSDecalInstance> PqsDecalInstanceList;
  public PQSDataOutputType PQSDataOutputType;
  private NativeArray<ushort> _nativeHeight;
  private NativeArray<ushort> _nativeAlpha;
  public NativeList<DecalInstance> DecalInstances;
  public Texture2D DecalMaskTex;
  private Color32[] _decalMaskBuffer;
  public DecalTextureSize DecalMaskTextureSize;
  public bool UseMaskTexture;
  public PQSData.FilteringMode DecalHeightFilteringMode;
  public PQSData.FilteringMode DecalAlphaFilteringMode;
  private Vector3 _pqsPosition;
  private int _frameCounter;
  private bool _needDelayedInit;
  private bool _isBeingDestroyed;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static int SortBySortOrder(PQSDecalInstance i1, PQSDecalInstance i2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NativeArray<ushort> GetNativeHeights() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NativeArray<uint> GetNativeHeightUInt() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool HasGeneratedData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NativeArray<ushort> GetNativeAlpha() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NativeArray<uint> GetNativeAlphaUInt() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DelayedInit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DisposeNativeMemory() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddDecalInstance(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsInstanceBaked(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsAllInstancesBaked() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RegenerateTextureArrays() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSDecalInstance GetDecalInstance(string decalInstanceID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Transform GetDecalParent() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveDecalInstance(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DecalUpdatedRunTime(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SerializeDeleteDecal(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ClearMaskTexture() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ClearMaskBuffer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateDecalDataTextures() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RefreshDecalInstances() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateDecalInstances(bool forPqs = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private PQSDecalBounds GetBoundsForDecal(PQSDecalInstance decalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RenderDecalToTexture(
    PQSDecalBounds bounds,
    PQSDecalInstance decalInstance,
    int index)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int GetDecalIndex(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Texture2D GetFirstDiffuseTexture() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Texture2D GetFirstNormalTexture() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Texture2D GetFirstAlphaTexture() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Texture2D GetFirstHeightTexture() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ClearSubObjects() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GenerateTextureArrays() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PackHeightData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Texture2D ResizeTexture(Texture2D source, int width, int height, bool linear) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void WriteDecalToTextureRange(Vector2 prevuv, Vector2 uv, int index) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSDecalController() => throw null;
}
