// Decompiled with JetBrains decompiler
// Type: RTG.RTGApp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace RTG
{
  public class RTGApp : MonoSingleton<RTGApp>, IRLDApplication
  {
    private Camera _renderCamera;
    private RenderPipelineId _renderPipelineId;

    public event RTGAppInitializedHandler Initialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public RenderPipelineId RenderPipelineId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Camera RenderCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCanCameraUseScrollWheel(YesNoAnswer answer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCanCameraProcessInput(YesNoAnswer answer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCanUndoRedo(UndoRedoOpType undoRedoOpType, YesNoAnswer answer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCanDoGizmoHoverUpdate(YesNoAnswer answer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnViewportsCameraAdded(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnViewportCameraRemoved(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DetectRenderPipeline() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRenderObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTGApp() => throw null;
  }
}
