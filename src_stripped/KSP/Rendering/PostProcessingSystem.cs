// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PostProcessingSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Rendering
{
  public class PostProcessingSystem : MonoBehaviour, IUpdate
  {
    private GameInstance Game;
    private PrevisCameraManager PrevisCameraManager;
    private PrevisGameInstance PrevisGame;
    private bool previsScene;
    [SerializeField]
    private GraphicsManager GraphicsManager;
    private CelestialBodyProvider CelestialBodyProvider;
    private UniverseCameraManager CameraManager;
    private PrevisCelestialBodyProvider PrevisCelestialBodyProvider;
    private SessionManager SessionManager;
    private GraphicsSettings _graphicsSettings;
    public PostProcessingSettings settings;
    [SerializeField]
    [Header("Resources")]
    private PostProcessResources _postProcessResources;
    private int _postLayer;
    private ActiveCameraGroup _activeCameraGroup;
    [SerializeField]
    [Header("Global Profiles")]
    private PostProcessProfile _flightPostProfile;
    [SerializeField]
    private PostProcessProfile _mapPostProfile;
    [SerializeField]
    private PostProcessProfile _oabPostProfile;
    [SerializeField]
    private PostProcessProfile _tutorialProfile;
    private PostProcessVolumeOverride _currentGlobalVolumeOverride;
    private PostProcessVolumeOverride _currentStarVolumeOverride;
    private PostProcessVolumeOverride _currentBodyVolumeOverride;
    [SerializeField]
    private GameObject _flightVolumeObj;
    [SerializeField]
    private GameObject _mapVolumeObj;
    [SerializeField]
    private GameObject _oabVolumeObj;
    private string _starName;
    private double _starVolumeInnerRadius;
    private double _starVolumeOuterRadius;
    private bool _starBlendingActive;
    private CelestialBodyLightingData _lightingData;
    private string _bodyName;
    private double _bodyVolumeInnerRadius;
    private double _bodyVolumeOuterRadius;
    private bool _bodyBlendingActive;
    [SerializeField]
    private PostProcessVolume _tutorialVolume;
    private bool _cachedOverrideEnable;
    private bool _cachedFlightEnable;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessResources GetPostProcessResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPrevisProfile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckGraphicsSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSettingChanged(Setting setting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCameraChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSOIEntered(string bodyEntered, bool isStar) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSOIExited(bool isStar) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTutorialLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTutorialEnded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFlightPostVolumes(Position observedPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOABPostVolumes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessVolume AddQuickVolume(PostProcessProfile profile, VolumePriority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVolume(PostProcessVolume volume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PostProcessVolumeOverride AddPostProcessVolumeOverride(
      GameObject volumeObj,
      Transform trans)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessVolumeOverride CreatePostProcessVolumeOverride(
      VolumePriority priority,
      string name,
      PostProcessData data,
      Transform trans)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemovePostProcessVolumeOverride(ref PostProcessVolumeOverride volumeOverride) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PostProcessVolume AddQuickVolumeTutorial(VolumePriority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableClouds(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEnabledAllVolumes(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEnabledFlightVolumes(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveStarPostVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveBodyPostVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEnabledTutorialVolume(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessingSystem() => throw null;
  }
}
