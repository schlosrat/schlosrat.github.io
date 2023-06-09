﻿// Decompiled with JetBrains decompiler
// Type: LocalTransformCacher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

public class LocalTransformCacher : MonoBehaviour
{
  [SerializeField]
  [Space(20f, order = 1)]
  [Header("Caches the local position/rotation for later use", order = 0)]
  private LocalTransformCacher.StoreMode _mode;
  [SerializeField]
  private bool _disableOnceCached;
  private bool _hasBeenCached;
  private double3 _cachedLocalPosition;
  private quaternion _cachedLocalRotation;
  private double4x4 _cachedParentToLocalMatrix;

  public double3 CachedLocalPosition
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public quaternion CachedLocalRotation
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public double4x4 CachedParentToLocalMatrix
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool HasBeenCached
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetCachedLocalTransform(double3 localPosition, quaternion localRotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ClearCachedTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void CacheLocalTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void FixedUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LocalTransformCacher() => throw null;

  public enum StoreMode
  {
    OnScript,
    OnEnable,
    OnAwake,
    OnStart,
    OnFirstUpdate,
    OnFirstLateUpdate,
    OnFirstFixedUpdate,
  }
}
