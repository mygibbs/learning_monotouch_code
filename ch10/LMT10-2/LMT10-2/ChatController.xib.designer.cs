// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LMT102 {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("ChatController")]
	public partial class ChatController {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UITextField __mt_chatText;
		
		private MonoTouch.UIKit.UIBarButtonItem __mt_chatJoin;
		
		private MonoTouch.UIKit.UITextView __mt_chatHistory;
		
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
		
		[MonoTouch.Foundation.Connect("chatText")]
		private MonoTouch.UIKit.UITextField chatText {
			get {
				this.__mt_chatText = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("chatText")));
				return this.__mt_chatText;
			}
			set {
				this.__mt_chatText = value;
				this.SetNativeField("chatText", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("chatJoin")]
		private MonoTouch.UIKit.UIBarButtonItem chatJoin {
			get {
				this.__mt_chatJoin = ((MonoTouch.UIKit.UIBarButtonItem)(this.GetNativeField("chatJoin")));
				return this.__mt_chatJoin;
			}
			set {
				this.__mt_chatJoin = value;
				this.SetNativeField("chatJoin", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("chatHistory")]
		private MonoTouch.UIKit.UITextView chatHistory {
			get {
				this.__mt_chatHistory = ((MonoTouch.UIKit.UITextView)(this.GetNativeField("chatHistory")));
				return this.__mt_chatHistory;
			}
			set {
				this.__mt_chatHistory = value;
				this.SetNativeField("chatHistory", value);
			}
		}
	}
}
