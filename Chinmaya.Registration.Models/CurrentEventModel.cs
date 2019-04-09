using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Chinmaya.Registration.Models
{
	public class CurrentEventModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string FamilyMemberName { get; set; }
		public string Description { get; set; }
		public string Weekday { get; set; }
		public string Frequency { get; set; }
		public List<multipleClassTimings> multimings { get; set; }
		public Nullable<int> AgeFrom { get; set; }
		public Nullable<int> AgeTo { get; set; }
		public Nullable<decimal> Amount { get; set; }
		public bool select { get; set; }
		public bool termsandConditions { get; set; }
		public string teacherFname { get; set; }
		public string teacherLname { get; set; }
		public string teachername { get; set; }
		public string teacherdetails { get; set; }
		public int ChangeAmount { get; set; }
		public string[] WeekdaySelect { get; set; }
		public string time { get; set; }
		public List<multipleConvertedTimings> multimingsConverted { get; set; }
	}
	public class multipleClassTimings
	{
		[DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
		public System.TimeSpan StartTime { get; set; }
		[DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
		public System.TimeSpan EndTime { get; set; }
	}

	public class multipleConvertedTimings
	{
		public string Stime { get; set; }
		public string Etime { get; set; }
	}
}
