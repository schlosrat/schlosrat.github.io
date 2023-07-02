// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UISubContextBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  [RequireComponent(typeof (ContextBindRoot))]
  public class UISubContextBinder : UIDataContextBindBase
  {
    public ContextBindRoot bindRoot;
    [SerializeField]
    [FormerlySerializedAs("key")]
    protected string subContextKey;
    private IDataContextReadonly foundSubContext;

    public string SubContextKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool HaveSubcontextKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected override bool CheckSelfForContextProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleBindrootContextChanged(IDataContextReadonly bindRootcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CheckForKeyRebinds(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UISubContextBinder() => throw null;
  }
}
