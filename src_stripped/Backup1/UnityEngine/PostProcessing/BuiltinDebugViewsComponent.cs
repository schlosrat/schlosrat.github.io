// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.BuiltinDebugViewsComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
  public sealed class BuiltinDebugViewsComponent : 
    PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
  {
    private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";
    private BuiltinDebugViewsComponent.ArrowArray m_Arrows;

    public override bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DepthTextureMode GetCameraFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CameraEvent GetCameraEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PopulateCommandBuffer(CommandBuffer cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DepthPass(CommandBuffer cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DepthNormalsPass(CommandBuffer cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MotionVectorsPass(CommandBuffer cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareArrows() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BuiltinDebugViewsComponent() => throw null;

    private static class Uniforms
    {
      internal static readonly int _DepthScale;
      internal static readonly int _TempRT;
      internal static readonly int _Opacity;
      internal static readonly int _MainTex;
      internal static readonly int _TempRT2;
      internal static readonly int _Amplitude;
      internal static readonly int _Scale;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Uniforms() => throw null;
    }

    private enum Pass
    {
      Depth,
      Normals,
      MovecOpacity,
      MovecImaging,
      MovecArrows,
    }

    private class ArrowArray
    {
      public Mesh mesh
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public int columnCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public int rowCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void BuildMesh(int columns, int rows) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Release() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ArrowArray() => throw null;
    }
  }
}
