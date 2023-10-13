// Decompiled with JetBrains decompiler
// Type: Shapes.Decayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
