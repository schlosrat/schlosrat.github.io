// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightReportCrewItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
