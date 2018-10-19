using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLibrary.Interfaces;
using TypeLibrary.Models;
using TypeLibrary.ViewModels;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBAccess : IDBAccess
    {
        public bool AddEmployer(AddEmployer addemployer)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach(var prop in addemployer.GetType().GetProperties())
            {
                if(prop.GetValue(addemployer) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(addemployer)));
                }
            }
            return DBHelper.NonQuery("uspAddEmployer", CommandType.StoredProcedure, parameters.ToArray());
        }

        public bool AddJobPost(AddJobPost addjobpost)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var prop in addjobpost.GetType().GetProperties())
            {
                if (prop.GetValue(addjobpost) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(addjobpost)));
                }
            }
            return DBHelper.NonQuery("uspAddJobPost", CommandType.StoredProcedure, parameters.ToArray());
        }

        public bool AddStudent(AddStudent addstudent)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var prop in addstudent.GetType().GetProperties())
            {
                if (prop.GetValue(addstudent) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(addstudent)));
                }
            }
            return DBHelper.NonQuery("uspAddStudent", CommandType.StoredProcedure, parameters.ToArray());
        }

        public bool AddNewSkill(AddNewSkill addNewSkill)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var prop in addNewSkill.GetType().GetProperties())
            {
                if (prop.GetValue(addNewSkill) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(addNewSkill)));
                }
            }
            return DBHelper.NonQuery("uspAddNewSkill", CommandType.StoredProcedure, parameters.ToArray());
         }

        public bool AddNewQual(AddNewQual addNewQual)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var prop in addNewQual.GetType().GetProperties())
            {
                if (prop.GetValue(addNewQual) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(addNewQual)));
                }
            }
            return DBHelper.NonQuery("uspAddNewQual", CommandType.StoredProcedure, parameters.ToArray());
        }

        public bool AddNewIndustry(AddNewIndustry addNewIndustry)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var prop in addNewIndustry.GetType().GetProperties())
            {
                if (prop.GetValue(addNewIndustry) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(addNewIndustry)));
                }
            }
            return DBHelper.NonQuery("uspAddNewIndustry", CommandType.StoredProcedure, parameters.ToArray());
        }

        public bool AddStudentSkill(AddStudentSkill addStudentSkill)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var prop in addStudentSkill.GetType().GetProperties())
            {
                if (prop.GetValue(addStudentSkill) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(addStudentSkill)));
                }
            }
            return DBHelper.NonQuery("uspAddStudentSkill", CommandType.StoredProcedure, parameters.ToArray());

        }

        public bool AddStudentQual(AddStudentQual addStudentQual)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var prop in addStudentQual.GetType().GetProperties())
            {
                if (prop.GetValue(addStudentQual) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(addStudentQual)));
                }
            }
            return DBHelper.NonQuery("uspAddStudentQual", CommandType.StoredProcedure, parameters.ToArray());
        }

        public bool DeleteJobPost(DeleteJobPost deletejobpost)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach(var prop in deletejobpost.GetType().GetProperties())
            {
                if (prop.GetValue(deletejobpost) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(deletejobpost)));
                }
            }
            return DBHelper.NonQuery("uspDeleteJobPost", CommandType.StoredProcedure, parameters.ToArray());
        }

        public bool DeleteStudent(DeleteStudent deleteStudent)
        {
            List<SqlParameter> params1 = new List<SqlParameter>();
            foreach(var prop in deleteStudent.GetType().GetProperties())
            {
                if(prop.GetValue(deleteStudent) != null)
                {
                    params1.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(deleteStudent)));
                }
            }
            return DBHelper.NonQuery("uspDeleteStudent", CommandType.StoredProcedure, params1.ToArray());
        }

        public bool DeleteStudentSkill(DeleteStudentSkill deleteStudentSkill)
        {
            List<SqlParameter> params1 = new List<SqlParameter>();
            foreach (var prop in deleteStudentSkill.GetType().GetProperties())
            {
                if (prop.GetValue(deleteStudentSkill) != null)
                {
                    params1.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(deleteStudentSkill)));
                }
            }
            return DBHelper.NonQuery("uspDeleteStudentSkill", CommandType.StoredProcedure, params1.ToArray());
        }

        public bool DeleteStudentQual(DeleteStudentQual deleteStudentQual)
        {
            List<SqlParameter> params1 = new List<SqlParameter>();
            foreach (var prop in deleteStudentQual.GetType().GetProperties())
            {
                if (prop.GetValue(deleteStudentQual) != null)
                {
                    params1.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(deleteStudentQual)));
                }
            }
            return DBHelper.NonQuery("uspDeleteStudentQual", CommandType.StoredProcedure, params1.ToArray());
        }
        public bool DeleteEmployer(DeleteEmployer deleteEmployer)
        {
            List<SqlParameter> params1 = new List<SqlParameter>();
            foreach (var prop in deleteEmployer.GetType().GetProperties())
            {
                if (prop.GetValue(deleteEmployer) != null)
                {
                    params1.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(deleteEmployer)));
                }
            }
            return DBHelper.NonQuery("uspDeleteEmployer", CommandType.StoredProcedure, params1.ToArray());
        }

        public bool UpdateEmployerProfile(UpdateEmployerProfile updateemployerprofile)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var prop in updateemployerprofile.GetType().GetProperties())
            {
                if (prop.GetValue(updateemployerprofile) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(updateemployerprofile)));
                }
            }
            return DBHelper.NonQuery("uspUpdateEmployerProfile", CommandType.StoredProcedure, parameters.ToArray());
        }

        public bool UpdateStudentProfile(UpdateStudentProfile updatestudentprofile)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var prop in updatestudentprofile.GetType().GetProperties())
            {
                if (prop.GetValue(updatestudentprofile) != null)
                {
                    parameters.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(updatestudentprofile)));
                }
            }
            return DBHelper.NonQuery("uspUpdateStudentProfile", CommandType.StoredProcedure, parameters.ToArray());
        }

        public UspGetAllJobPostsByEmployer GetAllJobPostsByEmployer(int employerID)
        {
            UspGetAllJobPostsByEmployer je = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@employerID", employerID)
            };
            using(DataTable table = DBHelper.ParamSelect("uspGetAllJobPostsByEmployer", CommandType.StoredProcedure, param))
            {
                //Check if any record exist or not
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    je = new UspGetAllJobPostsByEmployer
                    {
                        jobTitle = row["JobTitle"].ToString(),
                        datePosted = Convert.ToDateTime(row["DatePosted"]),
                        dateClosing = Convert.ToDateTime(row["DateClosing"]),
                        countryID = Convert.ToInt32(row["CountryID"]),
                        cityID = Convert.ToInt32(row["CityID"]),
                        jobDescription = row["JobDescription"].ToString(),
                        keyResponsibilities = row["KeyResponsibilities"].ToString(),
                        qualID = Convert.ToInt32(row["QualID"]),
                        skillID = Convert.ToInt32(row["SkillID"]),
                        typeID = Convert.ToInt32(row["TypeID"]),
                        duration = Convert.ToInt32(row["Duration"]),
                        startDate = Convert.ToDateTime(row["StartDate"]),
                        employerID = Convert.ToInt32(row["EmployerID"]),
                        postedBy = row["PostedBy"].ToString(),
                        statusID = Convert.ToInt32(row["StatusID"])
                    };
                }
                }
                return je;
            }
       

        public UspGetAllJobPostsByQualification GetAllJobPostsByQualification(int qualID)
        {
            UspGetAllJobPostsByQualification jq = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@qualID", qualID)
            };
            using (DataTable table = DBHelper.ParamSelect("uspGetAllJobPostsByQualification", CommandType.StoredProcedure, param))
            {
                //Check if any record exists
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    jq = new UspGetAllJobPostsByQualification
                    {
                        jobTitle = row["JobTitle"].ToString(),
                        datePosted = Convert.ToDateTime(row["DatePosted"]),
                        dateClosing = Convert.ToDateTime(row["DateClosing"]),
                        countryID = Convert.ToInt32(row["CountryID"]),
                        cityID = Convert.ToInt32(row["CityID"]),
                        jobDescription = row["JobDescription"].ToString(),
                        keyResponsibilities = row["KeyResponsibilities"].ToString(),
                        qualID = Convert.ToInt32(row["QualID"]),
                        skillID = Convert.ToInt32(row["SkillID"]),
                        typeID = Convert.ToInt32(row["TypeID"]),
                        duration = Convert.ToInt32(row["Duration"]),
                        startDate = Convert.ToDateTime(row["StartDate"]),
                        employerID = Convert.ToInt32(row["EmployerID"]),
                        postedBy = row["PostedBy"].ToString(),
                        statusID = Convert.ToInt32(row["StatusID"])
                    };
                }
            }
            return jq;
        }

        public UspGetAllJobPostsBySkill GetAllJobPostsBySkill(int skillID)
        {
            UspGetAllJobPostsBySkill js = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@skillID", skillID)
            };
            using (DataTable table = DBHelper.ParamSelect("uspGetAllJobPostsBySkill", CommandType.StoredProcedure, param))
            {
                //Check if any record exists
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    js = new UspGetAllJobPostsBySkill
                    {
                        jobTitle = row["JobTitle"].ToString(),
                        datePosted = Convert.ToDateTime(row["DatePosted"]),
                        dateClosing = Convert.ToDateTime(row["DateClosing"]),
                        countryID = Convert.ToInt32(row["CountryID"]),
                        cityID = Convert.ToInt32(row["CityID"]),
                        jobDescription = row["JobDescription"].ToString(),
                        keyResponsibilities = row["KeyResponsibilities"].ToString(),
                        qualID = Convert.ToInt32(row["QualID"]),
                        skillID = Convert.ToInt32(row["SkillID"]),
                        typeID = Convert.ToInt32(row["TypeID"]),
                        duration = Convert.ToInt32(row["Duration"]),
                        startDate = Convert.ToDateTime(row["StartDate"]),
                        employerID = Convert.ToInt32(row["EmployerID"]),
                        postedBy = row["PostedBy"].ToString(),
                        statusID = Convert.ToInt32(row["StatusID"])
                    };
                }
            }
            return js;
        }

        public UspGetAllJobPostsByType GetAllJobPostsByType(int typeID)
        {
            UspGetAllJobPostsByType jt = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@typeID", typeID)
            };
            using(DataTable table = DBHelper.ParamSelect("uspGetAllJobPostsByType", CommandType.StoredProcedure, param))
            {
                //Check if any record exists
                if(table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    jt = new UspGetAllJobPostsByType
                    {
                        jobTitle = row["JobTitle"].ToString(),
                        datePosted = Convert.ToDateTime(row["DatePosted"]),
                        dateClosing = Convert.ToDateTime(row["DateClosing"]),
                        countryID = Convert.ToInt32(row["CountryID"]),
                        cityID = Convert.ToInt32(row["CityID"]),
                        jobDescription = row["JobDescription"].ToString(),
                        keyResponsibilities = row["KeyResponsibilities"].ToString(),
                        qualID = Convert.ToInt32(row["QualID"]),
                        skillID = Convert.ToInt32(row["SkillID"]),
                        typeID = Convert.ToInt32(row["TypeID"]),
                        duration = Convert.ToInt32(row["Duration"]),
                        startDate = Convert.ToDateTime(row["StartDate"]),
                        employerID = Convert.ToInt32(row["EmployerID"]),
                        postedBy = row["PostedBy"].ToString(),
                        statusID = Convert.ToInt32(row["StatusID"])
                    };
                }
            }
            return jt;
        }

        public UspGetAllStudentsByCity GetAllStudentsByCity(int cityID)
        {
            UspGetAllStudentsByCity sc = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@cityID", cityID)
            };
            using (DataTable table = DBHelper.ParamSelect("uspGetAllStudentsByCity", CommandType.StoredProcedure, param))
            {
                //Check if any record exists
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    sc = new UspGetAllStudentsByCity
                    {
                        studentNo = Convert.ToInt32(row["StudentNo"]),
                        firstName = row["StudentFirstName"].ToString(),
                        lastName = row["StudentLastName"].ToString(),
                        studentDateOfBirth = Convert.ToDateTime(row["StudentDOB"]),
                        countryID = Convert.ToInt32(row["CountryID"]),
                        cityID = Convert.ToInt32(row["CityID"]),
                        studentEmail = row["StudentEmail"].ToString(),
                        contactNo = row["StudentContactNo"].ToString(),
                        industryID = Convert.ToInt32(row["IndustryID"]),
                        qualID = Convert.ToInt32(row["QualificationID"]),
                        skillID = Convert.ToInt32(row["SkillID"]),
                        driversLicence = row["DriversLicense"].ToString(),
                        profilePicture = Convert.ToByte(row["StudentProfilePicture"]),
                        studentUsername = row["StudentUsername"].ToString(),
                        studentPasssword = row["StudentPassword"].ToString(),
                        cv = Convert.ToByte(row["CV"]),
                        statusID = Convert.ToInt32(row["StatusID"]),
                        lastUpdated = Convert.ToDateTime(row["LastUpdate"])
                    };
                }
            }
            return sc;
        }

        public UspGetAllStudentsByQualification GetAllStudentsByQualification(int qualID)
        {
            UspGetAllStudentsByQualification sq = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@qualID", qualID)
            };
            using (DataTable table = DBHelper.ParamSelect("uspGetAllStudentsByQualification", CommandType.StoredProcedure, param))
            {
                //Check if any records exist
                if(table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    sq = new UspGetAllStudentsByQualification
                    {
                        studentNo = Convert.ToInt32(row["StudentNo"]),
                        firstName = row["StudentFirstName"].ToString(),
                        lastName = row["StudentLastName"].ToString(),
                        studentDateOfBirth = Convert.ToDateTime(row["StudentDOB"]),
                        countryID = Convert.ToInt32(row["CountryID"]),
                        cityID = Convert.ToInt32(row["CityID"]),
                        studentEmail = row["StudentEmail"].ToString(),
                        contactNo = row["StudentContactNo"].ToString(),
                        industryID = Convert.ToInt32(row["IndustryID"]),
                        qualID = Convert.ToInt32(row["QualificationID"]),
                        skillID = Convert.ToInt32(row["SkillID"]),
                        driversLicence = row["DriversLicense"].ToString(),
                        profilePicture = Convert.ToByte(row["StudentProfilePicture"]),
                        studentUsername = row["StudentUsername"].ToString(),
                        studentPasssword = row["StudentPassword"].ToString(),
                        cv = Convert.ToByte(row["CV"]),
                        statusID = Convert.ToInt32(row["StatusID"]),
                        lastUpdated = Convert.ToDateTime(row["LastUpdate"])
                    };
                }
            }
            return sq;
        }
        //public UspGetAllJobPosts GetAllJobPosts(int employerID)
        //{
        //    UspGetAllJobPosts jp = null;
        //    SqlParameter[] param = new SqlParameter[]
        //    {
        //        new SqlParameter ("@employerID", employerID)
        //    };
        //    using (DataTable table = DBHelper.ParamSelect("uspGetAllJobPosts", CommandType.StoredProcedure, param))
        //    {
        //        if (table.Rows.Count == 1)
        //        {
        //            DataRow row = table.Rows[0];
        //            jp = new UspGetAllJobPosts
        //            {
        //                JobID = Convert.ToInt32(row["JobID"]),
        //                DatePosted = Convert.ToDateTime(row["DatePosted"]),
        //                DateClosing = Convert.ToDateTime(row["DateClosing"]),
        //                CountryDescription = row["CountryDescription"].ToString(),
        //                CityDescription = row["CityDescription"].ToString(),
        //                JobDescription = row["JobDescription"].ToString(),
        //                KeyResponsebilities = row["KeyResponsebilities"].ToString(),
        //                QualificationDescription = row["QualificationDescription"].ToString(),
        //                SkillDescription = row["SkillDescription"].ToString(),
        //                TypeDescription = row["TypeDescription"].ToString(),
        //                Duration = Convert.ToInt32(row["Duration"]),
        //                StartDate = Convert.ToDateTime(row["StartDate"]),
        //                PostedBy = row["PostedBy"].ToString(),
        //                StatusDescription = row["StatusDescription"].ToString(),

        //            };
        //        }
        //    }
        //    return jp;
        //}

        public UspGetAllStudentsBySkill GetAllStudentsBySkill(int skillID)
        {
            UspGetAllStudentsBySkill ss = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@skillID", skillID)
            };
            using(DataTable table = DBHelper.ParamSelect("uspGetAllStudentsBySkill", CommandType.StoredProcedure, param))
            {
                //CHeck if any records exist
                if(table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    ss = new UspGetAllStudentsBySkill
                    {
                        studentNo = Convert.ToInt32(row["StudentNo"]),
                        firstName = row["StudentFirstName"].ToString(),
                        lastName = row["StudentLastName"].ToString(),
                        studentDateOfBirth = Convert.ToDateTime(row["StudentDOB"]),
                        countryID = Convert.ToInt32(row["CountryID"]),
                        cityID = Convert.ToInt32(row["CityID"]),
                        studentEmail = row["StudentEmail"].ToString(),
                        contactNo = row["StudentContactNo"].ToString(),
                        industryID = Convert.ToInt32(row["IndustryID"]),
                        qualID = Convert.ToInt32(row["QualificationID"]),
                        skillID = Convert.ToInt32(row["SkillID"]),
                        driversLicence = row["DriversLicense"].ToString(),
                        profilePicture = Convert.ToByte(row["StudentProfilePicture"]),
                        studentUsername = row["StudentUsername"].ToString(),
                        studentPasssword = row["StudentPassword"].ToString(),
                        cv = Convert.ToByte(row["CV"]),
                        statusID = Convert.ToInt32(row["StatusID"]),
                        lastUpdated = Convert.ToDateTime(row["LastUpdate"])
                    };
                }
            }
            return ss;
        }

        public UspCheckStudentLogin CheckStudentLogin(int studentNo, string studentPassword)
        {
            UspCheckStudentLogin sl = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@studentNo", studentNo),
                new SqlParameter("@password", studentPassword)
            };
            using (DataTable table = DBHelper.ParamSelect("uspCheckStudentLogin", CommandType.StoredProcedure, param))
            {
                if(table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    sl = new UspCheckStudentLogin
                    {
                        studentNo = Convert.ToInt32(row["StudentNo"]),
                        studentPassword = row["StudentPassword"].ToString()
                    };
                }
            }
            return sl;
        }

        public UspCheckEmployerLogin CheckEmployerLogin(string employerEmail, string employerPassword)
        {
            UspCheckEmployerLogin el = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@employerEmail", employerEmail),
                new SqlParameter("@employerPassword", employerPassword)
            };
            using (DataTable table = DBHelper.ParamSelect("uspCheckEmployerLogin", CommandType.StoredProcedure, param))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    el = new UspCheckEmployerLogin
                    {
                        employerEmail = row["Email"].ToString(),
                        employerPassword = row["EmployerPassword"].ToString()
                    };
                }
            }
            return el;
        }
        
        public List<UspGetAllCountries> GetAllCountries()
        {
            List<UspGetAllCountries> countries = new List<UspGetAllCountries>();

            using (DataTable table = DBHelper.Select("uspGetAllCountries", CommandType.StoredProcedure))
            {
                if(table.Rows.Count > 0)
                {
                    foreach(DataRow row in table.Rows)
                    {
                        UspGetAllCountries ct = new UspGetAllCountries
                        {
                            countryID = Convert.ToInt32(row["CountryID"]),
                            countryDescription = row["CountryDescription"].ToString()
                        };
                        countries.Add(ct);
                    }
                }
            }
            return countries;
        }

        public List<UspGetAllStudents> GetAllStudents()
        {
            List<UspGetAllStudents> students = new List<UspGetAllStudents>();

            using (DataTable table = DBHelper.Select("uspGetAllStudents", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllStudents gas = new UspGetAllStudents
                        {
                            studentNo = Convert.ToInt32(row["StudentNo"]),
                            firstName = row["StudentFirstName"].ToString(),
                            lastName = row["StudentLastName"].ToString(),
                            studentDateOfBirth = Convert.ToDateTime(row["StudentDateofBirth"]),
                            //countryID = Convert.ToInt32(row["CountryID"]),
                            //cityID = Convert.ToInt32(row["CityID"]),
                            studentEmail = row["StudentEmail"].ToString(),
                            contactNo = row["StudentContactNo"].ToString(),
                            //industryID = Convert.ToInt32(row["IndustryID"]),
                            //qualID = Convert.ToInt32(row["QualificationID"]),
                            //skillID = Convert.ToInt32(row["SkillID"]),
                            //driversLicence = row["DriversLicense"].ToString(),
                            //profilePicture = (Byte[])(row["StudentProfilePicture"]),
                            studentUsername = row["StudentUsername"].ToString(),
                            //studentPasssword = row["StudentPassword"].ToString(),
                           // cv = (Byte[])(row["CV"]),
                            //statusID = Convert.ToInt32(row["StatusID"]),
                            lastUpdated = Convert.ToDateTime(row["LastUpdate"])
                        };
                        students.Add(gas);
                    }
                }
            }
            return students;
        }

        public List<UspGetAllEmployers> GetAllEmployers()
        {
            List<UspGetAllEmployers> employers = new List<UspGetAllEmployers>();
            using(DataTable table = DBHelper.Select("uspGetAllEmployers", CommandType.StoredProcedure))
            {
                if(table.Rows.Count > 0)
                {
                    foreach(DataRow row in table.Rows)
                    {
                        UspGetAllEmployers gae = new UspGetAllEmployers
                        {
                            //employer_id = Convert.ToInt32(row["Employer_ID"]),
                            employerName = row["EmployerName"].ToString(),
                            employerDescription = row["EmployerDescription"].ToString(),
                            //CityID = Convert.ToInt32(row["CityID"]),
                            //countryID = Convert.ToInt32(row["CountryID"]),
                            email = row["Email"].ToString(),
                            vatNo = row["VATno"].ToString(),
                            employerUsername = row["EmployerUsername"].ToString(),
                            //employerPassword = row["EmployerPassword"].ToString(),
                            contactPerson = row["ContactPerson"].ToString(),
                            contactEmail = row["ContactEmail"].ToString(),
                            //industryID = Convert.ToInt32(row["IndustryID"])
                        };
                        employers.Add(gae);
                    }
                }
            }
            return employers;
        }

        public List<UspGetAllCities> GetAllCities()
        {
            List<UspGetAllCities> cities = new List<UspGetAllCities>();

            using (DataTable table = DBHelper.Select("uspGetAllCities", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllCities gct = new UspGetAllCities
                        {
                            CityID = Convert.ToInt32(row["CityID"]),
                            CityDescription = row["CityDescription"].ToString()
                        };
                        cities.Add(gct);
                    }
                }
            }
            return cities;
        }

        public List<UspNumberOfStudents> GetNumberOfStudents()
        {
            List<UspNumberOfStudents> number = new List<UspNumberOfStudents>();
            using(DataTable table = DBHelper.Select("uspNumberOfStudents", CommandType.StoredProcedure))
            {
                if(table.Rows.Count > 0)
                {
                    foreach(DataRow row in table.Rows)
                    {
                        UspNumberOfStudents nos = new UspNumberOfStudents
                        {
                            //number = Convert.ToInt32(row["number"])
                        };
                        number.Add(nos);
                    }
                }
            }
            return number;
        }

        public List<UspGetAllIndustries> GetAllIndustries()
        {
            List<UspGetAllIndustries> industries = new List<UspGetAllIndustries>();

            using (DataTable table = DBHelper.Select("uspGetAllIndustries", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllIndustries gal = new UspGetAllIndustries
                        {
                            industryID = Convert.ToInt32(row["IndustryID"]),
                            industryDescription = row["IndustryDescription"].ToString()
                        };
                        industries.Add(gal);
                    }
                }
            }
            return industries;
        }

        public List<UspGetStudentProfile> GetStudentProfile(int studentNo)
        {
            List<UspGetStudentProfile> listStudentProfile = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@studentNumber", studentNo)
            };

            using (DataTable table = DBHelper.ParamSelect("uspGetStudentProfile", CommandType.StoredProcedure, param))
            {
                if (table.Rows.Count > 0)
                {
                    listStudentProfile = new List<UspGetStudentProfile>();
                    foreach(DataRow row in table.Rows)
                    {
                        UspGetStudentProfile gsp = new UspGetStudentProfile();
                        //studentNo = Convert.ToInt32(row["StudentNo"]);\
                        studentNo = 213456854;
                        gsp.studentFirstName = row["StudentFirstName"].ToString();
                        gsp.studentLastName = row["StudentLastName"].ToString();
                        gsp.studentDateofBirth = Convert.ToDateTime(row["StudentDateofBirth"]);
                        gsp.countryDescription = row["CountryDescription"].ToString();
                        gsp.cityDescription = row["CityDescription"].ToString();
                        gsp.studentEmail = row["StudentEmail"].ToString();
                        gsp.studentContactNo = row["StudentContactNo"].ToString();
                        gsp.industryDescription = row["IndustryDescription"].ToString();
                        gsp.qualificationDescription = row["QualificationDescription"].ToString();
                        gsp.skillDescription = row["SkillDescription"].ToString();
                        gsp.driversLicense = row["DriversLicense"].ToString();
                        //gsp.studentProfilePicture = (byte[])(row["StudentProfilePicture"]);
                        gsp.studentUsername = row["StudentUsername"].ToString();
                        gsp.studentPassword = row["StudentPassword"].ToString();
                        //gsp.CV = (Byte[])(row["CV"]);
                        //status = Convert.ToInt32(row["StatusID"]),
                        gsp.lastUpdate = Convert.ToDateTime(row["LastUpdate"]);
                        listStudentProfile.Add(gsp);
                    }
                }
            }
            return listStudentProfile;
        }

       

        public UspGetStudentProfile GetStudentProfile1(int studentNumber)
        {
            UspGetStudentProfile getStudentProfile = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@studentNumber", studentNumber)
            };
            using (DataTable dt = DBHelper.ParamSelect("uspGetStudentProfile", CommandType.StoredProcedure, param))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    getStudentProfile = new UspGetStudentProfile
                    {
                        studentFirstName = row["StudentFirstName"].ToString(),
                        studentLastName = row["StudentLastName"].ToString(),
                        studentDateofBirth = Convert.ToDateTime(row["StudentDateofBirth"]),
                        countryDescription = row["CountryDescription"].ToString(),
                        cityDescription = row["CityDescription"].ToString(),
                        studentEmail = row["StudentEmail"].ToString(),
                        studentContactNo = row["StudentContactNo"].ToString(),
                        industryDescription = row["IndustryDescription"].ToString(),
                        qualificationDescription = row["QualificationDescription"].ToString(),
                        skillDescription = row["SkillDescription"].ToString(),
                        driversLicense = row["DriversLicense"].ToString(),
                        //gsp.studentProfilePicture = (byte[])(row["StudentProfilePicture,
                        studentUsername = row["StudentUsername"].ToString(),
                        studentPassword = row["StudentPassword"].ToString(),
                        //gsp.CV = (Byte[])(row["CV"]);
                        //status = Convert.ToInt32(row["StatusID"]),
                        lastUpdate = Convert.ToDateTime(row["LastUpdate"]),
                    };
                }
            }
            return getStudentProfile;
        }


        public UspGetEmployerProfile GetEmployerProfile1(string employerEmail)
        {
            UspGetEmployerProfile getEmployerProfile = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@employerEmail", employerEmail)
            };
            using (DataTable dt = DBHelper.ParamSelect("uspGetEmployerProfile", CommandType.StoredProcedure, param))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    getEmployerProfile = new UspGetEmployerProfile
                    {
                        employerName = row["EmployerName"].ToString(),
                        employerDescription = row["EmployerDescription"].ToString(),
                        countryDescription = row["CountryDescription"].ToString(),
                        cityDescription = row["CityDescription"].ToString(),
                        //email = row["Email"].ToString(),
                        vatNo = row["VATno"].ToString(),
                        //gep.logo = (Byte[])row["Logo"];
                        employerUsername = row["EmployerUsername"].ToString(),
                        employerPassword = row["EmployerPassword"].ToString(),
                        contactPerson = row["ContactPerson"].ToString(),
                        contactEmail = row["ContactEmail"].ToString(),
                        industryDescription = row["IndustryDescription"].ToString(),
                    };
                    
                    
                }
            }
            return getEmployerProfile;
        }




                    public List<UspGetAdminLogin> GetAdminLogin()
        {
            List<UspGetAdminLogin> admin = new List<UspGetAdminLogin>();

            using (DataTable table = DBHelper.Select("uspGetAdminLogin", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAdminLogin gal = new UspGetAdminLogin
                        {
                            adminUsername = row["AdminUsername"].ToString(),
                            adminPassword = row["AdminPassword"].ToString()
                        };
                        admin.Add(gal);
                    }
                }
            }
            return admin;
        }





        public List<UspGetAllQualifications> GetAllQualifications()
        {
            List<UspGetAllQualifications> qualification = new List<UspGetAllQualifications>();
            using (DataTable table = DBHelper.Select("uspGetAllQualifications", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllQualifications qual = new UspGetAllQualifications
                        {
                            QualID = Convert.ToInt32(row["QualID"]),
                            QualificationDescription = row["QualificationDescription"].ToString()
                        };
                        qualification.Add(qual);
                    }
                }
            }
            return qualification;
        }
        public List<UspGetAllJobPosts> GetAllJobPosts()
        {
            List<UspGetAllJobPosts> jobp = new List<UspGetAllJobPosts>();
            using (DataTable table = DBHelper.Select("uspGetAllJobPosts", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllJobPosts posts = new UspGetAllJobPosts
                        {
                            //employerID = Convert.ToInt32(row["EmployerID"]),
                            JobID = Convert.ToInt32(row["JobID"]),
                            DatePosted = Convert.ToDateTime(row["DatePosted"]),
                            DateClosing = Convert.ToDateTime(row["DateClosing"]),
                            CountryDescription = row["CountryDescription"].ToString(),
                            CityDescription = row["CityDescription"].ToString(),
                            JobDescription = row["JobDescription"].ToString(),
                            KeyResponsibilities = row["KeyResponsibilities"].ToString(),
                            QualificationDescription = row["QualificationDescription"].ToString(),
                            SkillDescription = row["SkillDescription"].ToString(),
                            TypeDescription = row["TypeDescription"].ToString(),
                            Duration = Convert.ToInt32(row["Duration"]),
                            StartDate = Convert.ToDateTime(row["StartDate"]),
                            PostedBy = row["PostedBy"].ToString(),
                            StatusDescription = row["StatusDescription"].ToString(),
                        };
                    }
                }
            }
            return jobp;
        }
        public List<UspGetAllJobType> GetAllJobType()
        {
            List<UspGetAllJobType> jobtype = new List<UspGetAllJobType>();
            using (DataTable table = DBHelper.Select("uspGetAllJobType", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllJobType type = new UspGetAllJobType
                        {
                            JobID = Convert.ToInt32(row["TypeID"]),
                            JobDescription = row["TypeDescription"].ToString()
                        };
                        jobtype.Add(type);
                    }
                }
            }
            return jobtype;
        }


        public List<UspGetAllSkills> GetAllSkills()
        {
            List<UspGetAllSkills> skills = new List<UspGetAllSkills>();

            using (DataTable table = DBHelper.Select("uspGetAllSkills", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllSkills skill = new UspGetAllSkills
                        {
                            SkillID = Convert.ToInt32(row["SkillID"]),
                            SkillDescription = row["SkillDescription"].ToString()
                        };
                        skills.Add(skill);
                    }
                }
            }
            return skills;
        }
        public List<UspGetAllStatus> GetAllStatus()
        {
            List<UspGetAllStatus> status = new List<UspGetAllStatus>();
            using (DataTable table = DBHelper.Select("UspGetAllStatus", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllStatus stat = new UspGetAllStatus
                        {
                            StatusID = Convert.ToInt32(row["StatusID"]),
                            StatusDescription = row["StatusDescription"].ToString()
                        };
                        status.Add(stat);
                    }
                }
            }
            return status;
        }
      


        public bool UpdateJobPost(UpdateJobPost updateJobPost)
        {
            List<SqlParameter> params1 = new List<SqlParameter>();
            foreach (var prop in updateJobPost.GetType().GetProperties())
            {
                if (prop.GetValue(updateJobPost) != null)
                {
                    params1.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(updateJobPost)));
                }
            }
            return DBHelper.NonQuery("uspUpdateJobPost", CommandType.StoredProcedure, params1.ToArray());

        }








        //public List<UspGetAllEmployers> GetAllEmployers()
        //{
        //    List<UspGetAllEmployers> emps = new List<UspGetAllEmployers>();
        //    using (DataTable table = DBHelper.Select("uspGetAllEmployers", CommandType.StoredProcedure))
        //    {
        //        if (table.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in table.Rows)
        //            {
        //                UspGetAllEmployers gae = new UspGetAllEmployers
        //                {
        //                    employerID = Convert.ToInt32(row["EmployerID"]),
        //                    employerName = row["EmployerName"].ToString()
        //                };
        //                emps.Add(gae);
        //            }
        //        }
        //    }
        //    return emps;
        //}
        public List<UspGetAllJobTypes> GetAllJobTypes()
        {
            List<UspGetAllJobTypes> jtype = new List<UspGetAllJobTypes>();
            using (DataTable table = DBHelper.Select("uspGetAllJobTypes", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllJobTypes gjt = new UspGetAllJobTypes
                        {
                            typeID = Convert.ToInt32(row["typeID"]),
                            typeDescription = row["typeDescription"].ToString()
                        };
                        jtype.Add(gjt);
                    }
                }
            }
            return jtype;
        }

        //public List<UspGetAllSkills> GetAllSkills()
        //{
        //    List<UspGetAllSkills> allski = new List<UspGetAllSkills>();
        //    using (DataTable table = DBHelper.Select("uspGetAllSkills", CommandType.StoredProcedure))
        //    {
        //        if (table.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in table.Rows)
        //            {
        //                UspGetAllSkills gas = new UspGetAllSkills
        //                {

        //                    skillID = Convert.ToInt32(row["SkillID"]),
        //                    skillDescription = row["SkillDescription"].ToString()
        //                };
        //                allski.Add(gas);
        //            }
        //        }
        //    }
        //    return allski;
        //}

        //public List<UspGetAllQualifications> GetAllQualifications()
        //{
        //    List<UspGetAllQualifications> allqual = new List<UspGetAllQualifications>();
        //    using (DataTable table = DBHelper.Select("uspGetAllQualifications", CommandType.StoredProcedure))
        //    {
        //        if (table.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in table.Rows)
        //            {
        //                UspGetAllQualifications gaq = new UspGetAllQualifications
        //                {
        //                    QualID = Convert.ToInt32(row["QualID"]),
        //                    QualificationDescription = row["QualificationDescription"].ToString()
        //                };
        //                allqual.Add(gaq);
        //            }
        //        }
        //    }
        //    return allqual;
        //}
        public UspSearchStudents SearchStudents(int cityID, int qualID, int skillID)
        {
            UspSearchStudents ss = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@cityID", cityID),
                new SqlParameter("@qualID", qualID),
                new SqlParameter("@skillID", skillID)
            };
            using (DataTable table = DBHelper.ParamSelect("UspSearchStudents", CommandType.StoredProcedure, param))
            {
                //Check if any record exists
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    ss = new UspSearchStudents
                    {


                        cityID = Convert.ToInt32(row["CityID"]),


                        qualificationID = Convert.ToInt32(row["QualificationID"]),
                        skillID = Convert.ToInt32(row["SkillID"]),



                    };
                }
            }
            return ss;
        }
        public UspSearchJobs SearchJobs(int cityID, int qualID, int skillID)
        {
            UspSearchJobs ss = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@cityID", cityID),
                new SqlParameter("@qualID", qualID),
                new SqlParameter("@skillID", skillID)
            };
            using (DataTable table = DBHelper.ParamSelect("UspSearchStudents", CommandType.StoredProcedure, param))
            {
                //Check if any record exists
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    ss = new UspSearchJobs
                    {
                        cityID = Convert.ToInt32(row["CityID"]),

                        typeID = Convert.ToInt32(row["TypeID"]),

                        employerID = Convert.ToInt32(row["EmployerID"]),


                    };
                }
            }
            return ss;
        }


        //N_A------------------------------------------------------------------------------------------------------
        //------------------------------ADMIN STUFF---------------------------
        public List<UspGetTotalEmployers> GetTotalEmployers()
        {
            List<UspGetTotalEmployers> totEmp = new List<UspGetTotalEmployers>();
            using (DataTable table = DBHelper.Select("uspGetTotalEmployers", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetTotalEmployers gte = new UspGetTotalEmployers
                        {

                            Total_Employers = Convert.ToInt32(row["Total Employers"]),
                        };
                        totEmp.Add(gte);
                    }
                }
            }
            return totEmp;
        }

        public List<UspGetTotalStudents> GetTotalStudents()
        {
            List<UspGetTotalStudents> totStu = new List<UspGetTotalStudents>();
            using (DataTable table = DBHelper.Select("uspGetTotalStudents", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetTotalStudents gts = new UspGetTotalStudents
                        {

                            Total_Students = Convert.ToInt32(row["Total Students"]),
                        };
                        totStu.Add(gts);
                    }
                }
            }
            return totStu;
        }

        public List<UspGetTotalJobPosts> GetTotalJobPosts()
        {
            List<UspGetTotalJobPosts> totJob = new List<UspGetTotalJobPosts>();
            using (DataTable table = DBHelper.Select("uspGetTotalJobPosts", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetTotalJobPosts gtjp = new UspGetTotalJobPosts
                        {

                            Total_Job_Posts = Convert.ToInt32(row["Total Job Posts"]),
                        };
                        totJob.Add(gtjp);
                    }
                }
            }
            return totJob;
        }

        //------------------------------STUDENT SEARCH STUFF---------------------------
        public List<UspGetAllEmployerNames> GetAllEmployerNames()
        {
            List<UspGetAllEmployerNames> emps = new List<UspGetAllEmployerNames>();
            using (DataTable table = DBHelper.Select("uspGetAllEmployerNames", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetAllEmployerNames gae = new UspGetAllEmployerNames
                        {
                            Employer_ID = Convert.ToInt32(row["Employer_ID"]),
                            EmployerName = row["EmployerName"].ToString()
                        };
                        emps.Add(gae);
                    }
                }
            }
            return emps;
        }

        public List<UspGetMostRecentJobPosts> GetMostRecentJobPosts()
        {
            List<UspGetMostRecentJobPosts> rjp = new List<UspGetMostRecentJobPosts>();
            using (DataTable table = DBHelper.Select("uspGetMostRecentJobPosts", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetMostRecentJobPosts more = new UspGetMostRecentJobPosts
                        {
                            //Logo = Convert.ToByte(row["Logo"]),
                            JobID = Convert.ToInt32(row["JobID"]),
                            JobTitle = row["JobTitle"].ToString(),
                            CityDescription = row["CityDescription"].ToString(),
                            TypeDescription = row["TypeDescription"].ToString(),
                            DateClosing = Convert.ToDateTime(row["DateClosing"])
                        };
                        rjp.Add(more);
                    }
                }
            }
            return rjp;
        }


        public List<UspGetJobTotalsByClosingDate> GetJobTotalsByClosingDate()
        {
            List<UspGetJobTotalsByClosingDate> dc = new List<UspGetJobTotalsByClosingDate>();
            using (DataTable table = DBHelper.Select("uspGetJobTotalsByClosingDate", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetJobTotalsByClosingDate gts = new UspGetJobTotalsByClosingDate
                        {
                            DateClosing = row["DateClosing"].ToString(),
                            Total = Convert.ToInt32(row["Total"])
                        };
                        dc.Add(gts);
                    }
                }
            }
            return dc;
        }


        public List<UspGetJobTotalsByQualification> GetJobTotalsByQualification()
        {
            List<UspGetJobTotalsByQualification> jtot = new List<UspGetJobTotalsByQualification>();
            using (DataTable table = DBHelper.Select("uspGetJobTotalsByQualification", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetJobTotalsByQualification gtq = new UspGetJobTotalsByQualification
                        {
                            QualificationDescription = row["QualificationDescription"].ToString(),
                            Total = Convert.ToInt32(row["Total"])
                        };
                        jtot.Add(gtq);
                    }
                }
            }
            return jtot;
        }

        public List<UspGetJobTotalsBySkill> GetJobTotalsBySkill()
        {
            List<UspGetJobTotalsBySkill> jtot = new List<UspGetJobTotalsBySkill>();
            using (DataTable table = DBHelper.Select("uspGetJobTotalsBySkill", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetJobTotalsBySkill gtq = new UspGetJobTotalsBySkill
                        {

                            SkillDescription = row["SkillDescription"].ToString(),
                            Total = Convert.ToInt32(row["Total"])
                        };
                        jtot.Add(gtq);
                    }
                }
            }
            return jtot;
        }

        public List<UspGetAllJobPostBySearch> GetAllJobPostBySearch(int cityID, int qualID, int skillID)
        {
            List<UspGetAllJobPostBySearch> ss = new List<UspGetAllJobPostBySearch>();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@cityID", cityID),
                new SqlParameter("@qualID", qualID),
                new SqlParameter("@skillID", skillID)
            };
            using (DataTable table = DBHelper.ParamSelect("UspGetAllJobPostBySearch", CommandType.StoredProcedure, param))
            {
                //Check if any record exists
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    UspGetAllJobPostBySearch jps = new UspGetAllJobPostBySearch
                    {
                        JobID = Convert.ToInt32(row["JobID"]),
                        JobTitle = row["JobTitle"].ToString(),
                        CityDescription = row["CityDescription"].ToString(),
                        TypeDescription = row["TypeDescription"].ToString(),
                        DateClosing = Convert.ToDateTime(row["DateClosing"])

                    };
                    ss.Add(jps);
                }
            }
            return ss;
        }


        public List<UspGetSelectedJobDetails> GetSelectedJobDetails()
        {
            List<UspGetSelectedJobDetails> jtot = new List<UspGetSelectedJobDetails>();
            using (DataTable table = DBHelper.Select("uspGetSelectedJobDetails>", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetSelectedJobDetails gtq = new UspGetSelectedJobDetails
                        {
                            JobID = Convert.ToInt32(row["JobID"]),
                            DatePosted = Convert.ToDateTime(row["DatePosted"]),
                            DateClosing = Convert.ToDateTime(row["DateClosing"]),
                            CityDescription = row["CityDescription"].ToString(),
                            JobDescription = row["JobDescription"].ToString(),
                            KeyResponsibilities = row["KeyResponsebilities"].ToString(),
                            QualificationDescription = row["QualificationDescription"].ToString(),
                            SkillDescription = row["SkillDescription"].ToString(),
                            TypeDescription = row["TypeDescription"].ToString(),

                        };
                        jtot.Add(gtq);
                    }
                }
            }
            return jtot;
        }
        //------------------------------EMPLOYER SEARCH STUFF---------------------------
        public List<UspGetMostRecentStudents> GetMostRecentStudents()
        {
            List<UspGetMostRecentStudents> gmrs = new List<UspGetMostRecentStudents>();
            using (DataTable table = DBHelper.Select("uspGetMostRecentStudents", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetMostRecentStudents mors = new UspGetMostRecentStudents
                        {
                            //ProfilePicture = Convert.ToByte(row["StudentProfilePicture"]),
                            StudentNo = Convert.ToInt32(row["StudentNo"]),
                            Student = row["Student"].ToString(),
                            CityDescription = row["CityDescription"].ToString(),
                            QualificationDescription = row["QualificationDescription"].ToString(),
                            SkillDescription = row["SkillDescription"].ToString(),
                            StudentEmail = row["StudentEmail"].ToString(),
                            //CV = Convert.ToByte(row["CV"])
                        };
                        gmrs.Add(mors);
                    }
                }
            }
            return gmrs;
        }

        public UspGetAllStudentsBySearch GetAllStudentsBySearch(int cityID, int qualID, int skillID)
        {
            UspGetAllStudentsBySearch ss = null;
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@cityID", cityID),
                new SqlParameter("@qualID", qualID),
                new SqlParameter("@skillID", skillID)
            };
            using (DataTable table = DBHelper.ParamSelect("UspGetAllStudentsBySearch", CommandType.StoredProcedure, param))
            {
                //Check if any record exists
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    ss = new UspGetAllStudentsBySearch
                    {
                        Student = row["Student"].ToString(),
                        CityDescription = row["CityDescription"].ToString(),
                        QualificationDescription = row["CityDescription"].ToString(),
                        SkillDescription = row["SkillDescription"].ToString(),
                        studentEmail = row["StudentEmail"].ToString()
                        //cv = Convert.ToByte(row["CV"]),

                    };
                }
            }
            return ss;
        }

        public List<UspGetStudentTotalsByQualification> GetStudentTotalsByQualification()
        {
            List<UspGetStudentTotalsByQualification> totQ = new List<UspGetStudentTotalsByQualification>();
            using (DataTable table = DBHelper.Select("uspGetStudentTotalsByQualification", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetStudentTotalsByQualification gtq = new UspGetStudentTotalsByQualification
                        {

                            QualificationDescription = row["QualificationDescription"].ToString(),
                            Total = Convert.ToInt32(row["Total"])
                        };
                        totQ.Add(gtq);
                    }
                }
            }
            return totQ;
        }
        public List<UspGetStudentTotalsBySkill> GetStudentTotalsBySkill()
        {
            List<UspGetStudentTotalsBySkill> totS = new List<UspGetStudentTotalsBySkill>();
            using (DataTable table = DBHelper.Select("uspGetStudentTotalsBySkill", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetStudentTotalsBySkill gts = new UspGetStudentTotalsBySkill
                        {

                            SkillDescription = row["SkillDescription"].ToString(),
                            Total = Convert.ToInt32(row["Total"])
                        };
                        totS.Add(gts);
                    }
                }
            }
            return totS;
        }

        public List<UspGetStudentTotalsByDrivers> GetStudentTotalsByDrivers()
        {
            List<UspGetStudentTotalsByDrivers> tdl = new List<UspGetStudentTotalsByDrivers>();
            using (DataTable table = DBHelper.Select("uspGetStudentTotalsByDrivers", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetStudentTotalsByDrivers gtq = new UspGetStudentTotalsByDrivers
                        {
                            DriversLicense = row["DriversLicense"].ToString(),
                            Total = Convert.ToInt32(row["Total"])
                        };
                        tdl.Add(gtq);
                    }
                }
            }
            return tdl;
        }

        public List<UspGetSelectedStudentDetails> GetSelectedStudentDetails()
        {
            List<UspGetSelectedStudentDetails> jtot = new List<UspGetSelectedStudentDetails>();
            using (DataTable table = DBHelper.Select("uspGetSelectedStudentDetails", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        UspGetSelectedStudentDetails gt = new UspGetSelectedStudentDetails
                        {



                            CityDescription = row["CityDescription"].ToString(),

                            QualificationDescription = row["QualificationDescription"].ToString(),
                            SkillDescription = row["SkillDescription"].ToString(),


                        };
                        jtot.Add(gt);
                    }
                }
            }
            return jtot;
        }
    }// END class DBACCESS
}//END namespace
