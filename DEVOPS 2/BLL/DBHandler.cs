using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLibrary.Interfaces;
using TypeLibrary.Models;
using TypeLibrary.ViewModels;
using DAL;

namespace BLL
{
    public class DBHandler : IDBHandler
    {
        private DBAccess dBAccess;

        public DBHandler()
        {
            dBAccess = new DBAccess();
        }

        public bool BLL_AddEmployer(AddEmployer addEmployer)
        {
            return dBAccess.AddEmployer(addEmployer);
        }

        public bool BLL_AddJobPost(AddJobPost addJobPost)
        {
            return dBAccess.AddJobPost(addJobPost);
        }

        public bool BLL_AddStudent(AddStudent addStudent)
        {
            return dBAccess.AddStudent(addStudent);
        }

        public bool BLL_AddNewSkill(AddNewSkill addNewSkill)
        {
            return dBAccess.AddNewSkill(addNewSkill);
        }

        public bool BLL_AddNewQual(AddNewQual addNewQual)
        {
            return dBAccess.AddNewQual(addNewQual);
        }

        public bool BLL_AddStudentSkill(AddStudentSkill addStudentSkill)
        {
            return dBAccess.AddStudentSkill(addStudentSkill);
        }

        public bool BLL_AddNewIndustry(AddNewIndustry addNewIndustry)
        {
            return dBAccess.AddNewIndustry(addNewIndustry);
        }

        public bool BLL_AddStudentQual(AddStudentQual addStudentQual)
        {
            return dBAccess.AddStudentQual(addStudentQual);
        }
        public bool BLL_DeleteJobPost(DeleteJobPost deleteJobPost)
        {
            return dBAccess.DeleteJobPost(deleteJobPost);
        }
        public bool BLL_DeleteStudent(DeleteStudent deleteStudent)
        {
            return dBAccess.DeleteStudent(deleteStudent);
        }

        public bool BLL_DeleteStudentSkill(DeleteStudentSkill deleteStudentSkill)
        {
            return dBAccess.DeleteStudentSkill(deleteStudentSkill);
        }

        public bool BLL_DeleteEmployer(DeleteEmployer deleteEmployer)
        {
            return dBAccess.DeleteEmployer(deleteEmployer);
        }
        public bool BLL_UpdateEmployerProfile(UpdateEmployerProfile updateEmployerProfile)
        {
            return dBAccess.UpdateEmployerProfile(updateEmployerProfile);
        }

        public bool BLL_UpdateStudentProfile(UpdateStudentProfile updateStudentProfile)
        {
            return dBAccess.UpdateStudentProfile(updateStudentProfile);
        }

        public UspGetAllJobPostsByEmployer BLL_GetAllJobPostsByEmployer(int employerID)
        {
            return dBAccess.GetAllJobPostsByEmployer(employerID);
        }

        public UspGetAllJobPosts BLL_GetAllJobPosts(int employerID)
        {
            return dBAccess.GetAllJobPosts(employerID);
        }
        public UspGetAllJobPostsByQualification BLL_GetAllJobPostsByQualification(int qualID)
        {
            return dBAccess.GetAllJobPostsByQualification(qualID);
        }

        public UspGetAllJobPostsBySkill BLL_GetAllJobPostsBySkill(int skillID)
        {
            return dBAccess.GetAllJobPostsBySkill(skillID);
        }

        public UspGetAllJobPostsByType BLL_GetAllJobPostsByType(int typeID)
        {
            return dBAccess.GetAllJobPostsByType(typeID);
        }

        public UspGetAllStudentsByCity BLL_GetAllStudentByCity(int cityID)
        {
            return dBAccess.GetAllStudentsByCity(cityID);
        }

        public UspGetAllStudentsByQualification BLL_GetAllStudentsByQualification(int qualID)
        {
            return dBAccess.GetAllStudentsByQualification(qualID);
        }

        public UspGetAllStudentsBySkill BLL_GetAllStudentsBySkill(int skillID)
        {
            return dBAccess.GetAllStudentsBySkill(skillID);
        }

        public UspCheckStudentLogin BLL_CheckStudentLogin(int studentNo, string studentPassword)
        {
            return dBAccess.CheckStudentLogin(studentNo, studentPassword);
        }

        public UspCheckEmployerLogin BLL_CheckEmployerLogin(string employerEmail, string employerPassword)
        {
            return dBAccess.CheckEmployerLogin(employerEmail, employerPassword);
        }

        public List<UspGetAllCountries> BLL_GetAllCountries()
        {
            return dBAccess.GetAllCountries();
        }

        public List<UspGetAllCities> BLL_GetAllCities()
        {
            return dBAccess.GetAllCities();
        }
      
        public List<UspGetAllIndustries> BLL_GetAllIndustries()
        {
            return dBAccess.GetAllIndustries();
        }
        
        public List<UspGetAllStudents> BLL_GetAllStudents()
        {
            return dBAccess.GetAllStudents();
        }

        public List<UspGetAllEmployers> BLL_GetAllEmployers()
        {
            return dBAccess.GetAllEmployers();
        }

        public List<UspGetStudentProfile> BLL_GetStudentProfile(int studentNo)
        {
            return dBAccess.GetStudentProfile(studentNo);
        }
        public UspGetStudentProfile BLL_GetStudentProfile1(int studentNumber)
        {
            return dBAccess.GetStudentProfile1(studentNumber);
        }
       

        public UspGetEmployerProfile BLL_GetEmployerProfile1(string employerEmail)
        {
            return dBAccess.GetEmployerProfile1(employerEmail);
        }

        public List<UspGetAdminLogin> BLL_GetAdminLogin()
        {
            return dBAccess.GetAdminLogin();
        }





        public List<UspGetAllQualifications> BLL_GetAllQualifications()
        {
            return dBAccess.GetAllQualifications();
        }
        public List<UspGetAllJobType> BLL_GetAllJobType()
        {
            return dBAccess.GetAllJobType();
        }
        public List<UspGetAllJobTypes> BLL_GetAllJobTypes()
        {
            return dBAccess.GetAllJobTypes();
        }
        public List<UspGetAllSkills> BLL_GetAllSkills()
        {
            return dBAccess.GetAllSkills();
        }
        public List<UspGetAllStatus> BLL_GetAllStatus()
        {
            return dBAccess.GetAllStatus();
        }
        public bool BLL_UpdateJopPost(UpdateJobPost updateJobPost)
        {
            return dBAccess.UpdateJobPost(updateJobPost);
        }

        public UspSearchStudents BLL_SearchStudents(int cityID, int typeID, int employerID)
        {
            return dBAccess.SearchStudents(cityID, typeID, employerID);
        }
        public UspSearchJobs BLL_SearchJobs(int cityID, int qualID, int skillID)
        {
            return dBAccess.SearchJobs(cityID, qualID, skillID);
        }

        //public List<UspGetAllEmployers> BLL_GetAllEmployers()
        //{
        //    return dBAccess.GetAllEmployers();
        //}
        //public List<UspGetAllJobTypes> BLL_GetAllJobTypes()
        //{
        //    return dBAccess.GetAllJobTypes();
        //}
        //public List<UspGetAllSkills> BLL_GetAllSkills()
        //{
        //    return dBAccess.GetAllSkills();
        //}
        //public List<UspGetAllQualifications> BLL_GetAllQualifications()
        //{
        //    return dBAccess.GetAllQualifications();
        //}


    }//END class DBHandler
}//End namespace BLL
