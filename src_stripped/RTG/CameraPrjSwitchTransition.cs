// Decompiled with JetBrains decompiler
// Type: RTG.CameraPrjSwitchTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class CameraPrjSwitchTransition
  {
    private IEnumerator _transitionCrtn;
    private MonoBehaviour _targetMono;
    private Camera _targetCamera;
    private float _camFieldOfView;
    private Vector3 _camFocusPoint;
    private Vector3 _camRestorePosition;
    private CameraPrjSwitchTransition.Type _transitionType;
    private float _durationInSeconds;
    private float _progress;

    public event CameraProjectionSwitchBeginHandler TransitionBegin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event CameraProjectionSwitchUpdateHandler TransitionUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event CameraProjectionSwitchBeginHandler TransitionEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public MonoBehaviour TargetMono
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Camera TargetCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public CameraPrjSwitchTransition.Type TransitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float DurationInSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Progress
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CamFieldOfView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 CamFocusPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Begin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DoTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraPrjSwitchTransition() => throw null;

    public enum Type
    {
      None,
      ToOrtho,
      ToPerspective,
    }
  }
}
