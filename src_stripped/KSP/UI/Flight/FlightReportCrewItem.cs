// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightReportCrewItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
