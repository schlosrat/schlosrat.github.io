// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteColor_AlphaToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_WriteColor_AlphaToggle : UIValueBinder<Color>
  {
    [SerializeField]
    private ToggleExtended toggle;
    [SerializeField]
    private bool makeNonclickableWhenOn;
    private bool ignoreToggleEvents;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleToggleValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetInteractableState(bool isInteractable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteColor_AlphaToggle() => throw null;
  }
}
