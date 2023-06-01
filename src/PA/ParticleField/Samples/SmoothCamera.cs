// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.SmoothCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace PA.ParticleField.Samples
{
  public class SmoothCamera : MonoBehaviour
  {
    public Transform target;
    public float distance;
    public float height;
    public float damping;
    public bool smoothRotation;
    public bool followBehind;
    public float rotationDamping;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SmoothCamera() => throw null;
  }
}
