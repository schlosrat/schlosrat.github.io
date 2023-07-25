// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.BasicDescriptors.DispatchingUserDataDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
  public abstract class DispatchingUserDataDescriptor : IUserDataDescriptor, IOptimizableDescriptor
  {
    private int m_ExtMethodsVersion;
    private Dictionary<string, IMemberDescriptor> m_MetaMembers;
    private Dictionary<string, IMemberDescriptor> m_Members;
    protected const string SPECIALNAME_INDEXER_GET = "get_Item";
    protected const string SPECIALNAME_INDEXER_SET = "set_Item";
    protected const string SPECIALNAME_CAST_EXPLICIT = "op_Explicit";
    protected const string SPECIALNAME_CAST_IMPLICIT = "op_Implicit";

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string FriendlyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DispatchingUserDataDescriptor(Type type, string friendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddMetaMember(string name, IMemberDescriptor desc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddDynValue(string name, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddMember(string name, IMemberDescriptor desc) => throw null;

    public IEnumerable<string> MemberNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<KeyValuePair<string, IMemberDescriptor>> Members
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IMemberDescriptor FindMember(string memberName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveMember(string memberName) => throw null;

    public IEnumerable<string> MetaMemberNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<KeyValuePair<string, IMemberDescriptor>> MetaMembers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IMemberDescriptor FindMetaMember(string memberName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveMetaMember(string memberName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddMemberTo(
      Dictionary<string, IMemberDescriptor> members,
      string name,
      IMemberDescriptor desc)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DynValue Index(
      Script script,
      object obj,
      DynValue index,
      bool isDirectIndexing)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue TryIndexOnExtMethod(Script script, object obj, string indexName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasMember(string exactName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasMetaMember(string exactName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual DynValue TryIndex(Script script, object obj, string indexName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool SetIndex(
      Script script,
      object obj,
      DynValue index,
      DynValue value,
      bool isDirectIndexing)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool TrySetIndex(
      Script script,
      object obj,
      string indexName,
      DynValue value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IOptimizableDescriptor.Optimize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static string Camelify(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static string UpperFirstLetter(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string AsString(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual DynValue ExecuteIndexer(
      IMemberDescriptor mdesc,
      Script script,
      object obj,
      DynValue index,
      DynValue value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DynValue MetaIndex(Script script, object obj, string metaname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int PerformComparison(object obj, object p1, object p2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue MultiDispatchLessThanOrEqual(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue MultiDispatchLessThan(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue TryDispatchLength(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue MultiDispatchEqual(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckEquality(object obj, object p1, object p2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue DispatchMetaOnMethod(Script script, object obj, string methodName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue TryDispatchToNumber(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue TryDispatchToBool(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool IsTypeCompatible(Type type, object obj) => throw null;
  }
}
