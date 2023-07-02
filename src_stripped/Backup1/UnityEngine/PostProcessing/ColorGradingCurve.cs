// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ColorGradingCurve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public sealed class ColorGradingCurve
  {
    public AnimationCurve curve;
    [SerializeField]
    private bool m_Loop;
    [SerializeField]
    private float m_ZeroValue;
    [SerializeField]
    private float m_Range;
    private AnimationCurve m_InternalLoopingCurve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Evaluate(float t) => throw null;
  }
}
