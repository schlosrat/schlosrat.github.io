// Decompiled with JetBrains decompiler
// Type: CameraKeyFrameEvents.Fade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
