// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LMT64 {
    
    
    // Base type probably should be MonoTouch.Foundation.NSObject or subclass
    [MonoTouch.Foundation.Register("AppDelegate")]
    public partial class AppDelegate {
        
        private MonoTouch.UIKit.UIWindow __mt_window;
        
        private AnimationDemoViewController __mt_animationDemoVC;
        
        #pragma warning disable 0169
        [MonoTouch.Foundation.Connect("window")]
        private MonoTouch.UIKit.UIWindow window {
            get {
                this.__mt_window = ((MonoTouch.UIKit.UIWindow)(this.GetNativeField("window")));
                return this.__mt_window;
            }
            set {
                this.__mt_window = value;
                this.SetNativeField("window", value);
            }
        }
        
        [MonoTouch.Foundation.Connect("animationDemoVC")]
        private AnimationDemoViewController animationDemoVC {
            get {
                this.__mt_animationDemoVC = ((AnimationDemoViewController)(this.GetNativeField("animationDemoVC")));
                return this.__mt_animationDemoVC;
            }
            set {
                this.__mt_animationDemoVC = value;
                this.SetNativeField("animationDemoVC", value);
            }
        }
    }
}