// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIActionBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding.Core
{
  public abstract class UIActionBinder : UIDataContextBindBase, IUIActionBinder, IUIActionBindable
  {
    [SerializeField]
    [FormerlySerializedAs("key")]
    protected string actionKey;
    protected System.Action<bool> IsBoundChanged;
    private IAction fallback;
    private IAction action;

    public string ActionKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool HaveActionKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected override bool CheckSelfForContextProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsBound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IAction Action
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CheckForKeyRebinds(IDataContextReadonly context) => throw null;

    protected bool IsContextKeyResolved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateBindingFromContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BindAction(IAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIActionBinder() => throw null;

    private class WarnAction : IAction
    {
      public string warning;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WarnAction(string warning) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public System.Type[] GetParamTypes() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public System.Type GetReturnType() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Invoke(params object[] args) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void InvokeSafe(params object[] args) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Warn() => throw null;
    }
  }
}
