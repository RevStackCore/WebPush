﻿using System;
namespace RevStackCore.WebPush
{
	public class VapidDetails
	{
		public string Subject { get; set; }
		public string PublicKey { get; set; }
		public string PrivateKey { get; set; }

		public VapidDetails()
		{

		}

		/// <param name="subject">This should be a URL or a 'mailto:' email address</param>
		/// <param name="publicKey">The VAPID public key as a base64 encoded string</param>
		/// <param name="privateKey">The VAPID private key as a base64 encoded string</param>
		public VapidDetails(string subject, string publicKey, string privateKey)
		{
			Subject = subject;
			PublicKey = publicKey;
			PrivateKey = privateKey;
		}
	}
}
