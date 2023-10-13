// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapManeuverGizmo3DExpanded
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class MapManeuverGizmo3DExpanded : KerbalMonoBehaviour
  {
    private static readonly Vector3 DEFAULT_ARROW_SCALE;
    [Header("General")]
    [SerializeField]
    private GameObject _center;
    [SerializeField]
    private GameObject _orientationIndicator;
    [Header("Directional Groups")]
    [SerializeField]
    private GameObject _prograde;
    [SerializeField]
    private GameObject _retrograde;
    [SerializeField]
    private GameObject _normal;
    [SerializeField]
    private GameObject _antiNormal;
    [SerializeField]
    private GameObject _radialIn;
    [SerializeField]
    private GameObject _radialOut;
    [SerializeField]
    [Header("Specific Visuals")]
    private float _maxFeedbackScale;
    [SerializeField]
    private float _feedbackSensitivity;
    [SerializeField]
    private GameObject _progradeTail;
    [SerializeField]
    private GameObject _retrogradeTail;
    [SerializeField]
    private GameObject _normalTail;
    [SerializeField]
    private GameObject _antiNormalTail;
    [SerializeField]
    private GameObject _radialInTail;
    [SerializeField]
    private GameObject _radialOutTail;
    [SerializeField]
    private GameObject _progradeHead;
    [SerializeField]
    private GameObject _retrogradeHead;
    [SerializeField]
    private GameObject _normalHead;
    [SerializeField]
    private GameObject _antiNormalHead;
    [SerializeField]
    private GameObject _radialInHead;
    [SerializeField]
    private GameObject _radialOutHead;
    private Camera _viewingCamera;
    private Vector3 _defaultIconOffset;

    public Vector3 DirPrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 DirRetrograde
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 DirRadialOut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 DirRadialIn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 DirNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 DirAntiNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CenterObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ScaleToDrag(ManeuverGizmoInputType inputType, float dragAmount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetHandleObjectsFromDragValue(
      ManeuverGizmoInputType inputType,
      float dragAmount,
      out GameObject arrow,
      out GameObject icon)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverGizmoInputType GetInverseInput(ManeuverGizmoInputType inputType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetDrag(ManeuverGizmoInputType inputType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetDirForType(ManeuverGizmoInputType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject GetArrowForType(ManeuverGizmoInputType inputType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject GetIconForType(ManeuverGizmoInputType inputType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHandleVisibilityCamera(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IndicateOrientation(Quaternion lookDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideIfInCameraFacingArc(GameObject target, Camera viewingCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetTheArrowManeuverParent(
      ManeuverGizmoInputType maneuverGizmoInputType,
      out GameObject arrowObject,
      out GameObject inputparent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapManeuverGizmo3DExpanded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MapManeuverGizmo3DExpanded() => throw null;
  }
}
