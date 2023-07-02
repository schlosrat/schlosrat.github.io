// Decompiled with JetBrains decompiler
// Type: CullingSparseSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
