// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DCameraCulling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  [RequireComponent(typeof (Renderer))]
  public class Map3DCameraCulling : MonoBehaviour
  {
    public Action<bool> MapCameraVisibilityChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBecameVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBecameInvisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DCameraCulling() => throw null;
  }
}
