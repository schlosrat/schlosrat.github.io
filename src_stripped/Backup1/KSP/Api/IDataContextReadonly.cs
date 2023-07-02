// Decompiled with JetBrains decompiler
// Type: KSP.Api.IDataContextReadonly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System;
using System.Collections.Generic;

namespace KSP.Api
{
  public interface IDataContextReadonly
  {
    event Action<IDataContextReadonly> ContextChanged;

    event Action<IDataContextReadonly> ContextMetadataChanged;

    bool IsDisposed { get; }

    int PropertyCount { get; }

    int StackPropertyCount { get; }

    int ActionCount { get; }

    int StackActionCount { get; }

    int ListCount { get; }

    int StackListCount { get; }

    int SubContextCount { get; }

    int StackSubContextCount { get; }

    IReadOnlyDictionary<string, IProperty> Properties { get; }

    IReadOnlyDictionary<string, IAction> Actions { get; }

    IReadOnlyDictionary<string, IContextListProperty> Lists { get; }

    IReadOnlyDictionary<string, IDataContextReadonly> SubContexts { get; }

    IReadOnlyDictionary<string, UIValueNumberRange> NumberRanges { get; }

    IReadOnlyDictionary<string, string> Labels { get; }

    IReadOnlyDictionary<string, ToStringDelegate> ToStringDelegates { get; }

    void GetPropertyKeys(ISet<string> target, bool searchStack = true);

    void GetActionKeys(ISet<string> target, bool searchStack = true);

    void GetListKeys(ISet<string> target, bool searchStack = true);

    void GetSubContextKeys(ISet<string> target, bool searchStack = true);

    void GetNumberRangeKeys(ISet<string> target, bool searchStack = true);

    void GetLabelKeys(ISet<string> target, bool searchStack = true);

    void GetToStringDelegateKeys(ISet<string> target, bool searchStack = true);

    bool TryResolveProperty(string keyPath, out IProperty property, bool searchStack = true);

    bool TryResolveAction(string keyPath, out IAction action, bool searchStack = true);

    bool TryResolveList(string keyPath, out IContextListProperty list, bool searchStack = true);

    bool TryResolveSubContext(
      string keyPath,
      out IDataContextReadonly subContext,
      bool searchStack = true,
      bool wrapStackResult = true);

    bool TryResolveNumberRange(string keyPath, out UIValueNumberRange valueRange, bool searchStack = true);

    bool TryResolveLabel(string keyPath, out string label, bool searchStack = true);

    bool TryResolveToStringDelegate(
      string keyPath,
      out ToStringDelegate toStringDelegate,
      bool searchStack = true);

    bool TryResolvePathHierarchy(
      string keyPath,
      out IDataContextReadonly hierarchyContext,
      out string keyLocal);

    IDataContextReadonly GetHierarchyParent(bool searchStack = true);

    IDataContextReadonly GetStackParent();

    string GetDebugName();

    string GetDebugStackChain();

    string GetDebugHierarchyChain();
  }
}
