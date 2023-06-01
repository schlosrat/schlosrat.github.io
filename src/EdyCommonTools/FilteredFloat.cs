// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.FilteredFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace EdyCommonTools
{
  public class FilteredFloat
  {
    private float m_lastFilterRate;
    private float m_alpha;
    private float m_value;

    public float value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Filter(float targetValue, float filterRate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset(float currentValue = 0.0f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Filter(float fromValue, float toValue, float filterRate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FilteredFloat() => throw null;
  }
}
