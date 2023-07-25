// Decompiled with JetBrains decompiler
// Type: ConfigurableJointExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
