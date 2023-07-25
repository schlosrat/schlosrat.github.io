// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.ByteBuffer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.VsCodeDebugger.SDK
{
  internal class ByteBuffer
  {
    private byte[] _buffer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ByteBuffer() => throw null;

    public int Length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetString(Encoding enc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Append(byte[] b, int length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public byte[] RemoveFirst(int n) => throw null;
  }
}
