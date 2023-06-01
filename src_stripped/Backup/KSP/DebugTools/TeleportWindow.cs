// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.TeleportWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.DebugTools
{
  public class TeleportWindow : KerbalMonoBehaviour
  {
    private const string TARGET_TYPE = "Current Targeted Object";
    private const string VESSEL_TYPE = "Vessel";
    private const string COLONY_TYPE = "Colony";
    private const string PART_TYPE = "Part";
    private static readonly string PREFAB_KEY;
    private static TeleportWindow Instance;
    [SerializeField]
    private GameObject _orbitForm;
    [SerializeField]
    private TMP_Dropdown _orbitCelestialBodyDropdown;
    [SerializeField]
    private TMP_InputField _orbitSemimajorAxisField;
    [SerializeField]
    private TMP_InputField _orbitEccentricityInputField;
    [SerializeField]
    private TMP_InputField _orbitInclinationAxisField;
    [SerializeField]
    private TMP_InputField _orbitAscendingInputField;
    [SerializeField]
    private TMP_InputField _orbitArgumentInputField;
    [SerializeField]
    private TMP_InputField _orbitMeanAnomalyAtEpochInputField;
    [SerializeField]
    private TMP_InputField _orbitEpochInputField;
    [SerializeField]
    private GameObject _surfaceForm;
    [SerializeField]
    private TMP_Dropdown _surfaceCelestialBodyDropdown;
    [SerializeField]
    private TMP_InputField _surfaceLatitudeInputField;
    [SerializeField]
    private TMP_InputField _surfaceLongitudeInputField;
    [SerializeField]
    private TMP_InputField _surfaceAltitudeInputField;
    [SerializeField]
    private TMP_InputField _surfaceSpeedInputField;
    [SerializeField]
    private GameObject _rendezvousForm;
    [SerializeField]
    private TMP_Dropdown _rendezvousTypeDropdown;
    [SerializeField]
    private TMP_Dropdown _rendezvousObjectsDropdown;
    [SerializeField]
    private TMP_InputField _rendezvousDistanceXInputField;
    [SerializeField]
    private TMP_InputField _rendezvousDistanceYInputField;
    [SerializeField]
    private TMP_InputField _rendezvousDistanceZInputField;
    [SerializeField]
    private TMP_InputField _rendezvousPitchInputField;
    [SerializeField]
    private TMP_InputField _rendezvousYawInputField;
    [SerializeField]
    private TMP_InputField _rendezvousRollInputField;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectOrbit(bool isSelected) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectSurface(bool isSelected) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectRendezvous(bool isSelected) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TeleportToRendezvous() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TeleportToOrbit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TeleportToSurface() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReloadRendezvousObjectsDropDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TeleportWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TeleportWindow() => throw null;
  }
}
