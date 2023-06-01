// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraPQSChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/CurrentPQSChangedMessage", true, "The observed PQS planet has changed", "")]
  public class CameraPQSChangedMessage : CameraMessageBase
  {
    public string BodyName;
    public PQS PqsReference;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraPQSChangedMessage() => throw null;
  }
}
