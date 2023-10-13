// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtCameraState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  public class SgtCameraState
  {
    public Camera Camera;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Find<T>(ref List<T> cameraStates, Camera camera) where T : SgtCameraState, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Restore<T>(List<T> cameraStates, Camera camera) where T : SgtCameraState => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Clear<T>(List<T> cameraStates) where T : SgtCameraState => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtCameraState() => throw null;
  }
}
