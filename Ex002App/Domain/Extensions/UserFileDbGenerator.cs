using Extensions;

public static class FileGenerator
{
  public static void Create(this int count, string path, string prefix)
  {
    if (!File.Exists(path))
      for (int i = 0; i < count; i++)
      {
        File.AppendAllText(path, $"{prefix}_{i + 1}\n");
      }
  }
}