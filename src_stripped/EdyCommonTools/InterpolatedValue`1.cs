// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.InterpolatedValue`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace EdyCommonTools
{
  public class InterpolatedValue<T>
  {
    private T m_prevValue;
    private T m_value;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InterpolatedValue(T initialValue = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset(T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetInterpolated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetInterpolated(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Get() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetFrameRatio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static T InternalLerp(T a, T b, float t) => throw null;
  }
}
