﻿// Copyright (c) 2010-2013 Anders Gustafsson, Cureos AB.
// This source is subject to the Microsoft Public License.
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
// All other rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.

namespace System.Net
{
	public sealed class IPAddress
	{
        #region FIELDS

	    private readonly long _address;

		public static readonly IPAddress Any = new IPAddress(0);

	    private IPAddress(long address)
	    {
	        _address = address;
	    }

	    #endregion
	}
}