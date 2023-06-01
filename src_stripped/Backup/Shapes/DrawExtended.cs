// Decompiled with JetBrains decompiler
// Type: Shapes.DrawExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Shapes
{
  public static class DrawExtended
  {
    public static readonly Color DEFAULT_FADE_COLOR;
    public const float DEFAULT_MIN_THICKNESS = 1f;

    public static Color FadeColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static float FadeMinThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void LinesFromPolyline(PolylinePath path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void DottedLinesFromPolyline(PolylinePath path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void DottedLinesFromPolylineWithDashStyle(
      PolylinePath path,
      DashStyle dashStyling)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void LinesFromPolylineWithFade(
      PolylinePath path,
      float minThickness,
      Color fadeColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void DottedLinesFromPolylineWithFade(
      PolylinePath path,
      float minThickness,
      Color fadeColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void DottedLinesFromPolylineWithFadeAndDashStyle(
      PolylinePath path,
      DashStyle dashStyling,
      float minThickness,
      Color fadeColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void LinesFromPolylineWithFade(PolylinePath path, Color fadeColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void LinesFromPolylineWithFade(PolylinePath path, float minThickness) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void LinesFromPolylineWithFade(PolylinePath path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void LineWithFade(
      Vector3 from,
      Vector3 to,
      float thickness,
      Color fromColor,
      Color toColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void DottedLineWithFade(
      Vector3 from,
      Vector3 to,
      float thickness,
      Color fromColor,
      Color toColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void DottedLineWithFadeAndDashStyle(
      Vector3 from,
      Vector3 to,
      DashStyle dashStyling,
      float thickness,
      Color fromColor,
      Color toColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void LineWithFade(Vector3 from, Vector3 to, float thickness, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void LineWithFade(Vector3 from, Vector3 to, Color fromColor, Color toColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static void LineWithFade(Vector3 from, Vector3 to, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static void ApplyThicknessFade(
      ref float thickness,
      ref Color fromColor,
      ref Color toColor,
      float minThickness,
      Color fadeColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static void ApplyThicknessFade(
      ref float thickness,
      ref Color color,
      float minThickness,
      Color fadeColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static Color OpaqueFadeBlend(Color color, Color fadeColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static Color FixGammaColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DrawExtended() => throw null;
  }
}
