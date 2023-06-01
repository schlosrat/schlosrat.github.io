// Decompiled with JetBrains decompiler
// Type: JTemp.UIRadioButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace JTemp
{
  [RequireComponent(typeof (Button))]
  public class UIRadioButton : UIInteract
  {
    private Action OnToggledOn;
    private Action OnToggledOff;
    private Button button;
    private UIRadioButton[] radioButtonGroup;
    private bool toggled;

    public bool Toggled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void GetComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIRadioButton() => throw null;
  }
}
