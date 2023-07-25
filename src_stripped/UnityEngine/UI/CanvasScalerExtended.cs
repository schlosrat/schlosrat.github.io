// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.CanvasScalerExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [DisallowMultipleComponent]
  [ExecuteInEditMode]
  public class CanvasScalerExtended : CanvasScaler
  {
    [SerializeField]
    private bool m_useGlobalCanvasScale;
    private float m_GlobalCanvasScale;
    [SerializeField]
    private float m_UIScale;
    [SerializeField]
    private bool m_ReferencePixelsRespectsCanvasScale;
    private const float kLogBase = 2f;
    private Canvas m_CanvasExtended;
    private UIScaleController uIScaleController;

    public bool useGlobalCanvasScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float globalCanvasScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float uIScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

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
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SubscribeToScaleController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnsubscribeToScaleController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGlobalUIScaleChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyUIScale(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleWorldCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNewScaleFactor(float newScaleFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetScaleFactor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetUIScaleFactorPreference() => throw null;

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
