/*
 * テスト用定数を使う場合は,
 * このクラスをプロジェクトに加え,
 * 名前空間 
 * KunappCommonRt.Const を削除してください.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace SDKTemplate.Common
{
	public class Const
	{
		// このAPIキーはテスト用です。
		public const string API_CONSUMER_TOKEN = "rkuuY3PIx0zBWkmfyufQTcR5t";
		public const string API_CONSUMER_SECRET = "cMtMX82i26k52s8nFmsSsAV5qkvOTq66oFo8gEmb3Z4HuYGV4N";
		
		public const int TweetStringLength = 140;
#if DEBUG
		public const string ToScreenName = "shirokichi0";
		public const string PostTweetPhrase = "を購入したなう。#kunapp #KunappWin #Testing";
#else
		public const string ToScreenName = "kunkoku";
		public const string PostTweetPhrase = "を購入したなう。#kunapp #KunappWin";
#endif
		public const string PreTweetPhrase = @"@" + Const.ToScreenName + " さん経由で";

		// for save and load class
		public const string FileDirectory = @".\";

		public const string FileName = "SETTINGS";
		public const string FileExtensionPlane = ".xml";
		public const string FileExtensionEnc = ".enc";
		public const string FileFillPathNonExtension = FileDirectory + FileName + ".";
		public const string FileFullPathPlane = FileDirectory + FileName + FileExtensionPlane;
		public const string FileFullPathEnc = FileDirectory + FileName + FileExtensionEnc;
		public const string Password = "Password";
		public const int SizeOfEos = 1;

		// for encript option
		public const string InitVector = "IntVector";

		public const int KeySize = 256;
		public const int PasswordIterations = 1000;
		public const string SaltValue = "SaltValue";

		// size of setting data byte
		public const int SizeOfSaveByte = 4 * 1024 * 1024;
	}
}
