// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraOrbitTargetChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Gameplay/CameraOrbitTargetChangedMessage", true, "", "")]
  public class CameraOrbitTargetChangedMessage : GameplayMessageBase
  {
    public KerbalCameraMode newMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraOrbitTargetChangedMessage() => throw null;
  }
}
