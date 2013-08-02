using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Mappy
{
	public class MapOptionsDialog : Android.Support.V4.App.DialogFragment
	{
	
		public static MapOptionsDialog NewInstance()
		{
			return new MapOptionsDialog ();
		}

		public MapOptionsDialog() : base()
		{
		}

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
		}

		public override Dialog OnCreateDialog (Bundle bundle)
		{
			base.OnCreateDialog (bundle);
			var builder = new AlertDialog.Builder(Activity);
			builder.SetTitle("Options").SetPositiveButton("OK", HandleContinuePressed).SetNegativeButton("Cancel", HandleCancelPressed);
			var view = LayoutInflater.From (Activity).Inflate (Resource.Layout.BankEntityTypeSelection, null);

			CheckBox atmCheckBox = view.FindViewById<CheckBox> (Resource.Id.SelectAtm);
			CheckBox branchCheckBox = view.FindViewById<CheckBox> (Resource.Id.SelectBranch);
			CheckBox partnerAtmCheckbox = view.FindViewById<CheckBox> (Resource.Id.SelectPartnerAtms);
			var options = (Activity as IMapActivity).MapOptions;
			atmCheckBox.Selected = options.SelectOwnAtms;
			branchCheckBox.Selected = options.SelectOwnBranches;
			partnerAtmCheckbox.Selected = options.SelectPartnerAtms;

			builder.SetView (view);
			var dialog = builder.Create ();

			return dialog;
		}

		private void HandleCancelPressed(object s, EventArgs e)
		{
			this.Dismiss();
		}

		private void HandleContinuePressed(object s, EventArgs e)
		{
			CheckBox atmCheckBox = Dialog.FindViewById<CheckBox> (Resource.Id.SelectAtm);
			CheckBox branchCheckBox = Dialog.FindViewById<CheckBox> (Resource.Id.SelectBranch);
			CheckBox partnerAtmCheckbox = Dialog.FindViewById<CheckBox> (Resource.Id.SelectPartnerAtms);
			(Activity as IMapActivity).MapOptions = new Options (atmCheckBox.Checked, branchCheckBox.Checked, partnerAtmCheckbox.Checked);
			this.Dismiss();
		}
	}
}

