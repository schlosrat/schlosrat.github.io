// Decompiled with JetBrains decompiler
// Type: CameraRenderViewFade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraRenderViewFade : MonoBehaviour
{
  [SerializeField]
  private float camNearEndFade;
  [SerializeField]
  private float camFarStartFade;
  private CameraEvent cameraEventSrc;
  private CameraEvent cameraEventDst;
  private CameraEvent cameraEventSrcOld;
  private CameraEvent cameraEventDstOld;
  private Camera m_Camera;
  private List<CommandBuffer> buffersOnCamera;
  private CommandBuffer buffSrc;
  private CommandBuffer buffDst;
  private Material fadeMaterial;
  private int nearClipPlaneID;
  private int farClipPlaneID;
  private int camStartFadeID;
  private int camEndFadeID;
  private bool render;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Cleanup() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPreRender() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddBufferSrc() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddBufferDest() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CameraRenderViewFade() => throw null;
}
