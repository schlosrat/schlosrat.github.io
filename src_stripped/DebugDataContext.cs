// Decompiled with JetBrains decompiler
// Type: DebugDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
