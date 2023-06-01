// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.UIValue_ReadIsDead_Icon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Iteration.UI.Binding
{
  public class UIValue_ReadIsDead_Icon : UIValueBinder<bool>
  {
    [SerializeField]
    private Image icon;
    [SerializeField]
    private Color colorAlive;
    [SerializeField]
    private Color colorDead;
    [SerializeField]
    private float animateDuration;

    private bool IsDead
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadIsDead_Icon() => throw null;
  }
}
