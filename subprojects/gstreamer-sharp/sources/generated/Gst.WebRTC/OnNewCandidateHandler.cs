// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;

	public delegate void OnNewCandidateHandler(object o, OnNewCandidateArgs args);

	public class OnNewCandidateArgs : GLib.SignalArgs {
		public string Object{
			get {
				return (string) Args [0];
			}
		}

	}
}