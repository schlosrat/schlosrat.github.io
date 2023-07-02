// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ManipulationWidget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ManipulationWidget : KerbalMonoBehaviour
  {
    protected ObjectAssemblyBuilderEvents eventsBuilder;
    protected OABSessionInformation stats;
    protected ObjectAssemblyInputHandler input;
    [SerializeField]
    protected bool _scaleWidgetToPreserveScreenSize;
    [SerializeField]
    [Tooltip("Tells the tool if it should even consider trying to snap positions to a grid when snap is enabled by the user. If this is true but snap is disabled by the user, no snap will be attempted.")]
    protected bool _canSnapTranslation;
    [SerializeField]
    [Tooltip("Tells the tool if it should even consider trying to snap rotations to existing angles when snap is enabled by the user. If this is true but snap is disabled by the user, no snap will be attempted.")]
    protected bool _canSnapRotation;
    [SerializeField]
    protected float _sizeOnScreenMultiplier;
    [Space(10f)]
    [SerializeField]
    private GameObject translationGroup;
    [SerializeField]
    private GameObject rotationGroup;
    [SerializeField]
    private GameObject[] translationAxis;
    [SerializeField]
    private GameObject[] rotationAxis;
    public float dragSpeedScale;
    [HideInInspector]
    public Camera CurCamera;
    [HideInInspector]
    public Vector3 OriginalScale;
    protected Vector3 curPos;
    protected Vector3 lastPos;
    protected Plane rotPlane;
    protected Vector3 rotStartMousePos;
    protected Vector3 lastTranslateMousePos;
    protected Quaternion rotStartRot;
    protected Vector3 translateStartPos;
    protected Dictionary<IObjectAssemblyPart, Quaternion> siblingRotStartDictionary;
    protected ManipulationWidget.ManipulateType curManipulation;
    protected ManipulationWidget.ManipulateType bestManipulation;
    protected Vector3 manipulateDir;
    protected GameObject bestObj;
    protected IObjectAssemblyPart controlledPart;
    protected bool _controlledPartIsStackAttached;
    protected Vector3 queuedMove;
    protected float snapThreshold;
    protected float snapThresholdFine;
    protected Bounds translateRefPartBounds;
    protected Vector3 translateLimits;
    protected bool isLocalFrame;
    protected bool toolActive;
    protected Vector3 startPt;
    protected Vector3 vOld;
    protected Vector3 vNew;
    private ObjectAssemblyPartTracker _OABactivePartTracker;
    private Vector3 _currentLocalPosition;
    private Vector3 _newPosition;
    private Vector3 _relativePosition;

    public bool IsRotatingOrDragging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      ObjectAssemblyBuilderEvents events,
      OABSessionInformation stats,
      ObjectAssemblyInputHandler input)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateWidgetSizeOnCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetManipGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetControlledPart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsManipulating() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateClonePosRots(IObjectAssemblyPart targetPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CheckMouse() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetToolActive(bool Active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFrameOfReference() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePartTrackerPartBeingManipulated(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClampSnapQueuedMovement(ref Vector3 queued, float threshold) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClampQueuedMovementToLimit(ref Vector3 queued) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPartPositionWithinLimits(
      out Vector3 limitPoint,
      out Vector3 partGrabbedPosition,
      Vector3 queued)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsControlledPartStackAttached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateTranslateLimits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManipulationWidget() => throw null;

    protected enum ManipulateType
    {
      MANIPULATE_NONE,
      MANIPULATE_ROTATE,
      MANIPULATE_TRANSLATE,
    }
  }
}
