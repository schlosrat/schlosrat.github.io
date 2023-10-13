// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
