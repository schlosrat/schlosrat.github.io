// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.ScaleController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public class ScaleController : MonoBehaviour
  {
    public Vector3 scale;
    public bool unified;
    public bool damped;
    public float damping;
    public bool clamped;
    public Vector3 min;
    public Vector3 max;
    public ScaleController.OnScaleFinished onScaleFinished;
    private Transform m_trans;
    private Vector3 m_currentScale;
    private bool m_scaling;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetScale(Vector3 newScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClampScale(ref Vector3 s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaleController() => throw null;

    public delegate void OnScaleFinished();
  }
}
