// Decompiled with JetBrains decompiler
// Type: Shapes.Compass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Shapes
{
  public class Compass : MonoBehaviour
  {
    public Vector2 position;
    public float width;
    [Range(0.0f, 0.01f)]
    public float lineThickness;
    [Range(0.1f, 2f)]
    public float bendRadius;
    [Range(0.05f, 3.07876086f)]
    public float fieldOfView;
    [Header("Ticks")]
    public int ticksPerQuarterTurn;
    [Range(0.0f, 0.2f)]
    public float tickSize;
    [Range(0.0f, 1f)]
    public float tickEdgeFadeFraction;
    [Range(0.01f, 0.26f)]
    public float fontSizeTickLabel;
    [Range(0.0f, 0.1f)]
    public float tickLabelOffset;
    [Header("Degree Marker")]
    [Range(0.01f, 0.26f)]
    public float fontSizeLookLabel;
    public Vector2 lookAngLabelOffset;
    [Range(0.0f, 0.05f)]
    public float triangleNootSize;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawCompass(Vector3 worldDir) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Compass() => throw null;
  }
}
