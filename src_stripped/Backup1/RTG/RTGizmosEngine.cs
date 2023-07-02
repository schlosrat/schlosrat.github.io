// Decompiled with JetBrains decompiler
// Type: RTG.RTGizmosEngine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class RTGizmosEngine : MonoSingleton<RTGizmosEngine>, IHoverableSceneEntityContainer
  {
    [SerializeField]
    private EditorToolbar _mainToolbar;
    [SerializeField]
    private GizmoEngineSettings _settings;
    private GizmosEnginePipelineStage _pipelineStage;
    private Gizmo _draggedGizmo;
    private bool _justReleasedDrag;
    private Gizmo _hoveredGizmo;
    private GizmoHoverInfo _gizmoHoverInfo;
    private List<Gizmo> _gizmos;
    private List<ISceneGizmo> _sceneGizmos;
    private List<RTSceneGizmoCamera> _sceneGizmoCameras;
    private List<Camera> _renderCameras;
    [SerializeField]
    private SceneGizmoLookAndFeel _sceneGizmoLookAndFeel;
    [SerializeField]
    private MoveGizmoSettings2D _moveGizmoSettings2D;
    [SerializeField]
    private MoveGizmoSettings3D _moveGizmoSettings3D;
    [SerializeField]
    private MoveGizmoLookAndFeel2D _moveGizmoLookAndFeel2D;
    [SerializeField]
    private MoveGizmoLookAndFeel3D _moveGizmoLookAndFeel3D;
    [SerializeField]
    private MoveGizmoHotkeys _moveGizmoHotkeys;
    [SerializeField]
    private ObjectTransformGizmoSettings _objectMoveGizmoSettings;
    [SerializeField]
    private RotationGizmoSettings3D _rotationGizmoSettings3D;
    [SerializeField]
    private RotationGizmoLookAndFeel3D _rotationGizmoLookAndFeel3D;
    [SerializeField]
    private RotationGizmoHotkeys _rotationGizmoHotkeys;
    [SerializeField]
    private ObjectTransformGizmoSettings _objectRotationGizmoSettings;
    [SerializeField]
    private ScaleGizmoSettings3D _scaleGizmoSettings3D;
    [SerializeField]
    private ScaleGizmoLookAndFeel3D _scaleGizmoLookAndFeel3D;
    [SerializeField]
    private ScaleGizmoHotkeys _scaleGizmoHotkeys;
    [SerializeField]
    private ObjectTransformGizmoSettings _objectScaleGizmoSettings;
    [SerializeField]
    private UniversalGizmoConfig _universalGizmoConfig;
    [SerializeField]
    private UniversalGizmoSettings2D _universalGizmoSettings2D;
    [SerializeField]
    private UniversalGizmoSettings3D _universalGizmoSettings3D;
    [SerializeField]
    private UniversalGizmoLookAndFeel2D _universalGizmoLookAndFeel2D;
    [SerializeField]
    private UniversalGizmoLookAndFeel3D _universalGizmoLookAndFeel3D;
    [SerializeField]
    private UniversalGizmoHotkeys _universalGizmoHotkeys;
    [SerializeField]
    private ObjectTransformGizmoSettings _objectUniversalGizmoSettings;

    public event GizmoEngineCanDoHoverUpdateHandler CanDoHoverUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public GizmoEngineSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmosEnginePipelineStage PipelineStage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Camera RenderStageCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool HasHoveredSceneEntity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsAnyGizmoHovered
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Gizmo HoveredGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Gizmo DraggedGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool JustReleasedDrag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumRenderCameras
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SceneGizmoLookAndFeel SceneGizmoLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoSettings2D MoveGizmoSettings2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoSettings3D MoveGizmoSettings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoLookAndFeel2D MoveGizmoLookAndFeel2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoLookAndFeel3D MoveGizmoLookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoHotkeys MoveGizmoHotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectTransformGizmoSettings ObjectMoveGizmoSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RotationGizmoSettings3D RotationGizmoSettings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RotationGizmoLookAndFeel3D RotationGizmoLookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RotationGizmoHotkeys RotationGizmoHotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectTransformGizmoSettings ObjectRotationGizmoSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScaleGizmoSettings3D ScaleGizmoSettings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScaleGizmoLookAndFeel3D ScaleGizmoLookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScaleGizmoHotkeys ScaleGizmoHotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectTransformGizmoSettings ObjectScaleGizmoSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoSettings2D UniversalGizmoSettings2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoSettings3D UniversalGizmoSettings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoLookAndFeel2D UniversalGizmoLookAndFeel2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoLookAndFeel3D UniversalGizmoLookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoHotkeys UniversalGizmoHotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectTransformGizmoSettings ObjectUniversalGizmoSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRenderCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRenderCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveRenderCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTSceneGizmoCamera CreateSceneGizmoCamera(
      Camera sceneCamera,
      ISceneGizmoCamViewportUpdater viewportUpdater)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSceneGizmoCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ISceneGizmo GetSceneGizmoByCamera(Camera sceneCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Gizmo CreateGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveGizmo(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneGizmo CreateSceneGizmo(Camera sceneCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoveGizmo CreateMoveGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTransformGizmo CreateObjectMoveGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RotationGizmo CreateRotationGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTransformGizmo CreateObjectRotationGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaleGizmo CreateScaleGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTransformGizmo CreateObjectScaleGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniversalGizmo CreateUniversalGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTransformGizmo CreateObjectUniversalGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoHandleHoverData GetGizmoHandleHoverData(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render_SystemCall(Camera renderCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortHandleHoverDataCollection(
      List<GizmoHandleHoverData> hoverDataCollection,
      Vector3 inputDevicePos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterGizmo(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterGizmo(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoDragBegin(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoDragEnd(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTGizmosEngine() => throw null;
  }
}
