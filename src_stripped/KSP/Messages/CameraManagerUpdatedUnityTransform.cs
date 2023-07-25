// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraManagerUpdatedUnityTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/CameraManagerUpdatedUnityTransform", false, "The Camera Manager has updated in response to a floating origin reset", "")]
  public class CameraManagerUpdatedUnityTransform : CameraMessageBase
  {
    public CameraID UpdatedCameraID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraManagerUpdatedUnityTransform() => throw null;
  }
}
