using static System.Console;

WriteLine($"Currently having {args.Length} arguments.");

foreach (string arg in args)
{
  WriteLine(arg);
}

if (args.Length < 3)
{
  WriteLine("You must specify two colors and a cursor size, e.g.");
  WriteLine("dotnet run yellow green 68");
  return; // stop running
}

ForegroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor),
  value: args[0],
  ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor),
  value: args[1],
  ignoreCase: true);

try
{
  CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
  WriteLine("The current platform does not support changing the size of the cursor.");
}

if (OperatingSystem.IsWindows() && OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
  WriteLine("You can execute Window-Only code that compatible for at least Window 10");
}
else if (OperatingSystem.IsIOSVersionAtLeast(major: 16, minor: 5))
{
  WriteLine("You can execute IOS-Only code that compatible for at least IOS 16.5");
}
else if (OperatingSystem.IsBrowser())
{
  WriteLine("You can execute Browser-Only code");
}

#if NET6_0_ANDROID
// compile statements that only works on Android
#elif NET6_0_IOS
// compile statements that only works on iOS
#else
// compile statements that work everywhere else
#endif