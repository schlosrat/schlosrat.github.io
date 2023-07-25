// Decompiled with JetBrains decompiler
// Type: JacksonDunstan.NativeCollections.NativeHashSet`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace JacksonDunstan.NativeCollections
{
  [DebuggerDisplay("Length = {Length}. Capacity = {Capacity}")]
  [NativeContainer]
  [DebuggerTypeProxy(typeof (NativeHashSetDebugView<>))]
  public struct NativeHashSet<T> : IDisposable where T : unmanaged, IEquatable<T>
  {
    [NativeDisableUnsafePtrRestriction]
    private unsafe NativeHashSetState* m_State;
    private readonly Allocator m_Allocator;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NativeHashSet(int capacity, Allocator allocator) => throw null;

    public int Length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Capacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryAdd(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(T item) => throw null;

    public bool IsCreated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle Dispose(JobHandle inputDeps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NativeArray<T> ToNativeArray(NativeArray<T> array = default (NativeArray<T>), int index = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NativeHashSet<T>.ParallelWriter AsParallelWriter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Deallocate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static unsafe int AllocFreeListEntry(NativeHashSetState* state, int threadIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static unsafe bool TryGetFirstValueAtomic(
      NativeHashSetState* state,
      T item,
      out NativeHashSet<T>.NativeMultiHashSetIterator it)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static unsafe bool TryGetNextValueAtomic(
      NativeHashSetState* state,
      ref NativeHashSet<T>.NativeMultiHashSetIterator it)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reallocate(int newCapacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RequireBlittable() => throw null;

    [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RequireReadAccess() => throw null;

    [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RequireWriteAccess() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int NextHigherPowerOfTwo(int val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CalculateDataLayout(
      int length,
      int bucketLength,
      out int nextOffset,
      out int bucketOffset)
    {
      throw null;
    }

    [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TestUseOnlySetAllowReadAndWriteAccess(bool allowReadOrWriteAccess) => throw null;

    private struct NativeMultiHashSetIterator
    {
      internal T Item;
      internal int NextEntryIndex;
    }

    private struct DisposeJob : IJob
    {
      internal NativeHashSet<T> Set;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute() => throw null;
    }

    [NativeContainerIsAtomicWriteOnly]
    [NativeContainer]
    public struct ParallelWriter
    {
      [NativeDisableUnsafePtrRestriction]
      internal unsafe NativeHashSetState* m_State;
      [NativeSetThreadIndex]
      internal int m_ThreadIndex;

      public int Capacity
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryAdd(T item) => throw null;

      [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void TestUseOnlySetAllowReadAndWriteAccess(bool allowReadOrWriteAccess) => throw null;
    }
  }
}
