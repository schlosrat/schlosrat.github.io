// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Networking.Models.FinalizeFileUploadsRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
