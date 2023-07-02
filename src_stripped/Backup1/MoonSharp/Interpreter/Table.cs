// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Table
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.DataStructs;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public class Table : RefIdObject, IScriptPrivateResource
  {
    private readonly LinkedList<TablePair> m_Values;
    private readonly LinkedListIndex<DynValue, TablePair> m_ValueMap;
    private readonly LinkedListIndex<string, TablePair> m_StringMap;
    private readonly LinkedListIndex<int, TablePair> m_ArrayMap;
    private readonly Script m_Owner;
    private int m_InitArray;
    private int m_CachedLength;
    private bool m_ContainsNilEntries;
    private Table m_MetaTable;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Table(Script owner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Table(Script owner, params DynValue[] arrayValues) => throw null;

    public Script OwnerScript
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetIntegralKey(double d) => throw null;

    public object this[params object[] keys]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public object this[object key]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Table ResolveMultipleKeys(object[] keys, out object key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Append(DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformTableSet<T>(
      LinkedListIndex<T, TablePair> listIndex,
      T key,
      DynValue keyDynValue,
      DynValue value,
      bool isNumber,
      int appendKey)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(string key, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(int key, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(DynValue key, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(object key, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(object[] keys, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Get(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Get(int key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Get(DynValue key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Get(object key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Get(params object[] keys) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue RawGetValue(LinkedListNode<TablePair> linkedListNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue RawGet(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue RawGet(int key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue RawGet(DynValue key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue RawGet(object key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue RawGet(params object[] keys) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PerformTableRemove<T>(
      LinkedListIndex<T, TablePair> listIndex,
      T key,
      bool isNumber)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(int key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(DynValue key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(object key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(params object[] keys) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectDeadKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TablePair? NextKey(DynValue v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TablePair? GetNextOf(LinkedListNode<TablePair> linkedListNode) => throw null;

    public int Length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void InitNextArrayKeys(DynValue val, bool lastpos) => throw null;

    public Table MetaTable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IEnumerable<TablePair> Pairs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<DynValue> Keys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<DynValue> Values
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
