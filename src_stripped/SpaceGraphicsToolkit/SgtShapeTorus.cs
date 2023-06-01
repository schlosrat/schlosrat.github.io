// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShapeTorus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Shape Torus")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShapeTorus")]
  public class SgtShapeTorus : SgtShape
  {
    public float Radius;
    public float Thickness;
    public SgtEase.Type Ease;
    public float Sharpness;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override float GetDensity(Vector3 worldPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtShapeTorus Create(int layer = 0, Transform parent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtShapeTorus Create(
      int layer,
      Transform parent,
      Vector3 localPosition,
      Quaternion localRotation,
      Vector3 localScale)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtShapeTorus() => throw null;
  }
}
