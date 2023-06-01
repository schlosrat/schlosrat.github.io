// Decompiled with JetBrains decompiler
// Type: KSP.UI.OrbitalReadoutInstrumentManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class OrbitalReadoutInstrumentManager : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
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
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitalReadoutInstrumentManager() => throw null;
  }
}
