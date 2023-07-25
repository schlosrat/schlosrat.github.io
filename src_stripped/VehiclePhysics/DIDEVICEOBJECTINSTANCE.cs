// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DIDEVICEOBJECTINSTANCE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
