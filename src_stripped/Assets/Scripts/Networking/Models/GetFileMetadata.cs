// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Networking.Models.GetFileMetadata
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
