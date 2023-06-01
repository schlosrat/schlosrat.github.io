// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXPlanetaryContextTestTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Assets;
using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim;
using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.VFX
{
  public class VFXPlanetaryContextTestTool : MonoBehaviour
  {
    private GameInstance Game;
    private PrevisGameInstance previsGame;
    private ContextualFxSystem contextualFXSystem;
    private FXContextData testContextData;
    public string VFXPrefabTarget;
    private List<GameObject> _VFXPrefabsByEventType;
    public CelestialBodyData MainCB;
    private PQSTestCameraShot _camera;
    private ICameraShot _flightCamera;
    private Camera _mainCamera;
    private Vector3 _spawnPosition;
    private Quaternion _spawnRotation;
    private GameObject _debugPartGameObj;
    private VFXPartTestingHelper _vfxPartHelper;
    private double AltitudeFromSeaLevel;
    private double AtmosphericDensity;
    private double AtmosphericTemperature;
    private double StaticPressure_kPa;
    private double ExternalTemperature;
    private double DynamicPressure_kPa;
    private double SoundSpeed;
    private double MachNumber;
    private VFXSituation currentSituation;
    private PQSData.BiomeSurfaceData currentBiomeData;
    private double atmosphereTemperatureLapseRate;
    private double atmosphereGasMassLapseRate;
    private double radiusAtmosphereFactor;
    private double atmosphereDensityASL;
    [Header("UI References")]
    public GameObject Canvas_UI;
    public Text Text_Info;
    public Text Text_SelectedPrefabName;
    public Dropdown Dropdown_EventType;
    public Dropdown Dropdown_Prefab;
    public Toggle Toggle_OverridePrefabName;
    public Toggle Toggle_ShowInfo;
    public Toggle Toggle_SpawnOnRay;
    public GameObject Group_OverridePrefabName;
    public GameObject Group_TextInfo;
    [Header("FX Context Data UI")]
    public Toggle Toggle_OverrideFXContextData;
    public GameObject Group_FXContextOverride;
    public Slider Slider_AtmoDensity;
    public InputField InputField_AtmoDensity;
    public Slider Slider_AtmoTemperature;
    public InputField InputField_AtmoTemperature;
    public Slider Slider_Gravity;
    public InputField InputField_Gravity;
    public Dropdown Dropdown_BiomeType;
    public Slider Slider_MachNumber;
    public InputField InputField_MachNumber;
    public Dropdown Dropdown_Situation;
    public Dropdown Biome_Color;
    private VFXEventType selectedEventType;
    private FXContextualEvent fxEvent;
    private AssetProvider _assets;
    private bool _initializedForPlanetaryScenes;
    public BiomeTextureColorLookupTable biomeTextureColorLUT;

    public VFXPartTestingHelper VFXPartHelper
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDevTerrainCollision(
      PQSData.BiomeSurfaceData biomeData,
      float hitDistance,
      Vector3 normal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadPrefab(bool useSpawnPosition = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePrefabTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSituation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAltitudeFromSeaLevel(Position pos, out double altFromSeaLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadVFXPrefabs(VFXEventType vfxEventType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVFXPrefabsLoaded(IList<GameObject> prefabs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupConstants() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAtmosphericValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMainCB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateContextData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTemperature(double altitude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetPressure(double altitudeFromSeaLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDensity(double pressure, double temperature) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOverridePrefabChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOverrideFXContextChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTextInfoChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEventTypeChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAtmoDensitySliderChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAtmoDensityTextChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAtmoTemperatureSliderChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAtmoTemperatureTextChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGravitySliderChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGravityTextChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMachNumberSliderChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMachNumberTextChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBiomeTypeChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSituationChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXPlanetaryContextTestTool() => throw null;
  }
}
