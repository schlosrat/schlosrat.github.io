// Decompiled with JetBrains decompiler
// Type: CameraKeyFrameEvents.SceneTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace CameraKeyFrameEvents
{
  public class SceneTransition : CameraKeyFrameEvent
  {
    public GameScenes destination;
    public bool Test;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RunEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneTransition() => throw null;
  }
}
