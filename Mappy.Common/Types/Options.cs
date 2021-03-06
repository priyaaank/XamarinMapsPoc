using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappy
{
	public class Options
	{
		private const string Atm = "ATM";
		private const string Branch = "Branch";

		public bool SelectOwnAtms {get; set;}
		public bool SelectOwnBranches {get; set;}
		public bool SelectPartnerAtms {get; set;}

		public Options(bool selectOwnAtms, bool selectOwnBranches, bool SelectPartnerAtms)
		{
			this.SelectOwnAtms = selectOwnAtms;
			this.SelectOwnBranches = selectOwnBranches;
			this.SelectPartnerAtms = SelectPartnerAtms;
		}

		public bool SelectAnyEntity()
		{
			return (SelectAnyAtm() && this.SelectOwnBranches);
		}

		public bool SelectAnySuncorpEntity ()
		{
			return (SelectOwnAtms && SelectOwnBranches);
		}

		public bool SelectAnyAtm()
		{
			return (this.SelectOwnAtms && this.SelectPartnerAtms);
		}

		public List<Type> FiltersForSelection()
		{
			List<Type> filtersForSelectedOptions = new List<Type> ();
			if(!SelectPartnerAtms) filtersForSelectedOptions.Add (typeof(ExcludePartnerEstablishmentsFilter));
			if(!SelectOwnAtms) filtersForSelectedOptions.Add (typeof(ExcludeOwnAtmsFilter));
			if(!SelectOwnBranches) filtersForSelectedOptions.Add (typeof(ExcludeOwnBranchesFilter));

			return filtersForSelectedOptions;
		}

		public string SelectionCriteria()
		{
			List<string> optionValues = new List<string>();
			if(this.SelectOwnAtms || this.SelectPartnerAtms) optionValues.Add(Atm);
			if(this.SelectOwnBranches) optionValues.Add(Branch);

			return optionValues.Count > 0 ? string.Join (",", optionValues.ToArray()) : Atm;
		}

	}
}

