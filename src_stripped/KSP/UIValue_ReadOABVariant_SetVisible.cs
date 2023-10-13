// Decompiled with JetBrains decompiler
// Type: KSP.UIValue_ReadOABVariant_SetVisible
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.OAB;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  public class UIValue_ReadOABVariant_SetVisible : UIValueBinder<OABVariant>
  {
    [Tooltip("If the variant we're bound to is the same as this, we make ourselves visible.")]
    [SerializeField]
    private OABVariant _associatedVariant;
    [Tooltip("The object we're toggling the visiblity of. Can be the same or a different object, will default to the same object.")]
    [SerializeField]
    public CanvasGroup _canvasGroup;
    [Tooltip("If the key specified isn't present, what's our default visibility?")]
    [SerializeField]
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
