// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DIDEVICEOBJECTINSTANCE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.InteropServices;

namespace VehiclePhysics
{
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  public struct DIDEVICEOBJECTINSTANCE
  {
    private uint dwSize;
    private Guid guidType;
    private uint dwOfs;
    private uint dwType;
    private uint dwFlags;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string name;
    private uint dwFFMaxForce;
    private uint dwFFForceResolution;
    private ushort wCollectionNumber;
    private ushort wDesignatorIndex;
    private ushort wUsagePage;
    private ushort wUsage;
    private uint dwDimension;
    private ushort wExponent;
    private ushort wReportId;
  }
}
