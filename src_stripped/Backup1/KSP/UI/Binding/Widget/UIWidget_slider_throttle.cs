// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_slider_throttle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
