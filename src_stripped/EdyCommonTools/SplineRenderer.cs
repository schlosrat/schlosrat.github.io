// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SplineRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [RequireComponent(typeof (Spline))]
  [ExecuteInEditMode]
  [RequireComponent(typeof (LineRenderer))]
  public class SplineRenderer : MonoBehaviour
  {
    public SplineRenderer.UpdateMode updateMode;
    [Range(1f, 100f)]
    public int resolution;
    private Spline m_spline;
    private LineRenderer m_renderer;
    private Vector3[] positions;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [ContextMenu("Update Renderer")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRendererPositions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SplineRenderer() => throw null;

    public enum UpdateMode
    {
      Update,
      Manual,
    }
  }
}
