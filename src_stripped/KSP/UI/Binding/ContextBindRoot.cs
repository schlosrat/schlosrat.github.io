// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.ContextBindRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class ContextBindRoot : MonoBehaviour, IUIDataContextProvider, IDataContextProvider
  {
    protected DataContext context;
    private bool isInit;

    protected event Action OnValidateNextUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RequestForModifications(out IDataContext writableContext) => throw null;

    public IDataContextReadonly Context
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BindContext(IDataContextReadonly parentContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Context_contextChanged(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string DebugContextToString(
      bool showParentHierarchy = false,
      bool showSubContexts = false,
      bool showListContent = false,
      bool printKeysCompact = true,
      bool showExpandedKeyValues = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextBindRoot() => throw null;
  }
}
