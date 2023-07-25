// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.OverloadedMethodMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class OverloadedMethodMemberDescriptor : 
    IOptimizableDescriptor,
    IMemberDescriptor,
    IWireableDescriptor
  {
    private const int CACHE_SIZE = 5;
    private List<IOverloadableMemberDescriptor> m_Overloads;
    private List<IOverloadableMemberDescriptor> m_ExtOverloads;
    private bool m_Unsorted;
    private OverloadedMethodMemberDescriptor.OverloadCacheItem[] m_Cache;
    private int m_CacheHits;
    private int m_ExtensionMethodVersion;

    public bool IgnoreExtensionMethods
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OverloadedMethodMemberDescriptor(string name, Type declaringType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OverloadedMethodMemberDescriptor(
      string name,
      Type declaringType,
      IOverloadableMemberDescriptor descriptor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OverloadedMethodMemberDescriptor(
      string name,
      Type declaringType,
      IEnumerable<IOverloadableMemberDescriptor> descriptors)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetExtensionMethodsSnapshot(
      int version,
      List<IOverloadableMemberDescriptor> extMethods)
    {
      throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Type DeclaringType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOverload(IOverloadableMemberDescriptor overload) => throw null;

    public int OverloadCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue PerformOverloadedCall(
      Script script,
      object obj,
      ScriptExecutionContext context,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Cache(
      bool hasObject,
      CallbackArguments args,
      IOverloadableMemberDescriptor bestOverload)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckMatch(
      bool hasObject,
      CallbackArguments args,
      OverloadedMethodMemberDescriptor.OverloadCacheItem overloadCacheItem)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CalcScoreForOverload(
      ScriptExecutionContext context,
      CallbackArguments args,
      IOverloadableMemberDescriptor method,
      bool isExtMethod)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CalcScoreForSingleArgument(
      ParameterDescriptor desc,
      Type parameterType,
      DynValue arg,
      bool isOptional)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(
      Script script,
      object obj)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IOptimizableDescriptor.Optimize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CallbackFunction GetCallbackFunction(Script script, object obj = null) => throw null;

    public bool IsStatic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MemberDescriptorAccess MemberAccess
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetValue(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(Script script, object obj, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareForWiring(Table t) => throw null;

    private class OverloadableMemberDescriptorComparer : IComparer<IOverloadableMemberDescriptor>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public int Compare(IOverloadableMemberDescriptor x, IOverloadableMemberDescriptor y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OverloadableMemberDescriptorComparer() => throw null;
    }

    private class OverloadCacheItem
    {
      public bool HasObject;
      public IOverloadableMemberDescriptor Method;
      public List<DataType> ArgsDataType;
      public List<Type> ArgsUserDataType;
      public int HitIndexAtLastHit;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OverloadCacheItem() => throw null;
    }
  }
}
