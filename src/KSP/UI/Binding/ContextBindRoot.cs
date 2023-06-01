// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.ContextBindRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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

    public IDataContextReadonly BoundParentContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
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
