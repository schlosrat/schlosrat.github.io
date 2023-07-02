// Decompiled with JetBrains decompiler
// Type: DebugUIContextBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class DebugUIContextBase : 
  MonoBehaviour,
  IUIDataContextProvider,
  IDataContextProvider
{
  [SerializeField]
  protected DebugDataContext testContextValues;
  public DataContext context;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract void HandleUIRootBinding() => throw null;

  public IDataContextReadonly Context
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Context_contextChanged(IDataContextReadonly uiContext) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void BindContext(IDataContextReadonly parentContext) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool RequestForModifications(out IDataContext writableContext) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected DebugUIContextBase() => throw null;
}
