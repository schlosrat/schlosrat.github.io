// Decompiled with JetBrains decompiler
// Type: TerrainBlendingBufferSampler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class TerrainBlendingBufferSampler : MonoBehaviour
{
  public Material CopyDepthMaterial;
  public Material CopyDiffuseMaterial;
  public CameraEvent SampleBufferCameraEvent;
  public Camera TargetCamera;
  public CommandBuffer SampleBuffersCommandBuffer;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateCommandBuffer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddDrawMesh(CommandBuffer commandBuffer, MeshRenderer meshRenderer) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TerrainBlendingBufferSampler() => throw null;
}
