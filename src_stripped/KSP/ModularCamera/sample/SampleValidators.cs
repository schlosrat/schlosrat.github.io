// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.sample.SampleValidators
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.ModularCamera.sample
{
  public static class SampleValidators
  {
    private static float EPSILON_SQR;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinCameraHeight(float lowestCameraHeight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinPivotHeight(float lowestPivotHeight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinCameraAndPivotHeight(
      float lowestCameraHeight,
      float lowestPivotHeight)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator MinPivotHeightFromRotation(
      float lowestCameraHeight,
      float lowestPivotHeight)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Validator ShiftMinHeightPivotTowardCamera(
      float lowestCameraHeight,
      float lowestPivotHeight)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SampleValidators() => throw null;
  }
}
