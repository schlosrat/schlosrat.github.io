// Decompiled with JetBrains decompiler
// Type: KSP.Dev.MatthewsUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Dev
{
  public class MatthewsUtils : KerbalMonoBehaviour
  {
    public static readonly Color DEBUG_LINE_COLOR;
    public static readonly Color DEBUG_POINT_COLOR;
    public static readonly Color DEBUG_RAY_COLOR;
    public static readonly Color DEBUG_TEXT_COLOR;
    public static readonly Color DEBUG_QUATERNION_COLOR;
    public const float POINT_SIZE = 0.25f;
    public const float RAY_START_POINT_SIZE = 0.125f;
    public const float SEVEN_SEG_WIDTH = 0.125f;
    private static MatthewsUtils _instance;
    private List<MatthewsUtils.DebugTextBundle> _toDraw;
    private static readonly bool[] NUM_0;
    private static readonly bool[] NUM_1;
    private static readonly bool[] NUM_2;
    private static readonly bool[] NUM_3;
    private static readonly bool[] NUM_4;
    private static readonly bool[] NUM_5;
    private static readonly bool[] NUM_6;
    private static readonly bool[] NUM_7;
    private static readonly bool[] NUM_8;
    private static readonly bool[] NUM_9;
    private static readonly bool[] A_DOT;
    private static readonly bool[][] NUM_LOOKUP;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawCharNum(char toDraw, Vector3 pos, Color? color = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Draw7Seg(bool[] toDraw, Vector3 pos, float segSize, Color col) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawPoint(Vector3 loc, Color? color = null, float size = 0.25f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawRay(Ray ray, Color? color = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawRay(Vector3 start, Vector3 dir, Color? color = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawQuaternionAxis(
      Vector3 location,
      Quaternion toVisualize,
      Vector3? referenceDirection = null,
      Color? color = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawQuaternionXYZ(Vector3 location, Quaternion toVisualize, Color? color = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawLine(Vector3 start, Vector3 end, Color? color = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void PrepareGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawText(Vector3 positionAndValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawText(Vector3 pos, string text, bool updateClear = true, Color? color = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MatthewsUtils() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MatthewsUtils() => throw null;

    private struct DebugTextBundle
    {
      public Vector3 Position;
      public string Text;
      public Color Color;
      public bool IsCleared;
    }
  }
}
