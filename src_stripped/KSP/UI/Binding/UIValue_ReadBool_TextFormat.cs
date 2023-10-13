// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_TextFormat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [Header("Size")]
    [SerializeField]
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
