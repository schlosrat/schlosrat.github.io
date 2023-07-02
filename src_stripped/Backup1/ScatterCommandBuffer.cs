// Decompiled with JetBrains decompiler
// Type: ScatterCommandBuffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class ScatterCommandBuffer : MonoBehaviour
{
  public CameraEvent DrawScatterCameraEvent;
  public LightEvent DrawScatterLightEvent;
  public Camera TargetCamera;
  public Light TargetLight;
  public CommandBuffer DrawScatterCommandBuffer;
  public Material CopyDiffuseMaterial;
  public RenderTexture DiffuseAfterRenderTexture;
  public RenderTexture NormalAfterRenderTexture;
  public Material PostProcessMaterial;
  private int terrainBlendingDiffuseAfterId;
  private int terrainBlendingNormalAfterId;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateCommandBuffer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StartScatterRendering() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StopScatterRendering() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ScatterCommandBuffer() => throw null;
}
