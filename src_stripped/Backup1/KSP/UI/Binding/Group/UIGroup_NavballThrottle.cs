// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Group.UIGroup_NavballThrottle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Widget;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Group
{
  public class UIGroup_NavballThrottle : UIWidgetGroup
  {
    [SerializeField]
    private UIWidget_slider_throttle throttleWidget;
    [SerializeField]
    private UIWidget_indicator_navball navballWidget;
    [SerializeField]
    private UIWidget_indicator_heading headingWidget;
    [SerializeField]
    private UIWidget_indicator_attitude yawWidget;
    [SerializeField]
    private UIWidget_indicator_attitude pitchWidget;
    [SerializeField]
    private UIWidget_indicator_attitude rollWidget;

    public UIWidget_slider_throttle ThrottleWidget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIWidget_indicator_navball NavballWidget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIWidget_indicator_heading HeadingWidget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIWidget_indicator_attitude YawWidget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIWidget_indicator_attitude PitchWidget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIWidget_indicator_attitude RollWidget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIGroup_NavballThrottle() => throw null;
  }
}
