// Generated by gencs from std_msgs/Char.msg
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
		public class Char : ROSMessage
		{
			public byte data;


			public Char()
			{
				this.data = 0;
			}

			public Char(byte data)
			{
				this.data = data;
			}

			new public static string GetMessageType()
			{
				return "std_msgs/Char";
			}

			new public static string GetMD5Hash()
			{
				return "1bf77f25acecdedba0e224b162199717";
			}
		} // class Char
	} // namespace std_msgs
} // namespace SIGVerse.ROSBridge
