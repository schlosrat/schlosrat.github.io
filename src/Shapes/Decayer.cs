// Decompiled with JetBrains decompiler
// Type: Shapes.Decayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Shapes
{
  [Serializable]
  public class Decayer
  {
    public float decaySpeed;
    public float magnitude;
    public AnimationCurve curve;
    [NonSerialized]
    public float value;
    [NonSerialized]
    public float valueInv;
    [NonSerialized]
    public float t;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetT(float v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Decayer() => throw null;
  }
}
