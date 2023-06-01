// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.RigidbodyState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
