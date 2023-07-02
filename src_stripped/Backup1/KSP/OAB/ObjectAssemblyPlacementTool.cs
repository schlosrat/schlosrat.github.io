// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyPlacementTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Input;
using KSP.Messages;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyPlacementTool : ObjectAssemblyTool
  {
    private const float ANGLE_ISNT_OPPOSITE_THRESHOLD = -0.4f;
    private const float MAX_SCREEN_DISTANCE_TOSHOW_SNAP_UI = 0.25f;
    private const float PITCH_LIMIT_DEGREES = 90f;
    private static readonly float EPSILON_SQR;
    private IDisposable iconLoadAction;
    private List<IObjectAssemblyPart> closeParts;
    private OabInputDefinition _inputDefinition;
    private bool _modifierTriggered;
    private bool _disableStackAttachment;
    private bool _cameraFastModifierTriggered;
    protected bool _tertiaryDown;
    protected readonly HashSet<Outline> _outlined;
    protected readonly HashSet<IObjectAssemblyPart> _outlinedParts;
    protected ObjectAssemblyPartTracker partTracker;
    protected ObjectAssemblyInputHandler utilInput;
    protected OABSessionInformation stats;
    protected ObjectAssemblyCameraManager cameraManager;
    protected IObjectAssemblyPart partToAttachTo;
    protected IObjectAssemblyPartNode parentNodeToAttach;
    protected IObjectAssemblyPartNode childNodeToAttach;
    public float cameraPannedVertically;
    private float lastHeightCameraMovedVertically;
    public Vector3 rotateAxis;
    private List<IObjectAssemblyPartNode> _grabbedNodes;
    private List<IObjectAssemblyPartNode> _validNodes;
    private List<ObjectAssemblyPlacementTool.ScreenNodeInfo> validFlatNodes;
    private List<ObjectAssemblyPlacementTool.ScreenNodeInfo> grabbedNodesScreenSpace;
    public const float raycastLimit = 2000f;
    public const float RaycastOffset = 5f;
    protected bool isRotating;
    protected bool _isDragging;
    protected bool isAligningPartToAnotherPart;
    private string partsPanelTag;
    private string partsPanelHiddenTag;
    protected IObjectAssembly lastOutlinedAssembly;
    protected IObjectAssembly lastMousedOverAssembly;
    protected IObjectAssemblyPart partPreviouslyUnderCursor;
    protected IObjectAssemblyPart lastGrabbedPart;
    protected ObjectAssemblyAssets oabAssets;
    private PartPlacementVFX _partPlacementVFX;
    private bool _lastSnapDidShow;
    private IObjectAssemblyPart _potentialPAMPart;
    private float _potentialPAMRightClickStartTime;
    private Shader partSelectionShader;
    private Dictionary<IGGuid, List<ObjectAssemblyPlacementTool.RendererShaderCache>> selectedPartRenderers;
    private IObjectAssembly _prevMainAssembly;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected IObjectAssemblyPart PartUnderCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected virtual bool CanOutlineDisabledRenderers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected virtual bool DoOutlinesFilterNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected IObjectAssemblyPart PartGrabbed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindValidNodes(List<IObjectAssemblyPartNode> validNodes) => throw null;

    protected bool GrabbingParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void GetGrabbedNodes(List<IObjectAssemblyPartNode> grabbedNodes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyPlacementTool(
      ObjectAssemblyBuilderEvents eventSystemToUse,
      ObjectAssemblyUIEvents uiEventsToUse,
      ObjectAssemblyInputHandler inputToUse,
      ObjectAssemblyPartTracker partTrackerToUse,
      OABSessionInformation statsToUse,
      ObjectAssemblyCameraManager cameraManagerToUse,
      ObjectAssemblyAssets oabAssets)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupCursorForTool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Terminate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeInputEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDelete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnModifier(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisableStackAttachmentHeld(bool isHeld) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraFastModifier(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool IsStackAttachment(
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPlacingPart(bool isAttachedToSomethingElse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowNodesOnAttachableParts(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnGrabbingPart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PrimaryActionDoubleClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PrimaryActionClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlaceAsTool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PickAsTool(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearInternalTracking() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsViewCubeUnderCursor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SecondaryActionUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SectiondaryActionDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GamepadRightStickPerformed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void TertiaryActionUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void TertiaryActionDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnCameraRotate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnCameraRotateReleased() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPreUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePartVisibilityOverUI(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSnapRotation(Vector3 rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnResetRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPostUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPreLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPostLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PostSnapToSurfaceOrNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PostSnapSelectionToNearbyNode(bool didShow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PostSnapSelectionToSurface(bool didShow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateValidScreenSpaceNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateClosestNodes(out Vector3 grabbedBestNodePos, out Vector3 otherBestNodePos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGrabbedScreenSpaceNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SnapNodes(
      IObjectAssemblyPartNode snapTarget,
      IObjectAssemblyPartNode gettingSnapped)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool NodesOrientationIsConnectable(
      IObjectAssemblyPartNode childNode,
      IObjectAssemblyPartNode parentNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SnapSelectionToNearbyNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetScreenSpaceNodeRadius(IObjectAssemblyPartNode node, Vector2 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3 NearestPointOnRay(
      Vector3 rayOrigin,
      Vector3 rayDir,
      Vector3 measuringPoint)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DetermineSuggestedRotation(
      IObjectAssemblyPart targetParent,
      IObjectAssemblyPart currentHeldChild,
      bool snapEnabled)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformSurfaceOffsetAdjustment(
      IObjectAssemblyPart target,
      IObjectAssemblyPart current,
      Vector3 hitSpot,
      Vector3 hitNormal,
      bool snapEnabled)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformMirrorSymmetryAdjustment(
      IObjectAssemblyPart target,
      IObjectAssemblyPart current)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SnapSelectionToSurface() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SnapSelectionToMouse() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveSelection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject FindParentWithTag(GameObject childObject, string tag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RotateSelection(Vector3 eulerAngles) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsInAssembly(IObjectAssemblyPart part, IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraZoom(float scrollWheelDifference, bool omitCameraZoomedMessages = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPointInCameraVolume(Vector3 positionToTest) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 ColliderNormalAtContactPoint(Vector3 camDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 ColliderContactPoint(Vector3 camDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void UpdateCameraLerp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAssemblyCreatedFromUI(IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateNewPickupPlane(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPartDropped(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetOutlinedPart(IObjectAssemblyPart part, bool includeChildren) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPartSelectionShader(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RevertPartSelectionShaders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartFinalized(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartCreated(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMainAssemblyChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABLoadFinalized(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnProceduralPartMeshBaked(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowSpriteForPartByName(string partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SelectPartInPartsManager(IObjectAssemblyPart partToSelect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ProcessInputCameraRotation(
      Vector3 orbitTargetPos,
      float prevYaw,
      float prevPitch,
      float deltaYaw,
      float deltaPitch,
      float distance,
      out Quaternion lookRotation,
      out Vector3 lookDirection,
      out Vector3 lookPosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectAssemblyPlacementTool() => throw null;

    public struct RendererShaderCache
    {
      public Renderer renderer;
      public Shader[] shaders;
      public Color[] colors;
      public float[] metallics;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public RendererShaderCache(Renderer renderer) => throw null;
    }

    public struct ScreenNodeInfo
    {
      public Vector2 screenLoc
      {
        [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public IObjectAssemblyPartNode node
      {
        [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3 nodeDir
      {
        [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }
    }
  }
}
