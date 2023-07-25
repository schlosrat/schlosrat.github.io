// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.ProfilerUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace KSP.Networking.MP.Utils
{
  [StructLayout(LayoutKind.Sequential, Size = 1)]
  public struct ProfilerUtil : IDisposable
  {
    public const string UNNAMED_BLOCK_NAME_STRING = "UnnamedProfilerBlock";

    public string BlockNameString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsRunning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProfilerUtil Start(string blockNameString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProfilerUtil Start([CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop() => throw null;
  }
}
