// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_slider_throttle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_slider_throttle : UIWidget
  {
    [Header("Vessel Throttle - Writable")]
    [SerializeField]
    private UIValueBinder throttle;

    public IUIValueNumberBindable Throttle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_slider_throttle() => throw null;
  }
}
