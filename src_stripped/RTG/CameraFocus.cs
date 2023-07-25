// Decompiled with JetBrains decompiler
// Type: RTG.CameraFocus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class CameraFocus
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraFocus.Data CalculateFocusData(
      Camera camera,
      AABB focusAABB,
      CameraFocusSettings focusSettings)
    {
      throw null;
    }

    public class Data
    {
      private Vector3 _cameraWorldPosition;
      private Vector3 _focusPoint;
      private float _focusPointOffset;

      public Vector3 CameraWorldPosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Vector3 FocusPoint
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public float FocusPointOffset
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Data(Vector3 cameraWorldPosition, Vector3 focusPoint) => throw null;
    }
  }
}
