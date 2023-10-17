using EtiqaCDN.Interfaces;
using EtiqaCDN.Models.Results;
using EtiqaCDN.Models.Tables;
using EtiqaCDN.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EtiqaCDN.Repositories
{
	public class FreelancerRepository : IFreelancer
	{
		// Initialized Connection String
		private string _conStr = "";

		// Intialized Models Used
		private List<FreelancerModel> _freelancerlist = new List<FreelancerModel>();
		private FreelancerResultModel _freelancerResult = new FreelancerResultModel();

		public FreelancerRepository()
		{
			_conStr = new AppSettingsJSON().GetValue("ConnectionStrings", "MainDB");
		}

		public async Task<FreelancerResultModel> GetAll()
		{
			using (SqlConnection conn = new SqlConnection(_conStr))
			{
				conn.Open();

				try
				{
					SqlCommand command = new SqlCommand("SELECT * FROM Freelancer", conn);

					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{						
						_freelancerlist.Add(await MapReaderIntoModel(reader));
					}

					if (_freelancerlist.Count == 0)
					{
						_freelancerResult.Success = false;
						_freelancerResult.Message = "No records found";
						_freelancerResult.Total = _freelancerlist.Count;
						_freelancerResult.Result = _freelancerlist;

					} else
					{
						_freelancerResult.Success = true;
						_freelancerResult.Message = "";
						_freelancerResult.Total = _freelancerlist.Count;
						_freelancerResult.Result = _freelancerlist;
					}
				}
				catch (Exception ex)
				{
					_freelancerResult.Success = false;
					_freelancerResult.Message = ex.Message.ToString();
					_freelancerResult.Total = 0;
					_freelancerResult.Result = new List<FreelancerModel>();
				}

				conn.Close();
			}

			return _freelancerResult;
		}

		public async Task<FreelancerResultModel> GetById(Guid id)
		{
			using (SqlConnection conn = new SqlConnection(_conStr))
			{
				conn.Open();

				try
				{
					SqlCommand command = new SqlCommand("SELECT * FROM Freelancer WHERE Id = @Id", conn);
					command.Parameters.AddWithValue("@Id", id);

					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						_freelancerlist.Add(await MapReaderIntoModel(reader));
					}

					if (_freelancerlist.Count == 0)
					{
						_freelancerResult.Success = false;
						_freelancerResult.Message = "No records found";
						_freelancerResult.Total = _freelancerlist.Count;
						_freelancerResult.Result = _freelancerlist;

					}
					else
					{
						_freelancerResult.Success = true;
						_freelancerResult.Message = "Records found";
						_freelancerResult.Total = _freelancerlist.Count;
						_freelancerResult.Result = _freelancerlist;
					}
				}
				catch (Exception ex)
				{
					_freelancerResult.Success = false;
					_freelancerResult.Message = ex.Message.ToString();
					_freelancerResult.Total = 0;
					_freelancerResult.Result = new List<FreelancerModel>();
				}

				conn.Close();
			}

			return _freelancerResult;
		}

		public async Task<FreelancerResultModel> Create(FreelancerModel freelancer)
		{
			using (SqlConnection conn = new SqlConnection(_conStr))
			{
				conn.Open();

				try
				{
					SqlCommand command = new SqlCommand()
					{
						CommandText = "SP_INSERT_Freelancer"
						, Connection = conn
						, CommandType = CommandType.StoredProcedure
					};

					command.Parameters.Add(new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Value = freelancer.UserName, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@FirstName", SqlDbType = SqlDbType.NVarChar, Value = freelancer.FirstName, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@LastName", SqlDbType = SqlDbType.NVarChar, Value = freelancer.LastName, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@Email", SqlDbType = SqlDbType.NVarChar, Value = freelancer.Email, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@PhoneNum", SqlDbType = SqlDbType.NVarChar, Value = freelancer.PhoneNum, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@Hobby", SqlDbType = SqlDbType.NVarChar, Value = freelancer.Hobby, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@SkillSet", SqlDbType = SqlDbType.NVarChar, Value = freelancer.SkillSet, Direction = ParameterDirection.Input });

					command.ExecuteNonQuery();

					_freelancerResult.Success = true;
					_freelancerResult.Message = "Data successfully inserted!";
					_freelancerResult.Total = 0;
					_freelancerResult.Result = new List<FreelancerModel>();
				}
				catch (Exception ex)
				{
					_freelancerResult.Success = false;
					_freelancerResult.Message = ex.Message.ToString();
					_freelancerResult.Total = 0;
					_freelancerResult.Result = new List<FreelancerModel>();
				}

				conn.Close();
			}

			return _freelancerResult;
		}

		public async Task<FreelancerResultModel> Update(FreelancerModel freelancer)
		{
			using (SqlConnection conn = new SqlConnection(_conStr))
			{
				conn.Open();

				try
				{
					SqlCommand command = new SqlCommand()
					{
						CommandText = @"
							UPDATE Freelancer 
							SET UserName = @UserName, FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNum = @PhoneNum, Hobby = @Hobby, SkillSet = @SkillSet
							WHERE Id = @Id
						"
						, Connection = conn
					};

					command.Parameters.Add(new SqlParameter { ParameterName = "@Id", SqlDbType = SqlDbType.UniqueIdentifier, Value = freelancer.Id, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@UserName", SqlDbType = SqlDbType.NVarChar, Value = freelancer.UserName, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@FirstName", SqlDbType = SqlDbType.NVarChar, Value = freelancer.FirstName, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@LastName", SqlDbType = SqlDbType.NVarChar, Value = freelancer.LastName, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@Email", SqlDbType = SqlDbType.NVarChar, Value = freelancer.Email, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@PhoneNum", SqlDbType = SqlDbType.NVarChar, Value = freelancer.PhoneNum, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@Hobby", SqlDbType = SqlDbType.NVarChar, Value = freelancer.Hobby, Direction = ParameterDirection.Input });
					command.Parameters.Add(new SqlParameter { ParameterName = "@SkillSet", SqlDbType = SqlDbType.NVarChar, Value = freelancer.SkillSet, Direction = ParameterDirection.Input });

					command.ExecuteNonQuery();

					_freelancerResult.Success = true;
					_freelancerResult.Message = "Data successfully updated!";
					_freelancerResult.Total = 0;
					_freelancerResult.Result = new List<FreelancerModel>();
				}
				catch (Exception ex)
				{
					_freelancerResult.Success = false;
					_freelancerResult.Message = ex.Message.ToString();
					_freelancerResult.Total = 0;
					_freelancerResult.Result = new List<FreelancerModel>();
				}

				conn.Close();
			}

			return _freelancerResult;
		}

		public async Task<FreelancerResultModel> Delete(Guid Id)
		{
			using (SqlConnection conn = new SqlConnection(_conStr))
			{
				conn.Open();

				try
				{
					SqlCommand command = new SqlCommand()
					{
						CommandText = "DELETE FROM Freelancer WHERE Id = @Id"
						, Connection = conn
					};

					command.Parameters.Add(new SqlParameter { ParameterName = "@Id", SqlDbType = SqlDbType.UniqueIdentifier, Value = Id, Direction = ParameterDirection.Input });

					command.ExecuteNonQuery();

					_freelancerResult.Success = true;
					_freelancerResult.Message = "Data successfully deleted!";
					_freelancerResult.Total = 0;
					_freelancerResult.Result = new List<FreelancerModel>();
				}
				catch (Exception ex)
				{
					_freelancerResult.Success = false;
					_freelancerResult.Message = ex.Message.ToString();
					_freelancerResult.Total = 0;
					_freelancerResult.Result = new List<FreelancerModel>();
				}

				conn.Close();
			}

			return _freelancerResult;
		}

		private async Task<FreelancerModel> MapReaderIntoModel(SqlDataReader reader)
		{
			return new FreelancerModel()
			{
				Id = Guid.Parse(reader["Id"].ToString())
				, UserName = reader["UserName"].ToString()
				, FirstName = reader["FirstName"].ToString()
				, LastName = reader["LastName"].ToString()
				, Email = reader["Email"].ToString()
				, PhoneNum = reader["PhoneNum"].ToString()
				, Hobby = reader["Hobby"].ToString()
				, SkillSet = reader["SkillSet"].ToString()
			};
		}
	}
}
