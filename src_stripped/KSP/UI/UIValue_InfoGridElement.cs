// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIValue_InfoGridElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI
{
  public class UIValue_InfoGridElement : UIValueBinder
  {
    [Tooltip("This can totally be empty.")]
    [Header("Pass Units directly or loc path")]
    public string units;
    [Header("Links")]
    public TextMeshProUGUI valueText;
    [SerializeField]
    [Header("Round to Decimal")]
    private bool _roundValue;
    [SerializeField]
    private int _decimalPlaces;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetTargetActive(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_InfoGridElement() => throw null;
  }
}
