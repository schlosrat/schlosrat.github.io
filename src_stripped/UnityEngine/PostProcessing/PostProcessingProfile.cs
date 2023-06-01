// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public class PostProcessingProfile : ScriptableObject
  {
    public BuiltinDebugViewsModel debugViews;
    public FogModel fog;
    public AntialiasingModel antialiasing;
    public AmbientOcclusionModel ambientOcclusion;
    public ScreenSpaceReflectionModel screenSpaceReflection;
    public DepthOfFieldModel depthOfField;
    public MotionBlurModel motionBlur;
    public EyeAdaptationModel eyeAdaptation;
    public BloomModel bloom;
    public ColorGradingModel colorGrading;
    public UserLutModel userLut;
    public ChromaticAberrationModel chromaticAberration;
    public GrainModel grain;
    public VignetteModel vignette;
    public DitheringModel dithering;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessingProfile() => throw null;
  }
}
