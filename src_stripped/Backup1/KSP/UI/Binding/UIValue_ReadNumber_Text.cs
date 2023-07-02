// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_ReadNumber_Text : 
    UIValue_ReadObject_Text,
    IUIValueNumberBindable,
    IUIValueBindable
  {
    [Space]
    [Tooltip("Enables overriding the text format with the scientific notation format if the value equals or exceeds the target value")]
    [SerializeField]
    private bool useScientificNotation;
    [SerializeField]
    private string scientificNotationFormat;
    [SerializeField]
    private double scientificNotationTargetValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty valueNumberProperty, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedValueRange(double min, double max, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumber_Text() => throw null;
  }
}
