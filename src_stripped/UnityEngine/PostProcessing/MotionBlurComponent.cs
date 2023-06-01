// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.MotionBlurComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
  public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
  {
    private MotionBlurComponent.ReconstructionFilter m_ReconstructionFilter;
    private MotionBlurComponent.FrameBlendingFilter m_FrameBlendingFilter;
    private bool m_FirstFrame;

    public MotionBlurComponent.ReconstructionFilter reconstructionFilter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MotionBlurComponent.FrameBlendingFilter frameBlendingFilter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetHistory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DepthTextureMode GetCameraFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CameraEvent GetCameraEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PopulateCommandBuffer(CommandBuffer cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MotionBlurComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _VelocityScale;
      internal static readonly int _MaxBlurRadius;
      internal static readonly int _RcpMaxBlurRadius;
      internal static readonly int _VelocityTex;
      internal static readonly int _MainTex;
      internal static readonly int _Tile2RT;
      internal static readonly int _Tile4RT;
      internal static readonly int _Tile8RT;
      internal static readonly int _TileMaxOffs;
      internal static readonly int _TileMaxLoop;
      internal static readonly int _TileVRT;
      internal static readonly int _NeighborMaxTex;
      internal static readonly int _LoopCount;
      internal static readonly int _TempRT;
      internal static readonly int _History1LumaTex;
      internal static readonly int _History2LumaTex;
      internal static readonly int _History3LumaTex;
      internal static readonly int _History4LumaTex;
      internal static readonly int _History1ChromaTex;
      internal static readonly int _History2ChromaTex;
      internal static readonly int _History3ChromaTex;
      internal static readonly int _History4ChromaTex;
      internal static readonly int _History1Weight;
      internal static readonly int _History2Weight;
      internal static readonly int _History3Weight;
      internal static readonly int _History4Weight;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }

    private enum Pass
    {
      VelocitySetup,
      TileMax1,
      TileMax2,
      TileMaxV,
      NeighborMax,
      Reconstruction,
      FrameCompression,
      FrameBlendingChroma,
      FrameBlendingRaw,
    }

    public class ReconstructionFilter
    {
      private RenderTextureFormat m_VectorRTFormat;
      private RenderTextureFormat m_PackedRTFormat;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ReconstructionFilter() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void CheckTextureFormatSupport() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool IsSupported() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ProcessImage(
        PostProcessingContext context,
        CommandBuffer cb,
        ref MotionBlurModel.Settings settings,
        RenderTargetIdentifier source,
        RenderTargetIdentifier destination,
        Material material)
      {
        throw null;
      }
    }

    public class FrameBlendingFilter
    {
      private bool m_UseCompression;
      private RenderTextureFormat m_RawTextureFormat;
      private MotionBlurComponent.FrameBlendingFilter.Frame[] m_FrameList;
      private int m_LastFrameCount;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FrameBlendingFilter() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Dispose() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void PushFrame(
        CommandBuffer cb,
        RenderTargetIdentifier source,
        int width,
        int height,
        Material material)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void BlendFrames(
        CommandBuffer cb,
        float strength,
        RenderTargetIdentifier source,
        RenderTargetIdentifier destination,
        Material material)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static bool CheckSupportCompression() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static RenderTextureFormat GetPreferredRenderTextureFormat() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private MotionBlurComponent.FrameBlendingFilter.Frame GetFrameRelative(int offset) => throw null;

      private struct Frame
      {
        public RenderTexture lumaTexture;
        public RenderTexture chromaTexture;
        private float m_Time;
        private RenderTargetIdentifier[] m_MRT;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public float CalculateWeight(float strength, float currentTime) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Release() => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void MakeRecord(
          CommandBuffer cb,
          RenderTargetIdentifier source,
          int width,
          int height,
          Material material)
        {
          throw null;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void MakeRecordRaw(
          CommandBuffer cb,
          RenderTargetIdentifier source,
          int width,
          int height,
          RenderTextureFormat format)
        {
          throw null;
        }
      }
    }
  }
}
