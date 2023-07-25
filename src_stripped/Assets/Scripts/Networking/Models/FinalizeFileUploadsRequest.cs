// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Networking.Models.FinalizeFileUploadsRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Assets.Scripts.Networking.Models
{
  public class FinalizeFileUploadsRequest
  {
    public Dictionary<string, string> CustomTags;
    public EntityKey Entity;
    public List<string> FileNames;
    public int ProfileVersion;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FinalizeFileUploadsRequest() => throw null;
  }
}
