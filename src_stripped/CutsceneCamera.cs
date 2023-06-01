// Decompiled with JetBrains decompiler
// Type: CutsceneCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using CameraKeyFrameEvents;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CutsceneCamera : MonoBehaviour
{
  public float totalDuration;
  public int i;
  public List<CutsceneCamera.CameraKeyFrame> keyFrames;
  private float T;
  private float normT;
  private float lastFrameT;
  private CutsceneCamera.CameraKeyFrame currentFrame;
  private int cFrameIndex;
  private float speedFactor;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [ContextMenu("Add Frame Here")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void CreateKeyFrame() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int kfCompare(CutsceneCamera.CameraKeyFrame a, CutsceneCamera.CameraKeyFrame b) => throw null;

  [ContextMenu("Sort KeyFrames")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SortKeyFrames() => throw null;

  [ContextMenu("Go To Frame i")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GoToFrame() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CutsceneCamera() => throw null;

  [Serializable]
  public class CameraKeyFrame
  {
    public Transform refTrf;
    public float duration;
    public int index;
    [HideInInspector]
    public CutsceneCamera.CameraKeyFrame nextFrm;
    public CutsceneCamera.CameraKeyFrame.Easing EaseToNextFrameMode;
    public List<CameraKeyFrameEvent> frameEvents;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 EvalPos(float normT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion EvalRot(float normT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EvalEvents(float normT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraKeyFrame() => throw null;

    public enum Easing
    {
      Linear,
      SinLerp,
      CosLerp,
      Hermite,
      Berp,
    }
  }
}
