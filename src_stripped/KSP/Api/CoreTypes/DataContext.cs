// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.DataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class DataContext : IDisposable, IDataContext, IDataContextReadonly, IDataContextWritable
  {
    protected string debugName;
    private IDataContextReadonly stackParent;
    private IDataContextReadonly hierarchyParent;
    private Dictionary<string, IProperty> properties;
    private Dictionary<string, IAction> actions;
    private Dictionary<string, IContextListProperty> lists;
    private Dictionary<string, IDataContextReadonly> subContexts;
    private Dictionary<string, UIValueNumberRange> numberRanges;
    private Dictionary<string, string> labels;
    private Dictionary<string, ToStringDelegate> toStringDelegates;

    public event Action<IDataContextReadonly> ContextChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<IDataContextReadonly> ContextMetadataChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool IsDisposed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IReadOnlyDictionary<string, IProperty> Properties
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<string, IAction> Actions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<string, IContextListProperty> Lists
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<string, IDataContextReadonly> SubContexts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<string, UIValueNumberRange> NumberRanges
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<string, string> Labels
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyDictionary<string, ToStringDelegate> ToStringDelegates
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int PropertyCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int StackPropertyCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ActionCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int StackActionCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ListCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int StackListCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int SubContextCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int StackSubContextCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataContext(string debugName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataContext(IDataContextReadonly stackParent, string debugName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnParentContextMetadataChanged(IDataContextReadonly stackParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnParentContextChanged(IDataContextReadonly stackParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDebugName(string debugName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStackParent(IDataContextReadonly newParent, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDataContextReadonly GetStackParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDataContextReadonly GetHierarchyParent(bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHierarchyParent(IDataContextReadonly newHierarchyParent, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPropertyKeys(ISet<string> target, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetActionKeys(ISet<string> target, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetListKeys(ISet<string> target, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetSubContextKeys(ISet<string> target, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetNumberRangeKeys(ISet<string> target, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetLabelKeys(ISet<string> target, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetToStringDelegateKeys(ISet<string> target, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataContext ExtendStack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddProperty(string key, IProperty property) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPropertyInternal(string key, IProperty property, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAction(string key, IAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddActionInternal(string key, IAction action, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddList(string key, IContextListProperty list) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddListInternal(string key, IContextListProperty list, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSubContext(string key, IDataContextReadonly subContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSubContextInternal(string key, IDataContextReadonly subContext, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNumberRange(string key, UIValueNumberRange numberRange) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNumberRange(string key, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNumberRange(string key, double min, double max, double step) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNumberRangeInternal(string key, UIValueNumberRange numberRange, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLabel(string key, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLabelInternal(string key, string label, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetToStringDelegate(string key, ToStringDelegate toStringDelegate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetToStringDelegateInternal(
      string key,
      ToStringDelegate toStringDelegate,
      bool fireEvent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveProperty(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePropertyInternal(string key, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAction(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveActionInternal(string key, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveList(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveListInternal(string key, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveSubContext(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveSubContextInternal(string key, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearNumberRange(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNumberRangeInternal(string key, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearLabel(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveLabelInternal(string key, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearToStringDelegate(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveToStringDelegateInternal(string key, bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAllData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearInternal(bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InvokeContextChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InvokeContextMetadataChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool TryResolveProperty(
      string keyPath,
      out IProperty property,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool TryResolveAction(string keyPath, out IAction action, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool TryResolveList(
      string keyPath,
      out IContextListProperty list,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool TryResolveSubContext(
      string keyPath,
      out IDataContextReadonly subContext,
      bool searchStack = true,
      bool wrapStackResult = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool TryResolveNumberRange(
      string keyPath,
      out UIValueNumberRange numberRange,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool TryResolveLabel(string keyPath, out string label, bool searchStack = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool TryResolveToStringDelegate(
      string keyPath,
      out ToStringDelegate toStringDelegate,
      bool searchStack = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool TryResolvePathHierarchy(
      string keyPath,
      out IDataContextReadonly hierarchyContext,
      out string keyLocal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPathAbsolute(string path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] ParsePath(string path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugStackChain() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugHierarchyChain() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Dispose(bool disposing) => throw null;

    private class WrappedSubContextFromStack : IDataContextReadonly
    {
      public event Action<IDataContextReadonly> ContextChanged
      {
        [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
      }

      public event Action<IDataContextReadonly> ContextMetadataChanged
      {
        [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
      }

      private IDataContextReadonly WrappedContext
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      private IDataContextReadonly ParentOverride
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public bool IsDisposed
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int PropertyCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int StackPropertyCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int ActionCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int StackActionCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int ListCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int StackListCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int SubContextCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int StackSubContextCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IReadOnlyDictionary<string, IProperty> Properties
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IReadOnlyDictionary<string, IAction> Actions
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IReadOnlyDictionary<string, IContextListProperty> Lists
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IReadOnlyDictionary<string, IDataContextReadonly> SubContexts
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IReadOnlyDictionary<string, UIValueNumberRange> NumberRanges
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IReadOnlyDictionary<string, string> Labels
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IReadOnlyDictionary<string, ToStringDelegate> ToStringDelegates
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WrappedSubContextFromStack(
        IDataContextReadonly wrappedContext,
        IDataContextReadonly parentOverride)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override bool Equals(object obj) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string ToString() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override int GetHashCode() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void GetPropertyKeys(ISet<string> target, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void GetActionKeys(ISet<string> target, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void GetListKeys(ISet<string> target, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void GetSubContextKeys(ISet<string> target, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void GetNumberRangeKeys(ISet<string> target, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void GetLabelKeys(ISet<string> target, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void GetToStringDelegateKeys(ISet<string> target, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryResolveProperty(string keyPath, out IProperty property, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryResolveAction(string keyPath, out IAction action, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryResolveList(string keyPath, out IContextListProperty list, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryResolveSubContext(
        string keyPath,
        out IDataContextReadonly subContext,
        bool searchStack = true,
        bool wrapStackResult = true)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryResolveNumberRange(
        string keyPath,
        out UIValueNumberRange numberRange,
        bool searchStack = true)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryResolveLabel(string keyPath, out string label, bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryResolveToStringDelegate(
        string keyPath,
        out ToStringDelegate toStringDelegate,
        bool searchStack = true)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool TryResolvePathHierarchy(
        string keyPath,
        out IDataContextReadonly hierarchyContext,
        out string keyLocal)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IDataContextReadonly GetHierarchyParent(bool searchStack = true) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IDataContextReadonly GetStackParent() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string GetDebugName() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string GetDebugStackChain() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string GetDebugHierarchyChain() => throw null;
    }
  }
}
