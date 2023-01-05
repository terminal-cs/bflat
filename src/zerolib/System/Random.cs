namespace System
{
	public struct Random
	{
		public Random(uint Seed)
		{
			Value = Seed;
		}

		#region Fields

		public uint Next() => Value = (1103515245 * Value + 12345) % 2147483648;

		private uint Value;

		#endregion
	}
}
