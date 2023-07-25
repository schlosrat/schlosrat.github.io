// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselLandedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  public class VesselLandedMessage : VesselMessage
  {
    public string LandingObjectName;
    public double Latitude;
    public double Longitude;
    public double Altitude;
    public bool IsSplash;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselLandedMessage() => throw null;
  }
}
