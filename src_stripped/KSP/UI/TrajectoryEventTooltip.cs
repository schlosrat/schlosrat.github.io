// Decompiled with JetBrains decompiler
// Type: KSP.UI.TrajectoryEventTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class TrajectoryEventTooltip : ExtendedTooltip<TrajectoryEventTooltipData>
  {
    [Space]
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<string> _vesselNameProp;
    private Property<Quaternion> _orientationProp;
    private Property<string> _eventTypeProp;
    private Property<double> _relativeVelProp;
    private Property<Quaternion> _relativeVelIndicatorProp;
    private Property<double> _distanceProp;
    private Property<double> _etaProp;
    private Property<double> _inclinationProp;
    private const string VESSEL_NAME_PROPERTY_KEY = "VesselName";
    private const string VESSEL_ORIENTATION_PROPERTY_KEY = "VesselOrientation";
    private const string EVENT_TYPE_PROPERTY_KEY = "EventType";
    private const string RELATIVE_VEL_PROPERTY_KEY = "RelativeVelocity";
    private const string RELATIVE_VEL_INDICATOR_PROPERTY_KEY = "RelativeVelocityIndicator";
    private const string DISTANCE_PROPERTY_KEY = "DistanceToTarget";
    private const string ETA_PROPERTY_KEY = "ETA";
    private const string INCLINATION_PROPERTY_KEY = "Inclination";
    private UIValue_ReadNumber_TextUnits _distancePropDataFormatter;
    private int DISTANCE_PROP_UNIT_ENTRY_INDEX_KM;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTooltipData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d GetRelativeVelocityAtUT(IPatchedOrbit patch, double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrajectoryEventTooltip() => throw null;
  }
}
