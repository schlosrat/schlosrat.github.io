// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DIJOYSTATE2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VehiclePhysics
{
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
  public struct DIJOYSTATE2
  {
    public int lX;
    public int lY;
    public int lZ;
    public int lRx;
    public int lRy;
    public int lRz;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public int[] rglSlider;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public int[] rgdwPOV;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] rgbButtons;
    public int lVX;
    public int lVY;
    public int lVZ;
    public int lVRx;
    public int lVRy;
    public int lVRz;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public int[] rglVSlider;
    public int lAX;
    public int lAY;
    public int lAZ;
    public int lARx;
    public int lARy;
    public int lARz;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public int[] rglASlider;
    public int lFX;
    public int lFY;
    public int lFZ;
    public int lFRx;
    public int lFRy;
    public int lFRz;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public int[] rglFSlider;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CompareTo(DIJOYSTATE2 other) => throw null;
  }
}
