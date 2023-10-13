// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ScreenSpaceReflectionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public class ScreenSpaceReflectionModel : PostProcessingModel
  {
    [SerializeField]
    private ScreenSpaceReflectionModel.Settings m_Settings;

    public ScreenSpaceReflectionModel.Settings settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScreenSpaceReflectionModel() => throw null;

    public enum SSRResolution
    {
      High = 0,
      Low = 2,
    }

    public enum SSRReflectionBlendType
    {
      PhysicallyBased,
      Additive,
    }

    [Serializable]
    public struct IntensitySettings
    {
      [Range(0.0f, 2f)]
      [Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
      public float reflectionMultiplier;
      [Tooltip("How far away from the maxDistance to begin fading SSR.")]
      [Range(0.0f, 1000f)]
      public float fadeDistance;
      [Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
      [Range(0.0f, 1f)]
      public float fresnelFade;
      [Range(0.1f, 10f)]
      [Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
      public float fresnelFadePower;
    }

    [Serializable]
    public struct ReflectionSettings
    {
      [Tooltip("How the reflections are blended into the render.")]
      public ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;
      [Tooltip("Half resolution SSRR is much faster, but less accurate.")]
      public ScreenSpaceReflectionModel.SSRResolution reflectionQuality;
      [Range(0.1f, 300f)]
      [Tooltip("Maximum reflection distance in world units.")]
      public float maxDistance;
      [Tooltip("Max raytracing length.")]
      [Range(16f, 1024f)]
      public int iterationCount;
      [Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
      [Range(1f, 16f)]
      public int stepSize;
      [Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
      [Range(0.01f, 10f)]
      public float widthModifier;
      [Tooltip("Blurriness of reflections.")]
      [Range(0.1f, 8f)]
      public float reflectionBlur;
      [Tooltip("Disable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
      public bool reflectBackfaces;
    }

    [Serializable]
    public struct ScreenEdgeMask
    {
      [Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
      [Range(0.0f, 1f)]
      public float intensity;
    }

    [Serializable]
    public struct Settings
    {
      public ScreenSpaceReflectionModel.ReflectionSettings reflection;
      public ScreenSpaceReflectionModel.IntensitySettings intensity;
      public ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;

      public static ScreenSpaceReflectionModel.Settings defaultSettings
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
