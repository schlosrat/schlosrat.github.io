// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXTestSuiteDialog
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
using UnityEngine.UI;

namespace KSP.VFX
{
  public class VFXTestSuiteDialog : KerbalMonoBehaviour
  {
    public const string DIALOG_PREFAB = "VFXTestSuite.prefab";
    [SerializeField]
    private ButtonExtended _closeWindowButton;
    [SerializeField]
    private TMP_Text _consoleText;
    [SerializeField]
    private TMP_Dropdown _mode;
    [SerializeField]
    private Button _multiFunctionButton;
    [SerializeField]
    private Toggle _showVFXPositions;
    [SerializeField]
    private Toggle _showChildPositions;
    [SerializeField]
    private Button _testDecouple;
    [SerializeField]
    private Button _testLaunchClamp;
    [SerializeField]
    private Button _testFairing;
    [SerializeField]
    private Button _testParachute;
    private static bool _initialActivationState;
    private VFXTestSuiteDialog.Mode _currentMode;
    private Dictionary<IGGuid, VFXTestSuiteDialog.ActiveEffect> _activeEffects;
    private Dictionary<IGGuid, VFXTestSuiteDialog.ActiveContact> _activeSurfaceContacts;
    private Dictionary<IGGuid, VFXTestSuiteDialog.ActiveLaunchEffect> _activeLaunchSmokeEffects;
    private Dictionary<IGGuid, VFXTestSuiteDialog.ActiveLaunchEffect> _activeLaunchFireEffects;
    private List<VFXTestSuiteDialog.RejectionMarker> _rejections;
    private Dictionary<IGGuid, VFXTestSuiteDialog.ActiveVesselGroundBlastGroup> _groundBlastVessels;
    private Vector3 scaleVector;
    public Mesh SphereMesh;
    private Material _nodeDrawMat;
    private Material _nodeRejectMat;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMultiFunctionButtonClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTestDecouple() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTestLaunchClamp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTestFairing() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTestParachute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModeSelectionChanged() => throw null;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateMaterials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRenderObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecurseDrawChildObjects(GameObject obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowRejectedEvent(FXContextualEvent fxevent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update_General() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update_LaunchFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update_SurfaceInteractions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update_GroundBlast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update_VFXSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterActiveEffect(IGGuid partguid, string partname, string prefabname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterActiveEffect(IGGuid partguid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLaunchSmokeFX(
      IGGuid partguid,
      string partname,
      float normalizedThrustDistance,
      float normalizedthrust,
      float thrust,
      float throttle,
      float distance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterLaunchSmoke(IGGuid partguid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLaunchFireFX(
      IGGuid partguid,
      string partname,
      float normalizedThrustDistance,
      float normalizedthrust,
      float thrust,
      float throttle,
      float distance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterLaunchFire(IGGuid partguid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterPartSurfaceContact(
      IGGuid partguid,
      string partname,
      float relativeVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePartSurfaceContact(IGGuid partguid, float relativeVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterPartSurfaceContact(IGGuid partguid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOrUpdateGroundBlastFX(
      IGGuid vesselGuid,
      string vesselName,
      int engineIdx,
      Vector3 pos,
      Quaternion orientation,
      float raycastDistance,
      float deviationFromVertical,
      float throttle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterGroundBlastFX(IGGuid vesselGuid, int engineIdx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXTestSuiteDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VFXTestSuiteDialog() => throw null;

    internal class ActiveContact
    {
      public bool Active;
      public string PartName;
      public float RelativeVelocity;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ActiveContact() => throw null;
    }

    internal class ActiveLaunchEffect
    {
      public string PartName;
      public float NormalizedThrust;
      public float NormalizedThrustDistance;
      public float ThrustMagnitude;
      public float ThrottleSetting;
      public float DistanceFromLaunch;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ActiveLaunchEffect() => throw null;
    }

    internal class ActiveEngineGroundBlastEffect
    {
      public Vector3 Pos;
      public Quaternion Orientation;
      public float RaycastDistance;
      public float DeviationFromVertical;
      public float Throttle;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ActiveEngineGroundBlastEffect() => throw null;
    }

    internal class ActiveVesselGroundBlastGroup
    {
      public string VesselName;
      public Dictionary<int, VFXTestSuiteDialog.ActiveEngineGroundBlastEffect> ActiveEffects;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddOrUpdateGroundBlastEffect(
        int engineIdx,
        Vector3 pos,
        Quaternion orientation,
        float raycastDistance,
        float deviationFromVertical,
        float throttle)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ActiveVesselGroundBlastGroup() => throw null;
    }

    internal class ActiveEffect
    {
      public string PartName;
      public string FXPrefabName;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ActiveEffect() => throw null;
    }

    internal class RejectionMarker
    {
      public float InitialTimeUGT;
      public Vector3 Position;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public RejectionMarker() => throw null;
    }

    private enum Mode
    {
      Invalid = -1, // 0xFFFFFFFF
      TestingTypes = 0,
      SurfaceContacts = 1,
      GroundBlast = 2,
      LaunchFX = 3,
      General = 4,
      SpatialDatabase = 5,
      VFXGlobalSettings = 6,
    }
  }
}
