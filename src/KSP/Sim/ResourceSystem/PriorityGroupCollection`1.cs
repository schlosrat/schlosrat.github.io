// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.PriorityGroupCollection`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class PriorityGroupCollection<TElement> : 
    IPriorityGroupCollection<TElement>,
    IReadOnlyPriorityGroupCollection<TElement>,
    IEnumerable<KeyValuePair<double, TElement>>,
    IEnumerable
  {
    private static readonly IReadOnlyCollection<TElement> EMPTY_GROUP;
    private readonly SortedList<double, IReadOnlyCollection<TElement>> _priorityGroups;
    private readonly Dictionary<TElement, double> _elementPriorityCache;

    public double FirstPriority
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
    }

    public double LastPriority
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
    }

    public int GroupCount
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
    }

    public IList<IReadOnlyCollection<TElement>> GroupElements
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
    }

    public IList<double> GroupPriorities
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
    }

    public IReadOnlyDictionary<double, IReadOnlyCollection<TElement>> PriorityElementGroups
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
    }

    public int ElementCount
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
    }

    public IReadOnlyDictionary<TElement, double> ElementPriorities
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
    }

    public double this[TElement element]
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] set => throw null;
    }

    public IComparer<double> PrioritySorter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEqualityComparer<TElement> ElementComparer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PriorityGroupCollection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PriorityGroupCollection(IComparer<double> prioritySorter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PriorityGroupCollection(IEqualityComparer<TElement> elementComparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PriorityGroupCollection(
      IComparer<double> prioritySorter,
      IEqualityComparer<TElement> elementComparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PriorityGroupCollection(IReadOnlyPriorityGroupCollection<TElement> other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PriorityGroupCollection(
      IReadOnlyPriorityGroupCollection<TElement> other,
      IComparer<double> prioritySorter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PriorityGroupCollection(
      IReadOnlyPriorityGroupCollection<TElement> other,
      IEqualityComparer<TElement> elementComparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PriorityGroupCollection(
      IReadOnlyPriorityGroupCollection<TElement> other,
      IComparer<double> prioritySorter,
      IEqualityComparer<TElement> elementComparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public int IndexOfPriority(double priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public int IndexOfElement(TElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public IEnumerable<KeyValuePair<double, TElement>> GetFirstToLast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public IEnumerable<KeyValuePair<double, TElement>> GetLastToFirst() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public IEnumerator<KeyValuePair<double, TElement>> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private List<TElement> InternalGetGroupList(int groupIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(TElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveGroupsWithPriority(double priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveGroupAt(int groupIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MovePriorityGroup(int oldPriority, int newPriority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public void Add(TElement element, double priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOrUpdate(TElement element, double priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private IList<TElement> InternalGetOrCreateGroup(double priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private bool InternalRemoveElementFromGroup(IList<TElement> list, TElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PriorityGroupCollection() => throw null;

    public class HighToLowPrioritySorter : IComparer<double>
    {
      public static readonly PriorityGroupCollection<TElement>.HighToLowPrioritySorter Instance;

      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
      public int Compare(double x, double y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public HighToLowPrioritySorter() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static HighToLowPrioritySorter() => throw null;
    }

    public class LowToHighPrioritySorter : IComparer<double>
    {
      public static readonly PriorityGroupCollection<TElement>.LowToHighPrioritySorter Instance;

      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
      public int Compare(double x, double y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LowToHighPrioritySorter() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static LowToHighPrioritySorter() => throw null;
    }
  }
}
