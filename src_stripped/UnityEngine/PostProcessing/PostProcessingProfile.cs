// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
