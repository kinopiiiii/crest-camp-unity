// Generated by gencs from std_msgs/Int8.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;


namespace SIGVerse.ROSBridge 
{
	namespace std_msgs 
	{
		[System.Serializable]
		public class Int8 : ROSMessage
		{
			public sbyte data;


			public Int8()
			{
				this.data = 0;
			}

			public Int8(sbyte data)
			{
				this.data = data;
			}

			new public static string GetMessageType()
			{
				return "std_msgs/Int8";
			}

			new public static string GetMD5Hash()
			{
				return "27ffa0c9c4b8fb8492252bcad9e5c57b";
			}
		} // class Int8
	} // namespace std_msgs
} // namespace SIGVerse.ROSBridge
