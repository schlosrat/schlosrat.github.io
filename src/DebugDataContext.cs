// Decompiled with JetBrains decompiler
// Type: DebugDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class DebugDataContext
{
  public bool debugPrintContextChanges;
  protected DataContext context;
  [SerializeField]
  protected List<DebugDataContextEntry> contextData;
  private Dictionary<string, DebugDataContextEntryType> mappedTypes;
  private Dictionary<string, Action<object>> mappedDebug;

  public IDataContext Context
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugDataContext() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SyncContextWithInspector() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DebugPrintContext(object message) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Context_contextChanged(IDataContextReadonly context) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InjectStackParentContext(IDataContextReadonly newParent) => throw null;
}
