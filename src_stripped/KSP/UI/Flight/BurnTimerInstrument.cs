// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.BurnTimerInstrument
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Flight
{
  public class BurnTimerInstrument : UIFlightHUDInstrument
  {
    [Tooltip("Window in seconds")]
    [SerializeField]
    private int _playerBurnInputWindow;
    [Header("Light tree")]
    [SerializeField]
    private Image[] _lights;
    [SerializeField]
    private Color _offColor;
    [SerializeField]
    private Color _greenColor;
    [SerializeField]
    private Color _yellowColor;
    [SerializeField]
    private Color _redColor;
    [Header("Light tree animation binders")]
    [SerializeField]
    private BurnTimerLightCountdownUIValueBinder _startBurnCountdown;
    [SerializeField]
    private BurnTimerLightCountdownUIValueBinder _stopBurnCountdown;
    [SerializeField]
    private BurnTimerLightConfirmationUIValueBinder _startBurnConfirmation;
    [SerializeField]
    private BurnTimerLightConfirmationUIValueBinder _stopBurnConfirmation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BurnTimerInstrument() => throw null;
  }
}
