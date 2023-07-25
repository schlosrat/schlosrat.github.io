// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightReportCrewItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Flight
{
  public class FlightReportCrewItem : KerbalMonoBehaviour, IDisposable
  {
    [SerializeField]
    private Image _debugProfileIcon;
    [SerializeField]
    private TextMeshProUGUI _name;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(Sprite crewIcon, string crewName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightReportCrewItem() => throw null;
  }
}
