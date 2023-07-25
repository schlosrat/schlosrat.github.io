// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Networking.Models.InitiateFileUploadsResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Assets.Scripts.Networking.Models
{
  public class InitiateFileUploadsResponse : PlayFabResponseModel
  {
    public EntityKey Entity;
    public int ProfileVersion;
    public List<InitiateFileUploadMetadata> UploadDetails;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitiateFileUploadsResponse() => throw null;
  }
}
