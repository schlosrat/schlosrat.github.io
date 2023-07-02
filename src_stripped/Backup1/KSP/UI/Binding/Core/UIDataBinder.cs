// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIDataBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  [DisallowMultipleComponent]
  public abstract class UIDataBinder : MonoBehaviour, IUIDataBinder, IUIDataBindable
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void ClearDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void SetDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void RedrawOnBoundValueChanged(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void RedrawOnIsBoundChanged(bool instant = true) => throw null;

    private string LogTag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected IProperty DataProperty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    private object ObjectData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsBound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public event Action IsBoundChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    private bool IsBeingDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public System.Type BoundType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BindData(IProperty dataProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleDataSwap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetDataObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetDataObjectAs<T>() where T : class => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIDataBinder() => throw null;
  }
}
