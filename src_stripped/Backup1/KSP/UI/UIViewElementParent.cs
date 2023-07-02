// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIViewElementParent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class UIViewElementParent : KerbalMonoBehaviour, IUIViewElement
  {
    [SerializeField]
    private string _id;
    private ViewState _currentState;

    public string ID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ViewState State
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetViewState(ViewState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIViewElementParent() => throw null;
  }
}
