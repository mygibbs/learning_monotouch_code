// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LMT52 {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("CustomerDetailViewController")]
	public partial class CustomerDetailViewController {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UITextField __mt_firstNameTextField;
		
		private MonoTouch.UIKit.UITextField __mt_lastNameTextField;
		
		private MonoTouch.UIKit.UITextField __mt_noteTextField;
		
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
		
		[MonoTouch.Foundation.Connect("firstNameTextField")]
		private MonoTouch.UIKit.UITextField firstNameTextField {
			get {
				this.__mt_firstNameTextField = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("firstNameTextField")));
				return this.__mt_firstNameTextField;
			}
			set {
				this.__mt_firstNameTextField = value;
				this.SetNativeField("firstNameTextField", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lastNameTextField")]
		private MonoTouch.UIKit.UITextField lastNameTextField {
			get {
				this.__mt_lastNameTextField = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("lastNameTextField")));
				return this.__mt_lastNameTextField;
			}
			set {
				this.__mt_lastNameTextField = value;
				this.SetNativeField("lastNameTextField", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("noteTextField")]
		private MonoTouch.UIKit.UITextField noteTextField {
			get {
				this.__mt_noteTextField = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("noteTextField")));
				return this.__mt_noteTextField;
			}
			set {
				this.__mt_noteTextField = value;
				this.SetNativeField("noteTextField", value);
			}
		}
	}
}
