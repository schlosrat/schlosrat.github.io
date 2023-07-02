// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.FilteredFloat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
