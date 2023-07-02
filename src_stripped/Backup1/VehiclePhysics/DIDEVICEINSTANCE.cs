// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DIDEVICEINSTANCE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.InteropServices;

namespace VehiclePhysics
{
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  public struct DIDEVICEINSTANCE
  {
    public uint dwSize;
    public Guid guidInstance;
    public Guid guidProduct;
    public uint dwDevType;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string instanceName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string productName;
    public Guid guidFFDriver;
    public ushort wUsagePage;
    public ushort wUsage;
  }
}
