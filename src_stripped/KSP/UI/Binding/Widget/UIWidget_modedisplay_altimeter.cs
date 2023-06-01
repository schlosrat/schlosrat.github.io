// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_modedisplay_altimeter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_modedisplay_altimeter : UIWidget
  {
    [Header("Enum for Altitude Mode - Writable")]
    [SerializeField]
    private UIValueBinder altimeterMode;
    [Header("Altitude Value for current Velocity Mode - Readonly")]
    [SerializeField]
    private UIValueBinder altimeterDisplay;

    public IUIValueEnumBindable AltimeterMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueNumberBindable AltimeterDisplay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_modedisplay_altimeter() => throw null;
  }
}
