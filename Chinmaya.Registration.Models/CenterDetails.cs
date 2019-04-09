using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Chinmaya.Registration.Models
{
	public class CenterDetails
	{
		[DisplayName("Country")]
		[Required]
		public Guid Country { get; set; }

		[DisplayName("State")]
		[Required]
		public Guid State { get; set; }

		[DisplayName("City")]
		[Required]
		public Guid City { get; set; }

		[DisplayName("Center")]
		[Required]
		public Guid Center { get; set; }

	}
}
