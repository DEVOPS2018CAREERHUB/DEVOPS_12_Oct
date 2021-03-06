﻿using TypeLibrary.Models;
using TypeLibrary.ViewModels;
using System.Collections.Generic;

namespace TypeLibrary.Interfaces
{
    public interface IDBHandler
    {
        bool BLL_AddEmployer(AddEmployer addEmployer);
        bool BLL_AddJobPost(AddJobPost addJobPost);
        bool BLL_AddStudent(AddStudent addStudent);
        bool BLL_AddNewSkill(AddNewSkill addNewSkill);
        bool BLL_AddNewQual(AddNewQual addNewQual);
        bool BLL_AddNewIndustry(AddNewIndustry addNewIndustry);
        bool BLL_AddStudentSkill(AddStudentSkill addStudentSkill);
        bool BLL_AddStudentQual(AddStudentQual addStudentQual);
        UspCheckEmployerLogin BLL_CheckEmployerLogin(string employerEmail, string employerPassword);
        UspCheckStudentLogin BLL_CheckStudentLogin(int studentNo, string studentPassword);
        bool BLL_DeleteJobPost(DeleteJobPost deleteJobPost);
        bool BLL_DeleteStudent(DeleteStudent deleteStudent);
        bool BLL_DeleteStudentSkill(DeleteStudentSkill deleteStudentSkill);
        bool BLL_DeleteStudentQual(DeleteStudentQual deleteStudentQual);
        bool BLL_DeleteEmployer(DeleteEmployer deleteEmployer);
        UspGetAllJobPostsByEmployer BLL_GetAllJobPostsByEmployer(int employerID);
        //UspGetAllJobPosts BLL_GetAllJobPosts(int employerID);
        UspGetAllJobPostsByQualification BLL_GetAllJobPostsByQualification(int qualID);
        UspGetAllJobPostsBySkill BLL_GetAllJobPostsBySkill(int skillID);
        UspGetAllJobPostsByType BLL_GetAllJobPostsByType(int typeID);
        UspGetAllStudentsByCity BLL_GetAllStudentByCity(int cityID);
        UspGetAllStudentsByQualification BLL_GetAllStudentsByQualification(int qualID);
        UspGetAllStudentsBySkill BLL_GetAllStudentsBySkill(int skillID);
        bool BLL_UpdateEmployerProfile(UpdateEmployerProfile updateEmployerProfile);
        bool BLL_UpdateStudentProfile(UpdateStudentProfile updateStudentProfile);
        List<UspGetAllJobPosts> BLL_GetAllJobPosts();
        List<UspGetAllCountries> BLL_GetAllCountries();
        List<UspGetAllCities> BLL_GetAllCities();
        List<UspGetAllStudents> BLL_GetAllStudents();
        List<UspGetAllEmployers> BLL_GetAllEmployers();
        List<UspGetAllIndustries> BLL_GetAllIndustries();
        List<UspNumberOfStudents> BLL_NumberOfStudents();
        List<UspGetStudentProfile> BLL_GetStudentProfile(int studentNo);
        UspGetStudentProfile BLL_GetStudentProfile1(int studentNumber);
        
        UspGetEmployerProfile BLL_GetEmployerProfile1(string employerEmail);
        List<UspGetAdminLogin> BLL_GetAdminLogin();





        List<UspGetAllQualifications> BLL_GetAllQualifications();
        List<UspGetAllSkills> BLL_GetAllSkills();
        List<UspGetAllJobType> BLL_GetAllJobType();
        List<UspGetAllStatus> BLL_GetAllStatus();








        UspSearchStudents BLL_SearchStudents(int cityID, int typeID, int employerID);
        UspSearchJobs BLL_SearchJobs(int cityID, int qualID, int skillID);

        //N_A------------------------------------------------------------------------------------------------------
        //------------------------------ADMIN STUFF---------------------------
        List<UspGetTotalEmployers> BLL_GetTotalEmployers();
        List<UspGetTotalStudents> BLL_GetTotalStudents();
        List<UspGetTotalJobPosts> BLL_GetTotalJobPosts();

        //------------------------------STUDENT SEARCH STUFF---------------------------
        List<UspGetAllEmployerNames> BLL_GetAllEmployerNames();
        List<UspGetMostRecentJobPosts> BLL_GetMostRecentJobPosts();
        List<UspGetJobTotalsByClosingDate> BLL_GetJobTotalsByClosingDate();
        List<UspGetJobTotalsByQualification> BLL_GetJobTotalsByQualification();
        List<UspGetJobTotalsBySkill> BLL_GetJobTotalsBySkill();
        List<UspGetAllJobPostBySearch> BLL_GetAllJobPostBySearch(int cityID, int qualID, int skillID);
        List<UspGetSelectedJobDetails> BLL_GetSelectedJobDetails();

        //------------------------------EMPLOYER SEARCH STUFF---------------------------
        List<UspGetMostRecentStudents> BLL_GetMostRecentStudents();
        UspGetAllStudentsBySearch BLL_GetAllStudentsBySearch(int cityID, int typeID, int employerID);
        List<UspGetStudentTotalsByQualification> BLL_GetStudentTotalsByQualification();
        List<UspGetStudentTotalsBySkill> BLL_GetStudentTotalsBySkill();
        List<UspGetStudentTotalsByDrivers> BLL_GetStudentTotalsByDrivers();
        List<UspGetSelectedStudentDetails> BLL_GetSelectedStudentDetails();
    }

}