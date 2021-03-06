﻿namespace K4os.Compression.LZ4.Streams
{
	public interface ILZ4FrameInfo
	{
		long? ContentLength { get; }
		bool ContentChecksum { get; }

		bool Chaining { get; }
		bool BlockChecksum { get; }

		int BlockSize { get; }
	}
}
