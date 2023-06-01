// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.GamepadClickLayoutTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.Navigation
{
  public class GamepadClickLayoutTrigger : 
    KerbalMonoBehaviour,
    IPointerClickHandler,
    IEventSystemHandler
  {
    public GameObject TargetLayout;
    private INavigatable _layout;

    private INavigatable Layout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GamepadClickLayoutTrigger() => throw null;
  }
}
