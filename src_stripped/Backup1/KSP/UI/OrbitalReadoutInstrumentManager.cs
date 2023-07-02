// Decompiled with JetBrains decompiler
// Type: KSP.UI.OrbitalReadoutInstrumentManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using KSP.UI.Flight;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class OrbitalReadoutInstrumentManager : UIFlightHUDInstrument
  {
    [SerializeField]
    private UIValue_ReadNumber_TextUnits _distancePropDataApoapsis;
    [SerializeField]
    private UIValue_ReadNumber_TextUnits _distancePropDataPeriapsis;
    private DataContext _dataContext;
    private Property<double> _apoapsis;
    private Property<double> _periapsis;
    private Property<double> _apoasisTime;
    private Property<double> _periapsisTime;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitalReadoutInstrumentManager() => throw null;
  }
}
