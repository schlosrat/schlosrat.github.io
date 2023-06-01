// Decompiled with JetBrains decompiler
// Type: ReadOnlySet`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ReadOnlySet<T> : 
  IReadOnlyCollection<T>,
  IEnumerable<T>,
  IEnumerable,
  ISet<T>,
  ICollection<T>
{
  private readonly ISet<T> _set;

  public int Count
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  bool ICollection<T>.IsReadOnly
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  int ICollection<T>.Count
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ReadOnlySet(ISet<T> set) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerator<T> GetEnumerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  IEnumerator IEnumerable.GetEnumerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  void ICollection<T>.Add(T item) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ExceptWith(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void IntersectWith(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsProperSubsetOf(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsProperSupersetOf(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsSubsetOf(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsSupersetOf(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Overlaps(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool SetEquals(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SymmetricExceptWith(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UnionWith(IEnumerable<T> other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  bool ISet<T>.Add(T item) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Clear() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Contains(T item) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void CopyTo(T[] array, int arrayIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Remove(T item) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool ThrowReadOnlyException([CallerMemberName] string memberName = "") => throw null;
}
