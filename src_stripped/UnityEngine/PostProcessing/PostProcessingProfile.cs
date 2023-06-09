﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
