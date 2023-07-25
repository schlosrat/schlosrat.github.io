// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DCameraCulling
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
