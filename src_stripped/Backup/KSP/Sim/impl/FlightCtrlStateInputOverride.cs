// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.FlightCtrlStateInputOverride
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public static class FlightCtrlStateInputOverride
  {
    public static float? InputYawOverride;
    public static float? InputPitchOverride;
    public static float? InputRollOverride;
    public static float? InputTranslateXOverride;
    public static float? InputTranslateYOverride;
    public static float? InputTranslateZOverride;
    public static bool? InputStageOverride;
    public static float? InputWheelSteeringOverride;
    public static float? InputWheelThrottleOverride;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static FlightCtrlStateInputOverride() => throw null;
  }
}
