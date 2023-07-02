// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Networking.Models.GetFileMetadata
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace Assets.Scripts.Networking.Models
{
  public class GetFileMetadata
  {
    public string Checksum;
    public string DownloadUrl;
    public string FileName;
    public DateTime LastModified;
    public int Size;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GetFileMetadata() => throw null;
  }
}
