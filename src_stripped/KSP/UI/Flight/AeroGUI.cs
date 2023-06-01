// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.AeroGUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI.Flight
{
  public class AeroGUI : 
    KerbalMonoBehaviour,
    IBeginDragHandler,
    IEventSystemHandler,
    IDragHandler,
    IInitializePotentialDragHandler
  {
    public const string FIELD_DYNAMIC_PRESSURE = "Flight/DynamicPressure";
    public const string FIELD_STATIC_PRESSURE = "Flight/StaticPressure";
    public const string FIELD_DENSITY = "Flight/Density";
    public const string FIELD_STATIC_AMBIENT_TEMPERATURE = "Flight/StaticAmbientTemperature";
    public const string FIELD_EXTERNAL_TEMPERATURE = "Flight/ExternalTemperature";
    public const string FIELD_SOUND_SPEED = "Flight/SoundSpeed";
    public const string FIELD_MACH_NUMBER = "Flight/MachNumber";
    public const string FIELD_ANGLE_OF_ATTACK = "Flight/AngleOfAttack";
    public const string FIELD_SIDESLIP = "Flight/Sideslip";
    public const string FIELD_TOTAL_DRAG = "Flight/TotalDrag";
    public const string FIELD_TOTAL_LIFT = "Flight/TotalLift";
    public const string FIELD_LIFT_DRAG_RATIO = "Flight/LiftDragRatio";
    public const string FIELD_TOTAL_THRUST = "Flight/TotalThrust";
    private static readonly HashSet<System.Type> _dragForceTypes;
    private static readonly HashSet<System.Type> _liftForceTypes;
    private static readonly HashSet<System.Type> _thrustForceTypes;
    private bool _isInitialized;
    private RectTransform _rectTransform;
    private RectTransform _rectTransformParent;
    private Vector2 _dragStartOffset;
    private double _totalDrag;
    private double _totalLift;
    private double _totalThrust;
    private double _liftDragRatio;
    private double _alpha;
    private double _sideslip;
    [SerializeField]
    private TMP_Text _tmpDynamicPressure;
    [SerializeField]
    private TMP_Text _tmpStaticPressure;
    [SerializeField]
    private TMP_Text _tmpDensity;
    [SerializeField]
    private TMP_Text _tmpStaticAmbTemp;
    [SerializeField]
    private TMP_Text _tmpExternalTemp;
    [SerializeField]
    private TMP_Text _tmpSpeedOfSound;
    [SerializeField]
    private TMP_Text _tmpMachNumber;
    [SerializeField]
    private TMP_Text _tmpAlpha;
    [SerializeField]
    private TMP_Text _tmpSideslip;
    [SerializeField]
    private TMP_Text _tmpTotalLift;
    [SerializeField]
    private TMP_Text _tmpTotalDrag;
    [SerializeField]
    private TMP_Text _tmpLiftDragRatio;
    [SerializeField]
    private TMP_Text _tmpTotalThrust;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetAeroStats(VesselComponent activeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTextFields(VesselComponent activeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetFormattedStringWithNaNCheck(double quantity, string format) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeginDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnInitializePotentialDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AeroGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AeroGUI() => throw null;
  }
}
