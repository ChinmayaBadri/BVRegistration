using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Chinmaya.Mission.UI.Controllers
{

    public class BalaViharGroup
    {
        public string DisplaySequence { get; set; }
        public string GradeName { get; set; }
        public string Grade { get; set; }
        public string Syllabus { get; set; }
        public string TextBooks { get; set; }

    }


    public class HomeController : Controller
	{
        

        public ActionResult Index()
		{
			return View();
		}

		public ActionResult ContactUs()
		{
			return View();
		}

		public ActionResult BalaViharRegistrationForUnregistered()
		{
			return View();
		}

		public ActionResult DonationForUnregistered()
		{
			IList<SelectListItem> AvailableOptions = new List<SelectListItem>();
			AvailableOptions.Add(new SelectListItem { Value = "Badri Development Fund", Text = "0" });
			AvailableOptions.Add(new SelectListItem { Value = "Donation For Badri", Text = "1" });
			AvailableOptions.Add(new SelectListItem { Value = "Kerala Relief Fund", Text = "2" });
			AvailableOptions.Add(new SelectListItem { Value = "Youth Camp 2018", Text = "3" }); 
			AvailableOptions.Add(new SelectListItem { Value = "Bala vihar 2018 - 2019", Text = "4" });
			AvailableOptions.Add(new SelectListItem { Value = "Yoga & Meditation", Text = "5" });
			AvailableOptions.Add(new SelectListItem { Value = "Gita Chanting", Text = "6" });
			SelectList avoption = new SelectList(AvailableOptions, "Value", "Text", "0");
			ViewBag.Options = avoption;
			return View();
		}

		public ActionResult BalaViharPurpose()
		{
			return View();
		}

		public ActionResult BalaViharGroups()
		{
            string connection = WebConfigurationManager.ConnectionStrings["ChinmayaDemo"].ToString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            DataTable grades = new DataTable();
            SqlCommand cmd = new SqlCommand("USP_CM_Home_GetGradesByCenter", conn);
            cmd.Parameters.AddWithValue("@CenterCode", null);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(grades);
            conn.Close();
            ViewBag.Grades = grades;
            return View(grades);
        }





        public ActionResult BalaViharResources()
        {
            string connection = WebConfigurationManager.ConnectionStrings["ChinmayaDemo"].ToString();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            DataTable res = new DataTable();
            SqlCommand cmd = new SqlCommand("select ResourceName,Resourcelocation from cm_centerprogramresources order by resourcename", conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(res);
            conn.Close();
            return View(res);
        }

		public ActionResult BalaViharRegistration()
		{
			return View();
		}

		public ActionResult GitaChanting()
		{
			return View();
		}

		public ActionResult StutiVandana()
		{
			return View();
		}

		public ActionResult Swaranjali()
		{
			return View();
		}

		public ActionResult Admin()
		{
			return View();
		}

		public ActionResult Programs()
		{
			string connection = WebConfigurationManager.ConnectionStrings["ChinmayaDemo"].ToString();
			SqlConnection conn = new SqlConnection(connection);
			conn.Open();
			DataTable centers = new DataTable();
			SqlCommand cmd = new SqlCommand("select ProgramCode,ProgramDescription, EffectiveStartDate, EffectiveEndDate from CM_Programs where active=1 order by DisplaySequence", conn);
			cmd.CommandType = CommandType.Text;
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(centers);
			conn.Close();
			return View(centers);
		}

		public ActionResult Events()
		{
			string connection = WebConfigurationManager.ConnectionStrings["ChinmayaDemo"].ToString();
			SqlConnection conn = new SqlConnection(connection);
			conn.Open();
			DataTable centers = new DataTable();
			SqlCommand cmd = new SqlCommand("select EventCode, EventDescription, EffectiveStartDate, EffectiveEndDate from CM_Events where active=1 order by EventCode", conn);
			cmd.CommandType = CommandType.Text;
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(centers);
			conn.Close();
			return View(centers);
		}

		public ActionResult Grades()
		{
			string connection = WebConfigurationManager.ConnectionStrings["ChinmayaDemo"].ToString();
			SqlConnection conn = new SqlConnection(connection);
			conn.Open();
			DataTable centers = new DataTable();
			SqlCommand cmd = new SqlCommand("select GradeCode, GradeName, GradeDescription from CM_Grades  where active=1 order by DisplaySequence", conn);
			cmd.CommandType = CommandType.Text;
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(centers);
			conn.Close();
			return View(centers);
		}

		public ActionResult AgeGroups()
		{
			string connection = WebConfigurationManager.ConnectionStrings["ChinmayaDemo"].ToString();
			SqlConnection conn = new SqlConnection(connection);
			conn.Open();
			DataTable centers = new DataTable();
			SqlCommand cmd = new SqlCommand("select AgeGroupCode, AgeGroupDescription, MinAge, maxAge from cm_agegroups where active=1 order by DisplaySequence", conn);
			cmd.CommandType = CommandType.Text;
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(centers);
			conn.Close();
			return View(centers);
		}

		public ActionResult Syllabus()
		{
			string connection = WebConfigurationManager.ConnectionStrings["ChinmayaDemo"].ToString();
			SqlConnection conn = new SqlConnection(connection);
			conn.Open();
			DataTable centers = new DataTable();
			SqlCommand cmd = new SqlCommand("select SyllabusCode, SyllabusDescription from CM_Syllabuses order by SyllabusCode desc", conn);
			cmd.CommandType = CommandType.Text;
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(centers);
			conn.Close();
			return View(centers);
		}

		public ActionResult Textbooks()
		{
			string connection = WebConfigurationManager.ConnectionStrings["ChinmayaDemo"].ToString();
			SqlConnection conn = new SqlConnection(connection);
			conn.Open();
			DataTable centers = new DataTable();
			SqlCommand cmd = new SqlCommand("select TextbookCode, Textbookdescription from CM_Textbooks order by TextbookDescription", conn);
			cmd.CommandType = CommandType.Text;
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(centers);
			conn.Close();
			return View(centers);
		}

		public ActionResult EnrollmentFees()
		{
			return View();
		}

		public ActionResult Teachers()
		{
			return View();
		}

		public ActionResult Users()
		{
			return View();
		}

		public ActionResult SendMessages()
		{
			IList<SelectListItem> AvailableOptions = new List<SelectListItem>();
			AvailableOptions.Add(new SelectListItem { Value = "All Members", Text = "0" });
			AvailableOptions.Add(new SelectListItem { Value = "All Teachers", Text = "1" });
			AvailableOptions.Add(new SelectListItem { Value = "All Registered Users", Text = "2" });
			AvailableOptions.Add(new SelectListItem { Value = "All Centers", Text = "3" });
			SelectList avoption = new SelectList(AvailableOptions, "Value", "Text", "0");
			ViewBag.Users = avoption;

			IList<SelectListItem> AvailableOptions1 = new List<SelectListItem>();
			AvailableOptions1.Add(new SelectListItem { Value = "None", Text = "0" });
			AvailableOptions1.Add(new SelectListItem { Value = "All Members", Text = "1" });
			AvailableOptions1.Add(new SelectListItem { Value = "All Teachers", Text = "2" });
			AvailableOptions1.Add(new SelectListItem { Value = "All Registered Users", Text = "3" });
			AvailableOptions1.Add(new SelectListItem { Value = "All Centers", Text = "4" });
			SelectList avoption1 = new SelectList(AvailableOptions1, "Value", "Text", "0");
			ViewBag.Users1 = avoption1;

			return View();
		}

	}
}