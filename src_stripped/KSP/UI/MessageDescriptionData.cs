// Decompiled with JetBrains decompiler
// Type: KSP.UI.MessageDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  [Serializable]
  public class MessageDescriptionData
  {
    public string description;
    public string spriteName;
    public bool _IsBeingSelected;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MessageDescriptionData DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MessageDescriptionData() => throw null;
  }
}
