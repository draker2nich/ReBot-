using System.Runtime.CompilerServices;

public struct LinkItem
{
	public string Href;

	public string Text;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Text;
	}
}
