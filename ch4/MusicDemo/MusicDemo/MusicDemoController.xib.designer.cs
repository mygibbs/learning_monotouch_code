// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MusicDemo {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("MusicDemoController")]
	public partial class MusicDemoController {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UILabel __mt_artistLabel;
		
		private MonoTouch.UIKit.UILabel __mt_titleLabel;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_open;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_stop;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_pause;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_play;
		
		private MonoTouch.UIKit.UISlider __mt_volumeSlider;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("artistLabel")]
		private MonoTouch.UIKit.UILabel artistLabel {
			get {
				this.__mt_artistLabel = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("artistLabel")));
				return this.__mt_artistLabel;
			}
			set {
				this.__mt_artistLabel = value;
				this.SetNativeField("artistLabel", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("titleLabel")]
		private MonoTouch.UIKit.UILabel titleLabel {
			get {
				this.__mt_titleLabel = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("titleLabel")));
				return this.__mt_titleLabel;
			}
			set {
				this.__mt_titleLabel = value;
				this.SetNativeField("titleLabel", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("open")]
		private MonoTouch.UIKit.UIBarButtonItem open {
			get {
				this.__mt_open = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("open")));
				return this.__mt_open;
			}
			set {
				this.__mt_open = value;
				this.SetNativeField("open", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("stop")]
		private MonoTouch.UIKit.UIBarButtonItem stop {
			get {
				this.__mt_stop = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("stop")));
				return this.__mt_stop;
			}
			set {
				this.__mt_stop = value;
				this.SetNativeField("stop", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("pause")]
		private MonoTouch.UIKit.UIBarButtonItem pause {
			get {
				this.__mt_pause = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("pause")));
				return this.__mt_pause;
			}
			set {
				this.__mt_pause = value;
				this.SetNativeField("pause", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("play")]
		private MonoTouch.UIKit.UIBarButtonItem play {
			get {
				this.__mt_play = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("play")));
				return this.__mt_play;
			}
			set {
				this.__mt_play = value;
				this.SetNativeField("play", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("volumeSlider")]
		private MonoTouch.UIKit.UISlider volumeSlider {
			get {
				this.__mt_volumeSlider = ((MonoTouch.UIKit.UISlider)(this.GetNativeField("volumeSlider")));
				return this.__mt_volumeSlider;
			}
			set {
				this.__mt_volumeSlider = value;
				this.SetNativeField("volumeSlider", value);
			}
		}
	}
}
