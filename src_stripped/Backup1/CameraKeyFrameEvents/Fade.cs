// Decompiled with JetBrains decompiler
// Type: CameraKeyFrameEvents.Fade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace CameraKeyFrameEvents
{
  public class Fade : CameraKeyFrameEvent
  {
    public float fadeDuration;
    public Color T0;
    public Color T1;
    public CameraFade fadeController;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RunEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Fade() => throw null;
  }
}
