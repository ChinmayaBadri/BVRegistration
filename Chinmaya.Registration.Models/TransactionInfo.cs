using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinmaya.Registration.Models
{
	public class TransactionInfo
	{
		public string AccountHolderName { get; set; }
		public string AccountType { get; set; }
		public string BankName { get; set; }
		public string AccountNumber { get; set; }
		public string RoutingNumber { get; set; }
		public Nullable<decimal> Amount { get; set; }
		public System.DateTime CreatedDate { get; set; }
	}
}
