// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShadowRing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShadowRing")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Shadow Ring")]
  public class SgtShadowRing : SgtShadow
  {
    public Texture Texture;
    public float RadiusMin;
    public float RadiusMax;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Texture GetTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void CalculateShadow(SgtLight light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtShadowRing() => throw null;
  }
}
