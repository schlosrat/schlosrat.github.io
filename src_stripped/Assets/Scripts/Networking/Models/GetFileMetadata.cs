// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Networking.Models.GetFileMetadata
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
