// Decompiled with JetBrains decompiler
// Type: ConfigurableJointExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public static class ConfigurableJointExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetTargetRotationLocal(
    this ConfigurableJoint joint,
    Quaternion targetLocalRotation,
    Quaternion startLocalRotation)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetTargetRotation(
    this ConfigurableJoint joint,
    Quaternion targetWorldRotation,
    Quaternion startWorldRotation)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void SetTargetRotationInternal(
    this ConfigurableJoint joint,
    Quaternion targetRotation,
    Quaternion startRotation,
    Space space)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Quaternion GetExternalToJointSpaceRotation(this ConfigurableJoint joint) => throw null;
}
