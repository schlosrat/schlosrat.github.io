﻿// Decompiled with JetBrains decompiler
// Type: CullingSparseSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CullingSparseSet
{
  public int DenseUsedCount;
  public int[] Dense;
  public BoundingSphere[] DenseData;
  public Action<CullingGroup, CullingGroupEvent>[] DenseCallbacks;
  public int[] Sparse;
  private int _sparseFreeHead;
  private int _groupSizeIncrement;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CullingSparseSet(int size) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CullingSparseSet() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Update(int sparseIndex, BoundingSphere newValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int Add(BoundingSphere value, Action<CullingGroup, CullingGroupEvent> callback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(int sparseIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int Reserve(Action<CullingGroup, CullingGroupEvent> callback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int GetNextAvailableSparseIndex() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ConfigureCullingSparseSet() => throw null;
}
