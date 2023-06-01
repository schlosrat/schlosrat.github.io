// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.Data.IDemoView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.Generic;

namespace KSP.Iteration.Data
{
  public interface IDemoView
  {
    IProperty<bool> MapIsEnabled { get; }

    void ToggleMapIsEnabled();

    void SetMapIsEnabled(bool value);

    IProperty<IDemoVessel> ActiveVessel { get; }
  }
}
