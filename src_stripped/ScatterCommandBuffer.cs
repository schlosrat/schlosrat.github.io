// Decompiled with JetBrains decompiler
// Type: ScatterCommandBuffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
