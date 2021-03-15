// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.MessageTypeGType))]
	public enum MessageType : uint {

		Unknown = 0U,
		Eos = 1,
		Error = 2,
		Warning = 4,
		Info = 8,
		Tag = 16,
		Buffering = 32,
		StateChanged = 64,
		StateDirty = 128,
		StepDone = 256,
		ClockProvide = 512,
		ClockLost = 1024,
		NewClock = 2048,
		StructureChange = 4096,
		StreamStatus = 8192,
		Application = 16384,
		Element = 32768,
		SegmentStart = 65536,
		SegmentDone = 131072,
		DurationChanged = 262144,
		Latency = 524288,
		AsyncStart = 1048576,
		AsyncDone = 2097152,
		RequestState = 4194304,
		StepStart = 8388608,
		Qos = 16777216,
		Progress = 33554432,
		Toc = 67108864,
		ResetTime = 134217728,
		StreamStart = 268435456,
		NeedContext = 536870912,
		HaveContext = 1073741824,
		Extended = 2147483648,
		DeviceAdded = 2147483649,
		DeviceRemoved = 2147483650,
		PropertyNotify = 2147483651,
		StreamCollection = 2147483652,
		StreamsSelected = 2147483653,
		Redirect = 2147483654,
		DeviceChanged = 2147483655,
		InstantRateRequest = 2147483656,
		Any = 4294967295,
	}

	internal class MessageTypeGType {
		[DllImport ("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_message_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_message_type_get_type ());
			}
		}
	}
#endregion
}