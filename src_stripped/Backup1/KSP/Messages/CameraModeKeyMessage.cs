// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraModeKeyMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/CameraModeKeyMessage", false, "The basic camera rig updates the camera mode.", "")]
  public class CameraModeKeyMessage : CameraMessageBase
  {
    public string CameraMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraModeKeyMessage() => throw null;
  }
}
