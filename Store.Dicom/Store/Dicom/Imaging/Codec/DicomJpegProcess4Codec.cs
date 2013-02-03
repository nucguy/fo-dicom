﻿using Dicom.Imaging.Codec.Jpeg;

// ReSharper disable CheckNamespace
namespace Dicom.Imaging.Codec
// ReSharper restore CheckNamespace
{
	public class DicomJpegProcess4Codec : DicomJpegNativeCodec
	{
		public override DicomTransferSyntax TransferSyntax
		{
			get { return DicomTransferSyntax.JPEGProcess2_4; }
		}

		protected override IJpegNativeCodec GetCodec(int bits, DicomJpegParams jparams)
		{
/*		if (bits == 8)
			return new Jpeg8Codec(JpegMode.Sequential, 0, 0);
		else*/ if (bits <= 12)
			return new Jpeg12Codec(JpegMode.Sequential, 0, 0);
		else
			throw new DicomCodecException("Unable to create JPEG Process 4 codec for bits stored == {0}", bits);
		}
	}
}