﻿using System.IO;

namespace ZKWebStandard.Web.Mock {
	/// <summary>
	/// Http posted file mock
	/// </summary>
	public class HttpPostFileMock : IHttpPostedFile {
#pragma warning disable CS1591
		public string contentType { get; set; }
		public string filename { get; set; }
		public long length { get; set; }
		public Stream stream { get; set; }

		public string ContentType { get { return contentType; } }
		public string FileName { get { return filename; } }
		public long Length { get { return length; } }
		public Stream OpenReadStream() {
			return stream;
		}
#pragma warning restore CS1591
	}
}
