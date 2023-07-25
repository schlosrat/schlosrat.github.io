// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightReportLogItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Flight
{
  public class FlightReportLogItem : KerbalMonoBehaviour
  {
    [SerializeField]
    private Image _icon;
    [SerializeField]
    private TextMeshProUGUI _eventText;
    [SerializeField]
    private Color _successLogColor;
    [SerializeField]
    private Sprite _successLogIcon;
    [SerializeField]
    private Color _missionElapsedTimeSuccessTextColor;
    [SerializeField]
    private Color _failureLogColor;
    [SerializeField]
    private Sprite _failureLogIcon;
    [SerializeField]
    private Color _missionElapsedTimeFailureTextColor;
    [SerializeField]
    private Color _warningLogColor;
    [SerializeField]
    private Sprite _warningLogIcon;
    [SerializeField]
    private Color _missionElapsedTimeWarningTextColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(TravelObjectEvent newEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightReportLogItem() => throw null;
  }
}
