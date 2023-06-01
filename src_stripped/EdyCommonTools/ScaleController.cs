// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.ScaleController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
