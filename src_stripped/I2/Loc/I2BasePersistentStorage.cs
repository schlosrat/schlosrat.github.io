// Decompiled with JetBrains decompiler
// Type: I2.Loc.I2BasePersistentStorage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public abstract class I2BasePersistentStorage
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetSetting_String(string key, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetSetting_String(string key, string defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void DeleteSetting(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ForceSaveSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool HasSetting(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool CanAccessFiles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool SaveFile(
      PersistentStorage.eFileType fileType,
      string fileName,
      string data,
      bool logExceptions = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string LoadFile(
      PersistentStorage.eFileType fileType,
      string fileName,
      bool logExceptions = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool DeleteFile(
      PersistentStorage.eFileType fileType,
      string fileName,
      bool logExceptions = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool HasFile(
      PersistentStorage.eFileType fileType,
      string fileName,
      bool logExceptions = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected I2BasePersistentStorage() => throw null;
  }
}
