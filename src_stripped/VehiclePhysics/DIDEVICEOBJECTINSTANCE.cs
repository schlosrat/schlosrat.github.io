// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DIDEVICEOBJECTINSTANCE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
