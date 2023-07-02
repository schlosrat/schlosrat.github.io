// Decompiled with JetBrains decompiler
// Type: KSP.Map.UI3DTrackingObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  [RequireComponent(typeof (RectTransform))]
  public class UI3DTrackingObject : KerbalMonoBehaviour
  {
    protected RectTransform _canvasRect;
    protected RectTransform _currentRect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Configure(Canvas uiCanvas) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FollowTransform(Transform target, Camera currentCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UI3DTrackingObject() => throw null;
  }
}
