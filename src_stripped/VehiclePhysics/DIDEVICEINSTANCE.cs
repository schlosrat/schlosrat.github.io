// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DIDEVICEINSTANCE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
