// Decompiled with JetBrains decompiler
// Type: KSP.UIValue_ReadOABVariant_SetVisible
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  public class UIValue_ReadOABVariant_SetVisible : UIValueBinder<OABVariant>
  {
    [SerializeField]
    [Tooltip("If the variant we're bound to is the same as this, we make ourselves visible.")]
    private OABVariant _associatedVariant;
    [Tooltip("The object we're toggling the visiblity of. Can be the same or a different object, will default to the same object.")]
    [SerializeField]
    public CanvasGroup _canvasGroup;
    [SerializeField]
    [Tooltip("If the key specified isn't present, what's our default visibility?")]
    public bool _visibleWithNoKey;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCanvasGroupVisibility(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadOABVariant_SetVisible() => throw null;
  }
}
