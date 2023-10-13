// Decompiled with JetBrains decompiler
// Type: KSP.UI.Map3DFocusItemTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Map;
using KSP.Sim.impl;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class Map3DFocusItemTooltip : StandardTooltip
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private SimulationObjectModel _simObject;
    private const string NAME_KEY = "Name";
    private const string ALTITUDE_KEY = "Altitude";
    private const string VELOCITY_KEY = "Velocity";
    private const string HIDE_VELOCITY_ALTUTUDE_KEY = "HideVelocityAltitude";
    private const string CELESTIALBODY_LOC_PATH = "CelestialBody/";
    private Property<string> _nameProp;
    private Property<bool> _hideVelocityAltitude;
    private PropertyExternal<double> _velocityProp;
    private PropertyExternal<double> _altitudeProp;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(SimulationObjectModel simObject, MapItemType itemType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetAltitude() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DFocusItemTooltip() => throw null;
  }
}
