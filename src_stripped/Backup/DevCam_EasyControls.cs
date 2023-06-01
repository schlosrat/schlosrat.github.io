// Decompiled with JetBrains decompiler
// Type: DevCam_EasyControls
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DevCam_EasyControls : MonoBehaviour
{
  private static Vector3 _defaultCamPos;
  private const float _zoomMin = 0.1f;
  private const float _zoomMax = 1000f;
  [SerializeField]
  private Transform _root;
  [SerializeField]
  private Transform _rotTransform;
  [SerializeField]
  private Transform _posTransform;
  [SerializeField]
  private float _rotSpeedMul;
  [SerializeField]
  private float _zoomSpeedMul;
  [SerializeField]
  private float _zoomRelativePosSpeedMul;
  private Quaternion _initQuat;
  private float _curYaw;
  private float _curPitch;
  private float _curRoll;
  private float _curSpeedMul;
  private bool _rotInProgress;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateSpeedMul() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetCameraPos() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetCameraAll() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ApplyLocalRotToRoot() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetLocalCameraRotation() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DevCam_EasyControls() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static DevCam_EasyControls() => throw null;
}
