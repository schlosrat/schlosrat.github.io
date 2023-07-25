// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.PAMeshParticlesFaceCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
