// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.CameraFovController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [RequireComponent(typeof (Camera))]
  public class CameraFovController : MonoBehaviour
  {
    public Transform target;
    public float fieldOfView;
    public CameraFovController.Mode mode;
    public float targetSize;
    public float targetSizeOffset;
    public bool damped;
    public float damping;
    public bool clampedFov;
    public float minFov;
    public float maxFov;
    public bool clampedSize;
    public float minSize;
    public float maxSize;
    private Camera m_cam;
    private Transform m_trans;
    private float m_currentFov;
    private bool m_firstRun;
    private Transform m_cachedTarget;
    private Renderer m_targetRenderer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetFieldOfView(float fovAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetFovAngleBySize(float size, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraFovController() => throw null;

    public enum Mode
    {
      Free,
      AdjustToTarget,
      AdjustSizeToTargetDistance,
    }
  }
}
