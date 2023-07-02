// Decompiled with JetBrains decompiler
// Type: JacksonDunstan.NativeCollections.NativeHashSetState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.InteropServices;

namespace JacksonDunstan.NativeCollections
{
  [StructLayout(LayoutKind.Explicit)]
  internal struct NativeHashSetState
  {
    [FieldOffset(0)]
    internal unsafe byte* Items;
    [FieldOffset(8)]
    internal unsafe byte* Next;
    [FieldOffset(16)]
    internal unsafe byte* Buckets;
    [FieldOffset(24)]
    internal int ItemCapacity;
    [FieldOffset(28)]
    internal int BucketCapacityMask;
    [FieldOffset(32)]
    internal int AllocatedIndexLength;
    [FieldOffset(64)]
    internal unsafe fixed int FirstFreeTLS[2048];
    internal const int IntsPerCacheLine = 16;
  }
}
