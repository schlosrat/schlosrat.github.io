// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.BurnTimerLightCountdownUIValueBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Maneuver;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class BurnTimerLightCountdownUIValueBinder : UIValueNumberBinder
  {
    [SerializeField]
    private bool _isStartBurn;
    private ManeuverProvider _maneuverProvider;
    private bool _isInitialized;
    private Image[] _lights;
    private Color _offColor;
    private Color _greenColor;
    private Color _yellowColor;
    private Color _redColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      Image[] lights,
      Color offColor,
      Color greenColor,
      Color yellowColor,
      Color redColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLightTree(int timeLeft) => throw null;

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
    public BurnTimerLightCountdownUIValueBinder() => throw null;
  }
}
