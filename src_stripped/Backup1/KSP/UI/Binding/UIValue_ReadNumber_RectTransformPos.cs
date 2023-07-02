// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_RectTransformPos
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadNumber_RectTransformPos : UIValueNumberBinder
  {
    [Header("Transform To Resize")]
    [SerializeField]
    private RectTransform rectTransform;
    [SerializeField]
    private bool _setXPos;
    [SerializeField]
    private float minXPos;
    [SerializeField]
    private float maxXPos;
    [SerializeField]
    private bool _setYPos;
    [SerializeField]
    private float minYPos;
    [SerializeField]
    private float maxYPos;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMappedNumberRangeChanged(
      UIValueNumberRange oldRange,
      bool shouldRedraw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumber_RectTransformPos() => throw null;
  }
}
