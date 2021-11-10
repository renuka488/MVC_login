using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MVC_login.Models;

namespace MVC_login.Infrastructure.Repository
{
	public class LoginRepository : ILoginRepository

	{
		SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conString"]);


		public myloginEntity GetAllMyloginDetails(myloginEntity entity)
		{
			myloginEntity myln = new myloginEntity();
			SqlCommand com = new SqlCommand("SPselectlogin", con);
			com.CommandType = CommandType.StoredProcedure;
			com.Parameters.Add(new SqlParameter("@UserId", entity.UserID));
			com.Parameters.Add(new SqlParameter("@Password", entity.Password));
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(com);

			try
			{
				da.Fill(dt);
				if (dt.Rows.Count == 1)
				{
					foreach (DataRow eahRow in dt.Rows)
					{
						myln.Id = Convert.ToInt32(eahRow["id"]);
						myln.UserID = Convert.ToString(eahRow["UserID"]);
						myln.Password = eahRow["Password"].ToString();
						myln.Role = eahRow["Role"].ToString();
						myln.EmailAddress = eahRow["EmailAddress"].ToString();
						myln.MobileNumber = eahRow["MobileNumber"].ToString();
					}
				}

			}
			catch (Exception ex)
			{
				string err = ex.Message;
			}
			return myln;
		}
		public string CreateRegistation(myloginEntity entity)
		{
			string msg = string.Empty;
			
			SqlCommand com = new SqlCommand("SPinsertlogin", con);
			com.CommandType = CommandType.StoredProcedure;

			
			com.Parameters.AddWithValue("@Password", entity.Password);
			com.Parameters.AddWithValue("@Name", entity.Name);
			com.Parameters.AddWithValue("@Role", entity.Role);
			com.Parameters.AddWithValue("@EmailAddress", entity.EmailAddress);
			com.Parameters.AddWithValue("@MobileNumber", entity.MobileNumber);
			com.Parameters.AddWithValue("@Employeeid ", entity.EmployeeID);
			try
			{
				con.Open();
				int n = com.ExecuteNonQuery();
				con.Close();
				if (n > 0)
				{
					msg = "success";
				}
				else
				{
					msg = "failed";
				}
			}
			catch (Exception ex)
			{
				msg = "some exception";
			}
			return msg;
		}



		public string UpdateRegistation(myloginEntity entity)
		{
			string msg = string.Empty;

			SqlCommand com = new SqlCommand("Spupdatelogin", con);
			com.CommandType = CommandType.StoredProcedure;

			com.Parameters.AddWithValue("@UserId", entity.UserID);
			com.Parameters.AddWithValue("@Password", entity.Password);
			com.Parameters.AddWithValue("@Name", entity.Name);
			com.Parameters.AddWithValue("@Role", entity.Role);
			com.Parameters.AddWithValue("@EmailAddress", entity.EmailAddress);
			com.Parameters.AddWithValue("@MobileNumber", entity.MobileNumber);
			com.Parameters.AddWithValue("@Employeeid ", entity.EmployeeID);
			try

			{
				con.Open();
				int n = com.ExecuteNonQuery();
				con.Close();
				if (n > 0)
				{
					msg = "success";
				}
				else
				{
					msg = "failed";
				}
			}
			catch (Exception ex)
			{
				msg = "some exception";
			}
			return msg;
		}
		public string Insertcasestudy(CaseStudyDetails entity)
		{
			//return null;
			SqlCommand com = new SqlCommand("SP__InsertCaseStudy", con);
			com.CommandType = CommandType.StoredProcedure;
			CaseStudyDetails obj = new CaseStudyDetails();
			com.Parameters.AddWithValue("@CaseStudy", entity.CaseStudy);
			com.Parameters.AddWithValue("@IsActive", entity.IsActive);
			com.Parameters.AddWithValue("@ReviewStatus", entity.ReviewStatus);
			com.Parameters.AddWithValue("@SolutionDescription1", entity.SolutionDescription1);
			com.Parameters.AddWithValue("@CompID1", entity.CompID1);
			com.Parameters.AddWithValue("@SolutionDescription2", entity.SolutionDescription2);
			com.Parameters.AddWithValue("@CompID2", entity.CompID2);
			com.Parameters.AddWithValue("@SolutionDescription3", entity.SolutionDescription3);
			com.Parameters.AddWithValue("@CompID3", entity.CompID3);
			com.Parameters.AddWithValue("@SolutionDescription4", entity.SolutionDescription4);
			com.Parameters.AddWithValue("@CompID4", entity.CompID4);
			com.Parameters.AddWithValue("@CreateBy", entity.CreatedBy);
			string msg;
			
			try
			{
				con.Open();
				int n = com.ExecuteNonQuery();
				con.Close();
				if (n > 0)
				{
					msg = "success";
				}
				else
				{
					msg = "failed";
				}
			}
			catch (Exception )
			{
				msg = "some exception";
			}
			return msg;

		}
	}
}


	