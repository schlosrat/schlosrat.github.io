// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.MathUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Networking.MP.Utils
{
  public static class MathUtil
  {
    public const float DEGREES_TO_RADIANS = 0.0174532924f;
    public const float RADIANS_TO_DEGREES = 57.29578f;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClampMin(ref float valueRef, float minValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClampMax(ref float valueRef, float maxValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClampMinMax(ref float valueRef, float minValue, float maxValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void NormalizeAngle360(ref float angleRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void NormalizeAngle180(ref float angleRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_Init(ref Matrix4x4 matRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_Init(
      ref Matrix4x4 matRef,
      Vector3 pos,
      Quaternion quat,
      Vector3 scale)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetAxisX(ref Matrix4x4 matRef, float ax, float ay, float az) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetAxisX(ref Matrix4x4 matRef, Vector3 vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Matrix4x4_GetAxisX(ref Matrix4x4 matRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetAxisY(ref Matrix4x4 matRef, float ax, float ay, float az) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetAxisY(ref Matrix4x4 matRef, Vector3 vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Matrix4x4_GetAxisY(ref Matrix4x4 matRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetAxisZ(ref Matrix4x4 matRef, float ax, float ay, float az) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetAxisZ(ref Matrix4x4 matRef, Vector3 vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Matrix4x4_GetAxisZ(ref Matrix4x4 matRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetPosition(ref Matrix4x4 matRef, float x, float y, float z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetPosition(ref Matrix4x4 matRef, Vector3 coord) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Matrix4x4_GetPosition(ref Matrix4x4 matRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetRotation(ref Matrix4x4 matRef, Quaternion quat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Quaternion Matrix4x4_GetRotation(ref Matrix4x4 mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetScale(ref Matrix4x4 matRef, float sx, float sy, float sz) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_SetScale(ref Matrix4x4 matRef, Vector3 scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Matrix4x4_GetScale(ref Matrix4x4 matRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_RotateXZ(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_RotateZX(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_YawLeft(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_YawRight(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_RotateXY(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_RotateYX(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_RollLeft(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_RollRight(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_RotateYZ(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_RotateZY(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_PitchDown(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_PitchUp(ref Matrix4x4 matRef, float angle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MovePositiveX(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MoveNegativeX(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MoveRight(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MoveLeft(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MovePositiveY(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MoveNegativeY(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MoveUp(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MoveDown(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MovePositiveZ(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MoveNegativeZ(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MoveForward(ref Matrix4x4 matRef, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Matrix4x4_MoveBackward(ref Matrix4x4 matRef, float distance) => throw null;
  }
}
