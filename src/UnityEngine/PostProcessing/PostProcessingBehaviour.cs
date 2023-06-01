// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
  [ImageEffectAllowedInSceneView]
  [RequireComponent(typeof (Camera))]
  [DisallowMultipleComponent]
  [ExecuteInEditMode]
  [AddComponentMenu("Effects/Post-Processing Behaviour", -1)]
  public class PostProcessingBehaviour : MonoBehaviour
  {
    public PostProcessingProfile profile;
    public Func<Vector2, Matrix4x4> jitteredMatrixFunc;
    private Dictionary<System.Type, KeyValuePair<CameraEvent, CommandBuffer>> m_CommandBuffers;
    private List<PostProcessingComponentBase> m_Components;
    private Dictionary<PostProcessingComponentBase, bool> m_ComponentStates;
    private MaterialFactory m_MaterialFactory;
    private RenderTextureFactory m_RenderTextureFactory;
    private PostProcessingContext m_Context;
    private Camera m_Camera;
    private PostProcessingProfile m_PreviousProfile;
    private bool m_RenderingInSceneView;
    private BuiltinDebugViewsComponent m_DebugViews;
    private AmbientOcclusionComponent m_AmbientOcclusion;
    private ScreenSpaceReflectionComponent m_ScreenSpaceReflection;
    private FogComponent m_FogComponent;
    private MotionBlurComponent m_MotionBlur;
    private TaaComponent m_Taa;
    private EyeAdaptationComponent m_EyeAdaptation;
    private DepthOfFieldComponent m_DepthOfField;
    private BloomComponent m_Bloom;
    private ChromaticAberrationComponent m_ChromaticAberration;
    private ColorGradingComponent m_ColorGrading;
    private UserLutComponent m_UserLut;
    private GrainComponent m_Grain;
    private VignetteComponent m_Vignette;
    private DitheringComponent m_Dithering;
    private FxaaComponent m_Fxaa;
    private List<PostProcessingComponentBase> m_ComponentsToEnable;
    private List<PostProcessingComponentBase> m_ComponentsToDisable;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreCull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPostRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRenderImage(RenderTexture source, RenderTexture destination) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetTemporalEffects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckObservers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CommandBuffer AddCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveCommandBuffer<T>() where T : PostProcessingModel => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CommandBuffer GetCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryExecuteCommandBuffer<T>(PostProcessingComponentCommandBuffer<T> component) where T : PostProcessingModel => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryPrepareUberImageEffect<T>(
      PostProcessingComponentRenderTexture<T> component,
      Material material)
      where T : PostProcessingModel
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private T AddComponent<T>(T component) where T : PostProcessingComponentBase => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessingBehaviour() => throw null;
  }
}
