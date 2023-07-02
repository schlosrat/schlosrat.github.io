// Decompiled with JetBrains decompiler
// Type: ShaderHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public static class ShaderHelper
{
  public static string RK_INTERNAL_CUBEMAP;
  public static string RK_OBSERVER_CUBEMAP;
  public static string RK_GALAXY_CUBEMAP;
  public static string RK_PREVIS_SCENE;
  public static string RK_CUBEMAP_RENDERMODE;
  public static string KSP_HAIRCOMPRESSION_ON;
  public static string KSP_HAIRCOMPRESSION_HAT_ON;
  public static string _GLOSSYREFLECTIONS_OFF;
  public static int _Color;
  public static int _MainTex;
  public static int _Cull;
  public static int _EmissionColor;
  public static int _Alpha;
  public static int _WorldSpaceCameraPos;
  public static int _ScreenParams;
  public static int _ProjectionParams;
  public static int _ZBufferParams;
  public static int unity_CameraToWorld;
  public static int _DetailTex;
  public static int _DetailScale;
  public static int _DetailOffset;
  public static int _DetailTwist;
  public static int _DetailTwistBias;
  public static int _LightingTex;
  public static int _AmbientColor;
  public static int _ScatteringMie;
  public static int _AlphaNear;
  public static int _AlphaFar;
  public static int _AlphaEdge;
  public static int _ShadowThickness;
  public static int _PhysicsWorldToInternalMatrix;
  public static int _ScaledSpaceLightPos;
  public static int _ScaledSpaceLightColor;
  public static int _ScaledLightColor;
  public static int _ScaledLightScatter;
  public static int _ScaledLightPosition;
  public static int _ScaledLightDirection;
  public static int _Transition;
  public static int _DitheringScale;
  public static int _Exposure;
  public static int _ObserverCubemapTexture;
  public static int _CelestialBodyCubemapTexture;
  public static int _GalaxyCubemapTexture;
  public static int _CubemapFaceDepthTexture;
  public static int _CubemapViewTransparentIntensity;
  public static int _DiffuseAmbientIntensity;
  public static int _DiffuseCubemapIntensity;
  public static int _DiffuseCubemapMip;
  public static int _ReflectionPhysicsWorldToLocalMatrix;
  public static int _ReflectionToSkyboxRotationMatrix;
  public static int _ReflectionBlendValue;
  public static int _ReflectionBlendTarget;
  public static int _ReflectionColorBoost;
  public static int _ReflectionIntensityMultiplier;
  public static int _MipBiasMaxSteps;
  public static int _MipBiasGrowthRate;
  public static int _MipBiasOffset;
  public static int _RotationMatrix;
  public static int _LightmapBlend;
  public static int _LightmapST;
  public static int _LightmapA;
  public static int _LightmapIndA;
  public static int _LightmapShadowA;
  public static int _LightmapB;
  public static int _LightmapIndB;
  public static int _LightmapShadowB;
  public static int _ProjPos;
  public static int _ProjRotX;
  public static int _ProjRotY;
  public static int _ProjRotZ;
  public static int _HairSuppression;
  public static int _HelmetRadius;
  public static int _HelmetCenter;
  public static int _TimeOfDayKSC;
  public static int _TimeOfDayOAB;
  public static int _Vignette_Color;
  public static int _Vignette_Center;
  public static int _Vignette_Settings;
  public static int _CRT_Vignette_Settings;
  public static int _CRT_Settings;
  public static int _UseOceanDepth;
  public static int _EnableWaterShadow;
  public static int _EnableCloudsShadow;
  public static int _ActiveDebugOption;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static ShaderHelper() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetShaderRotationMatrix(int nameID, QuaternionD rotation) => throw null;

  public static class Shaders
  {
    public static Shader Post_CRTVignette;
    public static Shader ReflectionBlitHelper;
    public static Shader SkyboxCubemap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void InitShaderResources() => throw null;
  }

  public static class Materials
  {
    public static Material ReflectionBlitMaterial;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void InitMaterialResources() => throw null;
  }
}
