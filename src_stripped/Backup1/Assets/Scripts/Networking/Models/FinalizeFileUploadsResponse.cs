// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Networking.Models.FinalizeFileUploadsResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Assets.Scripts.Networking.Models
{
  public class FinalizeFileUploadsResponse : PlayFabResponseModel
  {
    public EntityKey Entity;
    public Dictionary<string, GetFileMetadata> Metadata;
    public int ProfileVersion;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FinalizeFileUploadsResponse() => throw null;
  }
}
