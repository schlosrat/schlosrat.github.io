// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_GraphicsColor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_ReadBool_GraphicsColor : UIValueBinder<bool>
  {
    [SerializeField]
    private UIValue_ReadBool_GraphicsColor.GraphicEntry[] elementsToColor;

    private string logTag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsValueTrue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadBool_GraphicsColor() => throw null;

    [Serializable]
    private struct GraphicEntry
    {
      public Graphic graphicToColor;
      public Color colorTrue;
      public Color colorFalse;
      public bool modifyAlpha;
      public float animationDuration;
    }
  }
}
