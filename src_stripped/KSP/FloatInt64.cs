// Decompiled with JetBrains decompiler
// Type: KSP.FloatInt64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace KSP
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FloatInt64
  {
    [FieldOffset(0)]
    public long int64;
    [FieldOffset(0)]
    public ulong uint64;
    [FieldOffset(0)]
    public double float64;
    [FieldOffset(0)]
    public byte byte0;
    [FieldOffset(1)]
    public byte byte1;
    [FieldOffset(2)]
    public byte byte2;
    [FieldOffset(3)]
    public byte byte3;
    [FieldOffset(4)]
    public byte byte4;
    [FieldOffset(5)]
    public byte byte5;
    [FieldOffset(6)]
    public byte byte6;
    [FieldOffset(7)]
    public byte byte7;
    public const int Length = 8;

    public byte this[int i]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }
  }
}
