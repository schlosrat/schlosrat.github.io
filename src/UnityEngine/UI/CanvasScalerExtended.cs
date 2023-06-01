// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.CanvasScalerExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [DisallowMultipleComponent]
  [ExecuteInEditMode]
  public class CanvasScalerExtended : CanvasScaler
  {
    [SerializeField]
    private bool m_ReferencePixelsRespectsCanvasScale;
    private const float kLogBase = 2f;
    private Canvas m_CanvasExtended;

    public bool referencePixelSizeRespectsCanvasScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private float referencePixelScaleFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleWorldCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNewScaleFactor(float newScaleFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetScaleFactor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleConstantPixelSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleScaleWithScreenSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleConstantPhysicalSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasScalerExtended() => throw null;
  }
}
