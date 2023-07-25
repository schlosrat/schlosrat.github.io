// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_TextFormat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  [RequireComponent(typeof (TextMeshProUGUI))]
  public class UIValue_ReadBool_TextFormat : UIValueBinder<bool>
  {
    [SerializeField]
    private TextMeshProUGUI _targetText;
    [SerializeField]
    private float _animationDuration;
    [SerializeField]
    [Header("Size")]
    private bool _updateSize;
    [SerializeField]
    private float _sizeOn;
    [SerializeField]
    private float _sizeOff;
    [SerializeField]
    [Header("Color")]
    private bool _updateColor;
    [SerializeField]
    private Color _colorOn;
    [SerializeField]
    private Color _colorOff;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadBool_TextFormat() => throw null;
  }
}
