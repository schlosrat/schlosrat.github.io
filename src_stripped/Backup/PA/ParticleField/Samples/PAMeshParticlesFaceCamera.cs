// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.PAMeshParticlesFaceCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace PA.ParticleField.Samples
{
  public class PAMeshParticlesFaceCamera : MonoBehaviour
  {
    public PAParticleField particleField;
    public PAMeshParticlesFaceCamera.FaceMethod faceMethod;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PAMeshParticlesFaceCamera() => throw null;

    public enum FaceMethod
    {
      Face,
      Up,
    }
  }
}
