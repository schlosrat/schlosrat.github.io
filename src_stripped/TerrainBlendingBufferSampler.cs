// Decompiled with JetBrains decompiler
// Type: TerrainBlendingBufferSampler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
