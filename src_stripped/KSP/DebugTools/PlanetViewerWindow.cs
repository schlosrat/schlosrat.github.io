// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.PlanetViewerWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class PlanetViewerWindow : KerbalMonoBehaviour
  {
    private static readonly string PREFAB_KEY;
    private static PlanetViewerWindow Instance;
    private string _bookmarksDir;
    private Coroutine _statusMessageCoroutine;
    private TMP_InputField[] _inputFields;
    [SerializeField]
    private TMP_InputField _newBookmarkNameInputField;
    [SerializeField]
    private TMP_Dropdown _bookmarksDropdown;
    [SerializeField]
    private TMP_Text _statusMessageText;
    [SerializeField]
    private GameObject _noCelestialBodiesMessage;
    [SerializeField]
    private GameObject _cloudsForm;
    [SerializeField]
    private GameObject _teleportForm;
    [SerializeField]
    private GameObject _rotationForm;
    [SerializeField]
    private GameObject _kerbalForm;
    [SerializeField]
    private TMP_Text _currentValuesText;
    [SerializeField]
    private TMP_Dropdown _celestialBodyDropdown;
    [SerializeField]
    private TMP_InputField _latitudeInputField;
    [SerializeField]
    private TMP_InputField _longitudeInputField;
    [SerializeField]
    private TMP_InputField _altitudeInputField;
    [SerializeField]
    private TMP_InputField _camAngleInputField;
    [SerializeField]
    private TMP_InputField _camPitchInputField;
    [SerializeField]
    private Toggle _renderCloudsToggle;
    [SerializeField]
    private Slider _rotationOffsetSlider;
    [SerializeField]
    private TMP_Text _rotationOffsetText;
    [SerializeField]
    private TMP_InputField _forceRotationAngleInputField;
    [SerializeField]
    private TMP_Text _currentCelestialRotationText;
    [SerializeField]
    private Slider _kerbalForwardOffsetSlider;
    [SerializeField]
    private TMP_Text _kerbalForwardOffsetText;
    [SerializeField]
    private Slider _kerbalVerticalOffsetSlider;
    [SerializeField]
    private TMP_Text _kerbalVerticalOffsetText;
    [SerializeField]
    private GameObject _exitPlanetViewButton;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Teleport() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExitPlanetViewerToKSC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ExitPlanetViewerToFlightView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RenderClouds(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOffsetRotationChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOffsetRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowKerbalForScale(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnKerbalForwardOffsetChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnKerbalVerticalOffsetChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveNewBookmark() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveSelectedBookmark() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadSelectedBookmark() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteSelectedBookmark() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshPanels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetSelectedBookmarkFilePath(out string filePath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string SerializeCurrentState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeserializeCurrentState(string json) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshBookmarks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowStatusMessage(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator ShowStatusMessageCoroutine(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlanetViewerWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PlanetViewerWindow() => throw null;

    [Serializable]
    public class PlanetViewerBookmark
    {
      public string CelestialBody;
      public string Latitude;
      public string Longitude;
      public string Altitude;
      public string CamAngle;
      public string CamPitch;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PlanetViewerBookmark() => throw null;
    }
  }
}
