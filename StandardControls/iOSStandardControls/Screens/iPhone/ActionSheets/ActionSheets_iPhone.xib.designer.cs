// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPhone.ActionSheets {
	
	
	// Base type probably should be UIKit.UIViewController or subclass
	[Foundation.Register("ActionSheets_iPhone")]
	public partial class ActionSheets_iPhone {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIButton __mt_btnSimpleActionSheet;
		
		private UIKit.UIButton __mt_btnActionSheetWithOtherButtons;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("btnSimpleActionSheet")]
		private UIKit.UIButton btnSimpleActionSheet {
			get {
				this.__mt_btnSimpleActionSheet = ((UIKit.UIButton)(this.GetNativeField("btnSimpleActionSheet")));
				return this.__mt_btnSimpleActionSheet;
			}
			set {
				this.__mt_btnSimpleActionSheet = value;
				this.SetNativeField("btnSimpleActionSheet", value);
			}
		}
		
		[Foundation.Connect("btnActionSheetWithOtherButtons")]
		private UIKit.UIButton btnActionSheetWithOtherButtons {
			get {
				this.__mt_btnActionSheetWithOtherButtons = ((UIKit.UIButton)(this.GetNativeField("btnActionSheetWithOtherButtons")));
				return this.__mt_btnActionSheetWithOtherButtons;
			}
			set {
				this.__mt_btnActionSheetWithOtherButtons = value;
				this.SetNativeField("btnActionSheetWithOtherButtons", value);
			}
		}
	}
}
