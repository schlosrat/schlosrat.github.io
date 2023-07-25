// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.RigidbodyState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Converters;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct RigidbodyState
  {
    public string referenceTransformGuid;
    public TransformFrameType referenceFrameType;
    public Vector3d localVelocity;
    public Vector3d localAngularVelocity;
    public Vector3d localPosition;
    public QuaternionD localRotation;
    [TypeConverterIgnore]
    public float mass;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RigidbodyState FromSerialized(SerializedRigidbodyState rigidbodyState) => throw null;
  }
}
