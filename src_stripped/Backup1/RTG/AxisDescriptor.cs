// Decompiled with JetBrains decompiler
// Type: RTG.AxisDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class AxisDescriptor
  {
    private AxisSign _sign;
    private int _index;

    public AxisSign Sign
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Index
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsPositive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsNegative
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisDescriptor(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisDescriptor(int axisIndex, bool isNegative) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxFace GetAssociatedBoxFace() => throw null;
  }
}
