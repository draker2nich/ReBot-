using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("987A573E-46EE-4E89-96AB-DDF7F8FDC98C")]
[CoClass(typeof(ShellUIHelperClass))]
public interface ShellUIHelper : IShellUIHelper6
{
}
