// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Networking.MP;
using KSP.OAB;
using KSP.Rendering.Planets;
using KSP.VFX;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class PartBehavior : 
    ViewObjectComponent<PartComponent>,
    IInteractivePart,
    IFixedUpdate,
    IPriorityOverride,
    WaterManager.IWaterDetectObject
  {
    private const string untagged = "Untagged";
    public bool debugMode;
    public List<Collider> currentCollisions;
    public bool GroundContact;
    public bool PermanentGroundContact;
    public Vector3 GroundContactNormal;
    public bool WaterContact;
    [HideInInspector]
    public uint WaterDetectObjectId;
    private readonly List<ConfigurableJoint> _tempJointStorage;
    private List<AttachNodeData> _tempAttachmentData;
    private DictionaryValueList<System.Type, IPartModule> modules;
    private bool _isInitialized;
    private ProcedurallyEditablePart _procedurallyEditablePart;
    public IPartBrakes partBrake;
    private PartHeatIndicatorTracker _partHeatIndicatorTracker;
    private bool _enableVerboseCollisionDebug;

    public DictionaryValueList<System.Type, IPartModule> Modules
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform ModelTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Collider _collider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Collider[] Colliders
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Renderer[] Renderers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool Landed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Splashed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<PartBehavior> OnUnpack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<PartBehavior> OnPack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public PartHeatIndicatorTracker PartHeatIndicatorTracker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetInitialized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(PartComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnProceduralPartFinalized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCollisionEnter(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCollisionExit(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCollisionStay(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTriggerEnter(Collider otherCollider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CollisionDetails BuildCollisionDetails(
      CollisionDetails.CollisionEventType collisionEventType,
      Collider impactedCollider,
      Vector3 relativeVelocity,
      Vector3 contactPoint,
      Vector3 contactNormal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsOceanImpact(Collider collider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsSurvivableCrash(Collider otherCollider, Vector3 relativeVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnJointBreak(float breakForce) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPartColliders() => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGGuid Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCategoryName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDisplayName() => throw null;

    public PartOwnerBehavior partOwner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselBehavior vessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public System.Type ModelType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSPPartAudioManager PartAudioManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool ShieldedFromAirstream
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<FXGroup> fxGroups
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double staticPressureAtm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double atmDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double soundSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double machNumber
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RigidbodyBehavior Rigidbody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector VelocityRelativeToSOIBodyFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector3 VelocityRelativeToSOIBodyFrameInPhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double SpeedRelativeToSOIBodyFrameInPhysics
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float dynamicPressure
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float dynamicPressure_kPa
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float explosionPotential
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SeperationVFXController seperationVFXController
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PartCategories Category
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeData FindAttachNode(string nodeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartOwnerBehavior GetPartOwner() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselBehavior GetVesselBehavior() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Vector3 WaterManager.IWaterDetectObject.GetPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    CelestialBodyComponent WaterManager.IWaterDetectObject.GetBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Vector3 WaterManager.IWaterDetectObject.GetHorizonUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RedirectChildPhysX(UnityEngine.Rigidbody rb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool VerifyStopPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool VerifyPackPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool VerifyUnpackPhysX(bool rigidbodyExpected, bool jointExpected) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Transform FindModelTransform(string transformName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<Transform> FindModelTransforms(string transformName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXGroup FindFxGroup(string v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSkinThermalFlux(double v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddForce(IForce force) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveForce(IForce force) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSingleFrameForce(IForce force) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTorque(ITorque torque) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTorque(ITorque torque) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyImpulse(
      ForceType forceType,
      Vector3d relativeImpulse,
      Vector3d relativePosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddThermalFlux(double thermalFlux) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DetermineNewParent(
      PartOwnerBehavior partOwnerBehavior,
      out Transform newParent,
      out ITransformFrame newParentReferenceFrame)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TriggerSurfaceImpactEffect(
      Vector3 contactPoint,
      Quaternion effectRotation,
      float deviationFromVertical,
      SimulationObjectModel celestialBodyModel,
      Collider hitCollider)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartComponentExplosion(FXContextualEventParams eventParams) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartComponentWaterSplash(WaterSplashEventData waterSplashEventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IPartModule GetModule(System.Type moduleType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetModule<T>() where T : class, IPartModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ActivateAllModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandlePartDetach(PartOwnerBehavior oldOwner, bool showFX) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PublishPartDetachMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandlePartDetachEffects(PartOwnerBehavior oldOwner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandlePartDetachPhysics(PartOwnerBehavior oldOwner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncToSimulationObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void HandleCollisionEnter(CollisionDetails collisionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void HandleCollisionExit(CollisionDetails collisionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void HandleCollisionStay(CollisionDetails collisionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionEnter(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionExit(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionStay(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionEnterEffects(
      Vector3 relativeVelocity,
      Vector3 contactPoint,
      Vector3 contactNormal,
      int collisionLayer,
      bool isOcean,
      bool isSurvivable,
      Collider hitCollider)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionEnterInternal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleTriggerEnter(Collider otherCollider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionExitInternal(int collisionLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnsplashVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionStayInternal(
      Vector3 contactNormal,
      int collisionLayer,
      bool isOceanImpact)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleTriggerEnterInternal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionEnterAnimation(float collisionRelativeVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateBiomeAudio(
      Collider otherCollider,
      bool isTerrainCollision,
      Vector3 position)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionEnterAudio(
      Collider otherCollider,
      int collisionLayer,
      Vector3 contactPoint,
      Vector3 relativeVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionExitAudio(int collisionLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionStayAudio(
      Collider otherCollider,
      int collisionLayer,
      Vector3 contactPoint,
      Vector3 relativeVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionEnterVFX(
      Collider hitCollider,
      Vector3 contactPoint,
      Vector3 relativeVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionStayVFX(
      Collider hitCollider,
      Vector3 contactPoint,
      Vector3 relativeVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionExitVFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleWaterSplashEffects(
      Vector3 contactPoint,
      float deviationFromVertical,
      float contactVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExecuteInteractivePartDestruction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleExplosionEffect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandlePartDestruction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsLandableLayer(int gameObjectLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsDefaultLayer(int gameObjectLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsTerrainLayer(int gameObjectLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsSceneryLayer(int gameObjectLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetComponentUpwards<T>(GameObject obj) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CleanSymmetryVesselReferencesRecursively() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CleanSymmetryVesselReferences() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateRendererLists() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckBodyLiftAttachment() => throw null;

    public bool IsNoCrashDamageEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector GetVelocityRelativeToSOIBodyFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyInteractivePart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartBehavior() => throw null;
  }
}
