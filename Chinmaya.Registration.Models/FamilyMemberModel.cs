﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Chinmaya.Registration.Models
{
	public class FamilyMemberModel
	{
		public string Id { get; set; }
		[DisplayName("First Name")]
		[Required]
		[StringLength(100, ErrorMessage = "First Name should not be more than 100 characters")]
		public string FirstName { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "Last Name should not be more than 100 characters")]
		[DisplayName("Last Name")]
		public string LastName { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> DOB { get; set; } = null;

		[Required]
		[DisplayName("Relationship")]
		public int RelationshipData { get; set; }

		[DisplayName("Grade")]
		public Nullable<int> Grade { get; set; }

		[Required]
		[DisplayName("Gender")]
		public int GenderData { get; set; }

		//[StringLength(20, ErrorMessage = "Cell Phone should not be more than 20 characters")]
		[RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid Cell Phone")]
		[DisplayName("Cell Phone")]
		public string CellPhone { get; set; }

		
		[DisplayName("Email Address")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		//[StringLength(256, ErrorMessage = "Email should not be more than 256 characters")]
		public string Email { get; set; }

		public bool MonthlyNewsLetter { get; set; }

		public string UpdatedBy { get; set; }
        public List<KeyGuidValueModel> relationships { get; set; }
        public List<KeyGuidValueModel> grades { get; set; }
        public List<KeyGuidValueModel> genders { get; set; }
        public bool Status { get; set; }
        public int Year { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
