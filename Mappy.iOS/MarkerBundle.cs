using System;
using MonoTouch.UIKit;
using System.Collections.Generic;
using Mappy.Common;

namespace Mappy.iOS
{
	public class MarkerBundle
	{
		Dictionary<BankEntity.Type, Dictionary<IconType, UIImage>> Icons;

		public MarkerBundle ()
		{
			Icons = new Dictionary<BankEntity.Type, Dictionary<IconType, UIImage>> {
				{BankEntity.Type.Atm,
					new Dictionary<IconType, UIImage> {
						{ IconType.None, MakeBlankMarker() },
						{ IconType.Micro, UIImage.FromBundle("atm_micro")},
						{ IconType.Small,  UIImage.FromBundle("atm_small")},
						{ IconType.Medium,  UIImage.FromBundle("atm_medium")}
					}
				}, {BankEntity.Type.Branch,
					new Dictionary<IconType, UIImage> {
						{ IconType.None, MakeBlankMarker() },
						{ IconType.Micro, UIImage.FromBundle("branch_micro")},
						{ IconType.Small, UIImage.FromBundle("branch_small")},
						{ IconType.Medium, UIImage.FromBundle("branch_medium")}
					}
				}
			};
		}

		public UIImage IconFor(BankEntity.Type entityType, IconType iconType)
		{
			return Icons[entityType][iconType];
		}

		UIImage MakeBlankMarker()
		{
			UIGraphics.BeginImageContextWithOptions (new System.Drawing.SizeF (1, 1), false, 0.0f);
			UIImage blankMarker = UIGraphics.GetImageFromCurrentImageContext();
			UIGraphics.EndImageContext ();
			return blankMarker;
		}
	}
}

