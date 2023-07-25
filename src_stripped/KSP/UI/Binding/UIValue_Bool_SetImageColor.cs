// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_Bool_SetImageColor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_Bool_SetImageColor : UIValueBinder<bool>
  {
    [SerializeField]
    private Image target;
    [SerializeField]
    private Color whenTrue;
    [SerializeField]
    private Color whenFalse;
    [SerializeField]
    [Header("Editor Only")]
    private bool previewState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetColor(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_Bool_SetImageColor() => throw null;
  }
}
