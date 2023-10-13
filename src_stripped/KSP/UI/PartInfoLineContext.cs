// Decompiled with JetBrains decompiler
// Type: KSP.UI.PartInfoLineContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class PartInfoLineContext : ApiDataContext
  {
    [DataProperty("lineKey")]
    public Property<string> LineKey;
    [DataProperty("lineValue")]
    public Property<string> LineValue;
    [DataProperty("hasKey")]
    public Property<bool> HasKey;
    [DataProperty("hasValue")]
    public Property<bool> HasValue;
    [DataProperty("hasKeyAndValue")]
    public Property<bool> HasKeyAndValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartInfoLineContext(string key = "", string value = "") => throw null;
  }
}
