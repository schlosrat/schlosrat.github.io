// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DCameraCulling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
