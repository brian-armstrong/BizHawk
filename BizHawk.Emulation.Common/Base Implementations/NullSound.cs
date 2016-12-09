﻿namespace BizHawk.Emulation.Common
{
	public class NullSound : ISoundProvider
	{
		public static readonly NullSound SilenceProvider = new NullSound();

		public void GetSamples(short[] samples) { }
		public void DiscardSamples() { }
	}
}
