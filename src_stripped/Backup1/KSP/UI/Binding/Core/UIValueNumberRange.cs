// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValueNumberRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.UI.Binding.Core
{
  public struct UIValueNumberRange
  {
    public static readonly UIValueNumberRange Default;

    public double Min
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Max
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Range
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double Step
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool UseRangeStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValueNumberRange(double min, double max, double rangeStep = 0.0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float MapValueTo01(double valueMapped) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double MapValueFrom01(float value01) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RoundValueMapped(double valueMapped, double toNearestMapped) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RoundValue01(float value01, double toNearestMapped, out double valueMappedRounded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static UIValueNumberRange() => throw null;
  }
}
